using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GPSoft.Games.GPMagic.GPMagic.UI;

namespace GPSoft.Games.GPMagic.GPMagic
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            WindowPanel wp = new WindowPanel();
            this.Controls.Add(wp);
            wp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
