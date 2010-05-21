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
        private DataOperateType editStatus;
        /// <summary>
        /// 获取或者设置当前编辑状态
        /// </summary>
        public DataOperateType EditStatus
        {
            get { return editStatus; }
            set
            {
                editStatus = value;
                ChangeFormTitle(editStatus);
            }
        }
        private Dictionary<string, AbstractTableInstance> tableInstanceDictionary = new Dictionary<string, AbstractTableInstance>();
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
        /// <summary>
        /// 填充指定ComboBox的内容
        /// </summary>
        /// <param name="cbx">要进行填充的ComboBox</param>
        /// <param name="newItem">是否拥有“新建”功能</param>
        private void SetComboBoxItems(ComboBox cbx, bool newItem)
        {
            AbstractTableInstance tableInstance = tableInstanceDictionary[cbx.Name];
            DataTable records = tableInstance.Records;
            if (newItem)
            {
                records.Rows.InsertAt(records.NewRow(), 0);
                records.Rows[0][tableInstance.DisplayColumnName] = DataOperateTypeDisplayWrods.New;
                records.Rows[0][tableInstance.PrimaryKeyColumnName] = 0; 
            }
            cbx.DataSource = records;
            cbx.DisplayMember = tableInstance.DisplayColumnName;
            cbx.ValueMember = tableInstance.PrimaryKeyColumnName;
            if (newItem && records.Rows.Count > 1)
            {
                cbx.SelectedIndex = 1;
            }
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
            tableInstanceDictionary.Add(cbxRarity.Name, new CardRarity());
            tableInstanceDictionary.Add(cbxImageType.Name, new CardImageType());
            tableInstanceDictionary.Add(cbxCardType.Name, new CardType());

            SetComboBoxItems(cbxRarity, true);
            SetComboBoxItems(cbxImageType, false);
            SetComboBoxItems(cbxCardType, true);

            ttpCardInfo.SetToolTip(cbxImageType, cbxImageType.Text);
            SetComboBoxDropDownWidth(cbxImageType);
        }

        private void SetComboBoxDropDownWidth(ComboBox cbx)
        {
            int dropDownWidth = 0;
            foreach (object item in cbx.Items)
            {
                dropDownWidth = Math.Max(dropDownWidth, 
                    TextRenderer.MeasureText(cbx.GetItemText(item), cbx.Font).Width);
            }
            cbx.DropDownWidth = dropDownWidth;
        }

        private void cbxImageType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ttpCardInfo.SetToolTip(cbxImageType, cbxImageType.Text);
            if (cbxImageType.SelectedItem.ToString().Equals(DataOperateTypeDisplayWrods.New))
            {
                string newValue = InputTextDialog.Show(lblImageType.Text, string.Empty);
                AbstractTableInstance tableInstance = tableInstanceDictionary[cbxImageType.Name];
                ListCardImageType imageType = (ListCardImageType)tableInstance.NewDataInstance();
                imageType.Comment = newValue;
                tableInstance.Add(imageType);
            }
        }

        private void cbxCardType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBoxSelectionChanged(cbxCardType, lblCardType.Text);
        }

        private void ComboBoxSelectionChanged(ComboBox cbx, string inputDialogTitle)
        {
            if (cbx.Text.Equals(DataOperateTypeDisplayWrods.New))
            {
                string newValue = InputTextDialog.Show(inputDialogTitle, string.Empty);
                if (!string.IsNullOrEmpty(newValue))
                {
                    AbstractTableInstance tableInstance = tableInstanceDictionary[cbx.Name];
                    object dataInstance = tableInstance.NewDataInstance();
                    dataInstance.GetType().GetProperty(tableInstance.DisplayColumnName).SetValue(dataInstance, newValue, null);
                    tableInstance.Add(dataInstance);
                    tableInstance.Reload();
                    SetComboBoxItems(cbx, true);
                    cbx.SelectedIndex = cbx.Items.Count - 1;
                }
            }
        }
    }
}
