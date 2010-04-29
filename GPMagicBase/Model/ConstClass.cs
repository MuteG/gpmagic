using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace GPSoft.GPMagic.GPMagicBase.Model
{
    /// <summary>
    /// 数据操作类型
    /// </summary>
    public enum DataOperateType
    {
        Insert,
        Delete,
        Update,
        Select
    }
    /// <summary>
    /// 数据操作类型对应的显示文字
    /// </summary>
    public struct DataOperateTypeDisplayWrods
    {
        public static readonly string Select = "查询";
        public static readonly string Delete = "删除";
        public static readonly string Update = "编辑";
        public static readonly string Insert = "添加";
    }
    /// <summary>
    /// 数据库表名
    /// </summary>
    public struct DatabaseTableNames
    {
        /// <summary>
        /// 全卡牌信息列表
        /// </summary>
        public static readonly string CardLibrary = "ListCardTotal";
        /// <summary>
        /// 卡牌稀有度
        /// </summary>
        public static readonly string CardRarity = "ListRarity";
    }
    /// <summary>
    /// SQLite数据库相关信息（连接字符串等）
    /// </summary>
    public struct SQLiteDatabaseInformation
    {
        public static readonly string Connection = "Data Source=./GPMagic.db3";
    }
    /// <summary>
    /// 表示稀有度的颜色
    /// </summary>
    public sealed class RarityColor
    {
        /// <summary>
        /// 普通（铁）
        /// </summary>
        public static readonly Color Common = Color.Black;
        /// <summary>
        /// 非普通（银）
        /// </summary>
        public static readonly Color Uncommon = Color.FromArgb(0x6E, 0x89, 0x92);
        /// <summary>
        /// 稀有（金）
        /// </summary>
        public static readonly Color Rare = Color.FromArgb(0xAE, 0x93, 0x5E);
        /// <summary>
        /// 密稀
        /// </summary>
        public static readonly Color MythicRare = Color.FromArgb(0xCB, 0x6A, 0x26);
    }
    public sealed class ConstClass
    {
        public static readonly string TitleOfCardInfomationForm = "卡牌信息";
    }
}
