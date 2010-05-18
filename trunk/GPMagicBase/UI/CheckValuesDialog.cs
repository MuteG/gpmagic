using System;
using System.Collections.Generic;
using System.Reflection;
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
        private Type modelType;
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
            cvd.modelType = modelType;
            cvd.dataInstance = Activator.CreateInstance(modelType) as AbstractTableInstance;
            cvd.SetValueListData();
            string[] defaultArray = defaultValue.Split(split.ToCharArray());
            foreach (string valueText in defaultArray)
            {
                int valueIndex = cvd.GetValueItemIndex(valueText);
                if (valueIndex >= 0)
                {
                    cvd.lvwValues.Items[valueIndex].Checked = true;
                }
            }
            if (cvd.ShowDialog() == DialogResult.OK)
            {
                List<string> list = new List<string>();
                foreach (ListViewItem item in cvd.lvwResults.Items)
                {
                    list.Add(item.Text);
                }
                result = string.Join(split, list.ToArray());
            }
            else
            {
                result = defaultValue;
            }
            return result;
        }

        private void SetValueListData()
        {
            lvwValues.Items.Clear();
            string displayColumnName = GetDisplayColumnName();
            foreach (DataRow aRow in this.dataInstance.Records.Rows)
            {
                lvwValues.Items.Add(string.Empty).SubItems.Add(aRow[displayColumnName].ToString());
            }
        }

        private int GetValueItemIndex(string value)
        {
            int result = -1;
            DataRow[] rows = dataInstance.Records.Select(
                string.Format("{0}='{1}'", GetDisplayColumnName(), value));
            result = rows.Length > 0 ? dataInstance.Records.Rows.IndexOf(rows[0]) : -1;
            return result;
        }

        private string GetDisplayColumnName()
        {
            string result = string.Empty;
            PropertyInfo[] properties = this.dataInstance.TableInstanceType.GetProperties();
            foreach (PropertyInfo info in properties)
            {
                object[] attributes = info.GetCustomAttributes(typeof(ColumnInfoAttribute), false);
                if (attributes.Length > 0)
                {
                    ColumnInfoAttribute colAttr = (ColumnInfoAttribute)attributes[0];
                    if (colAttr != null && colAttr.IsDisplayKeyWord)
                    {
                        result = info.Name;
                        break;
                    }
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
                int existIndex = GetValueItemIndex(newValue);
                if (existIndex >= 0)
                {
                    MessageBox.Show("新建数据已经存在，本次新建操作失败。",
                        "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    object newObj = dataInstance.NewTableInstance();
                    dataInstance.TableInstanceType.GetProperty(GetDisplayColumnName()).SetValue(newObj, newValue, null);
                    dataInstance.Add(newObj);
                    dataInstance.Reload();
                    lvwValues.Items.Add(string.Empty).SubItems.Add(newValue);
                    existIndex = dataInstance.Records.Rows.Count - 1;
                }
                if (existIndex >= 0) lvwValues.Items[existIndex].Selected = true;
            }
        }

        private void mnuItemDelete_Click(object sender, EventArgs e)
        {

        }

        private void DeleteSelectedResultItems()
        {
            foreach (ListViewItem resultItem in lvwResults.SelectedItems)
            {
                int valueIndex = GetValueItemIndex(resultItem.Text);
                if (valueIndex >= 0)
                {
                    lvwValues.Items[valueIndex].Checked = false;
                }
            }
        }

        private void lvwValues_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            string itemText = string.Empty;
            if (e.Item.Checked)
            {
                itemText = e.Item.SubItems[1].Text;
                lvwResults.Items.Add(itemText, itemText, -1);
            }
            else
            {
                if (lvwResults.Items.Count > 0)
                {
                    if (e.Item.SubItems.Count > 1) itemText = e.Item.SubItems[1].Text;
                    foreach (ListViewItem item in lvwResults.Items.Find(itemText, true))
                    {
                        item.Remove();
                    }
                }
            }
        }

        private void lvwValues_DragDrop(object sender, DragEventArgs e)
        {
            DeleteSelectedResultItems();
        }

        private void lvwResults_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lvwResults.DoDragDrop(lvwResults.SelectedItems, DragDropEffects.Copy);
        }

        private void lvwValues_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lvwResults_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    {
                        DeleteSelectedResultItems();
                        break;
                    }
            }
        }
    }
}
