using System;
using System.Collections.Generic;
using System.Text;

namespace GPSoft.Games.GPMagic.GPMagicBase.Model.Database
{
    public sealed class CardImageType : AbstractTableInstance
    {
        public CardImageType()
        {
            this.tableName = "ListCardImageType";
        }
        /// <summary>
        /// 新生成一个本实例对应的表结构实例
        /// </summary>
        /// <returns></returns>
        public override object NewDataInstance()
        {
            return new ListCardImageType();
        }
    }
    /// <summary>
    /// 卡牌图片展示形式
    /// </summary>
    public sealed class ListCardImageType
    {
        private int cardImageTypeID;
        private string comment = string.Empty;
        /// <summary>
        /// 获取或者设置图片类型编号
        /// </summary>
        [ColumnInfo(IsAutoIncrement = true, IsPrimaryKey = true)]
        public int CardImageTypeID
        {
            get { return cardImageTypeID; }
            set { cardImageTypeID = value; }
        }
        /// <summary>
        /// 获取或者设置图片类型说明
        /// </summary>
        [ColumnInfo(IsDisplayKeyWord = true)]
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
    }
}
