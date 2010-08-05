using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GPSoft.GPMagic.GPSearch.Common;
using GPSoft.GPMagic.GPMagicBase.Model;
using GPSoft.GPMagic.GPMagicBase.UI;

namespace GPSoft.GPMagic.GPSearch.UI
{
    public partial class FormEditDeckFilter : Form
    {
        private DataTable filterFieldTable = new DataTable();
        public FormEditDeckFilter()
        {
            InitializeComponent();
            FillFilterList();
            FillComboBoxFilterName();
        }

        private void FillComboBoxFilterName()
        {
            this.filterFieldTable.Columns.Add("colDisplayName", typeof(string));
            this.filterFieldTable.Columns.Add("colFieldName", typeof(string));
            this.filterFieldTable.Rows.Add("卡牌类别", "TypeName");
            this.filterFieldTable.Rows.Add("卡牌子类别", "SubTypeName");
            cbxFieldName.DataSource = this.filterFieldTable;
            cbxFieldName.DisplayMember = "colDisplayName";
            cbxFieldName.ValueMember = "colFieldName";
        }

        private void FillFilterList()
        {
            foreach (ConfigDeckFilter filter in CommonHelper.DeckFilterListConfiguration.DeckFilterList)
            {
                lbxFilterList.Items.Add(filter.DisplayName);
            }
            if (CommonHelper.DeckFilterListConfiguration.DeckFilterList.Count > 0)
            {
                lbxFilterList.SelectedIndex = 0;
            }
            else
            {
                cbxFieldName.SelectedIndex = 0;
                cbxIsShow.Checked = true;
                pbxBackgroundColor.BackColor = Color.White;
            }
        }

        private void PackFilterInformation(ConfigDeckFilter filter)
        {
            filter.DisplayName = tbxDisplayName.Text;
            filter.FieldName = Convert.ToString(cbxFieldName.SelectedValue);
            filter.FieldValue = tbxFieldValue.Text;
            filter.IsReverse = cbxIsReverse.Checked;
            filter.IsShow = cbxIsShow.Checked;
            filter.BackgroundColor = pbxBackgroundColor.BackColor.ToArgb();
        }

        private void DisplayFilterInformation(ConfigDeckFilter filter)
        {
            tbxDisplayName.Text = filter.DisplayName;
            cbxIsShow.Checked = filter.IsShow;
            cbxIsReverse.Checked = filter.IsReverse;
            cbxFieldName.SelectedValue = filter.FieldName;
            tbxFieldValue.Text = filter.FieldValue;
            pbxBackgroundColor.BackColor = System.Drawing.Color.FromArgb(filter.BackgroundColor);
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxBackgroundColor.BackColor = colorDialog1.Color;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            ConfigDeckFilter filter;
            List<ConfigDeckFilter> filterList = CommonHelper.DeckFilterListConfiguration.DeckFilterList;
            if (lbxFilterList.Items.Count > 0 && lbxFilterList.SelectedIndex >= 0)
            {
                filter = filterList[lbxFilterList.SelectedIndex];
                PackFilterInformation(filter);
            }
            else
            {
                filter = new ConfigDeckFilter();
                PackFilterInformation(filter);
                if (filterList.Contains(filter))
                {
                    ConfigDeckFilter existFilter = filterList[filterList.IndexOf(filter)];
                    existFilter.DisplayName = filter.DisplayName;
                    existFilter.FieldName = filter.FieldName;
                    existFilter.FieldValue = filter.FieldValue;
                    existFilter.IsShow = filter.IsShow;
                    existFilter.IsReverse = filter.IsReverse;
                    existFilter.BackgroundColor = filter.BackgroundColor;
                }
                else
                {
                    filterList.Add(filter);
                    lbxFilterList.Items.Add(filter.DisplayName);
                }
            }
            CommonHelper.DeckFilterListConfiguration.Save();
        }

        private bool CheckInput()
        {
            bool result = true;
            result = !tbxDisplayName.Text.Trim().Equals(string.Empty);
            if (!result)
            {
                MessageBox.Show("统计项名称不能为空", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;
        }

        private void lbxFilterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxFilterList.SelectedIndex;
            if (index >= 0 && lbxFilterList.Items.Count > 0)
            {
                DisplayFilterInformation(CommonHelper.DeckFilterListConfiguration.DeckFilterList[index]);
            }
        }

        private void btnFieldValue_Click(object sender, EventArgs e)
        {
            switch (Convert.ToString(cbxFieldName.SelectedValue))
            {
                case "TypeName":
                    {
                        tbxFieldValue.Text = CheckValuesDialog.Show(lblFieldValue.Text, tbxFieldValue.Text, "/", typeof(CardType));
                        break;
                    }
                case "SubTypeName":
                    {
                        tbxFieldValue.Text = CheckValuesDialog.Show(lblFieldValue.Text, tbxFieldValue.Text, "/", typeof(CardSubType));
                        break;
                    }
            }
        }

        private void cbxFieldName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxFilterList.SelectedIndex >= 0 && CommonHelper.DeckFilterListConfiguration.DeckFilterList.Count > 0)
            {
                ConfigDeckFilter filter = CommonHelper.DeckFilterListConfiguration.DeckFilterList[lbxFilterList.SelectedIndex];
                if (cbxFieldName.SelectedValue.Equals(filter.FieldName))
                {
                    tbxFieldValue.Text = filter.FieldValue;
                }
                else
                {
                    tbxFieldValue.Text = string.Empty;
                }
            }
            else
            {
                tbxFieldValue.Text = string.Empty;
            }
        }
    }
}
