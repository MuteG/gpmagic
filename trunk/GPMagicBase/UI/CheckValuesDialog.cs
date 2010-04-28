using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GP.GPMagic.GPMagicBase.UI
{
    public partial class CheckValuesDialog : Form
    {
        private CheckValuesDialog()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 打开列表选择对话框
        /// </summary>
        /// <param name="title">对话框标题</param>
        /// <param name="defaultValue">初始值</param>
        /// <param name="split">多数值的分隔符</param>
        /// <returns></returns>
        public static string Show(string title, string defaultValue, string split)
        {
            string result = string.Empty;
            CheckValuesDialog cvd = new CheckValuesDialog();
            cvd.Text = title;
            cvd.tbxSearch.Focus();
            if (cvd.ShowDialog() == DialogResult.OK)
            {
                List<string> list = new List<string>();
                foreach (object item in cvd.lbxResults.Items)
                {
                    list.Add(item.ToString());
                }
                result = string.Join(split, list.ToArray());
                string[] input = {"", "", ""};
                Array.Reverse(input);
            }
            else
            {
                result = defaultValue;
            }
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
