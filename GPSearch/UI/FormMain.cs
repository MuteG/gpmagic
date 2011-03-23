using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model;
using GPSoft.GPMagic.GPMagicBase.Model.Database;
using GPSoft.GPMagic.GPMagicBase.Model.Deck;
using GPSoft.GPMagic.GPMagicBase.Module.Deck;
using GPSoft.GPMagic.GPMagicBase.UI;
using GPSoft.GPMagic.GPSearch.Common;
using GPSoft.GPMagic.GPSearch.Model;
using GPSoft.Helper.Utility;

namespace GPSoft.GPMagic.GPSearch.UI
{
    public partial class FormMain : Form
    {
        private TotalCardFilter totalCardsFilter = new TotalCardFilter();
        private FormCardInfo frmInfo = null;
        /// <summary>
        /// 获取卡牌详细信息窗口实例
        /// </summary>
        public FormCardInfo FrmInfo
        {
            get
            {
                if (null == frmInfo || frmInfo.IsDisposed || frmInfo.Disposing)
                {
                    frmInfo = new FormCardInfo();
                }
                else
                {

                }
                return frmInfo;
            }
        }
        
        private CardTotal cards = new CardTotal();
        /// <summary>
        /// 获取卡牌一览对象
        /// </summary>
        public CardTotal Cards
        {
            get { return cards; }
        }
        public FormMain()
        {
            InitializeComponent();
            tscbxLanguage.SelectedIndex = 1;
            this.DoubleBuffered = true;
            deckTable = this.Cards.TableClone;
            LoadDeckFilter();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuNewDeck_Click(object sender, EventArgs e)
        {
            FormCardImage frmCardImage = new FormCardImage();
            frmCardImage.CardImage = Properties.Resources.cardDemo;
            frmCardImage.Show(this);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        public void FillDataGridView()
        {
            if (cards.Count > 0)
            {
                dgvCardList.Rows.Clear();
                foreach (DataRow cardRow in this.totalCardsFilter.Filter(cards.Records))
                {
                    int rarity = Convert.ToInt32(cardRow["Rarity"]);
                    int newRowIndex = dgvCardList.Rows.Add(
                        cardRow["Symbol"].ToString(),
                        cardRow["CardName"].ToString(),
                        cardRow["CardEnglishName"].ToString(),
                        cardRow["TypeName"].ToString(),
                        cardRow["SubTypeName"].ToString(),
                        cardRow["Abilities"].ToString(),
                        cardRow["ManaCost"].ToString(),
                        cardRow["Power"].ToString(),
                        cardRow["Toughness"].ToString(),
                        cardRow["CardPrice"].ToString()
                        );
                    dgvCardList.Rows[newRowIndex].Tag = cardRow["CardID"];
                    dgvCardList.Rows[newRowIndex].DefaultCellStyle.ForeColor = CommonHelper.CardRarity.GetRarityColor(rarity);
                }
                if (frmInfo != null && frmInfo.EditStatus == DataOperateType.Update)
                {
                    SelectCard(frmInfo.ActiveCard);
                }
            }
        }

        

        private void mnuItemEditCard_Click(object sender, EventArgs e)
        {
            if (dgvCardList.SelectedRows.Count > 0)
            {
                int cardID = Convert.ToInt32(dgvCardList.SelectedRows[0].Tag);
                ListCardTotal card = (ListCardTotal)cards.GetDataInstance(cardID);
                FrmInfo.Owner = this;
                FrmInfo.ShowCardInfo(card);
                ShowCardInfoForm(DataOperateType.Update);
            }
        }

        private void ShowCardInfoForm(DataOperateType editStatus)
        {
            FrmInfo.EditStatus = editStatus;
            FrmInfo.ShowDialog(this);
        }

        private void mnuItemAbout_Click(object sender, EventArgs e)
        {
            AboutBox frmAbout = new AboutBox();
            frmAbout.ShowDialog(this);
        }

        #region 数据拖曳
        //设置拖曳效果
        private void dgvDeckList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        //开始拖曳数据
        private void dgvCardList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Clicks == 1 && e.RowIndex >= 0)
            {
                DataGridViewRow[] rows;
                if (dgvCardList.Rows[e.RowIndex].Selected)
                {
                    rows = new DataGridViewRow[dgvCardList.SelectedRows.Count];
                    dgvCardList.SelectedRows.CopyTo(rows, 0);
                }
                else
                {
                    rows = new DataGridViewRow[1];
                    rows[0] = dgvCardList.Rows[e.RowIndex];
                }
                dgvCardList.DoDragDrop(rows, DragDropEffects.Copy);
            }
        }
        //拖曳动作结束
        private void dgvDeckList_DragDrop(object sender, DragEventArgs e)
        {
            DataGridViewRow[] selectedRows =
                (DataGridViewRow[])e.Data.GetData(typeof(DataGridViewRow[]));
            foreach (DataGridViewRow row in selectedRows)
            {
                int cardID = Convert.ToInt32(row.Tag);
                DeckCard card = (DeckCard)this.Cards.GetDataInstance(cardID, typeof(DeckCard));
                AddDeckList(card);
            }
        } 
        #endregion

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void dgvCardList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cardID = Convert.ToInt32(dgvCardList.Rows[e.RowIndex].Tag);
            ListCardTotal card = (ListCardTotal)cards.GetDataInstance(cardID);
            FrmInfo.Owner = this;
            FrmInfo.ShowCardInfo(card);
            ShowCardInfoForm(DataOperateType.Update);
        }

        #region 选择列表中的行
        /// <summary>
        /// 选择上一行
        /// </summary>
        public void SelectPreLineInGrid()
        {
            if (dgvCardList.SelectedRows.Count > 0)
            {
                int index = dgvCardList.SelectedRows[0].Index;
                if (index == 0)
                {
                    index = dgvCardList.Rows.Count - 1;
                }
                else
                {
                    index--;
                }
                SelectRowAtIndex(index);
                int cardID = Convert.ToInt32(dgvCardList.Rows[index].Tag);
                ListCardTotal card = (ListCardTotal)cards.GetDataInstance(cardID);
                FrmInfo.ShowCardInfo(card);

                ShowDardImage(card);
            }
        }

        private void ShowDardImage(ListCardTotal card)
        {
            string imagePath = Path.Combine(UtilityHelper.ApplicationPath,
                                                string.Format("{2}\\{0}\\{1}",
                                                              card.Symbol,
                                                              card.CardImage,
                                                              DefaultDirectoryName.CardPictures));
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
        /// 选择下一行
        /// </summary>
        public void SelectNextLineInGrid()
        {
            if (dgvCardList.SelectedRows.Count > 0)
            {
                int index = dgvCardList.SelectedRows[dgvCardList.SelectedRows.Count - 1].Index;
                if (index == dgvCardList.Rows.Count - 1)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
                SelectRowAtIndex(index);
                int cardID = Convert.ToInt32(dgvCardList.Rows[index].Tag);
                ListCardTotal card = (ListCardTotal)cards.GetDataInstance(cardID);
                FrmInfo.ShowCardInfo(card);

                ShowDardImage(card);
            }
        }

        public void SelectCard(ListCardTotal card)
        {
            int cardIndex = GetCardIndexOfTotalGridView(card.CardID);
            SelectRowAtIndex(cardIndex);
        }

        private int GetCardIndexOfTotalGridView(int cardID)
        {
            int result = 0;
            //这里要改为二分法搜索
            foreach (DataGridViewRow row in dgvCardList.Rows)
            {
                if (cardID == Convert.ToInt32(row.Tag))
                {
                    result = row.Index;
                    break;
                }
            }
            return result;
        }

        private void SelectRowAtIndex(int index)
        {
            foreach (DataGridViewRow row in dgvCardList.SelectedRows)
            {
                if (row.Selected) row.Selected = false;
            }
            if (index < 0) index = 0;
            if (dgvCardList.Rows.Count > 0) dgvCardList.Rows[index].Selected = true;
        }
        #endregion

        private void tsbtnType_Click(object sender, EventArgs e)
        {
            this.totalCardsFilter.SetCardType();
            FillDataGridView();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void mnuItemCardTypeSetting_Click(object sender, EventArgs e)
        {
            CheckValuesDialog.Show("卡牌类别", string.Empty, "/", typeof(CardType));
        }

        private void mnuItemAddCard_Click(object sender, EventArgs e)
        {
            ShowCardInfoForm(DataOperateType.Insert);
        }

        private void tsbtnShowDeckList_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
        }

        private void dgvCardList_CurrentCellChanged(object sender, EventArgs e)
        {
            if (null != dgvCardList.CurrentCell)
            {
                int index = dgvCardList.CurrentCell.RowIndex;
                int cardID = Convert.ToInt32(dgvCardList.Rows[index].Tag);
                if (cardID > 0)
                {
                    ListCardTotal card = (ListCardTotal)cards.GetDataInstance(cardID);
                    ShowDardImage(card);
                }
            }
        }

        private void mnuItemDeleteCard_Click(object sender, EventArgs e)
        {
            DeleteSelectedTotalCardsRecord();
        }

        private void DeleteSelectedTotalCardsRecord()
        {
            if (dgvCardList.SelectedRows.Count > 0 &&
                MessageBox.Show(string.Format("是否确认删除选择的{0}张卡牌？", dgvCardList.SelectedRows.Count), "确认删除",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvCardList.SelectedRows)
                {
                    Cards.Remove(Cards.GetDataInstance(row.Tag));
                }
                FillDataGridView();
            }
        }



        private IDeck workDeck = new CNDeck();
        private DataTable deckTable = new DataTable();

        private void LoadDeckFilter()
        {
            tsbtnDeckFilterType.DropDownItems.Clear();
            foreach (ConfigDeckFilter deckFilter in CommonHelper.DeckFilterListConfiguration.DeckFilterList)
            {
                ToolStripMenuItem item = (ToolStripMenuItem)tsbtnDeckFilterType.DropDownItems.Add(deckFilter.DisplayName);
                item.Click += new EventHandler(item_Click);
                item.Checked = true;
                item.CheckOnClick = true;
                item.Visible = deckFilter.IsShow;
            }
        }

        private void item_Click(object sender, EventArgs e)
        {
            RefillDeckGridViewWithDeck();
        }

        private void RefillDeckGridViewWithDeck()
        {
            dgvDeckList.Rows.Clear();
            foreach (ConfigDeckFilter filter in CommonHelper.DeckFilterListConfiguration.DeckFilterList)
            {
                if (filter.IsShow)
                {
                    // 根据统计设定分类显示卡牌

                }
            }
        }

        private void AddDeckList(DeckCard card)
        {
            int index = GetCardIndexOfDeckGridView(card.CardID);
            if (index < 0)
            {
                card.Count = 1;
                this.workDeck.Deck.Cards.Add(card);
                int rowIndex = dgvDeckList.Rows.Add(1,
                                                    card.Symbol,
                                                    card.CardName,
                                                    card.ManaCost);
                DataRow deckRow = this.Cards.Records.Select(string.Format("CardID={0}", card.CardID))[0];
                dgvDeckList.Rows[rowIndex].Tag = card.CardID;
                dgvDeckList.Rows[rowIndex].DefaultCellStyle.ForeColor =
                    CommonHelper.CardRarity.GetRarityColor(card.Rarity);
                this.workDeck.Deck.CardRecords.Rows.Add(deckRow.ItemArray);
            }
            else
            {
                AddDeckCardCount(index);
            }
        }

        private void AddDeckCardCount(int index)
        {
            int count = Convert.ToInt32(dgvDeckList.Rows[index].Cells["colDCount"].Value);
            dgvDeckList.Rows[index].Cells["colDCount"].Value = count + 1;
            DeckCard card = GetDeckCardFromWorkDeck((int)dgvDeckList.Rows[index].Tag);
            card.Count++;
        }

        private DeckCard GetDeckCardFromWorkDeck(int cardID)
        {
            DeckCard result = new DeckCard();
            foreach (DeckCard card in this.workDeck.Deck.Cards)
            {
                if (card.CardID == cardID)
                {
                    result = card;
                    break;
                }
            }
            return result;
        }

        private int GetCardIndexOfDeckGridView(int cardID)
        {
            int result = -1;
            foreach (DataGridViewRow row in dgvDeckList.Rows)
            {
                if (cardID == Convert.ToInt32(row.Tag))
                {
                    result = row.Index;
                    break;
                }
            }
            return result;
        }

        private void dgvDeckList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && !tsbtnLockDeck.Checked)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        {
                            // 修改为：左键点击入备
                            //AddDeckCardCount(e.RowIndex);
                            break;
                        }
                    case MouseButtons.Right:
                        {
                            // 修改为：右键点击回主
                            //SubDeckCardCount(e.RowIndex);
                            break;
                        }
                }
            }
        }

        private void SubDeckCardCount(int index)
        {
            int count = Convert.ToInt32(dgvDeckList.Rows[index].Cells["colDCount"].Value);
            if (count > 1)
            {
                dgvDeckList.Rows[index].Cells["colDCount"].Value = count - 1;
            }
            else
            {
                RemoveDeckCard(index);
            }
        }

        private void RemoveDeckCard(int deckGridViewIndex)
        {
            dgvDeckList.Rows.RemoveAt(deckGridViewIndex);
            DeckCard card = GetDeckCardFromWorkDeck((int)dgvDeckList.Rows[deckGridViewIndex].Tag);
            this.workDeck.Deck.Cards.Remove(card);
            foreach (DataRow deckRow in this.workDeck.Deck.CardRecords.Rows)
            {
                if (((int)deckRow["CardID"]) == card.CardID)
                {
                    deckRow.Delete();
                    break;
                }
            }
        }

        private void dgvDeckList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 187:
                case 107:
                    {
                        //加号键
                        foreach (DataGridViewRow row in dgvDeckList.SelectedRows)
                        {
                            AddDeckCardCount(row.Index);
                        }
                        break;
                    }
                case 189:
                case 109:
                    {
                        //减号键
                        foreach (DataGridViewRow row in dgvDeckList.SelectedRows)
                        {
                            SubDeckCardCount(row.Index);
                        }
                        break;
                    }
                case 46:
                case 110:
                    {
                        //删除键
                        foreach (DataGridViewRow row in dgvDeckList.SelectedRows)
                        {
                            RemoveDeckCard(row.Index);
                        }
                        break;
                    }
            }
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.L:
                        {
                            tsbtnLockDeck.Checked = !tsbtnLockDeck.Checked;
                            break;
                        }
                }
            }
        }

        private void tsbtnSaveDeck_Click(object sender, EventArgs e)
        {
            List<string> items = GenerateSaveFormatList();
            int index = RadioButtonDialog.Show("保存格式", items);
            if (index >= 0)
            {
                string formatText = items[index];
                SetSaveFileDialogFilter(formatText);
                SaveDeck(formatText);
            }
        }

        private void SaveDeck(string formatText)
        {
            if (this.workDeck.DeckFullPath.Length > 0)
            {
                OutputDeckFile(this.workDeck.DeckFullPath, formatText);
            }
            else
            {
                saveFileDialog1.Title = "保存牌表";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    OutputDeckFile(saveFileDialog1.FileName, formatText);
                }
            }
        }

        private void OutputDeckFile(string deckName, string formatText)
        {
            IDeck saveDeck = new CNDeck();
            if (formatText.Equals(DeckSaveFormat.CnList))
            {
                saveFileDialog1.Filter = "中文牌表|*.txt";
                saveDeck = new CNDeck();
            }
            else if (formatText.Equals(DeckSaveFormat.Mws))
            {
                saveFileDialog1.Filter = "MWS牌表格式|*.mwDeck";
                saveDeck = new MWSDeck();
            }
            foreach (DataRow row in this.workDeck.Deck.CardRecords.Rows)
            {
                saveDeck.Deck.CardRecords.ImportRow(row);
            }
            saveDeck.Deck.Cards.AddRange(this.workDeck.Deck.Cards);
            saveDeck.Save(deckName);
        }

        private int GetCardCountFromDeckList(int cardID)
        {
            int result = 0;
            foreach (DataGridViewRow row in dgvDeckList.Rows)
            {
                if (cardID == Convert.ToInt32(row.Tag))
                {
                    result = Convert.ToInt32(row.Cells["colDCount"].Value);
                    break;
                }
            }
            return result;
        }

        private List<string> GenerateSaveFormatList()
        {
            List<string> result = new List<string>();
            result.Add(DeckSaveFormat.Mws);
            //items.Add("GPMagic");
            result.Add(DeckSaveFormat.CnList);
            return result;
        }

        private void SetSaveFileDialogFilter(string formatText)
        {
            if (formatText.Equals(DeckSaveFormat.CnList))
            {
                saveFileDialog1.Filter = "中文牌表|*.txt";
            }
            else if (formatText.Equals(DeckSaveFormat.Mws))
            {
                saveFileDialog1.Filter = "MWS牌表格式|*.mwDeck";
            }
        }

        private void mnuItemDeckFilterSetting_Click(object sender, EventArgs e)
        {
            using (FormEditDeckFilter form = new FormEditDeckFilter())
            {
                form.ShowDialog(this);
            }
        }

        private void tsbtnOpenDeck_Click(object sender, EventArgs e)
        {
            if (ofdDeck.ShowDialog() == DialogResult.OK)
            {
                switch (ofdDeck.FilterIndex)
                {
                    case 1: // 中文牌表
                        {
                            this.workDeck = new CNDeck();
                            this.workDeck.Load(ofdDeck.FileName);
                            break;
                        }
                    case 2: // MWS牌表格式
                        {
                            this.workDeck = new MWSDeck();
                            this.workDeck.Load(ofdDeck.FileName);
                            break;
                        }
                }
                RefillDeckGridViewWithDeck();
            }
        }

        private void mnuItemModelImportSetting_Click(object sender, EventArgs e)
        {
            new FormImportCardsSetting().ShowDialog();
        }

        private void mnuItemTotalCarsGridHeaderSetting_Click(object sender, EventArgs e)
        {
            List<HeaderField> headerFields = new List<HeaderField>();
            using (FormSetHeader frmSetHeader = new FormSetHeader())
            {
                if (frmSetHeader.ShowDialog(headerFields) == DialogResult.OK)
                {
                    //测试用代码
                    StringBuilder message = new StringBuilder();
                    foreach (HeaderField header in headerFields)
                    {
                        message.AppendLine(string.Format("Field={0}, Display={1}", header.FieldName, header.Description));
                    }

                    MessageBox.Show(message.ToString());
                }
            }
        }

        private void mnuItemCardAbilitiesSetting_Click(object sender, EventArgs e)
        {
            CheckValuesDialog.Show("卡牌异能", string.Empty, "/", typeof(CardAbilitie));
        }
    }
}
