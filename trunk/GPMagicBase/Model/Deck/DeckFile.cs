using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Serialization;

namespace GPSoft.GPMagic.GPMagicBase.Model.Deck
{
    /// <summary>
    /// 套牌信息
    /// </summary>
    [Serializable]
    public sealed class DeckFile
    {
        private string name = string.Empty;
        /// <summary>
        /// 获取或者设置套牌名称
        /// </summary>
        [XmlElement]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string description = string.Empty;
        /// <summary>
        /// 获取或者设置套牌说明
        /// </summary>
        [XmlElement]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>
        /// 获取当前套牌内卡牌总数
        /// </summary>
        [XmlIgnore]
        public int Count
        {
            get { return GetDeckCardCount(); }
        }

        private int GetDeckCardCount()
        {
            int count = 0;
            foreach (DeckCard card in this._Cards)
            {
                count += card.Count;
            }
            foreach (DeckCard sbCard in this._SideboardCards)
            {
                count += sbCard.Count;
            }
            return count;
        }
        private List<DeckCard> _Cards = new List<DeckCard>();
        /// <summary>
        /// 获取或者设置包含的卡牌信息
        /// </summary>
        [XmlArray("Cards"), XmlArrayItem("Card")]
        public List<DeckCard> Cards
        {
            get { return _Cards; }
            set { _Cards = value; }
        }

        private List<DeckCard> _SideboardCards = new List<DeckCard>();
        /// <summary>
        /// 获取或者设置包含的卡牌信息
        /// </summary>
        [XmlArray("SBCards"), XmlArrayItem("Card")]
        public List<DeckCard> SideboardCards
        {
            get { return _SideboardCards; }
            set { _SideboardCards = value; }
        }
        
        private DataTable _CardRecords = null;
        /// <summary>
        /// 获取或者设置套牌所包含卡牌的数据库记录
        /// </summary>
        [XmlIgnore]
        public DataTable CardRecords
        {
            get
            {
                if (null == _CardRecords)
                {
                    _CardRecords = new CardLibrary().TableClone;
                }
                return _CardRecords;
            }
        }
    }
    /// <summary>
    /// 套牌中包含的卡牌信息
    /// </summary>
    [Serializable]
    public sealed class DeckCard
    {
        private int count;
        /// <summary>
        /// 获取或者设置当前卡牌总数
        /// </summary>
        [XmlElement]
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private string cardName = string.Empty;
        /// <summary>
        /// 获取或者设置卡牌名
        /// </summary>
        [XmlElement]
        public string CardName
        {
            get { return cardName; }
            set { cardName = value; }
        }
        private string cardEnglishName = string.Empty;
        /// <summary>
        /// 获取或者设置卡牌英文名
        /// </summary>
        [XmlElement]
        public string CardEnglishName
        {
            get { return cardEnglishName; }
            set { cardEnglishName = value; }
        }
        private string symbol = string.Empty;
        /// <summary>
        /// 获取或者设置卡牌所属系列的简称
        /// </summary>
        [XmlElement]
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }
        private int cardID;
        /// <summary>
        /// 获取或者设置卡牌ID
        /// </summary>
        [XmlElement]
        public int CardID
        {
            get { return cardID; }
            set { cardID = value; }
        }
    }
}
