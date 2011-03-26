using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GPSoft.GPMagic.GPMagicBase.Model.Setting
{
    public class SettingManager : ISetting
    {
        private List<ISetting> m_Settings = new List<ISetting>();

        public SettingManager()
        {
            Reload();
        }

        public ISetting GetInstance<T>()
        {
            ISetting result = null;
            foreach (ISetting setting in m_Settings)
            {
                if (setting is T)
                {
                    result = setting;
                    break;
                }
            }
            return result;
        }

        #region ISetting 成员

        public void Save()
        {
            foreach (ISetting setting in m_Settings)
            {
                setting.Save();
            }
        }

        public void Reload()
        {
            Assembly currentAssembly = Assembly.GetAssembly(this.GetType());
            Type[] typeList = currentAssembly.GetTypes();
            foreach (Type type in typeList)
            {
                if (type.IsSubclassOf(typeof(AbstractSetting)))
                {
                    ISetting instance = Activator.CreateInstance(type) as ISetting;
                    if (m_Settings.Contains(instance))
                    {
                        m_Settings[m_Settings.IndexOf(instance)].Reload();
                    }
                    else
                    {
                        instance.Reload();
                        m_Settings.Add(instance);
                    }
                }
            }
        }

        public void RestoreToDefault()
        {
            foreach (ISetting setting in m_Settings)
            {
                setting.RestoreToDefault();
            }
        }

        #endregion
    }
}
