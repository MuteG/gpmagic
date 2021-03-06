﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using GPSoft.Games.GPMagic.GPMagicBase.SQLite;
using GPSoft.Games.GPMagic.GPMagicBase.Model;
using System.Data;
using System.ComponentModel;

namespace GPSoft.Games.GPMagic.GPMagicBase.Model.Database
{
    public abstract class AbstractTableInstance : ITableIntanceAction, IDisposable
    {
        protected DatabaseOperator dbop;
        private DataTable records = null;
        protected string tableName = string.Empty;
        /// <summary>
        /// 获取当前实例对应的数据表名
        /// </summary>
        public string TableName
        {
            get { return tableName; }
        }
        private Type dataInstanceType = null;
        /// <summary>
        /// 获取当前实例对应的数据表实例的类型
        /// </summary>
        public Type DataInstanceType
        {
            get
            {
                if (null == dataInstanceType)
                {
                    dataInstanceType = Type.GetType(
                        string.Format("{0}.{1}", this.GetType().Namespace, this.tableName));
                }
                return dataInstanceType;
            }
        }
        private string displayColumnName = null;
        /// <summary>
        /// 获取用来进行显示的列的名称
        /// </summary>
        public string DisplayColumnName
        {
            get
            {
                if (string.IsNullOrEmpty(this.displayColumnName))
                    this.GetColumnName();
                return displayColumnName;
            }
        }
        private string primaryKeyColumnName = null;
        /// <summary>
        /// 获取主键列的名称
        /// </summary>
        public string PrimaryKeyColumnName
        {
            get
            {
                if (string.IsNullOrEmpty(this.primaryKeyColumnName))
                    this.GetColumnName();
                return primaryKeyColumnName;
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
        private DataTable _TableClone = null;
        /// <summary>
        /// 获取对应的数据表的表结构
        /// </summary>
        public DataTable TableClone
        {
            get
            {
                if (null == _TableClone) this.GetTableClone();
                return _TableClone.Clone();
            }
        }
        public AbstractTableInstance()
        {
            this.dbop = new DatabaseOperator();
        }
        private void GetTableClone()
        {
            _TableClone = dbop.ExecuteDataTableScript(string.Format("SELECT * FROM {0} WHERE 1 = -1", this.tableName));
        }
        private void GetColumnName()
        {
            PropertyInfo[] properties = this.DataInstanceType.GetProperties();
            foreach (PropertyInfo info in properties)
            {
                object[] attributes = info.GetCustomAttributes(typeof(ColumnInfoAttribute), false);
                if (attributes.Length > 0)
                {
                    ColumnInfoAttribute colAttr = (ColumnInfoAttribute)attributes[0];
                    if (colAttr != null)
                    {
                        if (colAttr.IsDisplayKeyWord) this.displayColumnName = info.Name;
                        if (colAttr.IsPrimaryKey) this.primaryKeyColumnName = info.Name;
                        if (!string.IsNullOrEmpty(this.primaryKeyColumnName)
                            && !string.IsNullOrEmpty(this.displayColumnName)) break;
                    }
                }
            }
        }
        /// <summary>
        /// 新生成一个本实例对应的表结构实例
        /// </summary>
        /// <returns></returns>
        public abstract object NewDataInstance();
        #region ITableIntanceAction 成员

        /// <summary>
        /// 再次读入数据
        /// </summary>
        public void Reload()
        {
            records = dbop.SelectTableData(this.tableName);
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        public void Save(DataRow saveRow)
        {
            dbop.UpdateTableData(this.TableName, saveRow);
            Reload();
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        public void Save(object saveObj)
        {
            dbop.UpdateTableData(this.TableName, saveObj);
            Reload();
        }

        /// <summary>
        /// 新建一条记录
        /// </summary>
        /// <param name="newObject">要添加的表实例</param>
        public virtual void Add(object newObject)
        {
            dbop.InsertTableData(this.tableName, newObject);
            Reload();
        }
        /// <summary>
        /// 新建一条记录
        /// </summary>
        /// <param name="newRow">要添加的数据行</param>
        public virtual void Add(DataRow newRow)
        {
            dbop.InsertTableData(this.tableName, newRow);
            Reload();
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Remove(object deleteObject)
        {
            dbop.DeleteTableData(this.tableName, deleteObject);
            Reload();
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Remove(DataRow deleteRow)
        {
            dbop.DeleteTableData(this.tableName, deleteRow);
            Reload();
        }
        /// <summary>
        /// 获得Records中指定索引行的数据封装
        /// </summary>
        /// <param name="pkID">Records中作为主键的列的值</param>
        /// <returns>返回封装好的对象</returns>
        public object GetDataInstance(object pkID)
        {
            return GetDataInstance(pkID, this.DataInstanceType);
        }
        /// <summary>
        /// 获得Records中指定索引行的数据封装
        /// </summary>
        /// <param name="pkID">Records中作为主键的列的值</param>
        /// <param name="instanceType">与当前表结构兼容的实例类型</param>
        /// <returns>返回封装好的对象</returns>
        public object GetDataInstance(object pkID, Type instanceType)
        {
            object result = Activator.CreateInstance(instanceType);
            DataRow row = this.Records.Select(string.Format("{1}={0}", pkID, this.PrimaryKeyColumnName))[0];
            foreach (PropertyInfo info in this.DataInstanceType.GetProperties())
            {
                if (row.Table.Columns.Contains(info.Name))
                {
                    object value;
                    if (info.PropertyType.Equals(typeof(string)))
                        value = row[info.Name].ToString();
                    else if (info.PropertyType.Equals(typeof(double)))
                        value = Convert.ToDouble(row[info.Name]);
                    else
                        value = Convert.ToInt32(row[info.Name]);
                    info.SetValue(result, value, null);
                }
            }
            return result;
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
