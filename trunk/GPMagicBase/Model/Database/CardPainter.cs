namespace GPSoft.Games.GPMagic.GPMagicBase.Model.Database
{
    public sealed class CardPainter : AbstractTableInstance
    {
        public CardPainter()
        {
            this.tableName = "ListPainter";
        }
        /// <summary>
        /// 新生成一个本实例对应的表结构实例
        /// </summary>
        /// <returns></returns>
        public override object NewDataInstance()
        {
            return new ListPainter();
        }
    }

    public sealed class ListPainter
    {
        private int painterID;
        /// <summary>
        /// 获取或者设置画家的编号
        /// </summary>
        [ColumnInfo(IsAutoIncrement = true, IsPrimaryKey = true)]
        public int PainterID
        {
            get { return painterID; }
            set { painterID = value; }
        }
        private string painterName = string.Empty;
        /// <summary>
        /// 获取或者设置画家的姓名
        /// </summary>
        [ColumnInfo(IsDisplayKeyWord = true)]
        public string PainterName
        {
            get { return painterName; }
            set { painterName = value; }
        }
    }
}
