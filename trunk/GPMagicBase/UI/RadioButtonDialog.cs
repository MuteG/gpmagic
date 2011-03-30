using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSoft.Games.GPMagic.GPMagicBase.UI
{
    public partial class RadioButtonDialog : Form
    {
        private RadioButtonDialog()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public static int Show(string title, List<string> items)
        {
            int result = -1;
            RadioButtonDialog rbd = new RadioButtonDialog();
            rbd.rgbMain.Text = title;
            foreach (string itemText in items)
            {
                rbd.rgbMain.Items.Add(itemText);
            }
            if (items.Count > 0)
            {
                rbd.rgbMain.Items[0].Checked = true;
            }
            if (rbd.ShowDialog() == DialogResult.OK)
            {
                result = rbd.rgbMain.CheckedIndex;
            }
            return result;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
