using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GP.GPMagic.GPMagic.UI
{
    public partial class CountPanel : UserControl
    {
        private int count;
        public CountPanel()
        {
            InitializeComponent();
        }

        public Image Image
        {
            get { return this.pbxIcon.Image; }
            set
            {
                this.pbxIcon.Image = value;
                if (null != value)
                {
                    this.Height = value.Height;
                    pbxIcon.Width = value.Width;
                }
            }
        }

        public int Count
        {
            get { return this.count; }
            set
            {
                this.count = value;
                this.lblCount.Text = this.count.ToString();
                if (this.Dock != DockStyle.Fill)
                {
                    this.Width = pbxIcon.Width + TextRenderer.MeasureText(this.lblCount.Text, this.Font).Width + 8;
                }
            }
        }

        public string Tip
        {
            get { return this.ttpCountName.GetToolTip(pbxIcon); }
            set
            {
                this.ttpCountName.SetToolTip(pbxIcon, value);
            }
        }
    }
}
