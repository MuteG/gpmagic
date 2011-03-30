using System;
using System.Collections.Generic;
using System.Text;
using GPSoft.Games.GPMagic.GPMagicBase.Model.Deck;

namespace GPSoft.Games.GPMagic.GPMagicBase.Module.Deck
{
    public interface IDeck
    {
        DeckFile Deck { get; }
        string DeckFullPath { set; get; }
        void Load(string deckFullPath);
        void Save(string deckFullPath);
        void Save();
    }
}
