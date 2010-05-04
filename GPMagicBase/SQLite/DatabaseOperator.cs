using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Reflection;
using System.Data;
using GPSoft.GPMagic.GPMagicBase.Model;

namespace GPSoft.GPMagic.GPMagicBase.SQLite
{
    public class DatabaseOperator : IDBOperate, IDisposable
    {
        private string _ConnStr = string.Empty;
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

        public DatabaseOperator(string connStr)
        {
            _ConnStr = connStr;
        }

        #region IDBOperate 成员

        /// <summary>
        /// 将一条数据封装成指定的对象
        /// </summary>
        /// <typeparam name="T">要封装成的对象类型</typeparam>
        /// <param name="dataRow">要进行封装的数据</param>
        /// <returns>返回封装好的对象</returns>
        public T EncapsulateDataRowToObject<T>(DataRow dataRow)
        {
            T result = Activator.CreateInstance<T>();
            PropertyInfo[] properties = result.GetType().GetProperties();
            foreach (PropertyInfo info in properties)
            {
                if (dataRow.Table.Columns.Contains(info.Name))
                {
                    info.SetValue(result, dataRow[info.Name], null);
                }
            }
            return result;
        }
        /// <summary>
        /// 执行没有返回值的数据库脚本
        /// <param name="sql">要执行的数据库脚本</param>
        /// </summary>
        private void ExecuteNonreturnSqlStript(string sql)
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

        public DataTable SelectScriptData(string sql)
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
            return SelectScriptData(sql);
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
            ColumnInfoAttribute pkidAttr = new ColumnInfoAttribute();
            pkidAttr.IsAutoIncrement = true;
            pkidAttr.IsPrimaryKey = true;
            foreach (PropertyInfo info in properties)
            {
                if (info.Attributes.Equals(pkidAttr)) continue;
                colNames.Add(info.Name);
                values.Add(info.GetValue(dataObj, null).ToString());
            }
            sqlStript = string.Format(sqlStript, tableName, 
                string.Join(",", colNames.ToArray()),
                string.Join(",", values.ToArray()));
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
            string classFullName = "GPSoft.GPMagic.GPMagicBase.Model." + tableName;
            InsertTableData(tableName, Activator.CreateInstance("GPMagicBase", classFullName));
        }

        public int DeleteTableData(string tableName, object dataObj)
        {
            throw new NotImplementedException();
        }

        public int DeleteScriptData(string sql)
        {
            throw new NotImplementedException();
        }

        public int UpdateTableData(string tableName, object dataObj)
        {
            throw new NotImplementedException();
        }

        public int UpdataTableData(string tableName, DataRow dataRow)
        {
            throw new NotImplementedException();
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
