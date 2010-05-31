using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model;
using GPSoft.GPMagic.GPMagicBase.UI;
using GPSoft.Helper.FunctionHelper;
using GPSoft.Helper.FileOperate;

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
        private CardLibrary cardLibrary = new CardLibrary();
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
                        btnPrevious.Enabled = false;
                        btnNext.Enabled = false;
                        break;
                    }
                case DataOperateType.Update:
                    {
                        Text = string.Format("{0} - {1}", ConstClass.TitleOfCardInfomationForm,
                                    DataOperateTypeDisplayWrods.Update);
                        btnSubmit.Text = DataOperateTypeDisplayWrods.Update;
                        btnPrevious.Enabled = true;
                        btnNext.Enabled = true;
                        break;
                    }
            }
        }
        /// <summary>
        /// 将当前界面中的数据封装成一个对象
        /// </summary>
        /// <returns></returns>
        private ListCardTotal PackageComponentToInstance()
        {
            ListCardTotal result = new ListCardTotal();
            if (CheckInput())
            {
                result.Symbol = cbxExpansions.Text;
                result.CollectorNumber = Convert.ToInt32(tbxCollectorNumber.Text);
                result.CardName = tbxCardName.Text;
                result.CardEnglishName = tbxCardEnglishName.Text;
                result.Abilities = tbxAbilitiesText.Text;
                result.FlavorText = tbxFlavorText.Text;
                result.ManaCost = tbxManaCost.Text;
                result.TypeName = cbxCardType.Text;
                result.SubTypeName = tbxCardSubType.Text;
                result.Power = Convert.ToInt32(tbxPower.Text);
                result.Toughness = Convert.ToInt32(tbxToughness.Text);
                result.Rarity = Convert.ToInt32(cbxRarity.SelectedValue);
                result.PainterName = cbxPainterName.Text;
                result.CardPrice = Convert.ToDouble(tbxCardPrice.Text);
                result.FAQ = tbxFAQ.Text;
                result.CardImage = SaveCardImage(tbxCardImage.Text);
                if (string.IsNullOrEmpty(result.CardImage))
                {
                    result = null;
                }
            }
            return result;
        }
        public void ShowCardInfo(ListCardTotal card)
        {
            UnPackInstanceToComponent(card);
        }
        private void UnPackInstanceToComponent(ListCardTotal card)
        {
            cbxExpansions.Text = card.Symbol;
            tbxCollectorNumber.Text = card.CollectorNumber.ToString();

        }
        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="sourcePath">原图路径</param>
        /// <returns>返回保存后的图片路径(路径从Pic\开始)</returns>
        private string SaveCardImage(string sourcePath)
        {
            string result = string.Empty;
            try
            {
                string targetPath = Path.Combine(FunctionHelper.ApplicationPath,
                                                 string.Format("Pic\\{0}", cbxExpansions.Text));
                FileHelper.CreateDirectory(targetPath);
                result = GetSavedImageName(sourcePath);
                if (!string.IsNullOrEmpty(result))
                {
                    targetPath = Path.Combine(targetPath, result);
                    FileHelper.CopyFileCompel(sourcePath, targetPath);
                }
            }
            catch (Exception ex)
            {
                result = string.Empty;
                MessageBox.Show(ex.Message, "保存图片时发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        /// <summary>
        /// 获得保存后的图片名
        /// </summary>
        /// <param name="sourceImageName">原图路径（带后缀文件名）</param>
        /// <returns>返回保存后的图片名</returns>
        private string GetSavedImageName(string sourceImageName)
        {
            string result = string.Empty;
            ImageDisplayType imageType = (ImageDisplayType)Convert.ToInt32(cbxImageType.SelectedValue);
            switch (imageType)
            {
                case ImageDisplayType.Full:
                    result = ".full";
                    break;
                case ImageDisplayType.Normal:
                    result = ".noml";
                    break;
                case ImageDisplayType.Middle:
                    result = ".midl";
                    break;
                case ImageDisplayType.TransverseFirst:
                    result = ".t1st";
                    break;
                case ImageDisplayType.TransverseSecond:
                    result = ".t2nd";
                    break;
                case ImageDisplayType.LargePic:
                    result = ".larg";
                    break;
            }
            result = string.Format("{0}{1}{2}", tbxCardEnglishName.Text, result, Path.GetExtension(sourceImageName));
            return result;
        }

        private bool CheckInput()
        {
            bool result = true;
            string message = string.Empty;

            if (!result)
            {
                MessageBox.Show(message, "错误的输入", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// <summary>
        /// 根据下拉框内容设置下拉列表显示宽度
        /// </summary>
        /// <param name="cbx">要进行设置的下拉框组件</param>
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
        /// <summary>
        /// 根据下拉框当前选项产生添加动作
        /// </summary>
        /// <param name="cbx">发生选择项改变的下拉框组件</param>
        /// <param name="inputDialogTitle">输入对话框的标题</param>
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
        #endregion

        #region 系统函数
        // 窗体载入
        private void FormCardInfo_Load(object sender, EventArgs e)
        {
            tableInstanceDictionary.Add(cbxRarity.Name, new CardRarity());
            tableInstanceDictionary.Add(cbxImageType.Name, new CardImageType());
            tableInstanceDictionary.Add(cbxCardType.Name, new CardType());
            tableInstanceDictionary.Add(cbxExpansions.Name, new CardExpansions());
            tableInstanceDictionary.Add(cbxPainterName.Name, new CardPainter());

            SetComboBoxItems(cbxRarity, true);
            SetComboBoxItems(cbxImageType, false);
            SetComboBoxItems(cbxCardType, true);
            SetComboBoxItems(cbxExpansions, true);
            SetComboBoxItems(cbxPainterName, true);

            ttpCardInfo.SetToolTip(cbxImageType, cbxImageType.Text);
            SetComboBoxDropDownWidth(cbxImageType);
        }
        // 关闭窗口
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        // 选择卡牌画像
        private void btnCardImage_Click(object sender, EventArgs e)
        {
            if (File.Exists(tbxCardImage.Text))
            {
                ofdCardImage.InitialDirectory = Path.GetDirectoryName(tbxCardImage.Text);
                ofdCardImage.FileName = Path.GetFileName(tbxCardImage.Text);
            }
            if (ofdCardImage.ShowDialog() == DialogResult.OK)
            {
                pbxCardImage.Image = Image.FromFile(ofdCardImage.FileName);
                tbxCardImage.Text = ofdCardImage.FileName;
            }
        }
        // 提交操作
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ListCardTotal data = PackageComponentToInstance();
            FormMain frmMain = (FormMain)this.Owner;
            if (null != data)
            {
                frmMain.Cards.Add(data);
                frmMain.Cards.Reload();
                frmMain.RefreshTotalCardsGrid();
            }
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

        // 画像表示形式选择项发生改变时
        private void cbxImageType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ttpCardInfo.SetToolTip(cbxImageType, cbxImageType.Text);
        }
        // 卡牌类别选择项发生改变时
        private void cbxCardType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBoxSelectionChanged(cbxCardType, lblCardType.Text);
        }
        // 卡牌系列选择项发生改变时
        private void cbxExpansions_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBoxSelectionChanged(cbxExpansions, lblExpansions.Text);
        }
        // 画家选择项发生改变时
        private void cbxPainterName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBoxSelectionChanged(cbxPainterName, lblPainterName.Text);
        }
        #endregion
    }
}
