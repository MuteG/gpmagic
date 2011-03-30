using System;
using System.Collections.Generic;
using System.Text;
using GPSoft.Games.GPMagic.GPMagicBase.Model;
using GPSoft.Games.GPMagic.GPMagicBase.Model.Database;
using GPSoft.Games.GPMagic.GPMagicBase.Model.Deck;

namespace GPSoft.Games.GPMagic.GPSearch.Common
{
    internal class CommonHelper
    {
        private static CardRarity cardRarity = new CardRarity();
        public static CardRarity CardRarity
        {
            get
            {
                return cardRarity;
            }
        }
        private static ConfigDeckFilterList deckFilterConfiguration = ConfigDeckFilterList.GetInstance();

        public static ConfigDeckFilterList DeckFilterListConfiguration
        {
            get
            {
                return CommonHelper.deckFilterConfiguration;
            }
        }

        public static void ReloadData()
        {
            cardRarity.Reload();
        }
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
