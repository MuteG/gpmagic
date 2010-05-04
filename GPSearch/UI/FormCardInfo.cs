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

        #region 自定义函数
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

        private void SetRarityItems()
        {
            CardRarity rarity = new CardRarity();
            rarity.Records.Rows.InsertAt(rarity.Records.NewRow(), 0);
            rarity.Records.Rows[0].ItemArray = new object[]{0, "新建"};
            this.cbxRarity.DataSource = rarity.Records;
            this.cbxRarity.DisplayMember = "RarityName";
            this.cbxRarity.ValueMember = "RarityID";
        }
        private void SetComboBoxItems(ComboBox cbx, DataTable records, string display, string value)
        {
            records.Rows.InsertAt(records.NewRow(), 0);
            records.Rows[0][display] = "新建";
            records.Rows[0][value] = 0;
            cbx.DataSource = records;
            cbx.DisplayMember = display;
            cbx.ValueMember = value;
        }
        #endregion

        #region 系统函数
        // 关闭窗口
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        // 选择卡牌画像
        private void btnCardImage_Click(object sender, EventArgs e)
        {
            if (ofdCardImage.ShowDialog() == DialogResult.OK)
            {
                pbxCardImage.Image = Image.FromFile(ofdCardImage.FileName);
                tbxCardImage.Text = ofdCardImage.FileName;
            }
        }
        // 提交操作
        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
        // 选择子类别
        private void btnCardSubType_Click(object sender, EventArgs e)
        {
            tbxCardSubType.Text = CheckValuesDialog.Show(lblCardSubType.Text, tbxCardSubType.Text, "/", typeof(CardSubType));
        }
        // 改变控件提示
        private void tbxCardSubType_TextChanged(object sender, EventArgs e)
        {
            //ttpCardInfo.SetToolTip((TextBox)sender, ((TextBox)sender).Text);
        }
        // 选择异能
        private void btnAbilities_Click(object sender, EventArgs e)
        {
            tbxAbilities.Text = CheckValuesDialog.Show(lblAbilities.Text, tbxAbilities.Text, ",", typeof(CardAbilitie));
        }
        // 输入异能描述文字
        private void btnAbilitiesText_Click(object sender, EventArgs e)
        {
            tbxAbilitiesText.Text = InputTextDialog.Show(lblAbilitiesText.Text, tbxAbilitiesText.Text);
        }
        // 输入背景描述文字
        private void btnFlavorText_Click(object sender, EventArgs e)
        {
            tbxFlavorText.Text = InputTextDialog.Show(lblFlavorText.Text, tbxFlavorText.Text);
        }
        // 输入卡牌FAQ
        private void btnFAQ_Click(object sender, EventArgs e)
        {
            tbxFAQ.Text = InputTextDialog.Show(lblFAQ.Text, tbxFAQ.Text);
        }
        #endregion

        private void FormCardInfo_Load(object sender, EventArgs e)
        {
            SetRarityItems();

        }
    }
}
