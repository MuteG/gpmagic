using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using GPSoft.GPMagic.GPMagicBase.SQLite;

namespace GPSoft.GPMagic.GPMagicBase.Model
{
    public sealed class CardLibrary : AbstractTableInstance
    {
        /// <summary>
        /// 获取牌库中卡牌的数量
        /// </summary>
        public int Count
        {
            get
            {
                return null == Records ? 0 : Records.Rows.Count;
            }
        }
        public CardLibrary()
        {
            tableName = DatabaseTableNames.CardLibrary;
        }
    }
}
