using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using GP.GPMagic.GPMagic.Model;

namespace GP.GPMagic.GPMagic.UI
{
    public partial class OrganismCard : MagicCardBase, ICanRotate
    {
        private CardStatus status = CardStatus.Normal;
        public OrganismCard()
        {
            InitializeComponent();
        }

        #region ICanRotate 成员

        public void Rotate(int angle)
        {
            
        }

        public void Tapping()
        {
            try
            {
                int width = this.Width;
                int height = this.Height;
                this.Width = height;
                this.Height = width;
                Image.RotateFlip(RotateFlipType.Rotate270FlipXY);
                this.status = CardStatus.Tapping;
            }
            catch (Exception ex)
            {
                //
            }
        }

        public void Round()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            int width = this.Width;
            int height = this.Height;
            this.Width = height;
            this.Height = width;
            Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            this.status = CardStatus.Normal;
        }

        #endregion

        private void OrganismCard_Click(object sender, EventArgs e)
        {
            switch (this.status)
            {
                case CardStatus.Normal:
                    {
                        Tapping();
                        break;
                    }
                case CardStatus.Tapping:
                    {
                        Reset();
                        break;
                    }
            }
        }
    }
}
