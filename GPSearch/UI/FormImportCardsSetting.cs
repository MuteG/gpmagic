﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model.Database;
using GPSoft.GPMagic.GPMagicBase.Model;
using GPSoft.Helper.FileOperate;
using GPSoft.Helper.FunctionHelper;
using System.IO;

namespace GPSoft.GPMagic.GPSearch.UI
{
    public partial class FormImportCardsSetting : Form
    {
        private const string CBX_DISPLAY_NAME = "PropertyText";
        private const string CBX_VALUE_NAME = "PropertyName";
        private const string MESSAGE_MODELNAMENOTALLOWEMPTY = "模板名称不允许为空";
        private const string MESSAGE_DISPLAYNAMENOTALLOWEMPTY = "标签文字不允许为空";
        private ImportExportModel currentModel = new ImportExportModel();
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
            lbxListModeCardProperties.Items.Add(
                string.Format("{0}({1})", 
                    tbxPropertyDisplayText.Text, 
                    cbxListModeCardPropertyName.Text));
            CardProperty newCardProperty = GenerateCardProperty();
            if(!currentModel.CardProperties.Contains(newCardProperty))
                currentModel.CardProperties.Add(newCardProperty);
        }

        private CardProperty GenerateCardProperty()
        {
            CardProperty result = new CardProperty();
            result.Name = tbxPropertyDisplayText.Text;
            result.PropertyName = cbxListModeCardPropertyName.SelectedValue.ToString();
            return result;
        }

        private void btnDelListModeStructure_Click(object sender, EventArgs e)
        {
            lbxListModeCardProperties.Items.Remove(lbxListModeCardProperties.SelectedItem);
            CardProperty existCardProperty = GenerateCardProperty();
            if (currentModel.CardProperties.Contains(existCardProperty))
                currentModel.CardProperties.Remove(existCardProperty);
        }

        private void btnListModeClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadModel()
        {
            ObjectXMLSerialize<ImportExportModel>.Load(currentModel, currentModel.Path);
        }

        private void SaveModel()
        {
            FileHelper.CreateDirectory(Path.GetDirectoryName(currentModel.Path));
            ObjectXMLSerialize<ImportExportModel>.Save(currentModel, currentModel.Path);
        }

        private void SaveAsModel()
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(CheckCurrentModel())
                SaveModel();
        }

        private bool CheckCurrentModel()
        {
            bool result = true;
            currentModel.Name = tbxModelName.Text;
            result = 0 != currentModel.Name.Length;
            if (result)
            {
                if (0 == currentModel.Path.Length)
                {
                    currentModel.Path = Path.Combine(FunctionHelper.ApplicationPath,
                        string.Format("{0}\\{1}.{2}",
                            DefaultDirectoryName.ImportExport,
                            currentModel.Name,
                            DefaultExtention.ImportExport));
                }
            }
            else
            {
                MessageBox.Show(MESSAGE_MODELNAMENOTALLOWEMPTY,
                    DialogInformation.TitleWarning,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxModelName.Focus();
            }
            return result;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {

        }
    }
}
