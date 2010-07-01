using System;
using System.Collections.Generic;
using System.Text;

namespace GPSoft.GPMagic.GPSearch.Common
{
    internal class CommonHelper
    {
        public static string JoinFilterStrings(params string[] filterStr)
        {
            string result = string.Empty;
            List<string> filters = new List<string>();
            foreach (string filter in filterStr)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filters.Add(filter);
                }
            }
            if (filters.Count > 0)
            {
                result = string.Join(" AND ", filters.ToArray());
            }
            return result;
        }
    }
}
