using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model;
using GPSoft.GPMagic.GPMagicBase.UI;
using GPSoft.GPMagic.GPSearch.Common;

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
        
        private CardLibrary cards = new CardLibrary();
        /// <summary>
        /// 获取卡牌一览对象
        /// </summary>
        public CardLibrary Cards
        {
            get { return cards; }
        }
        public FormMain()
        {
            InitializeComponent();
            tscbxLanguage.SelectedIndex = 1;
            this.DoubleBuffered = true;
        }

        private void Init()
        {

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
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
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
                        cardRow["CardPrice"].ToString(),
                        cardRow["CardID"]
                        );
                    dgvCardList.Rows[newRowIndex].DefaultCellStyle.ForeColor = CommonHelper.CardRarity.GetRarityColor(rarity);
                }
                if (frmInfo != null && frmInfo.EditStatus == DataOperateType.Update)
                {
                    SelectCard(frmInfo.ActiveCard);
                }
            }
        }

        private void mnuAddCard_Click(object sender, EventArgs e)
        {
            ShowCardInfoForm(DataOperateType.Insert);
        }

        private void mnuItemEditCard_Click(object sender, EventArgs e)
        {
            ShowCardInfoForm(DataOperateType.Update);
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
            if (e.Clicks == 1)
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
                AddDeckList(row);
            }
            dgvDeckList.Sort(colDCardID, System.ComponentModel.ListSortDirection.Ascending);
        } 
        #endregion

        private void AddDeckList(DataGridViewRow row)
        {
            int cardID = Convert.ToInt32(row.Cells["dgvColCardID"].Value);
            int index = GetCardIndexOfDeckGridView(cardID);
            if (index < 0)
            {
                dgvDeckList.Rows.Add(
                    1,
                    row.Cells["dgvColExpansions"].Value,
                    row.Cells["dgvColCNName"].Value,
                    row.Cells["dgvColCost"].Value,
                    row.Cells["dgvColCardID"].Value);
                dgvDeckList.Rows[dgvDeckList.Rows.Count - 1].DefaultCellStyle.ForeColor = row.DefaultCellStyle.ForeColor;
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
        }

        private int GetCardIndexOfDeckGridView(int cardID)
        {
            int result = -1;
            foreach (DataGridViewRow row in dgvDeckList.Rows)
            {
                if (cardID == Convert.ToInt32(row.Cells["colDCardID"].Value))
                {
                    result = row.Index;
                    break;
                }
            }
            return result;
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void dgvCardList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cardID = Convert.ToInt32(dgvCardList.Rows[e.RowIndex].Cells[dgvCardList.Columns.Count - 1].Value);
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
                int cardID = Convert.ToInt32(dgvCardList.Rows[index].Cells[dgvCardList.Columns.Count - 1].Value);
                ListCardTotal card = (ListCardTotal)cards.GetDataInstance(cardID);
                FrmInfo.ShowCardInfo(card);
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
                int cardID = Convert.ToInt32(dgvCardList.Rows[index].Cells[dgvCardList.Columns.Count - 1].Value);
                ListCardTotal card = (ListCardTotal)cards.GetDataInstance(cardID);
                FrmInfo.ShowCardInfo(card);
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
                if (cardID == Convert.ToInt32(row.Cells["dgvColCardID"].Value))
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
                row.Selected = false;
            }
            if (index < 0) index = 0;
            dgvCardList.Rows[index].Selected = true;
        } 
        #endregion

        private void tsbtnType_Click(object sender, EventArgs e)
        {
            this.totalCardsFilter.SetCardType();
            RefreshDataGridView();
        }

        private void dgvDeckList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && !tsbtnLockDeck.Checked)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        {
                            AddDeckCardCount(e.RowIndex);
                            break;
                        }
                    case MouseButtons.Right:
                        {
                            SubDeckCardCount(e.RowIndex);
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
                dgvDeckList.Rows.RemoveAt(index);
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
                            dgvDeckList.Rows.Remove(row);
                        }
                        break;
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
            saveFileDialog1.Title = "保存牌表";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFileDialog1.FileName))
                {
                    if (MessageBox.Show("文件已经存在，是否覆盖现有文件？",
                                    "文件名冲突",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        OutputDeckFile(saveFileDialog1.FileName, formatText);
                    }
                    else
                    {
                        SaveDeck(formatText);
                    }
                }
                else
                {
                    OutputDeckFile(saveFileDialog1.FileName, formatText);
                }
            }
        }

        private void OutputDeckFile(string deckName, string formatText)
        {
            if (!File.Exists(deckName)) File.Create(deckName).Close();
            FileStream writeStream = File.OpenWrite(deckName);
            if (formatText.Equals(DeckSaveFormat.CnList))
            {
                saveFileDialog1.Filter = "中文牌表|*.txt";
            }
            else if (formatText.Equals(DeckSaveFormat.Mws))
            {
                saveFileDialog1.Filter = "MWS牌表格式|*.mwDeck";
            }
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
    }
}
