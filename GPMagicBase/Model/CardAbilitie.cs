using System;
using System.Collections.Generic;
using System.Text;

namespace GPSoft.GPMagic.GPMagicBase.Model
{
    public sealed class CardAbilitie : AbstractTableInstance
    {
        public CardAbilitie()
        {
            this.tableName = "ListAbilities";
        }
        /// <summary>
        /// 新生成一个本实例对应的表结构实例
        /// </summary>
        /// <returns></returns>
        public override object NewTableInstance()
        {
            return new ListAbilities();
        }
    }
    /// <summary>
    /// 卡牌异能
    /// </summary>
    public sealed class ListAbilities
    {
        int abilitiesID;
        string abilitiesName;
        string reminderText;
        /// <summary>
        /// 获取或者设置异能说明文字
        /// </summary>
        public string ReminderText
        {
            get { return reminderText; }
            set { reminderText = value; }
        }
        /// <summary>
        /// 获取或者设置异能名称
        /// </summary>
        [ColumnInfo(IsDisplayKeyWord = true)]
        public string AbilitiesName
        {
            get { return abilitiesName; }
            set { abilitiesName = value; }
        }
        /// <summary>
        /// 获取或者设置异能编号（主键、自增）
        /// </summary>
        [ColumnInfo(IsPrimaryKey = true, IsAutoIncrement = true)]
        public int AbilitiesID
        {
            get { return abilitiesID; }
            set { abilitiesID = value; }
        }
    }
}
