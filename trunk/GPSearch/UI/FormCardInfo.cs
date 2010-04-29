using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model;
using GPSoft.GPMagic.GPMagicBase.UI;

namespace GPSoft.GPMagic.GPSearch.UI
{
    public partial class FormCardInfo : Form
    {
        private EditStatus _EditStatus;
        /// <summary>
        /// 获取或者设置当前编辑状态
        /// </summary>
        public EditStatus EditStatus
        {
            get { return _EditStatus; }
            set
            {
                _EditStatus = value;
                ChangeFormTitle(_EditStatus);
            }
        }
        public FormCardInfo()
        {
            InitializeComponent();
        }

        private void ChangeFormTitle(EditStatus editStatus)
        {
            switch (editStatus)
            {
                case EditStatus.Insert:
                    {
                        Text = string.Format(ConstClass.TITLE_CARDINFO, ConstClass.EDITSTATUS_INSERT);
                        break;
                    }
                case EditStatus.Update:
                    {
                        Text = string.Format(ConstClass.TITLE_CARDINFO, ConstClass.EDITSTATUS_UPDATE);
                        break;
                    }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCardImage_Click(object sender, EventArgs e)
        {
            if (ofdCardImage.ShowDialog() == DialogResult.OK)
            {
                pbxCardImage.Image = Image.FromFile(ofdCardImage.FileName);
                tbxCardImage.Text = ofdCardImage.FileName;
            }
        }

        private ListCardTotal PackageComponentToInstance()
        {
            ListCardTotal result = new ListCardTotal();
            if (CheckInput())
            {
                result.CardName = tbxCardName.Text;
                //result.CardEnglishName = tbxc
            }
            return result;
        }

        private bool CheckInput()
        {
            bool result = true;
            string message = string.Empty;

            if (!result)
            {
                MessageBox.Show("错误的输入", message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return result;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnCardSubType_Click(object sender, EventArgs e)
        {
            //
        }

        private void tbxCardSubType_TextChanged(object sender, EventArgs e)
        {
            ttpCardInfo.SetToolTip((TextBox)sender, ((TextBox)sender).Text);
        }

        private void btnAbilities_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnAbilitiesText_Click(object sender, EventArgs e)
        {
            tbxAbilitiesText.Text = InputTextDialog.Show(lblAbilitiesText.Text, tbxAbilitiesText.Text);
        }

        private void btnFlavorText_Click(object sender, EventArgs e)
        {
            tbxFlavorText.Text = InputTextDialog.Show(lblFlavorText.Text, tbxFlavorText.Text);
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            tbxFAQ.Text = InputTextDialog.Show(lblFAQ.Text, tbxFAQ.Text);
        }
    }
}
