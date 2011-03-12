using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model;
using GPSoft.GPMagic.GPMagicBase.Model.Database;
using GPSoft.GPMagic.GPMagicBase.SQLite;
using GPSoft.GPMagic.GPMagicBase.UI;
using GPSoft.GPMagic.GPSearch.Common;
using GPSoft.Helper.FileOperate;
using GPSoft.Helper.FunctionHelper;

namespace GPSoft.GPMagic.GPSearch.UI
{
    public partial class FormCardInfo : Form
    {
        private DatabaseOperator dbop;
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
        private ListCardTotal activeCard = new ListCardTotal();
        /// <summary>
        /// 获取或者设置当前显示的卡牌
        /// </summary>
        public ListCardTotal ActiveCard
        {
            get { return activeCard; }
            set { activeCard = value; }
        }
        private Dictionary<string, AbstractTableInstance> tableInstanceDictionary = new Dictionary<string, AbstractTableInstance>();
        public FormCardInfo()
        {
            InitializeComponent();
            this.dbop = new DatabaseOperator();
            tableInstanceDictionary.Add(cbxRarity.Name, new CardRarity());
            tableInstanceDictionary.Add(cbxImageType.Name, new CardImageType());
            tableInstanceDictionary.Add(cbxCardType.Name, new CardType());
            tableInstanceDictionary.Add(cbxExpansions.Name, new CardExpansions());
            tableInstanceDictionary.Add(cbxPainterName.Name, new CardPainter());

            ComponentFiller.FillComboBoxItems(cbxRarity, tableInstanceDictionary[cbxRarity.Name], true);
            ComponentFiller.FillComboBoxItems(cbxImageType, tableInstanceDictionary[cbxImageType.Name], false);
            ComponentFiller.FillComboBoxItems(cbxCardType, tableInstanceDictionary[cbxCardType.Name], true);
            ComponentFiller.FillComboBoxItems(cbxExpansions, tableInstanceDictionary[cbxExpansions.Name], true);
            ComponentFiller.FillComboBoxItems(cbxPainterName, tableInstanceDictionary[cbxPainterName.Name], true);

            ttpCardInfo.SetToolTip(cbxImageType, cbxImageType.Text);
            SetComboBoxDropDownWidth(cbxImageType);
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
                        btnDelete.Visible = false;
                        break;
                    }
                case DataOperateType.Update:
                    {
                        Text = string.Format("{0} - {1}", ConstClass.TitleOfCardInfomationForm,
                                    DataOperateTypeDisplayWrods.Update);
                        btnSubmit.Text = DataOperateTypeDisplayWrods.Update;
                        btnPrevious.Enabled = true;
                        btnNext.Enabled = true;
                        btnDelete.Visible = true;
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
                result.CardID = this.ActiveCard == null ? 0 : this.ActiveCard.CardID;
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
            this.ActiveCard = card;
            cbxExpansions.Text = card.Symbol;
            tbxCollectorNumber.Text = card.CollectorNumber.ToString();
            tbxCardName.Text = card.CardName;
            tbxCardEnglishName.Text = card.CardEnglishName;
            tbxAbilitiesText.Text = card.Abilities;
            tbxAbilities.Text = ((FormMain)this.Owner).Cards.GetAbilities(card.CardID);
            tbxFlavorText.Text = card.FlavorText;
            tbxManaCost.Text = card.ManaCost;
            cbxCardType.Text = card.TypeName;
            tbxCardSubType.Text = card.SubTypeName;
            tbxPower.Text = card.Power.ToString();
            tbxToughness.Text = card.Toughness.ToString();
            cbxRarity.SelectedValue = card.Rarity;
            cbxPainterName.Text = card.PainterName;
            tbxCardPrice.Text = card.CardPrice.ToString("0.00");
            tbxFAQ.Text = card.FAQ;
            tbxCardImage.Text = card.CardImage;
            LoadCardImage(card.CardImage);
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
                result = GetSavedImageName(sourcePath);
                string targetPath = GetSavedImagePath(cbxExpansions.Text, result);
                FileHelper.CreateDirectory(Path.GetDirectoryName(targetPath));
                if (tbxCardImage.Text.Equals(result))
                {
                    if (this.ActiveCard != null && !this.ActiveCard.Symbol.Equals(cbxExpansions.Text))
                    {
                        FileHelper.MoveFileCompel(GetSavedImagePath(this.ActiveCard.Symbol, result), targetPath);
                    }
                }
                else
                {
                    // 这里还需要加入画像大小调整（缩放成同样大小265*370）
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
        private string GetSavedImagePath(string symbol, string imageName)
        {
            return Path.Combine(FunctionHelper.ApplicationPath,
                                string.Format("{2}\\{0}\\{1}", symbol, imageName, DefaultDirectoryName.CardPictures));
        }
        private void LoadCardImage(string cardImageName)
        {
            pbxCardImage.Image = null;
            string imagePath = GetSavedImagePath(this.ActiveCard.Symbol, cardImageName);
            if (File.Exists(imagePath))
            {
                pbxCardImage.Image = Image.FromFile(imagePath);
            }
            else
            {
                // 这里还需要加入根据卡牌信息生成自定义画像
            }
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
            message = "必须指定卡牌英文名";
            result = !string.IsNullOrEmpty(tbxCardEnglishName.Text);
            if (!result)
            {
                MessageBox.Show(message, "错误的输入", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return result;
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
                    ComponentFiller.FillComboBoxItems(cbx, tableInstance, true);
                    //SetComboBoxItems(cbx, true);
                    cbx.SelectedIndex = cbx.Items.Count - 1;
                }
            }
        }
        private void AddRelateCardAbilities()
        {
            string[] abilities = tbxAbilities.Text.Split(",".ToCharArray());
            dbop.BeginTran();
            try
            {
                string sqlDelete = string.Format("DELETE FROM RelateCardAbilities WHERE CardID={0}",
                                                             this.activeCard.CardID);
                this.dbop.ExecuteNonreturnSqlStript(sqlDelete);
                foreach (string ability in abilities)
                {
                    string sqlAbilityID = string.Format("SELECT DISTINCT AbilitiesID FROM ListAbilities WHERE AbilitiesName='{0}'",
                                                        ability);
                    DataTable abilityTable = this.dbop.ExecuteDataTableScript(sqlAbilityID);
                    if (abilityTable.Rows.Count > 0)
                    {
                        int abilityID = Convert.ToInt32(abilityTable.Rows[0]["AbilitiesID"].ToString());
                        string sqlInsert = string.Format("INSERT INTO RelateCardAbilities VALUES({0},{1})",
                                                         this.ActiveCard.CardID,
                                                         abilityID);
                        this.dbop.ExecuteNonreturnSqlStript(sqlInsert);
                    }
                }
                dbop.CommitTran();
            }
            catch
            {
                dbop.RollbackTran();
            }
        }
        private void AddRelateCardSubTypes()
        {
            string[] subtypes = tbxCardSubType.Text.Split("/".ToCharArray());
            foreach (string ability in subtypes)
            {
                string sqlAbilityID = string.Format("SELECT DISTINCT SubTypeID FROM ListSubType WHERE SubTypeName='{0}'",
                                                    ability);
                DataTable abilityTable = this.dbop.ExecuteDataTableScript(sqlAbilityID);
                if (abilityTable.Rows.Count > 0)
                {
                    int subtypeID = Convert.ToInt32(abilityTable.Rows[0]["SubTypeID"].ToString());
                    string sqlInsert = string.Format("INSERT INTO RelateCardSubType VALUES({0},{1})",
                                                     this.ActiveCard.CardID,
                                                     subtypeID);
                    this.dbop.ExecuteNonreturnSqlStript(sqlInsert);
                }
            }
        }
        #endregion

        #region 系统函数
        // 窗体载入
        private void FormCardInfo_Load(object sender, EventArgs e)
        {
            
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
            this.ActiveCard = PackageComponentToInstance();
            FormMain frmMain = (FormMain)this.Owner;
            if (null != this.ActiveCard)
            {
                if (this.EditStatus == DataOperateType.Insert)
                {
                    frmMain.Cards.Add(this.ActiveCard);
                    AddRelateCardAbilities();
                    //AddRelateCardSubTypes();
                }
                else
                {
                    frmMain.Cards.Save(this.ActiveCard);
                }
                frmMain.FillDataGridView();
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
        // 上一条记录
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (this.EditStatus == DataOperateType.Update)
            {
                FormMain frmMain = (FormMain)this.Owner;
                frmMain.SelectPreLineInGrid();
            }
        }
        // 下一条记录
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.EditStatus == DataOperateType.Update)
            {
                FormMain frmMain = (FormMain)this.Owner;
                frmMain.SelectNextLineInGrid();
            }
        }
        // 当窗口关闭时
        private void FormCardInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认删除此卡牌？", "确认删除",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormMain frmMain = (FormMain)this.Owner;
                frmMain.Cards.Remove(ActiveCard);
                frmMain.FillDataGridView();
            }
        }
    }
}
