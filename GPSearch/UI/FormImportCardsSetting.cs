using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model;
using GPSoft.GPMagic.GPMagicBase.Model.Database;
using GPSoft.Helper.Files;
using GPSoft.Helper.Utility;

namespace GPSoft.GPMagic.GPSearch.UI
{
    public partial class FormImportCardsSetting : Form
    {
        private const string CBX_DISPLAY_NAME = "PropertyText";
        private const string CBX_VALUE_NAME = "PropertyName";
        private const string MESSAGE_MODELNAMENOTALLOWEMPTY = "模板名称不允许为空";
        private const string MESSAGE_DISPLAYNAMENOTALLOWEMPTY = "标签文字不允许为空";
        private ImportExportModel currentModel = new ImportExportModel();
        private enum ModelEditStatus
        {
            Create,
            Modify
        }
        private ModelEditStatus editStatus = ModelEditStatus.Create;
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
            SaveCurrentCardProperty();
        }

        private void SaveCurrentCardProperty()
        {
            CardProperty newCardProperty = GenerateCardProperty();
            if (currentModel.CardProperties.Contains(newCardProperty))
            {
                int index = currentModel.CardProperties.IndexOf(newCardProperty);
                currentModel.CardProperties[index] = newCardProperty;
            }
            else
            {
                lbxListModeCardProperties.Items.Add(GenerateListModeCardPropertyText(newCardProperty));
                currentModel.CardProperties.Add(newCardProperty);
            }
        }

        private string GenerateListModeCardPropertyText(CardProperty property)
        {
            string result = string.Empty;
            DataTable tblProperty = (DataTable)cbxListModeCardPropertyName.DataSource;
            foreach (DataRow aRow in tblProperty.Rows)
            {
                if (aRow[cbxListModeCardPropertyName.ValueMember].Equals(property.PropertyName))
                {
                    result = string.Format("{0}({1})",
                        property.Name,
                        aRow[cbxListModeCardPropertyName.DisplayMember].ToString());
                    break;
                }
            }
            return result;
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
            currentModel = ObjectXMLSerialize<ImportExportModel>.Load(currentModel, currentModel.Path);
        }

        private void SaveModel()
        {
            SaveCurrentCardProperty();
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
                    currentModel.Path = Path.Combine(UtilityHelper.ApplicationPath,
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

        private void mnuItemOpenModel_Click(object sender, EventArgs e)
        {
            FormImportCardsModelList frmSelectModel = new FormImportCardsModelList();
            ImportExportModel model = frmSelectModel.ShowDialog();
            if (null != model)
            {
                this.editStatus = ModelEditStatus.Modify;
                FillCardPropertiesList(model);
            }
        }

        private void FillCardPropertiesList(ImportExportModel model)
        {
            switch (model.Type)
            {
                case ImportModelType.List:
                    FillListModeCardProperties(model);
                    break;
                case ImportModelType.Table:
                    break;
            }
        }

        private void FillListModeCardProperties(ImportExportModel model)
        {
            lbxListModeCardProperties.Items.Clear();
            this.currentModel.Assign(model);
            tbxModelDescription.Text = currentModel.Description;
            tbxModelName.Text = currentModel.Name;
            foreach (CardProperty property in model.CardProperties)
            {
                lbxListModeCardProperties.Items.Add(GenerateListModeCardPropertyText(property));
            }
            if (lbxListModeCardProperties.Items.Count > 0)
            {
                lbxListModeCardProperties.SelectedIndex = 0;
            }
        }

        private void lbxListModeCardProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxListModeCardProperties.SelectedIndex > -1)
            {
                DisplayCardPropertyInformation(this.currentModel.CardProperties[lbxListModeCardProperties.SelectedIndex]);
            }
        }

        private void DisplayCardPropertyInformation(CardProperty property)
        {
            tbxPropertyDisplayText.Text = property.Name;
            cbxListModeCardPropertyName.SelectedValue = property.PropertyName;
        }
    }
}
