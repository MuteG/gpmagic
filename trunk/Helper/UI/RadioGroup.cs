using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;

namespace GPSoft.Helper.UI
{
    public partial class RadioGroupBox : UserControl
    {
        private RadioGroupItemCollection items;
        /// <summary>
        /// 获取选选项集合
        /// </summary>
        [Browsable(false)]
        public RadioGroupItemCollection Items
        {
            get { return items; }
        }
        private int checkedIndex = -1;
        /// <summary>
        /// 获取或者设置选中项的索引
        /// </summary>
        [Browsable(false)]
        public int CheckedIndex
        {
            get
            {
                GetCheckedIndex();
                return this.checkedIndex;
            }
        }
        private string checkedText = string.Empty;
        /// <summary>
        /// 获取或者设置选中项的显示文字
        /// </summary>
        [Browsable(false)]
        public string CheckedText
        {
            get
            {
                GetCheckedIndex();
                return this.checkedText;
            }
        }
        /// <summary>
        /// 获取或者设置组件的标题
        /// </summary>
        public new string Text
        {
            get { return this.gbxRadioGroup.Text; }
            set { this.gbxRadioGroup.Text = value; }
        }

        private void GetCheckedIndex()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Checked)
                {
                    this.checkedIndex = i;
                    this.checkedText = Items[i].Text;
                    break;
                }
            }
        }
        
        public RadioGroupBox()
        {
            InitializeComponent();
            items = new RadioGroupItemCollection(this.gbxRadioGroup);
        }

        public class RadioGroupItemCollection : IEnumerable
        {
            private List<RadioButton> listRadioButtonItems = new List<RadioButton>();
            private Dictionary<string, int> dictRadioButtonItems = new Dictionary<string, int>();
            private GroupBox groupPanel;

            public RadioGroupItemCollection(GroupBox groupBox)
            {
                this.groupPanel = groupBox;
            }

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
                    AddNewItem(newItem);
                }
                return result;
            }

            private void AddNewItem(RadioButton newItem)
            {
                groupPanel.Controls.Add(newItem);

            }

            private void SetItemTop(int index, RadioButton item)
            {
                if (index == 0)
                {
                    item.Top = 16;
                }
                else
                {
                    RadioButton lastItem = listRadioButtonItems[index - 1];
                    item.Top = 10 + lastItem.Top + lastItem.Font.Height;
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
                    //item.Visible = true;
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

            #region IEnumerable 成员

            public IEnumerator GetEnumerator()
            {
                return new Enumerator(listRadioButtonItems);
            }

            #endregion
            [Serializable]
            private class Enumerator : IEnumerator
            {
                private List<RadioButton> items;
                private int index = -1;
                private object current = null;
                internal Enumerator(List<RadioButton> list)
                {
                    items = list;
                }
                #region IEnumerator 成员

                public object Current
                {
                    get
                    {
                        if (this.current != null)
                        {
                            return this.current;
                        }
                        if (this.index == -1)
                        {
                            throw new InvalidOperationException("遍历尚未开始。");
                        }
                        throw new InvalidOperationException("遍历已经结束");
                    }
                }

                public bool MoveNext()
                {
                    bool result = index < items.Count - 1;
                    if (result)
                    {
                        index++;
                        this.current = items[index];
                    }
                    return result;
                }

                public void Reset()
                {
                    this.current = null;
                    this.index = -1;
                }

                #endregion
            }
        }
    }

     
}
