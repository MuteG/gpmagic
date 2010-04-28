using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using GP.GPMagic.GPMagicBase.SQLite;
using GP.GPMagic.GPMagicBase.Model;

namespace GP.GPMagic.GPSearch.Command
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
