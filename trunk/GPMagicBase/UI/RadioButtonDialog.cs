using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSoft.GPMagic.GPMagicBase.UI
{
    public partial class RadioButtonDialog : Form
    {
        private RadioButtonDialog()
        {
            InitializeComponent();
        }

        public static string Show(string title, string defaultText)
        {
            string result = string.Empty;
            RadioButtonDialog rbd = new RadioButtonDialog();
            rbd.gbxTitle.Text = title;
            if (rbd.ShowDialog() == DialogResult.OK)
            {
                //result = rbd.tbxText.Text;
            }
            else
            {
                result = defaultText;
            }
            return result;
        }
    }
}
