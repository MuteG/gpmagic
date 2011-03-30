using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel;
using GPSoft.Games.GPMagic.GPMagicBase.Model.Database;
using GPSoft.Helper.Files;

namespace GPSoft.Games.GPMagic.GPMagicBase.Model.Setting
{
    [Serializable]
    [XmlRoot("HeaderSetting")]
    public class HeaderFieldsSetting : AbstractSetting
    {
        private List<HeaderAttrabute> m_LibraryHeadersSetting = new List<HeaderAttrabute>();

        /// <summary>
        /// 获取或者设置牌库表头信息列表
        /// </summary>
        [XmlArray("LibHeaders"), XmlArrayItem("Header")]
        public List<HeaderAttrabute> LibraryHeadersSetting
        {
            get { return m_LibraryHeadersSetting; }
            set { m_LibraryHeadersSetting = value; }
        }

        [XmlIgnore]
        public int LibraryHeadersCount
        {
            get
            {
                int count = 0;
                foreach (HeaderAttrabute header in m_LibraryHeadersSetting)
                {
                    if (header.IsShow) count++;
                }
                return count;
            }
        }

        private List<HeaderAttrabute> m_DeckHeadersSetting = new List<HeaderAttrabute>();

        /// <summary>
        /// 获取或者设置套牌表头信息列表
        /// </summary>
        [XmlArray("DeckHeaders"), XmlArrayItem("Header")]
        public List<HeaderAttrabute> DeckHeadersSetting
        {
            get { return m_DeckHeadersSetting; }
            set { m_DeckHeadersSetting = value; }
        }

        [XmlIgnore]
        public int DeckHeadersCount
        {
            get
            {
                int count = 0;
                foreach (HeaderAttrabute header in m_DeckHeadersSetting)
                {
                    if (header.IsShow) count++;
                }
                return count;
            }
        }

        public override void RestoreToDefault()
        {
            LibraryHeadersSetting.Clear();
            DeckHeadersSetting.Clear();
            PropertyInfo[] properties = typeof(ListCardTotal).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                object[] attributes = property.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes.Length > 0)
                {
                    DescriptionAttribute description = (DescriptionAttribute)attributes[0];
                    if (description != null)
                    {
                        HeaderAttrabute header = new HeaderAttrabute();
                        header.Name = property.Name;
                        header.Text = description.Description;
                        header.Width = 80;
                        header.IsShow = true;
                        LibraryHeadersSetting.Add(header);
                        DeckHeadersSetting.Add(header);
                    }
                }
            }
        }

        protected override void Assign(ISetting another)
        {
            this.DeckHeadersSetting.Clear();
            this.DeckHeadersSetting.AddRange((another as HeaderFieldsSetting).DeckHeadersSetting);

            this.LibraryHeadersSetting.Clear();
            this.LibraryHeadersSetting.AddRange((another as HeaderFieldsSetting).LibraryHeadersSetting);
        }
    }

    /// <summary>
    /// 表头信息
    /// </summary>
    [Serializable]
    public sealed class HeaderAttrabute
    {
        private string m_Name;
        /// <summary>
        /// 获取或者设置表头名称
        /// </summary>
        [XmlAttribute]
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        private string m_Text;
        /// <summary>
        /// 获取或者设置表头显示文字
        /// </summary>
        [XmlAttribute]
        public string Text
        {
            get { return m_Text; }
            set { m_Text = value; }
        }

        private int m_Width = 80;
        /// <summary>
        /// 获取或者设置表头字段宽度
        /// </summary>
        [XmlAttribute]
        public int Width
        {
            get { return m_Width; }
            set { m_Width = value; }
        }

        private bool m_IsShow = true;
        /// <summary>
        /// 获取或者设置表头是否显示
        /// </summary>
        [XmlAttribute]
        public bool IsShow
        {
            get { return m_IsShow; }
            set { m_IsShow = value; }
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            HeaderAttrabute another = obj as HeaderAttrabute;
            return null != another &&
                string.Compare(another.Name, this.Name) == 0;
        }

        public void Assign(HeaderAttrabute another)
        {
            this.Name = another.Name;
            this.Text = another.Text;
            this.Width = another.Width;
            this.IsShow = another.IsShow;
        }
    }
}
