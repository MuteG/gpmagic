using System;
using System.Collections.Generic;
using System.Text;

namespace GPSoft.GPMagic.GPMagicBase.Module.Deck
{
    class GPMagicDeck:IDeck
    {
        #region IDeck 成员

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Description
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
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
