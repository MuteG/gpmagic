using System;
using System.Collections.Generic;
using System.Text;
using GPSoft.GPMagic.GPMagicBase.SQLite;
using GPSoft.GPMagic.GPMagicBase.Model;
using System.Data;

namespace GPSoft.GPMagic.GPMagicBase.Model
{
    public abstract class AbstractTableInstance : ITableIntanceAction, IDisposable
    {
        private DatabaseOperator dbop;
        private DataTable records = null;
        protected string tableName = string.Empty;
        /// <summary>
        /// 获取当前实例对应的数据表名
        /// </summary>
        public string TableName
        {
            get { return tableName; }
        }
        private Type tableInstanceType = null;
        /// <summary>
        /// 获取当前实例对应的数据表实例的类型
        /// </summary>
        public Type TableInstanceType
        {
            get
            {
                if (null == tableInstanceType)
                {
                    tableInstanceType = Type.GetType(
                        string.Format("{0}.{1}", this.GetType().Namespace, this.tableName));
                }
                return tableInstanceType;
            }
        }
        /// <summary>
        /// 获取全部记录数据
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
        /// <summary>
        /// 新生成一个本实例对应的表结构实例
        /// </summary>
        /// <returns></returns>
        public abstract object NewTableInstance();
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
        /// 新建一条记录
        /// </summary>
        /// <param name="newObject">要添加的表实例</param>
        public void Add(object newObject)
        {
            dbop.InsertTableData(this.tableName, newObject);
        }
        /// <summary>
        /// 新建一条记录
        /// </summary>
        /// <param name="newRow">要添加的数据行</param>
        public void Add(DataRow newRow)
        {
            dbop.InsertTableData(this.tableName, newRow);
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
