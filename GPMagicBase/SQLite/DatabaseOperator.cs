using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Reflection;
using System.Data;
using GPSoft.Games.GPMagic.GPMagicBase.Model;
using GPSoft.Games.GPMagic.GPMagicBase.Model.Database;

namespace GPSoft.Games.GPMagic.GPMagicBase.SQLite
{
    public class DatabaseOperator : IDBOperate, IDisposable
    {
        private string _ConnStr = SQLiteDatabaseInformation.Connection;
        /// <summary>
        /// 获取或者设置数据库连接字符串
        /// </summary>
        public string ConnStr
        {
            set { _ConnStr = value; }            
            get { return _ConnStr; }
        }
        private SQLiteTransaction tran = null;
        private bool useTran = false;

        #region IDBOperate 成员

        /// <summary>
        /// 将一条数据封装成指定的对象
        /// </summary>
        /// <typeparam name="T">要封装成的对象类型</typeparam>
        /// <param name="dataRow">要进行封装的数据</param>
        /// <returns>返回封装好的对象</returns>
        public T EncapsulateDataRowToObject<T>(DataRow dataRow)
        {
            object result = Activator.CreateInstance<T>();
            EncapsulateDataRowToObject(ref result, dataRow);
            return (T)result;
        }
        public void EncapsulateDataRowToObject(ref object instance, DataRow dataRow)
        {
            PropertyInfo[] properties = instance.GetType().GetProperties();
            foreach (PropertyInfo info in properties)
            {
                if (dataRow.Table.Columns.Contains(info.Name))
                {
                    info.SetValue(instance, dataRow[info.Name], null);
                }
            }
        }
        /// <summary>
        /// 执行没有返回值的数据库脚本
        /// <param name="sql">要执行的数据库脚本</param>
        /// </summary>
        public void ExecuteNonreturnSqlStript(string sql)
        {
            SQLiteConnection conn = null;
            try
            {
                SQLiteCommand cmd;
                if (useTran)
                {
                    cmd = new SQLiteCommand(sql, tran.Connection, tran);
                }
                else
                {
                    conn = new SQLiteConnection(ConnStr);
                    conn.Open();
                    cmd = new SQLiteCommand(sql, conn);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (useTran)
                {
                    RollbackTran();
                }
            }
            finally
            {
                if (null != conn) conn.Close();
            }
        }

        public DataTable ExecuteDataTableScript(string sql)
        {
            DataTable result = null;
            SQLiteConnection conn = null;
            try
            {
                SQLiteCommand cmd;
                if (useTran)
                {
                    cmd = new SQLiteCommand(sql, tran.Connection, tran);
                }
                else
                {
                    conn = new SQLiteConnection(ConnStr);
                    conn.Open();
                    cmd = new SQLiteCommand(sql, conn);
                }
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                result = ds.Tables[0];
            }
            catch (Exception ex)
            {
                if (useTran)
                {
                    RollbackTran();
                }
            }
            finally
            {
                if (null != conn) conn.Close();
            }
            return result;
        }

        public DataTable SelectTableData(string tableName)
        {
            string sql = "SELECT * FROM " + tableName;
            return ExecuteDataTableScript(sql);
        }
        /// <summary>
        /// 将一个封装好的数据实例插入到指定的表中
        /// </summary>
        /// <param name="tableName">要进行插入的表名</param>
        /// <param name="dataObj">封装好的数据实例</param>
        public void InsertTableData(string tableName, object dataObj)
        {
            PropertyInfo[] properties = dataObj.GetType().GetProperties();
            string sqlStript = "INSERT INTO {0} ({1}) VALUES({2})";
            List<string> colNames = new List<string>();
            List<string> values = new List<string>();
            foreach (PropertyInfo info in properties)
            {
                object[] attributes = info.GetCustomAttributes(typeof(ColumnInfoAttribute), false);
                if (attributes.Length > 0)
                {
                    ColumnInfoAttribute colAttr = (ColumnInfoAttribute)attributes[0];
                    if (colAttr != null && colAttr.IsAutoIncrement)
                    {
                        continue;
                    }
                }
                colNames.Add(info.Name);
                string valueStr = info.GetValue(dataObj, null).ToString();
                if (info.PropertyType.Equals(typeof(string)))
                    valueStr = string.Format("'{0}'", valueStr);
                values.Add(valueStr);
            }
            sqlStript = string.Format(sqlStript, tableName, 
                string.Join(", ", colNames.ToArray()),
                string.Join(", ", values.ToArray()));
            ExecuteNonreturnSqlStript(sqlStript);
            colNames.Clear();
            values.Clear();
        }
        /// <summary>
        /// 将一行数据插入到指定的表中
        /// </summary>
        /// <param name="tableName">要进行插入的表名</param>
        /// <param name="dataRow">数据行</param>
        public void InsertTableData(string tableName, DataRow dataRow)
        {
            object tableInstance = GetTableInstance(tableName, dataRow);
            InsertTableData(tableName, tableInstance);
        }

        private object GetTableInstance(string tableName, DataRow dataRow)
        {
            string classFullName = "GPSoft.Games.GPMagic.GPMagicBase.Model." + tableName;
            object tableInstance = Activator.CreateInstance("GPMagicBase", classFullName);
            EncapsulateDataRowToObject(ref tableInstance, dataRow);
            return tableInstance;
        }

        public void DeleteTableData(string tableName, object dataObj)
        {
            PropertyInfo[] properties = dataObj.GetType().GetProperties();
            string sqlStript = "DELETE FROM {0} WHERE {1}";
            List<string> where = new List<string>();
            foreach (PropertyInfo info in properties)
            {
                object[] attributes = info.GetCustomAttributes(typeof(ColumnInfoAttribute), false);
                string keyValueString = GetUpdateSetString(info, dataObj);
                if (attributes.Length > 0)
                {
                    ColumnInfoAttribute colAttr = (ColumnInfoAttribute)attributes[0];
                    if (colAttr != null && colAttr.IsPrimaryKey)
                    {
                        where.Add(keyValueString);
                    }
                }
            }
            sqlStript = string.Format(sqlStript, tableName,
                string.Join(" AND ", where.ToArray()));
            ExecuteNonreturnSqlStript(sqlStript);
            where.Clear();
        }

        public void DeleteTableData(string tableName, DataRow dataRow)
        {
            object tableInstance = GetTableInstance(tableName, dataRow);
            DeleteTableData(tableName, tableInstance);
        }

        public void UpdateTableData(string tableName, object dataObj)
        {
            PropertyInfo[] properties = dataObj.GetType().GetProperties();
            string sqlStript = "UPDATE {0} SET {1} WHERE {2}";
            List<string> setValues = new List<string>();
            List<string> where = new List<string>();
            foreach (PropertyInfo info in properties)
            {
                object[] attributes = info.GetCustomAttributes(typeof(ColumnInfoAttribute), false);
                string keyValueString = GetUpdateSetString(info, dataObj);
                if (attributes.Length > 0)
                {
                    ColumnInfoAttribute colAttr = (ColumnInfoAttribute)attributes[0];
                    if (colAttr != null)
                    {
                        if (colAttr.IsPrimaryKey)
                        {
                            where.Add(keyValueString);
                        }
                        if (colAttr.IsAutoIncrement) continue;
                    }
                }
                setValues.Add(keyValueString);
            }
            sqlStript = string.Format(sqlStript, tableName,
                string.Join(", ", setValues.ToArray()),
                string.Join(" AND ", where.ToArray()));
            ExecuteNonreturnSqlStript(sqlStript);
            setValues.Clear();
            where.Clear();
        }

        private string GetUpdateSetString(PropertyInfo info, object dataObj)
        {
            string result = string.Empty;
            string formatStr = string.Empty;
            if (info.PropertyType.Equals(typeof(string)))
                formatStr = "{0}='{1}'";
            else
                formatStr = "{0}={1}";
            result = string.Format(formatStr, info.Name, info.GetValue(dataObj, null));
            return result;
        }

        public void UpdateTableData(string tableName, DataRow dataRow)
        {
            object tableInstance = GetTableInstance(tableName, dataRow);
            UpdateTableData(tableName, tableInstance);
        }

        public bool BeginTran()
        {
            bool result = true;
            try
            {
                useTran = true;
                SQLiteConnection conn = new SQLiteConnection(_ConnStr);
                conn.Open();
                tran = conn.BeginTransaction();
            }
            catch (Exception ex)
            {
                result = false;
                useTran = false;
            }
            return result;
        }

        public bool RollbackTran()
        {
            bool result = true;
            try
            {
                tran.Rollback();
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                if (null != tran)
                {
                    tran.Connection.Close();
                    tran.Dispose();
                    tran = null;
                }
                useTran = false;
            }
            return result;
        }

        public bool CommitTran()
        {
            bool result = true;
            try
            {
                tran.Commit();
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                if (null != tran)
                {
                    tran.Connection.Close();
                    tran.Dispose();
                    tran = null;
                }
                useTran = false;
            }
            return result;
        }

        #endregion

        #region IDisposable 成员

        public void Dispose()
        {
            if (useTran)
            {
                this.tran.Connection.Close();
                this.tran.Dispose();
            }
        }

        #endregion
    }
}
