using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GPSearch.Command;

namespace GPSearch
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuNewDeck_Click(object sender, EventArgs e)
        {
            FormCardImage frmCardImage = new FormCardImage();
            frmCardImage.CardImage = Properties.Resources.cardDemo;
            frmCardImage.Show();
            DatabaseOperate.Init();
            DataTable table = DatabaseOperate.GetAllCardInfo();
            if (table != null)
                MessageBox.Show(table.Rows.Count.ToString());
            else
                MessageBox.Show("null");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
