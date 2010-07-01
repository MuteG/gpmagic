using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.UI;
using GPSoft.GPMagic.GPMagicBase.Model;
using GPSoft.GPMagic.GPSearch.Common;

namespace GPSoft.GPMagic.GPSearch.UI
{
    public partial class FormFilterCardType : Form
    {
        private string filterString = string.Empty;
        private static FormFilterCardType singleInstance = null;
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
            ComponentFiller.FillComboBoxItems(cbxCardType, new CardType(), false);
            ComponentFiller.FillComboBoxItems(cbxRarity, new CardRarity(), false);
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
    }
}
