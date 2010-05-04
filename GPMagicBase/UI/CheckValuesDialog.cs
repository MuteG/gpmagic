using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model;

namespace GPSoft.GPMagic.GPMagicBase.UI
{
    public partial class CheckValuesDialog : Form
    {
        /// <summary>
        /// 当前处理的数据实例
        /// </summary>
        private AbstractTableInstance dataInstance;
        private CheckValuesDialog()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 打开列表选择对话框
        /// </summary>
        /// <param name="title">对话框标题</param>
        /// <param name="defaultValue">初始值</param>
        /// <param name="split">多数值的分隔符</param>
        /// <param name="modelType">数据对应的类型</param>
        /// <returns></returns>
        public static string Show(string title, string defaultValue, string split, Type modelType)
        {
            string result = string.Empty;
            CheckValuesDialog cvd = new CheckValuesDialog();
            cvd.Text = title;
            cvd.tbxSearch.Focus();
            cvd.SetValueListData(modelType);
            if (cvd.ShowDialog() == DialogResult.OK)
            {
                List<string> list = new List<string>();
                foreach (object item in cvd.lvwResults.Items)
                {
                    list.Add(item.ToString());
                }
                result = string.Join(split, list.ToArray());
            }
            else
            {
                result = defaultValue;
            }
            return result;
        }

        private void SetValueListData(Type modelType)
        {
            this.dataInstance = Activator.CreateInstance(modelType) as AbstractTableInstance;
            string displayColumnName = GetDisplayColumnName(modelType);
            foreach (DataRow aRow in this.dataInstance.Records.Rows)
            {
                lvwValues.Items.Add(string.Empty).SubItems.Add(aRow[displayColumnName].ToString());
            }
        }

        private string GetDisplayColumnName(Type modelType)
        {
            string result = string.Empty;
            switch (modelType.FullName)
            {
                case "GPSoft.GPMagic.GPMagicBase.Model.CardSubType":
                    {
                        result = "SubTypeName";
                        break;
                    }
                case "GPSoft.GPMagic.GPMagicBase.Model.CardAbilitie":
                    {
                        result = "AbilitiesName";
                        break;
                    }
            }
            return result;
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            string newValue = InputTextDialog.Show(string.Format("新建 - {0}", this.Text), string.Empty);
            if (!string.IsNullOrEmpty(newValue))
            {
                DataRow newRow = this.dataInstance.Records.NewRow();
                newRow.ItemArray = new object[] { };
            }
        }

        private void mnuItemDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
