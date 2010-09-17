using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model;
using GPSoft.GPMagic.GPMagicBase.Model.Database;
using GPSoft.GPMagic.GPMagicBase.UI;
using GPSoft.GPMagic.GPSearch.Common;
using GPSoft.GPMagic.GPMagicBase.Model.Deck;
using GPSoft.GPMagic.GPMagicBase.Module.Deck;

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
                int cardID = Convert.ToInt32(row.Cells["dgvColCardID"].Value);
                DeckCard card = (DeckCard)this.Cards.GetDataInstance(cardID, typeof(DeckCard));
                AddDeckList(card);
            }
        } 
        #endregion

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

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void mnuItemImportModel_Click(object sender, EventArgs e)
        {
            new FormImportCardsSetting().ShowDialog();
        }
    }
}
