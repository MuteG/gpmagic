using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using GPSoft.GPMagic.GPMagicBase.SQLite;

namespace GPSoft.GPMagic.GPMagicBase.Model
{
    public sealed class CardLibrary
    {
        private DatabaseOperator dbop;
        private DataTable records = null;
        /// <summary>
        /// 获取所有卡牌的集合
        /// </summary>
        public DataTable Records
        {
            get
            {
                if (null == records)
                {
                    Reload();
                }
                return records;
            }
        }
        /// <summary>
        /// 获取牌库中卡牌的数量
        /// </summary>
        public int Count
        {
            get
            {
                return null == Records ? 0 : records.Rows.Count;
            }
        }
        public CardLibrary()
        {
            dbop = new DatabaseOperator(SQLiteDatabaseInformation.Connection);
        }
        private DataTable GetAllCardInformation()
        {
            DataTable result = null;
            try
            {
                result = dbop.SelectTableData(DatabaseTableNames.CardLibrary);
            }
            catch (Exception ex)
            {
                result = null;
            }
            return result;
        }
        /// <summary>
        /// 数据再读入
        /// </summary>
        public void Reload()
        {
            records = GetAllCardInformation();
        }
    }
}
