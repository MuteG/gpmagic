using System;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model;
using GPSoft.GPMagic.GPMagicBase.Model.Database;
using GPSoft.GPMagic.GPMagicBase.UI;
using GPSoft.GPMagic.GPSearch.Common;

namespace GPSoft.GPMagic.GPSearch.UI
{
    public partial class FormFilterCardType : Form
    {
        private string filterString = string.Empty;
        private static FormFilterCardType singleInstance = null;
        private CardRarity cardRarity = new CardRarity();
        private FormFilterCardType()
        {
            InitializeComponent();

            FillComponents();
        }
        public static FormFilterCardType CreateSingleInstance()
        {
            if (null == singleInstance)
            {
                singleInstance = new FormFilterCardType();
            }
            return singleInstance;
        }

        private void FillComponents()
        {
            ComponentFiller.FillComboBoxItems(cbxCardType, new CardType(), false, true);
            ComponentFiller.FillComboBoxItems(cbxRarity, cardRarity, false, true);
        }

        private void btnCardType_Click(object sender, EventArgs e)
        {
            tbxCardSubType.Text = CheckValuesDialog.Show(lblCardSubType.Text, tbxCardSubType.Text, "/", typeof(CardSubType));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        public string GetFilter()
        {
            string result = string.Empty;
            if (this.ShowDialog() == DialogResult.OK)
            {
                result = CommonHelper.JoinFilterStrings(GetCardTypeFilter(), 
                                                        GetCardSubTypeFilter(), 
                                                        GetCardRarityFilter());
            }
            return result;
        }

        private string GetCardTypeFilter()
        {
            string result = string.Empty;
            if (cbxCardType.Text.Length > 0)
            {
                result = string.Format("TypeName = '{0}'", cbxCardType.Text);
            }
            return result;
        }

        private string GetCardSubTypeFilter()
        {
            string result = string.Empty;
            if (tbxCardSubType.Text.Length > 0)
            {
                result = string.Format("SubTypeName LIKE '%{0}%'", cbxCardType.Text);
            }
            return result;
        }

        private string GetCardRarityFilter()
        {
            string result = string.Empty;
            if (cbxRarity.Text.Length > 0)
            {
                result = string.Format("Rarity = {0}", cbxRarity.SelectedValue);
            }
            return result;
        }

        private void cbxCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCardType.SelectedIndex > 0)
            {
                SetCardTypeText();
            }
        }

        private void SetCardTypeText()
        {
            lblTypePreview.Text = string.Format("{0} ～ {1}", cbxCardType.Text, tbxCardSubType.Text);
        }

        private void cbxRarity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRarity.SelectedIndex > 0)
            {
                lblRarityPreview.ForeColor = cardRarity.GetRarityColor(Convert.ToInt32(cbxRarity.SelectedValue));
                lblRarityPreview.Text = cbxRarity.Text;
            }
        }

        private void tbxCardSubType_TextChanged(object sender, EventArgs e)
        {
            SetCardTypeText();
        }
    }
}
