using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using GPSoft.GPMagic.GPMagicBase.SQLite;
using GPSoft.GPMagic.GPMagicBase.Model;

namespace GPSoft.GPMagic.GPSearch.Command
{
    public sealed class DatabaseOperate
    {
        private static DBOperator dbop;
        private DatabaseOperate() { }
        public static void Init()
        {
            dbop = new DBOperator(ConstClass.SQL_CONNACTION);
        }
        public static DataTable GetAllCardInfo()
        {
            DataTable result = null;
            result = dbop.SelectTableData(ConstClass.SQL_TABLENAME_TOTALCARD);
            return result;
        }
    }
}
