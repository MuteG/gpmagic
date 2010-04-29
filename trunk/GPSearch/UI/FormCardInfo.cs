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
        private DataOperateType _EditStatus;
        /// <summary>
        /// 获取或者设置当前编辑状态
        /// </summary>
        public DataOperateType EditStatus
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

        private void ChangeFormTitle(DataOperateType editStatus)
        {
            switch (editStatus)
            {
                case DataOperateType.Insert:
                    {
                        Text = string.Format("{0} - {1}", ConstClass.TitleOfCardInfomationForm,
                                    DataOperateTypeDisplayWrods.Insert);
                        btnSubmit.Text = DataOperateTypeDisplayWrods.Insert;
                        break;
                    }
                case DataOperateType.Update:
                    {
                        Text = string.Format("{0} - {1}", ConstClass.TitleOfCardInfomationForm,
                                    DataOperateTypeDisplayWrods.Update);
                        btnSubmit.Text = DataOperateTypeDisplayWrods.Update;
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
            tbxCardSubType.Text = CheckValuesDialog.Show(lblCardSubType.Text, tbxCardSubType.Text, "/");
        }

        private void tbxCardSubType_TextChanged(object sender, EventArgs e)
        {
            ttpCardInfo.SetToolTip((TextBox)sender, ((TextBox)sender).Text);
        }

        private void btnAbilities_Click(object sender, EventArgs e)
        {
            tbxAbilities.Text = CheckValuesDialog.Show(lblAbilities.Text, tbxAbilities.Text, ",");
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

        private void btnPainterName_Click(object sender, EventArgs e)
        {
            tbxPainterName.Text = InputTextDialog.Show(lblPainterName.Text, tbxPainterName.Text);
        }
    }
}
