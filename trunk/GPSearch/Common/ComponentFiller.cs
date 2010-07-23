using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model;
using System.Data;

namespace GPSoft.GPMagic.GPSearch.Common
{
    internal class ComponentFiller
    {
        /// <summary>
        /// 填充指定ComboBox的内容
        /// </summary>
        /// <param name="cbx">要进行填充的ComboBox</param>
        /// <param name="tableInstance">数据源（表的实例）</param>
        /// <param name="hasNewItem">是否拥有“新建”项</param>
        /// <param name="hasEmptyItem">是否拥有空白项</param>
        public static void FillComboBoxItems(ComboBox cbx, AbstractTableInstance tableInstance, bool hasNewItem, bool hasEmptyItem)
        {
            DataTable records = tableInstance.Records;
            if (hasNewItem)
            {
                records.Rows.InsertAt(records.NewRow(), 0);
                records.Rows[0][tableInstance.DisplayColumnName] = DataOperateTypeDisplayWrods.New;
                records.Rows[0][tableInstance.PrimaryKeyColumnName] = 0;
            }
            if (hasEmptyItem)
            {
                records.Rows.InsertAt(records.NewRow(), 0);
                records.Rows[0][tableInstance.DisplayColumnName] = string.Empty;
                records.Rows[0][tableInstance.PrimaryKeyColumnName] = -1;
            }
            cbx.DataSource = records;
            cbx.DisplayMember = tableInstance.DisplayColumnName;
            cbx.ValueMember = tableInstance.PrimaryKeyColumnName;
            if (hasNewItem && records.Rows.Count > 1)
            {
                cbx.SelectedIndex = 1;
            }
        }
        /// <summary>
        /// 填充指定ComboBox的内容
        /// </summary>
        /// <param name="cbx">要进行填充的ComboBox</param>
        /// <param name="tableInstance">数据源（表的实例）</param>
        /// <param name="hasNewItem">是否拥有“新建”项</param>
        public static void FillComboBoxItems(ComboBox cbx, AbstractTableInstance tableInstance, bool hasNewItem)
        {
            FillComboBoxItems(cbx, tableInstance, hasNewItem, false);
        }

        /// <summary>
        /// 填充指定ComboBox的内容
        /// </summary>
        /// <param name="cbx">要进行填充的ComboBox</param>
        /// <param name="tableInstance">数据源（表的实例）</param>
        public static void FillComboBoxItems(ComboBox cbx, AbstractTableInstance tableInstance)
        {
            FillComboBoxItems(cbx, tableInstance, false);
        }
    }
}
