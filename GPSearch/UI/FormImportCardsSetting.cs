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
        private const string CBX_DISPLAY_NAME = "PropertyText";
        private const string CBX_VALUE_NAME = "PropertyName";
        public FormImportCardsSetting()
        {
            InitializeComponent();
            FillComboBoxCardProperties();
        }

        private void FillComboBoxCardProperties()
        {
            Type cardType = typeof(ListCardTotal);
            DataTable tblCardProperties = new DataTable();
            tblCardProperties.Columns.Add(CBX_DISPLAY_NAME, typeof(string));
            tblCardProperties.Columns.Add(CBX_VALUE_NAME, typeof(string));
            foreach (PropertyInfo property in cardType.GetProperties())
            {
                object[] attributes = property.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes.Length > 0)
                {
                    DescriptionAttribute colAttr = (DescriptionAttribute)attributes[0];
                    if (colAttr != null)
                    {
                        tblCardProperties.Rows.Add(colAttr.Description, property.Name);
                    }
                }
            }
            BindingComboBoxData(cbxListModeCardPropertyName, tblCardProperties, CBX_DISPLAY_NAME, CBX_VALUE_NAME);
            BindingComboBoxData(cbxTableModeCardPropertyName, tblCardProperties, CBX_DISPLAY_NAME, CBX_VALUE_NAME);
        }

        private void BindingComboBoxData(ComboBox cbx, DataTable source, string displayName, string valueName)
        {
            cbx.DataSource = source;
            cbx.DisplayMember = displayName;
            cbx.ValueMember = valueName;
        }

        private void btnTableModeClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddListModeStructure_Click(object sender, EventArgs e)
        {
            lbxListModeCardProperties.Items.Add(string.Format("{0}({1})", tbxPropertyDisplayText.Text, cbxListModeCardPropertyName.Text));
        }

        private void btnDelListModeStructure_Click(object sender, EventArgs e)
        {

        }

        private void btnListModeClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
