using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

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
    /// 图片显示形式
    /// </summary>
    public enum ImageDisplayType
    {
        /// <summary>
        /// 全图
        /// </summary>
        Full = 1,
        /// <summary>
        /// 标准形式图片部分
        /// </summary>
        Normal = 2,
        /// <summary>
        /// 图片位于中间
        /// </summary>
        Middle = 3,
        /// <summary>
        /// 两张图片第一张
        /// </summary>
        TransverseFirst = 4,
        /// <summary>
        /// 两张图片第二张
        /// </summary>
        TransverseSecond = 5,
        /// <summary>
        /// 大图图片
        /// </summary>
        LargePic = 6
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
        public static readonly string New = "新建";
    }
    /// <summary>
    /// 套牌保存格式
    /// </summary>
    public struct DeckSaveFormat
    {
        public static readonly string Mws = "MWS";
        public static readonly string GPMagic = "GPMagic";
        public static readonly string CnList = "中文牌表";
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
        public static readonly string Connection = string.Format("Data Source={0}",
            Path.Combine(GPSoft.Helper.FunctionHelper.FunctionHelper.ApplicationPath, "GPMagic.db3"));
    }
    /// <summary>
    /// 系统各个文件夹的默认路径（相对路径）
    /// </summary>
    public struct DefaultDirectoryName
    {
        /// <summary>
        /// 卡牌图片文件夹
        /// </summary>
        public static readonly string CardPictures = "Pic";
        /// <summary>
        /// 卡牌数据导入/导出模板文件夹
        /// </summary>
        public static readonly string ImportExport = "Imp";
        /// <summary>
        /// 配置文件保存文件夹
        /// </summary>
        public static readonly string Config = "Set";
    }
    public struct DialogInformation
    {
        /// <summary>
        /// 对话框标题“警告”
        /// </summary>
        public static readonly string TitleWarning = "警告";
    }
    public struct DefaultExtention
    {
        public static readonly string ImportExport = "iem";
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
