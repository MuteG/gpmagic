using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagic.UI;

namespace GPSoft.GPMagic.GPMagic
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
            string connstr = "Data Source=";
            GPMagicBase.SQLite.DatabaseOperator dbop =
                new GPSoft.GPMagic.GPMagicBase.SQLite.DatabaseOperator(connstr);
        }
    }
}
