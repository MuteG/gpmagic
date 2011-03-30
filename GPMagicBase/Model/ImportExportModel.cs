using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GPSoft.Games.GPMagic.GPMagicBase.Model
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
        private ImportModelType _Type = ImportModelType.None;
        /// <summary>
        /// 获取或者设置模板类型
        /// </summary>
        [XmlElement]
        public ImportModelType Type
        {
            get { return _Type; }
            set { _Type = value; }
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
        private string _Description = string.Empty;
        /// <summary>
        /// 获取或者设置模板说明
        /// </summary>
        [XmlElement]
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
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
        public void Assign(ImportExportModel another)
        {
            this.Name = another.Name;
            this.Path = another.Path;
            this.Description = another.Description;
            this.Type = another.Type;
            this.CardProperties.Clear();
            this.CardProperties.AddRange(another.CardProperties.ToArray());
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
    /// <summary>
    /// 导入导出模板类型
    /// </summary>
    [Serializable]
    public enum ImportModelType
    {
        /// <summary>
        /// 未指定
        /// </summary>
        None = 0,
        /// <summary>
        /// 信息列表型
        /// </summary>
        List = 1,
        /// <summary>
        /// 表格型
        /// </summary>
        Table = 2
    }
}
