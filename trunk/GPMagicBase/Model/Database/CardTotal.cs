using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel;
using GPSoft.GPMagic.GPMagicBase.SQLite;

namespace GPSoft.GPMagic.GPMagicBase.Model.Database
{
    public sealed class CardTotal : AbstractTableInstance
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
        /// <summary>
        /// 获取最大的卡牌编号
        /// </summary>
        public int MaxCardID
        {
            get
            {
                return GetMaxCardID();
            }
        }
        public CardTotal()
        {
            tableName = DatabaseTableNames.CardLibrary;
        }
        /// <summary>
        /// 新生成一个本实例对应的表结构实例
        /// </summary>
        /// <returns></returns>
        public override object NewDataInstance()
        {
            return new ListCardTotal();
        }
        /// <summary>
        /// 获得指定卡牌的异能
        /// </summary>
        /// <param name="cardID"></param>
        /// <returns></returns>
        public string GetAbilities(int cardID)
        {
            string result = string.Empty;
            List<string> abilitiesList = new List<string>();
            StringBuilder sqlBulider = new StringBuilder();
            sqlBulider.AppendLine("SELECT DISTINCT ListAbilities.AbilitiesName");
            sqlBulider.AppendLine("FROM RelateCardAbilities, ListAbilities");
            sqlBulider.AppendLine("WHERE RelateCardAbilities.AbilitiesID = ListAbilities.AbilitiesID AND CardID={0}");
            string sql = string.Format(sqlBulider.ToString(), cardID);
            DataTable tablle = this.dbop.ExecuteDataTableScript(sql);
            foreach (DataRow row in tablle.Rows)
            {
                abilitiesList.Add(row["AbilitiesName"].ToString());
            }
            result = string.Join(",", abilitiesList.ToArray());
            return result;
        }

        private int GetMaxCardID()
        {
            string sql = "SELECT seq FROM sqlite_sequence WHERE name='ListCardTotal'";
            DataTable table = dbop.ExecuteDataTableScript(sql);
            return Convert.ToInt32(table.Rows[0]["seq"].ToString());
        }

        public override void Add(object newObject)
        {
            base.Add(newObject);
            ((ListCardTotal)newObject).CardID = this.MaxCardID;
        }
    }

    public class ListCardTotal
    {
        private int cardID;

        private string symbol = string.Empty;

        private int collectorNumber;

        private string cardName = string.Empty;

        private string cardEnglishName = string.Empty;

        private string abilities = string.Empty;

        private string flavorText = string.Empty;

        private string manaCost = string.Empty;

        private string subTypeName = string.Empty;

        private string typeName = string.Empty;

        private int power;

        private int toughness;

        private int rarity;

        private string cardImage = string.Empty;

        private string painterName = string.Empty;

        private double cardPrice;

        private string faq = string.Empty;
        /// <summary>
        /// 获取或者设置卡牌ID
        /// </summary>
        [ColumnInfo(IsAutoIncrement = true, IsPrimaryKey = true)]
        [Description("卡牌ID")]
        public int CardID
        {
            get
            {
                return this.cardID;
            }
            set
            {
                this.cardID = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌所属系列缩写
        /// </summary>
        public string Symbol
        {
            get
            {
                return this.symbol;
            }
            set
            {
                this.symbol = value;
            }
        }
        /// <summary>
        /// 获取或者设置收藏编号
        /// </summary>
        [Description("收藏编号")]
        public int CollectorNumber
        {
            get
            {
                return this.collectorNumber;
            }
            set
            {
                this.collectorNumber = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌名称
        /// </summary>
        [ColumnInfo(IsDisplayKeyWord = true)]
        [Description("卡牌名称")]
        public string CardName
        {
            get
            {
                return this.cardName;
            }
            set
            {
                this.cardName = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌英文名称
        /// </summary>
        [Description("卡牌英文名称")]
        public string CardEnglishName
        {
            get
            {
                return this.cardEnglishName;
            }
            set
            {
                this.cardEnglishName = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌异能全文
        /// </summary>
        [Description("异能全文")]
        public string Abilities
        {
            get
            {
                return this.abilities;
            }
            set
            {
                this.abilities = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌背景描述
        /// </summary>
        [Description("背景描述")]
        public string FlavorText
        {
            get
            {
                return this.flavorText;
            }
            set
            {
                this.flavorText = value;
            }
        }
        /// <summary>
        /// 获取或者设置法术力费用
        /// </summary>
        [Description("法术力费用")]
        public string ManaCost
        {
            get
            {
                return this.manaCost;
            }
            set
            {
                this.manaCost = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌子类型
        /// </summary>
        [Description("子类型")]
        public string SubTypeName
        {
            get
            {
                return this.subTypeName;
            }
            set
            {
                this.subTypeName = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌类型
        /// </summary>
        [Description("卡牌类型")]
        public string TypeName
        {
            get
            {
                return this.typeName;
            }
            set
            {
                this.typeName = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌攻击力
        /// </summary>
        [Description("攻击力")]
        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌防御力
        /// </summary>
        [Description("防御力")]
        public int Toughness
        {
            get
            {
                return this.toughness;
            }
            set
            {
                this.toughness = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌稀有度
        /// </summary>
        [Description("稀有度")]
        public int Rarity
        {
            get
            {
                return this.rarity;
            }
            set
            {
                this.rarity = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌图片路径
        /// </summary>
        [Description("图片路径")]
        public string CardImage
        {
            get
            {
                return this.cardImage;
            }
            set
            {
                this.cardImage = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌画家
        /// </summary>
        [Description("画家")]
        public string PainterName
        {
            get
            {
                return this.painterName;
            }
            set
            {
                this.painterName = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌价格
        /// </summary>
        [Description("价格")]
        public double CardPrice
        {
            get
            {
                return this.cardPrice;
            }
            set
            {
                this.cardPrice = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌FAQ
        /// </summary>
        [Description("FAQ")]
        public string FAQ
        {
            get
            {
                return this.faq;
            }
            set
            {
                this.faq = value;
            }
        }

    }
}
