using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Reflection;
using System.Drawing;
using GPSoft.Helper.Files;
using GPSoft.Helper.Utility;
using System.IO;

namespace GPSoft.Games.GPMagic.GPMagicBase.Model.Deck
{
    /// <summary>
    /// 套牌列表中卡牌类型过滤统计设定
    /// </summary>
    [Serializable]
    public sealed class ConfigDeckFilter : IEquatable<ConfigDeckFilter>
    {
        private string fieldName = string.Empty;
        /// <summary>
        /// 获取或者设置过滤器对应的数据库中字段名
        /// </summary>
        [XmlElement]
        public string FieldName
        {
            get { return fieldName; }
            set { fieldName = value; }
        }
        private string fieldValue = string.Empty;
        /// <summary>
        /// 获取或者设置过滤器对应的数据库中字段的取值
        /// <para>即：只有该字段取值符合设定的数据才会被统计</para>
        /// <para>注意，如果对应的是多个值，则中间用逗号隔开</para>
        /// </summary>
        [XmlElement]
        public string FieldValue
        {
            get { return fieldValue; }
            set { fieldValue = value; }
        }
        private bool isReverse = false;
        /// <summary>
        /// 获取或者设置过滤条件是否为当前条件的相反
        /// <para>即：过滤的数据为除了当前条件以外的所有数据</para>
        /// </summary>
        [XmlElement]
        public bool IsReverse
        {
            get { return isReverse; }
            set { isReverse = value; }
        }
        private string displayName = string.Empty;
        /// <summary>
        /// 获取或者设置过滤器显示名
        /// </summary>
        [XmlElement]
        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
        private bool isShow = true;
        /// <summary>
        /// 获取或者设置此过滤器是否显示
        /// </summary>
        [XmlElement]
        public bool IsShow
        {
            get { return isShow; }
            set { isShow = value; }
        }
        private int backgroundColor = Color.White.ToArgb();
        /// <summary>
        /// 获取或者设置此过滤项的背景色的ARGB值
        /// </summary>
        [XmlElement]
        public int BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.FieldName.Equals((obj as ConfigDeckFilter).FieldName)
                && this.FieldValue.Equals((obj as ConfigDeckFilter).FieldValue);
        }

        #region IEquatable<ConfigDeckFilter> 成员

        public bool Equals(ConfigDeckFilter other)
        {
            return this.FieldName.Equals(other.FieldName) && this.FieldValue.Equals(other.FieldValue);
        }

        #endregion
    }
    /// <summary>
    /// 套牌列表中卡牌类型过滤统计设定列表
    /// </summary>
    [Serializable]
    [XmlRoot("DeckFilterConfig")]
    public sealed class ConfigDeckFilterList
    {
        private string configPath = Path.Combine(UtilityHelper.ApplicationPath,
            string.Format("{0}\\DeckFilter.set", DefaultDirectoryName.Setting));
        /// <summary>
        /// 获取或者设置配置文件保存路径
        /// </summary>
        [XmlIgnore]
        public string ConfigPath
        {
            get { return configPath; }
            set { configPath = value; }
        }
        private List<ConfigDeckFilter> deckFilterList = new List<ConfigDeckFilter>();
        /// <summary>
        /// 获取或者设置过滤项列表
        /// </summary>
        [XmlArray("FilterList"), XmlArrayItem("Filter")]
        public List<ConfigDeckFilter> DeckFilterList
        {
            get { return deckFilterList; }
            set { deckFilterList = value; }
        }
        public void Save()
        {
            FileHelper.CreateDirectory(Path.GetDirectoryName(this.configPath));
            ObjectXMLSerialize<ConfigDeckFilterList>.Save(this, this.configPath);
        }
        private static ConfigDeckFilterList filterList = null;
        public static ConfigDeckFilterList GetInstance()
        {
            filterList = new ConfigDeckFilterList();
            if (File.Exists(filterList.configPath))
            {
                filterList = ObjectXMLSerialize<ConfigDeckFilterList>.Load(filterList, filterList.configPath);
            }
            return filterList;
        }

        private void Reload()
        {
            filterList = ObjectXMLSerialize<ConfigDeckFilterList>.Load(filterList, filterList.configPath);
        }
    }
}
