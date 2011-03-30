using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GPSoft.Games.GPMagic.GPSearch.Model
{
    [Serializable]
    public sealed class HeaderField
    {
        private string m_FieldName = string.Empty;
        /// <summary>
        /// 获取或者设置字段名
        /// </summary>
        [XmlAttribute]
        public string FieldName
        {
            get { return m_FieldName; }
            set { m_FieldName = value; }
        }

        private string m_Description = string.Empty;
        /// <summary>
        /// 获取或者设置该字段作为表头时显示的文字
        /// </summary>
        [XmlAttribute]
        public string Description
        {
            get { return m_Description; }
            set { m_Description = value; }
        }

        public void Assign(HeaderField another)
        {
            this.FieldName = another.FieldName;
            this.Description = another.Description;
        }

        public override int GetHashCode()
        {
            return FieldName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool isEqual = false;
            if (null != obj && obj is HeaderField)
            {
                HeaderField another = obj as HeaderField;
                isEqual = this.FieldName.Equals(another.FieldName);
            }
            return isEqual;
        }
    }
}
