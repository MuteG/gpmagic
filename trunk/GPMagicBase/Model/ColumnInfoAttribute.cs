using System;
using System.Collections.Generic;
using System.Text;

namespace GPSoft.GPMagic.GPMagicBase.Model
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ColumnInfoAttribute : Attribute
    {
        bool isPrimaryKey = false;
        bool isAutoIncrement = false;
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

        public override bool Equals(object obj)
        {
            bool result = false;
            result = obj is ColumnInfoAttribute;
            if (result)
            {
                ColumnInfoAttribute colInfoObj = obj as ColumnInfoAttribute;
                result = (this.IsAutoIncrement == colInfoObj.IsAutoIncrement) &&
                    (this.IsPrimaryKey == colInfoObj.IsPrimaryKey);
            }
            return result;
        }
    }
}
