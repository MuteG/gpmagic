using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using GPSoft.GPMagic.GPSearch.Model;

namespace GPSoft.GPMagic.GPSearch.Common
{
    public class TotalCardFilter : IFilterable
    {
        #region IFilterable 成员

        /// <summary>
        /// 获取过滤字符串
        /// </summary>
        public string FilterString
        {
            get
            {
                return GetFilterString();
            }
        }

        public DataRow[] Filter(DataTable table)
        {
            return table.Select(GetFilterString());
        }

        #endregion

        private string GetFilterString()
        {
            string result = string.Empty;
            result = Common.CommonHelper.JoinFilterStrings(this.cardTypeFilter);
            return result;
        }

        private string cardTypeFilter = string.Empty;

        public void SetCardType()
        {
            cardTypeFilter = UI.FormFilterCardType.CreateSingleInstance().GetFilter();
        }

        public void SetKeyWord()
        {
        }

        public void SetExpansions()
        {
        }
    }
}
