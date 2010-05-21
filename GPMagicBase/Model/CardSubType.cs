﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GPSoft.GPMagic.GPMagicBase.Model
{
    public sealed class CardSubType : AbstractTableInstance
    {
        public CardSubType()
        {
            this.tableName = "ListSubType";
        }
        /// <summary>
        /// 新生成一个本实例对应的表结构实例
        /// </summary>
        /// <returns></returns>
        public override object NewDataInstance()
        {
            return new ListSubType();
        }
    }
    /// <summary>
    /// 卡牌子类型
    /// </summary>
    public sealed class ListSubType
    {
        int subTypeID;
        string subTypeName;
        /// <summary>
        /// 获取或者设置卡牌子类型名称
        /// </summary>
        [ColumnInfo(IsDisplayKeyWord = true)]
        public string SubTypeName
        {
            get { return subTypeName; }
            set { subTypeName = value; }
        }
        /// <summary>
        /// 获取或者设置卡牌子类型编号（主键、自增）
        /// </summary>
        [ColumnInfo(IsAutoIncrement=true, IsPrimaryKey=true)]
        public int SubTypeID
        {
            get { return subTypeID; }
            set { subTypeID = value; }
        }
    }
}
