using System;
using System.Collections.Generic;
using System.Text;
using GPSoft.GPMagic.GPMagicBase.Model.Deck;

namespace GPSoft.GPMagic.GPMagicBase.Module.Deck
{
    public interface IDeck
    {
        DeckFile Deck { get; }

        void Load(string deckFullPath);
        void Save(string deckFullPath);
    }
}
