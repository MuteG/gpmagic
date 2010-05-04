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
        /// <summary>
        /// 新生成一个本实例对应的表结构实例
        /// </summary>
        /// <returns></returns>
        public override object NewTableInstance()
        {
            return new ListCardTotal();
        }
    }

    public sealed class ListCardTotal
    {
        private int cardID;

        private string symbol;

        private int collectorNumber;

        private string cardName;

        private string cardEnglishName;

        private string abilities;

        private string flavorText;

        private string manaCost;

        private string subTypeName;

        private string typeName;

        private int power;

        private int toughness;

        private int rarity;

        private string cardImage;

        private string painterName;

        private int cardPrice;

        private string faq;
        /// <summary>
        /// 获取或者设置卡牌ID
        /// </summary>
        [ColumnInfo(IsAutoIncrement = true, IsPrimaryKey = true)]
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
        public int CardPrice
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
