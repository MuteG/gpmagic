using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;
using GPSoft.GPMagic.GPMagicBase.SQLite;

namespace GPSoft.GPMagic.GPMagicBase.Model
{
    public sealed class CardRarity : AbstractTableInstance
    {
        public CardRarity()
        {
            this.tableName = DatabaseTableNames.CardRarity;
        }
        public Color GetRarityColor(int rarity)
        {
            Color result = RarityColor.Common;
            switch (rarity)
            {
                case 1:
                    {
                        result = RarityColor.Common;
                        break;
                    }
                case 2:
                    {
                        result = RarityColor.Uncommon;
                        break;
                    }
                case 3:
                    {
                        result = RarityColor.Rare;
                        break;
                    }
                case 4:
                    {
                        result = RarityColor.MythicRare;
                        break;
                    }
            }
            return result;
        }
    }
    /// <summary>
    /// 稀有度
    /// </summary>
    public struct Rarity
    {
        /// <summary>
        /// 稀有度编号
        /// </summary>
        int RarityID;
        /// <summary>
        /// 稀有度名称
        /// </summary>
        string RarityName;
    }
}
