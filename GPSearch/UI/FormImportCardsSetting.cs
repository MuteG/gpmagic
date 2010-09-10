using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model.Database;

namespace GPSoft.GPMagic.GPSearch.UI
{
    public partial class FormImportCardsSetting : Form
    {
        public FormImportCardsSetting()
        {
            InitializeComponent();
            FillComboBoxCardProperties();
        }

        private void FillComboBoxCardProperties()
        {
            cbxListModeCardPropertyName.Items.Clear();
            cbxTableModePropertyName.Items.Clear();
            Type cardType = typeof(CardTotal);
            foreach (PropertyInfo property in cardType.GetProperties())
            {

            }
        }
    }
}
