using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSoft.Games.GPMagic.GPMagicBase.UI
{
    public partial class InputTextDialog : Form
    {
        private InputTextDialog()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public static string Show(string title, string defaultText)
        {
            string result = string.Empty;
            InputTextDialog itd = new InputTextDialog();
            itd.Text = title;
            itd.tbxText.Text = defaultText;
            itd.tbxText.Focus();
            if (itd.ShowDialog() == DialogResult.OK)
            {
                result = itd.tbxText.Text;
            }
            else
            {
                result = defaultText;
            }
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
