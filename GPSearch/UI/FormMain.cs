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
    public partial class FormMain : Form
    {
        private FormCardInfo frmInfo;
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
        }

        private void Init()
        {
            frmInfo = new FormCardInfo();
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
            RefreshTotalCardsGrid();
        }

        public void RefreshTotalCardsGrid()
        {
            if (cards.Count > 0)
            {
                dgvCardList.Rows.Clear();
                foreach (DataRow cardRow in cards.Records.Rows)
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
                    if (rarity > 1)
                    {
                        CardRarity aRarity = new CardRarity();
                        dgvCardList.Rows[newRowIndex].DefaultCellStyle.ForeColor = aRarity.GetRarityColor(rarity);
                        aRarity.Dispose();
                    }
                }
            }
        }

        private void mnuAddCard_Click(object sender, EventArgs e)
        {
            FormCardInfo frmInfo = new FormCardInfo();
            frmInfo.EditStatus = DataOperateType.Insert;
            frmInfo.ShowDialog(this);
        }

        private void mnuEditCard_Click(object sender, EventArgs e)
        {
            FormCardInfo frmInfo = new FormCardInfo();
            frmInfo.EditStatus = DataOperateType.Update;
            frmInfo.ShowDialog(this);
        }

        private void ShowCardInfoForm(DataOperateType editStatus)
        {
            if (null == frmInfo)
            {
                frmInfo = new FormCardInfo();
            }
            frmInfo.EditStatus = editStatus;
            frmInfo.Show(this);
        }

        private void mnuItemAbout_Click(object sender, EventArgs e)
        {
            AboutBox frmAbout = new AboutBox();
            frmAbout.ShowDialog(this);
        }

        private void dgvDeckList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dgvCardList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCardList.DoDragDrop(dgvCardList.SelectedRows, DragDropEffects.Copy);
        }

        private void dgvDeckList_DragDrop(object sender, DragEventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = 
                (DataGridViewSelectedRowCollection)e.Data.GetData(typeof(DataGridViewSelectedRowCollection));
            MessageBox.Show(selectedRows.Count.ToString());
        }

        private void dgvCardList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            dgvCardList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
        }

        private void dgvCardList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvCardList.Rows[e.RowIndex];
            row.DefaultCellStyle.BackColor = e.RowIndex % 2 == 0 ? Color.White : Color.Lavender;
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTotalCardsGrid();
        }
    }
}
