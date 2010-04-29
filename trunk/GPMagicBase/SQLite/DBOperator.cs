using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Reflection;
using System.Data;

namespace GPSoft.GPMagic.GPMagicBase.SQLite
{
    public class DBOperator : IDBOperate
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

        public DBOperator(string connStr)
        {
            _ConnStr = connStr;
        }

        #region IDBOperate 成员

        public T DataRowToObject<T>(DataRow row)
        {
            T result = Activator.CreateInstance<T>();
            Type type = typeof(T);
            DataColumnCollection rowColumns = row.Table.Columns;
            foreach (PropertyInfo info in type.GetProperties())
            {
                if (rowColumns.Contains(info.Name))
                {
                    info.SetValue(result, row[info.Name], null);
                }
            }
            return result;
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

        public int InsertTableData(string tableName, object dataObj)
        {
            throw new NotImplementedException();
        }

        public int InsertTableData(string tableName, DataRow dataRow)
        {
            throw new NotImplementedException();
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
    }
}
