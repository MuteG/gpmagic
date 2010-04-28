using System;
using System.Collections.Generic;
using System.Text;

namespace GP.GPMagic.GPMagicBase.Model
{
    public enum EditStatus
    {
        Insert,
        Delete,
        Update,
        Select
    }
    public sealed class ConstClass
    {
        public static readonly string TITLE_CARDINFO = "卡牌信息 - {0}";

        public static readonly string EDITSTATUS_SELECT = "查询";
        public static readonly string EDITSTATUS_DELETE = "删除";
        public static readonly string EDITSTATUS_UPDATE = "编辑";
        public static readonly string EDITSTATUS_INSERT = "添加";

        public static readonly string SQL_CONNACTION = "Data Source=./GPMagic.db3";
        public static readonly string SQL_TABLENAME_TOTALCARD = "ListCardTotal";
    }
}
