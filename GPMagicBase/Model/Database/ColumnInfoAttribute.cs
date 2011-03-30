using System;
using System.Collections.Generic;
using System.Text;

namespace GPSoft.Games.GPMagic.GPMagicBase.Model.Database
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ColumnInfoAttribute : Attribute
    {
        bool isPrimaryKey = false;
        bool isAutoIncrement = false;
        bool isDisplayKeyWord = false;
        /// <summary>
        /// 获取或者设置是否是用来显示简略信息的关键字字段
        /// </summary>
        public bool IsDisplayKeyWord
        {
            get { return isDisplayKeyWord; }
            set { isDisplayKeyWord = value; }
        }
        /// <summary>
        /// 获取或者设置是否是自增列
        /// </summary>
        public bool IsAutoIncrement
        {
            get { return isAutoIncrement; }
            set { isAutoIncrement = value; }
        }
        /// <summary>
        /// 获取或者设置是否是主键
        /// </summary>
        public bool IsPrimaryKey
        {
            get { return isPrimaryKey; }
            set { isPrimaryKey = value; }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
