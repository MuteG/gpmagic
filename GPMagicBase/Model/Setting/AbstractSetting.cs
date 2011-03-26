using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows;
using System.Xml.Serialization;
using System.Reflection;
using System.ComponentModel;
using GPSoft.Helper.Files;

namespace GPSoft.GPMagic.GPMagicBase.Model.Setting
{
    [Serializable]
    public abstract class AbstractSetting : ISetting
    {
        protected static ISetting m_Instance = null;

        /// <summary>
        /// 获取配置文件的完整路径
        /// </summary>
        [XmlIgnore]
        public string SettingPath
        {
            get
            {
                object[] attributes = this.GetType().GetCustomAttributes(typeof(XmlRootAttribute), false);
                string assemblyName = attributes.Length > 0 ?
                    (attributes[0] as XmlRootAttribute).ElementName : this.GetType().Assembly.GetName().Name;
                return Path.Combine(Environment.CurrentDirectory,
                    string.Format("{0}\\{1}.set", DefaultDirectoryName.Setting, assemblyName));
            }
        }

        #region ISetting 成员

        public virtual void Save()
        {
            FileHelper.CreateDirectory(Path.GetDirectoryName(SettingPath));
            ObjectXMLSerialize<ISetting>.Save(this, SettingPath);
        }

        public virtual void Reload()
        {
            if (!File.Exists(SettingPath))
            {
                RestoreToDefault();
                Save();
            }
            m_Instance = ObjectXMLSerialize<ISetting>.Load(this, SettingPath);
            this.Assign(m_Instance);
        }

        public abstract void RestoreToDefault();

        #endregion

        protected abstract void Assign(ISetting another);
    }
}
