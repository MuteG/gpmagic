using System;
using System.Collections.Generic;
using System.Text;

namespace GPSoft.GPMagic.GPMagicBase.Model
{
    public sealed class CardType : AbstractTableInstance
    {
        public CardType()
        {
            this.tableName = "ListType";
        }
        /// <summary>
        /// 新生成一个本实例对应的表结构实例
        /// </summary>
        /// <returns></returns>
        public override object NewDataInstance()
        {
            return new ListType();
        }
    }
    /// <summary>
    /// 卡牌类型
    /// </summary>
    public sealed class ListType
    {
        private int typeID;
        /// <summary>
        /// 获取或者设置卡牌类型编号
        /// </summary>
        [ColumnInfo(IsPrimaryKey = true, IsAutoIncrement = true)]
        public int TypeID
        {
            get { return typeID; }
            set { typeID = value; }
        }
        private string typeName = string.Empty;
        /// <summary>
        /// 获取或者设置卡牌类型
        /// </summary>
        [ColumnInfo(IsDisplayKeyWord = true)]
        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }
        private string englishName = string.Empty;
        /// <summary>
        /// 获取或者设置卡牌类型的英文名
        /// </summary>
        public string EnglishName
        {
            get { return englishName; }
            set { englishName = value; }
        }
    }
}
