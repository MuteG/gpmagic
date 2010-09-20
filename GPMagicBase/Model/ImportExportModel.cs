using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GPSoft.GPMagic.GPMagicBase.Model
{
    [Serializable]
    public sealed class ImportExportModel
    {
        private string _Path = string.Empty;
        /// <summary>
        /// 获取或者设置模板保存路径
        /// </summary>
        [XmlIgnore]
        public string Path
        {
            get { return _Path; }
            set { _Path = value; }
        }
        private string _Name = string.Empty;
        /// <summary>
        /// 获取或者设置模板名称
        /// </summary>
        [XmlElement]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private List<CardProperty> _CardProperties = new List<CardProperty>();
        /// <summary>
        /// 获取或者设置卡牌属性列表
        /// </summary>
        [XmlArray("PropertyList"), XmlArrayItem("CardProperty")]
        public List<CardProperty> CardProperties
        {
            get { return _CardProperties; }
            set { _CardProperties = value; }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return (obj as ImportExportModel).Path.Equals(this.Path);
        }
    }
    [Serializable]
    public sealed class CardProperty
    {
        private string _Name = string.Empty;
        /// <summary>
        /// 获取或者设置导入文件中作为标志的文字
        /// </summary>
        [XmlElement]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private string _PropertyName = string.Empty;
        /// <summary>
        /// 获取或者设置对应的卡牌属性名称
        /// </summary>
        [XmlElement]
        public string PropertyName
        {
            get { return _PropertyName; }
            set { _PropertyName = value; }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return (obj as CardProperty).Name.Equals(this.Name) ||
                (obj as CardProperty).PropertyName.Equals(this.PropertyName);
        }
    }
}
