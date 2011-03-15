using System;
using System.Data;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model.Deck;
using GPSoft.GPMagic.GPMagicBase.SQLite;
using GPSoft.Helper.Files;

namespace GPSoft.GPMagic.GPMagicBase.Module.Deck
{
    public abstract class AbstractDeck : IDeck
    {
        protected DatabaseOperator dbOperator = new DatabaseOperator();

        #region IDeck 成员

        private DeckFile deck = new DeckFile();

        public DeckFile Deck
        {
            get { return deck; }
        }

        private string _DeckFullPath = string.Empty;

        public string DeckFullPath
        {
            get { return _DeckFullPath; }
            set { _DeckFullPath = value; }
        }

        public abstract void Load(string deckFullPath);

        public abstract void Save(string deckFullPath);

        public void Save()
        {
            Save(this.DeckFullPath);
        }

        #endregion
    }
}
