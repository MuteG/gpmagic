using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model.Database;
using GPSoft.GPMagic.GPMagicBase.Model.Setting;
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
            List<HeaderAttrabute> totalHeaders = new List<HeaderAttrabute>();
            foreach (PropertyInfo property in properties)
            {
                object[] attributes = property.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes.Length > 0)
                {
                    DescriptionAttribute description = (DescriptionAttribute)attributes[0];
                    if (description != null)
                    {
                        HeaderAttrabute header = new HeaderAttrabute();
                        header.Name = property.Name;
                        header.Text = description.Description;
                        header.Width = 80;
                        header.IsShow = true;
                        totalHeaders.Add(header);
                    }
                }
            }
            BindTotalHeaders(totalHeaders);
        }

        private void BindTotalHeaders(List<HeaderAttrabute> headers)
        {
            BindHeadersData(lbxTotalField, headers);
        }

        public DialogResult ShowDialog(List<HeaderAttrabute> currentHeaders)
        {
            List<HeaderAttrabute> displayHeaders = new List<HeaderAttrabute>();
            foreach (HeaderAttrabute header in currentHeaders)
            {
                if (header.IsShow)
                {
                    HeaderAttrabute displayHeader = new HeaderAttrabute();
                    displayHeader.Assign(header);
                    displayHeaders.Add(displayHeader);
                }
            }
            BindDisplayHeaders(displayHeaders);
            if (ShowDialog() == DialogResult.OK)
            {
                foreach (HeaderAttrabute header in currentHeaders)
                {
                    header.IsShow = displayHeaders.Contains(header);
                    if (!header.IsShow)
                    {
                        displayHeaders.Add(header);
                    }
                }
                currentHeaders.Clear();
                currentHeaders.AddRange(displayHeaders);
            }
            return this.DialogResult;
        }

        private void BindDisplayHeaders(List<HeaderAttrabute> headers)
        {
            BindHeadersData(lbxDisplayField, headers);
        }

        private void BindHeadersData(ListBox list, List<HeaderAttrabute> headers)
        {
            list.DataSource = headers;
            list.ValueMember = "Name";
            list.DisplayMember = "Text";
        }

        private void lbxTotalField_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1 && e.Button == MouseButtons.Left && lbxTotalField.SelectedIndices.Count > 0)
            {
                HeaderAttrabute header = new HeaderAttrabute();
                header.Name = lbxTotalField.SelectedValue.ToString();
                header.Text = lbxTotalField.Text;
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
            List<HeaderAttrabute> source = lbxDisplayField.DataSource as List<HeaderAttrabute>;
            HeaderAttrabute newHeader = (HeaderAttrabute)e.Data.GetData(typeof(HeaderAttrabute));
            if (!source.Contains(newHeader))
            {
                source.Add(newHeader);
                lbxDisplayField.DataSource = null;
                BindDisplayHeaders(source);
            }
        }

        private void lbxDisplayField_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1 && e.Button == MouseButtons.Left && lbxDisplayField.SelectedIndices.Count > 0)
            {
                HeaderAttrabute header = new HeaderAttrabute();
                header.Name = lbxDisplayField.SelectedValue.ToString();
                header.Text = lbxDisplayField.Text;
                lbxTotalField.AllowDrop = true;
                lbxDisplayField.AllowDrop = false;
                lbxTotalField.DoDragDrop(header, DragDropEffects.Copy);
            }
        }

        private void lbxTotalField_DragDrop(object sender, DragEventArgs e)
        {
            HeaderAttrabute dropHeader = (HeaderAttrabute)e.Data.GetData(typeof(HeaderAttrabute));
            List<HeaderAttrabute> source = lbxDisplayField.DataSource as List<HeaderAttrabute>;
            if (source.Contains(dropHeader))
            {
                source.Remove(dropHeader);
                lbxDisplayField.DataSource = null;
                BindDisplayHeaders(source);
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
                    HeaderAttrabute temp = new HeaderAttrabute();
                    temp.Assign(lbxDisplayField.SelectedItem as HeaderAttrabute);
                    List<HeaderAttrabute> source = lbxDisplayField.DataSource as List<HeaderAttrabute>;
                    source.RemoveAt(selectedIndex);
                    if (isMoveUp) selectedIndex--; else selectedIndex++;
                    source.Insert(selectedIndex, temp);
                    lbxDisplayField.DataSource = null;
                    BindDisplayHeaders(source);
                    lbxDisplayField.SelectedIndex = selectedIndex;
                }
            }
        }
    }
}
