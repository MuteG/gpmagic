using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using GPSoft.Helper.Files;
using GPSoft.Helper.Utility;
using GPSoft.GPMagic.GPMagicBase.Model;

namespace GPSoft.GPMagic.GPSearch.UI
{
    public partial class FormImportCardsModelList : Form
    {
        private readonly string modelDir = Path.Combine(UtilityHelper.ApplicationPath, DefaultDirectoryName.ImportExport);
        private List<ImportExportModel> modelList = new List<ImportExportModel>();
        public FormImportCardsModelList()
        {
            InitializeComponent();
            LoadAllModels();
        }

        public new ImportExportModel ShowDialog()
        {
            ImportExportModel result = null;
            if (base.ShowDialog() == DialogResult.OK)
            {
                if (lbxModelList.SelectedIndex > -1)
                {
                    result = modelList[lbxModelList.SelectedIndex];
                }
            }
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void LoadAllModels()
        {
            string[] modelArray = Directory.GetFiles(modelDir, "*.iem", SearchOption.TopDirectoryOnly);
            lbxModelList.Items.Clear();
            modelList.Clear();
            foreach (string modelPath in modelArray)
            {
                try
                {
                    ImportExportModel model = new ImportExportModel();
                    model = ObjectXMLSerialize<ImportExportModel>.Load(model, modelPath);
                    model.Path = modelPath;
                    modelList.Add(model);
                    lbxModelList.Items.Add(model.Name);
                    if (lbxModelList.Items.Count > 0)
                    {
                        lbxModelList.SelectedIndex = 0;
                    }
                }
                catch
                {
                    continue;
                }
            }
        }

        private void lbxModelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxModelList.SelectedIndex > -1)
            {
                DisplayModelInformation(modelList[lbxModelList.SelectedIndex]);
                btnDelete.Enabled = true;
            }
        }

        private void DisplayModelInformation(ImportExportModel model)
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(string.Format("模板名称：{0}", model.Name));
            info.AppendLine(string.Format("模板类型：{0}", TranslateModelTypeToString(model.Type)));
            info.AppendLine(string.Format("信息种类：{0}", model.CardProperties.Count));
            info.AppendLine(string.Format("模板说明：{0}", model.Description));
            lblModelInfo.Text = info.ToString();
        }

        private string TranslateModelTypeToString(ImportModelType type)
        {
            string result = string.Empty;
            switch (type)
            {
                case ImportModelType.None:
                    result = "未定义";
                    break;
                case ImportModelType.List:
                    result = "信息序列模式";
                    break;
                case ImportModelType.Table:
                    result = "表格模式";
                    break;
            }
            return result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxModelList.SelectedIndex > -1 &&
                MessageBox.Show("确认要删除这个模板么？",
                    "删除确认",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
            {
                FileHelper.DeleteFileSafely(modelList[lbxModelList.SelectedIndex].Path);
                modelList.RemoveAt(lbxModelList.SelectedIndex);
                lbxModelList.Items.RemoveAt(lbxModelList.SelectedIndex);
                if (lbxModelList.Items.Count > 0)
                {
                    lbxModelList.SelectedIndex = 0;
                }
            }
        }
    }
}
