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
            cbxSearchLanguage.SelectedIndex = 0;
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
            SetDataGridViewData();
        }

        public void SetDataGridViewData()
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
    }
}
