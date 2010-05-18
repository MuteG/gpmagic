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
        FormCardInfo frmInfo;
        CardLibrary cards = new CardLibrary();
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
            frmCardImage.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (cards.Count > 0)
            {
                foreach (DataRow cardRow in cards.Records.Rows)
                {
                    string symbol = cardRow["Symbol"] as string;
                    string cnName = cardRow["CardName"] as string;
                    string enName = cardRow["CardEnglishName"] as string;
                    int rarity = Convert.ToInt32(cardRow["Rarity"]);
                    int newRowIndex = dgvCardList.Rows.Add(symbol, cnName, enName);
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
            frmInfo.Show();
        }

        private void mnuEditCard_Click(object sender, EventArgs e)
        {
            FormCardInfo frmInfo = new FormCardInfo();
            frmInfo.EditStatus = DataOperateType.Update;
            frmInfo.Show();
        }

        private void ShowCardInfoForm(DataOperateType editStatus)
        {
            if (null == frmInfo)
            {
                frmInfo = new FormCardInfo();
            }
            frmInfo.EditStatus = editStatus;
            frmInfo.Show();
        }

        private void mnuItemAbout_Click(object sender, EventArgs e)
        {
            AboutBox frmAbout = new AboutBox();
            frmAbout.ShowDialog();
        }
    }
}
