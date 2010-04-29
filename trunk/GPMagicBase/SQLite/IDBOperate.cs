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
        /// 将一行数据封装成指定类型的实例
        /// </summary>
        /// <typeparam name="T">指定要封装成的类型</typeparam>
        /// <param name="row">要进行封装的数据行</param>
        /// <returns>封装成的实例</returns>
        T DataRowToObject<T>(DataRow row);
        /// <summary>
        /// 执行查询语句
        /// </summary>
        /// <param name="sql">查询字符串</param>
        /// <returns>查询结果</returns>
        DataTable SelectScriptData(string sql);
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
        /// <returns>影响到的行数</returns>
        int InsertTableData(string tableName, object dataObj);
        /// <summary>
        /// 将一行数据插入到指定的表中
        /// </summary>
        /// <param name="tableName">要进行插入的表名</param>
        /// <param name="dataRow">数据行</param>
        /// <returns>影响到的行数</returns>
        int InsertTableData(string tableName, DataRow dataRow);
        /// <summary>
        /// 从指定表中删除指定数据实例对应的数据行
        /// </summary>
        /// <param name="tableName">要进行删除的表名</param>
        /// <param name="dataObj">要删除的数据实例</param>
        /// <returns>影响到的行数</returns>
        int DeleteTableData(string tableName, object dataObj);
        /// <summary>
        /// 执行删除语句
        /// </summary>
        /// <param name="sql">删除语句</param>
        /// <returns>影响到的行数</returns>
        int DeleteScriptData(string sql);
        /// <summary>
        /// 将指定数据实例更新到指定表中
        /// </summary>
        /// <param name="tableName">要进行更新的表名</param>
        /// <param name="dataObj">要更新的数据实例</param>
        /// <returns>影响到的行数</returns>
        int UpdateTableData(string tableName, object dataObj);
        /// <summary>
        /// 将指定的数据行更新到指定的表中
        /// </summary>
        /// <param name="tableName">要进行更新的表名</param>
        /// <param name="dataRow">要更新的数据行</param>
        /// <returns>影响到的行数</returns>
        int UpdataTableData(string tableName, DataRow dataRow);
    }
}
