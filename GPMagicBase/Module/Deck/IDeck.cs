using System;
using System.Collections.Generic;
using System.Text;

namespace GPSoft.GPMagic.GPMagicBase.Module.Deck
{
    public interface IDeck
    {
        string Name { set; get; }
        string Description { set; get; }
        void Load(string deckFullPath);
        void Save(string deckFullPath);
    }
}
