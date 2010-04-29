using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;
using GPSoft.GPMagic.GPMagicBase.SQLite;

namespace GPSoft.GPMagic.GPMagicBase.Model
{
    public sealed class CardRarity : IDisposable
    {
        private DatabaseOperator dbop;
        public CardRarity()
        {
            dbop = new DatabaseOperator(SQLiteDatabaseInformation.Connection);
        }
        private DataTable GetCardRarity()
        {
            DataTable result = null;
            result = dbop.SelectTableData(DatabaseTableNames.CardRarity);
            return result;
        }
        public Color GetRarityColor(int rarity)
        {
            Color result = RarityColor.Common;
            switch (rarity)
            {
                case 1:
                    {
                        result = RarityColor.Common;
                        break;
                    }
                case 2:
                    {
                        result = RarityColor.Uncommon;
                        break;
                    }
                case 3:
                    {
                        result = RarityColor.Rare;
                        break;
                    }
                case 4:
                    {
                        result = RarityColor.MythicRare;
                        break;
                    }
            }
            return result;
        }

        #region IDisposable 成员

        public void Dispose()
        {
            dbop.Dispose();
        }

        #endregion
    }
}
