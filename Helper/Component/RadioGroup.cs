using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GPSoft.Helper.Component
{
    public partial class RadioGroup : UserControl
    {
        private RadioGroupItemCollection items = new RadioGroupItemCollection();

        public RadioGroupItemCollection Items
        {
            get { return items; }
            set { items = value; }
        }

        public int CheckedIndex
        {
            get
            {
                return GetCheckedIndex();
            }
        }

        private int GetCheckedIndex()
        {
            int result = -1;
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Checked)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
        
        public RadioGroup()
        {
            InitializeComponent();
            items.groupPanel = this;
        }
    }

    public class RadioGroupItemCollection
    {
        private List<RadioButton> listRadioButtonItems = new List<RadioButton>();
        private Dictionary<string, int> dictRadioButtonItems = new Dictionary<string, int>();
        internal RadioGroup groupPanel;

        public int Count
        {
            get { return listRadioButtonItems.Count; }
        }

        public int Add(string itemText)
        {
            int result = -1;
            if (Contains(itemText))
            {
                throw new Exception(string.Format("添加的项（{0}）已经存在。", itemText));
            }
            else
            {
                RadioButton newItem = NewItem(itemText);
                result = listRadioButtonItems.Count;
                listRadioButtonItems.Add(newItem);
                dictRadioButtonItems.Add(itemText, result);
                SetItemTop(listRadioButtonItems.Count - 1, newItem);
                groupPanel.Controls.Add(newItem);
            }
            return result;
        }

        private void SetItemTop(int index, RadioButton item)
        {
            if (index == 0)
            {
                item.Top = 6;
            }
            else
            {
                RadioButton lastItem = listRadioButtonItems[index - 1];
                item.Top = 6 + lastItem.Top + lastItem.Font.Height;
            }
        }

        private RadioButton NewItem(string itemText)
        {
            RadioButton newItem = new RadioButton();
            newItem.Text = itemText;
            newItem.Font = groupPanel.Font;
            newItem.Left = 12;
            newItem.Visible = true;
            return newItem;
        }

        public void Clear()
        {
            listRadioButtonItems.Clear();
        }

        public bool Contains(string itemText)
        {
            return dictRadioButtonItems.ContainsKey(itemText);
        }

        public int IndexOf(string itemText)
        {
            return Contains(itemText) ? dictRadioButtonItems[itemText] : -1;
        }

        public void Insert(int index, string itemText)
        {
            if (Contains(itemText))
            {
                throw new Exception(string.Format("插入的项（{0}）已经存在。", itemText));
            }
            else
            {
                RadioButton newItem = NewItem(itemText);
                listRadioButtonItems.Insert(index, newItem);
                ResetDictRadioButtonItems();
                ResetRadioGroup();
            }
        }

        private void ResetRadioGroup()
        {
            groupPanel.Controls.Clear();
            for (int i = 0; i < listRadioButtonItems.Count; i++)
            {
                RadioButton item = listRadioButtonItems[i];
                SetItemTop(i, item);
                groupPanel.Controls.Add(item);
            }
        }

        private void ResetDictRadioButtonItems()
        {
            for (int i = 0; i < listRadioButtonItems.Count; i++)
            {
                dictRadioButtonItems[listRadioButtonItems[i].Text] = i;
            }
        }

        public void Remove(string itemText)
        {
            if (Contains(itemText))
            {
                RemoveAt(IndexOf(itemText));
            }
            else
            {
                throw new Exception(string.Format("没有找到指定的项（{0}）。", itemText));
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > listRadioButtonItems.Count - 1)
            {
                throw new Exception(string.Format("索引值（{0}）超出允许的范围。", index));
            }
            else
            {
                listRadioButtonItems.RemoveAt(index);
                ResetDictRadioButtonItems();
                ResetRadioGroup();
            }
        }

        public RadioButton this[int index]
        {
            get
            {
                return listRadioButtonItems[index];
            }
            set
            {
                dictRadioButtonItems.Remove(listRadioButtonItems[index].Text);
                listRadioButtonItems[index] = value;
                groupPanel.Controls[index].Text = value.Text;
                dictRadioButtonItems.Add(value.Text, index);
            }
        }
    }
}
