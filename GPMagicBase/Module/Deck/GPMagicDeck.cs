using System;
using System.Collections.Generic;
using System.Text;
using GPSoft.GPMagic.GPMagicBase.Model.Deck;

namespace GPSoft.GPMagic.GPMagicBase.Module.Deck
{
    public class GPMagicDeck:IDeck
    {
        #region IDeck 成员

        private DeckFile deck = new DeckFile();

        public DeckFile Deck
        {
            get { return deck; }
        }

        public void Load(string deckFullPath)
        {
            throw new NotImplementedException();
        }

        public void Save(string deckFullPath)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
