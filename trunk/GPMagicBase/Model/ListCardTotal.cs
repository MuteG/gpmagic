using System;
using System.Collections.Generic;
using System.Text;

namespace GPSoft.GPMagic.GPMagicBase.Model
{
    public sealed class ListCardTotal
    {
        private int _CardID;

        private string _Symbol;

        private int _CollectorNumber;

        private string _CardName;

        private string _CardEnglishName;

        private string _Abilities;

        private string _FlavorText;

        private string _ManaCost;

        private string _SubTypeName;

        private string _TypeName;

        private int _Power;

        private int _Toughness;

        private int _Rarity;

        private string _CardImage;

        private string _PainterName;

        private int _CardPrice;

        private string _FAQ;

        public int CardID
        {
            get
            {
                return this._CardID;
            }
            set
            {
                this._CardID = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌所属系列缩写
        /// </summary>
        public string Symbol
        {
            get
            {
                return this._Symbol;
            }
            set
            {
                this._Symbol = value;
            }
        }
        /// <summary>
        /// 获取或者设置收藏编号
        /// </summary>
        public int CollectorNumber
        {
            get
            {
                return this._CollectorNumber;
            }
            set
            {
                this._CollectorNumber = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌名称
        /// </summary>
        public string CardName
        {
            get
            {
                return this._CardName;
            }
            set
            {
                this._CardName = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌英文名称
        /// </summary>
        public string CardEnglishName
        {
            get
            {
                return this._CardEnglishName;
            }
            set
            {
                this._CardEnglishName = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌异能全文
        /// </summary>
        public string Abilities
        {
            get
            {
                return this._Abilities;
            }
            set
            {
                this._Abilities = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌背景描述
        /// </summary>
        public string FlavorText
        {
            get
            {
                return this._FlavorText;
            }
            set
            {
                this._FlavorText = value;
            }
        }
        /// <summary>
        /// 获取或者设置法术力费用
        /// </summary>
        public string ManaCost
        {
            get
            {
                return this._ManaCost;
            }
            set
            {
                this._ManaCost = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌子类型
        /// </summary>
        public string SubTypeName
        {
            get
            {
                return this._SubTypeName;
            }
            set
            {
                this._SubTypeName = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌类型
        /// </summary>
        public string TypeName
        {
            get
            {
                return this._TypeName;
            }
            set
            {
                this._TypeName = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌攻击力
        /// </summary>
        public int Power
        {
            get
            {
                return this._Power;
            }
            set
            {
                this._Power = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌防御力
        /// </summary>
        public int Toughness
        {
            get
            {
                return this._Toughness;
            }
            set
            {
                this._Toughness = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌稀有度
        /// </summary>
        public int Rarity
        {
            get
            {
                return this._Rarity;
            }
            set
            {
                this._Rarity = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌图片路径
        /// </summary>
        public string CardImage
        {
            get
            {
                return this._CardImage;
            }
            set
            {
                this._CardImage = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌画家
        /// </summary>
        public string PainterName
        {
            get
            {
                return this._PainterName;
            }
            set
            {
                this._PainterName = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌价格
        /// </summary>
        public int CardPrice
        {
            get
            {
                return this._CardPrice;
            }
            set
            {
                this._CardPrice = value;
            }
        }
        /// <summary>
        /// 获取或者设置卡牌FAQ
        /// </summary>
        public string FAQ
        {
            get
            {
                return this._FAQ;
            }
            set
            {
                this._FAQ = value;
            }
        }

    }
}
