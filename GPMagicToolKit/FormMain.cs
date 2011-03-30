using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSoft.Games.GPMagic.GPMagicToolKit
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnuItemBatchImageResize_Click(object sender, EventArgs e)
        {
            FormBatchImageResize formBatchImageResize = new FormBatchImageResize();
            formBatchImageResize.MdiParent = this;
            formBatchImageResize.Text = (sender as ToolStripMenuItem).Text;
            formBatchImageResize.Show();
        }
    }
}
