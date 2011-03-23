using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model.Database;
using GPSoft.GPMagic.GPSearch.Model;

namespace GPSoft.GPMagic.GPSearch.UI
{
    public partial class FormSetHeader : Form
    {
        public FormSetHeader()
        {
            InitializeComponent();
        }

        private void FormSetHeader_Load(object sender, EventArgs e)
        {
            PropertyInfo[] properties = typeof(ListCardTotal).GetProperties();
            List<HeaderField> totalFields = new List<HeaderField>();
            foreach (PropertyInfo property in properties)
            {
                object[] attributes = property.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes.Length > 0)
                {
                    DescriptionAttribute description = (DescriptionAttribute)attributes[0];
                    if (description != null)
                    {
                        HeaderField header = new HeaderField();
                        header.FieldName = property.Name;
                        header.Description = description.Description;
                        totalFields.Add(header);
                    }
                }
            }
            lbxTotalField.DataSource = totalFields;
            lbxTotalField.ValueMember = "FieldName";
            lbxTotalField.DisplayMember = "Description";
        }

        public DialogResult ShowDialog(List<HeaderField> currentHeaders)
        {
            lbxDisplayField.DataSource = currentHeaders;
            lbxDisplayField.ValueMember = "FieldName";
            lbxDisplayField.DisplayMember = "Description";
            return this.ShowDialog();
        }

        private void lbxTotalField_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1 && e.Button == MouseButtons.Left && lbxTotalField.SelectedIndices.Count > 0)
            {
                HeaderField header = new HeaderField();
                header.FieldName = lbxTotalField.SelectedValue.ToString();
                header.Description = lbxTotalField.Text;
                lbxTotalField.AllowDrop = false;
                lbxDisplayField.AllowDrop = true;
                lbxDisplayField.DoDragDrop(header, DragDropEffects.Copy);
            }
        }

        private void lbxDisplayField_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lbxDisplayField_DragDrop(object sender, DragEventArgs e)
        {
            List<HeaderField> source = lbxDisplayField.DataSource as List<HeaderField>;
            HeaderField newHeader = (HeaderField)e.Data.GetData(typeof(HeaderField));
            if (!source.Contains(newHeader))
            {
                source.Add(newHeader);
                lbxDisplayField.DataSource = null;
                lbxDisplayField.DataSource = source;
                lbxDisplayField.ValueMember = "FieldName";
                lbxDisplayField.DisplayMember = "Description";
            }
        }

        private void lbxDisplayField_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1 && e.Button == MouseButtons.Left && lbxDisplayField.SelectedIndices.Count > 0)
            {
                HeaderField header = new HeaderField();
                header.FieldName = lbxDisplayField.SelectedValue.ToString();
                header.Description = lbxDisplayField.Text;
                lbxTotalField.AllowDrop = true;
                lbxDisplayField.AllowDrop = false;
                lbxTotalField.DoDragDrop(header, DragDropEffects.Copy);
            }
        }

        private void lbxTotalField_DragDrop(object sender, DragEventArgs e)
        {
            HeaderField dropHeader = (HeaderField)e.Data.GetData(typeof(HeaderField));
            List<HeaderField> source = lbxDisplayField.DataSource as List<HeaderField>;
            if (source.Contains(dropHeader))
            {
                source.Remove(dropHeader);
                lbxDisplayField.DataSource = null;
                lbxDisplayField.DataSource = source;
                lbxDisplayField.ValueMember = "FieldName";
                lbxDisplayField.DisplayMember = "Description";
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveItemPosition(true);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveItemPosition(false);
        }

        private void MoveItemPosition(bool isMoveUp)
        {
            if (lbxDisplayField.SelectedIndices.Count > 0)
            {
                int selectedIndex = lbxDisplayField.SelectedIndex;
                bool canWork = isMoveUp ? selectedIndex > 0 : selectedIndex < lbxDisplayField.Items.Count - 1;
                if (canWork)
                {
                    HeaderField temp = new HeaderField();
                    temp.Assign(lbxDisplayField.SelectedItem as HeaderField);
                    List<HeaderField> source = lbxDisplayField.DataSource as List<HeaderField>;
                    source.RemoveAt(selectedIndex);
                    if (isMoveUp) selectedIndex--; else selectedIndex++;
                    source.Insert(selectedIndex, temp);
                    lbxDisplayField.DataSource = null;
                    lbxDisplayField.DataSource = source;
                    lbxDisplayField.ValueMember = "FieldName";
                    lbxDisplayField.DisplayMember = "Description";
                    lbxDisplayField.SelectedIndex = selectedIndex;
                }
            }
        }
    }
}
