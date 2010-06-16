using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.UI;
using GPSoft.GPMagic.GPMagicBase.Model;

namespace GPSoft.GPMagic.GPSearch.UI
{
    public partial class FormFilterCardType : Form
    {
        public FormFilterCardType()
        {
            InitializeComponent();
        }

        private void btnCardType_Click(object sender, EventArgs e)
        {
            tbxCardSubType.Text = CheckValuesDialog.Show(lblCardSubType.Text, string.Empty, "/", typeof(CardSubType));
        }
    }
}
