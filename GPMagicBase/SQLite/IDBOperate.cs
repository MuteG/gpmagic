using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GPSoft.GPMagic.GPMagicBase.SQLite
{
    internal interface IDBOperate
    {
        bool BeginTran();
        bool RollbackTran();
        bool CommitTran();
        /// <summary>
        /// 将一条数据封装成指定的对象
        /// </summary>
        /// <typeparam name="T">要封装成的对象类型</typeparam>
        /// <param name="dataRow">要进行封装的数据</param>
        /// <returns>返回封装好的对象</returns>
        T EncapsulateDataRowToObject<T>(DataRow dataRow);
        /// <summary>
        /// 执行查询语句
        /// </summary>
        /// <param name="sql">查询字符串</param>
        /// <returns>查询结果</returns>
        DataTable ExecuteDataTableScript(string sql);
        /// <summary>
        /// 查询指定表的全部数据
        /// </summary>
        /// <param name="tableName">要进行查询的表名</param>
        /// <returns>查询的结果</returns>
        DataTable SelectTableData(string tableName);
        /// <summary>
        /// 将一个封装好的数据实例插入到指定的表中
        /// </summary>
        /// <param name="tableName">要进行插入的表名</param>
        /// <param name="dataObj">封装好的数据实例</param>
        void InsertTableData(string tableName, object dataObj);
        /// <summary>
        /// 将一行数据插入到指定的表中
        /// </summary>
        /// <param name="tableName">要进行插入的表名</param>
        /// <param name="dataRow">数据行</param>
        void InsertTableData(string tableName, DataRow dataRow);
        /// <summary>
        /// 从指定表中删除指定数据实例对应的数据
        /// </summary>
        /// <param name="tableName">要进行删除的表名</param>
        /// <param name="dataObj">要删除的数据实例</param>
        /// <returns>影响到的行数</returns>
        void DeleteTableData(string tableName, object dataObj);
        /// <summary>
        /// 从指定表中删除指定数据行对应的数据
        /// </summary>
        /// <param name="tableName">要进行删除的表名</param>
        /// <param name="dataRow">数据行</param>
        void DeleteTableData(string tableName, DataRow dataRow);
        /// <summary>
        /// 将指定数据实例更新到指定表中
        /// </summary>
        /// <param name="tableName">要进行更新的表名</param>
        /// <param name="dataObj">要更新的数据实例</param>
        /// <returns>影响到的行数</returns>
        void UpdateTableData(string tableName, object dataObj);
        /// <summary>
        /// 将指定的数据行更新到指定的表中
        /// </summary>
        /// <param name="tableName">要进行更新的表名</param>
        /// <param name="dataRow">要更新的数据行</param>
        /// <returns>影响到的行数</returns>
        void UpdateTableData(string tableName, DataRow dataRow);
    }
}
