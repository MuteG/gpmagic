namespace GPSoft.GPMagic.GPMagicBase.Model.Database
{
    /// <summary>
    /// 卡牌所属小系列
    /// </summary>
    public sealed class CardExpansions : AbstractTableInstance
    {
        public CardExpansions()
        {
            this.tableName = "ListExpansions";
        }
        /// <summary>
        /// 新生成一个本实例对应的表结构实例
        /// </summary>
        /// <returns></returns>
        public override object NewDataInstance()
        {
            return new ListExpansions();
        }
    }
    /// <summary>
    /// 卡牌所属小系列
    /// </summary>
    public sealed class ListExpansions
    {
        private int expansionsID;
        /// <summary>
        /// 获取或者设置卡牌所属系列的编号
        /// </summary>
        [ColumnInfo(IsAutoIncrement = true, IsPrimaryKey = true)]
        public int ExpansionsID
        {
            get { return expansionsID; }
            set { expansionsID = value; }
        }
        private int releasedMonth;
        /// <summary>
        /// 获取或者设置发布月份
        /// </summary>
        public int ReleasedMonth
        {
            get { return releasedMonth; }
            set { releasedMonth = value; }
        }
        private string expansionsName = string.Empty;
        /// <summary>
        /// 获取或者设置系列名称
        /// </summary>
        public string ExpansionsName
        {
            get { return expansionsName; }
            set { expansionsName = value; }
        }
        private string m_EnglishName = string.Empty;
        /// <summary>
        /// 获取或者设置系列英文名称
        /// </summary>
        public string EnglishName
        {
            get { return m_EnglishName; }
            set { m_EnglishName = value; }
        }
        private string symbol = string.Empty;
        /// <summary>
        /// 获取或者设置系列简称
        /// </summary>
        [ColumnInfo(IsDisplayKeyWord = true)]
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }
        private int cardCount;
        /// <summary>
        /// 获取或者设置包含卡牌总数
        /// </summary>
        public int CardCount
        {
            get { return cardCount; }
            set { cardCount = value; }
        }
    }
}
