using System;
using System.Collections.Generic;
using System.Text;
using GPSoft.GPMagic.GPMagicBase.SQLite;
using GPSoft.GPMagic.GPMagicBase.Model;
using System.Data;

namespace GPSoft.GPMagic.GPMagicBase
{
    public abstract class AbstractTableInstance : ITableIntanceAction, IDisposable
    {
        private DatabaseOperator dbop;
        private DataTable records = null;
        protected string tableName = string.Empty;
        /// <summary>
        /// 获得全部记录数据
        /// </summary>
        public DataTable Records
        {
            get
            {
                if (null == records) this.Reload();
                return records;
            }
        }
        public AbstractTableInstance()
        {
            this.dbop = new DatabaseOperator(SQLiteDatabaseInformation.Connection);
        }
        private DataTable GetTableRecords()
        {
            DataTable result = null;
            result = dbop.SelectTableData(this.tableName);
            return result;
        }
        #region ITableIntanceAction 成员

        /// <summary>
        /// 再次读入数据
        /// </summary>
        public void Reload()
        {
            records = GetTableRecords();
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        public void Save()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 在指定位置插入记录
        /// </summary>
        public void InsertAt()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 新建一条记录
        /// </summary>
        public void NewRecord()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 在尾部追加一条记录
        /// </summary>
        public void Append()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Remove()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IDisposable 成员

        public void Dispose()
        {
            if (null != this.records) records.Dispose();
            if (null != this.dbop) dbop.Dispose();
        }

        #endregion
    }
}
