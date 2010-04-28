using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GP.GPMagic.GPMagic.UI;

namespace GP.GPMagic.GPMagic
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
            GPMagicBase.SQLite.DBOperator dbop = 
                new GP.GPMagic.GPMagicBase.SQLite.DBOperator(connstr);
        }
    }
}
