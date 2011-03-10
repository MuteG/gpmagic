using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GPSoft.GPMagic.GPMagicBase.UI
{
    public partial class CollapsiblePanel : UserControl
    {
        public class Item
        {
            private string m_Name = string.Empty;
            /// <summary>
            /// 获取或者设置项目名称
            /// </summary>
            public string Name
            {
                get { return m_Name; }
                set { m_Name = value; }
            }

            private string m_Key = string.Empty;
            /// <summary>
            /// 获取或者设置项目标题
            /// </summary>
            public string Key
            {
                get { return m_Key; }
                set { m_Key = value; }
            }

            private string m_Value = string.Empty;
            /// <summary>
            /// 获取或者设置项目内容
            /// </summary>
            public string Value
            {
                get { return m_Value; }
                set { m_Value = value; }
            }

            private Color m_ForeColor = Color.Black;
            /// <summary>
            /// 获取或者设置前景色
            /// </summary>
            public Color ForeColor
            {
                get { return m_ForeColor; }
                set { m_ForeColor = value; }
            }

            public override int GetHashCode()
            {
                return (this.Key + this.Value).GetHashCode();
            } 

            public override bool Equals(object obj)
            {
                bool isEquals = obj is Item;
                if (isEquals)
                {
                    Item another = obj as Item;
                    isEquals = string.Compare(another.Key, this.Key) == 0 && string.Compare(another.Value, this.Value) == 0;
                }
                return isEquals;
            }
        }

        public class ItemCollection
        {
            private List<Item> m_ItemList = new List<Item>();

            public ItemCollection(Graphics parentGraphics, Font parentFont)
            {
                m_ParentGraphics = parentGraphics;
                m_ParentFont = parentFont;
            }

            private Graphics m_ParentGraphics;

            private Font m_ParentFont;

            private int m_MaxKeyWidth = 0;
            /// <summary>
            /// 获取Key的最大宽度
            /// </summary>
            public int MaxKeyWidth
            {
                get { return m_MaxKeyWidth; }
            }

            private int m_MaxValueWidth = 0;
            /// <summary>
            /// 获取Value的最大宽度
            /// </summary>
            public int MaxValueWidth
            {
                get { return m_MaxValueWidth; }
            }

            public void Add(Item item)
            {
                m_ItemList.Add(item);
                SetMaxWidth(item);
            }

            private void SetMaxWidth(Item item)
            {
                m_MaxKeyWidth = Math.Max(m_MaxKeyWidth, (int)m_ParentGraphics.MeasureString(item.Key, m_ParentFont).Width);
                m_MaxValueWidth = Math.Max(m_MaxValueWidth, (int)m_ParentGraphics.MeasureString(item.Value, m_ParentFont).Width);
            }

            public int IndexOf(Item item)
            {
                return m_ItemList.IndexOf(item);
            }

            public void Insert(int index, Item item)
            {
                m_ItemList.Insert(index, item);
                SetMaxWidth(item);
            }

            public void RemoveAt(int index)
            {
                m_ItemList.Remove(m_ItemList[index]);
            }

            public Item this[int index]
            {
                get
                {
                    return m_ItemList[index];
                }
                set
                {
                    m_ItemList[index] = value;
                }
            }

            public void Clear()
            {
                m_MaxKeyWidth = 0;
                m_MaxValueWidth = 0;
                m_ItemList.Clear();
            }

            public bool Contains(Item item)
            {
                return m_ItemList.Contains(item);
            }
            /// <summary>
            /// 获取项目数量
            /// </summary>
            public int Count
            {
                get { return m_ItemList.Count; }
            }

            public bool Remove(Item item)
            {
                bool successed = m_ItemList.Remove(item);
                if (successed)
                {
                    ResetMaxWidth();
                }
                return successed;
            }

            private void ResetMaxWidth()
            {
                foreach (Item item in m_ItemList)
                {
                    m_MaxKeyWidth = 0;
                    m_MaxValueWidth = 0;
                    SetMaxWidth(item);
                }
            }
        }

        private ItemCollection m_Items;
        /// <summary>
        /// 获取项目集合
        /// </summary>
        public ItemCollection Items
        {
            get { return m_Items; }
        }

        private int m_BodyHeight = 0; //记录可折叠区域高度

        private bool m_Collapsed = false;
        /// <summary>
        /// 获取或者设置是否处于折叠状态
        /// </summary>
        public bool Collapsed
        {
            get { return m_Collapsed; }
            set
            {
                m_Collapsed = value;
                Collapse();
            }
        }
        /// <summary>
        /// 获取或者设置控件标题文字
        /// </summary>
        public new string Text
        {
            get { return lblTitle.Text; }
            set
            {
                lblTitle.Text = value;
                Text = value;
            }
        }

        public CollapsiblePanel()
        {
            InitializeComponent();
            m_BodyHeight = pnlBody.Height;
            m_Items = new ItemCollection(pnlBody.CreateGraphics(), pnlBody.Font);
        }

        private void pbxTitle_Click(object sender, EventArgs e)
        {
            Collapsed = !Collapsed;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            Collapsed = !Collapsed;
        }

        private void Collapse()
        {
            pbxTitle.Image = m_Collapsed ? Properties.Resources.TriangleRight : Properties.Resources.TriangleBottom;
            Height = m_Collapsed ? Height - m_BodyHeight : Height + m_BodyHeight;
        }

        private void CollapsiblePanel_Resize(object sender, EventArgs e)
        {
            if (!m_Collapsed)
            {
                m_BodyHeight = pnlBody.Height;
            }
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {
            if (Items.Count > 0)
            {
                e.Graphics.Clear(pnlBody.BackColor);
                float height = e.Graphics.MeasureString(Items[0].Key, pnlBody.Font).Height;
#if DEBUG
                Console.WriteLine(string.Format("Key={0}", Items[0].Key));
                Console.WriteLine(string.Format("Height={0}", height));
#endif
                for (int i = 0; i < Items.Count; i++)
                {
                    Item item = Items[i];
                    e.Graphics.DrawString(item.Key, pnlBody.Font, new Pen(item.ForeColor).Brush, 0f, height * i + 2);
                    e.Graphics.DrawString(item.Value, pnlBody.Font, new Pen(item.ForeColor).Brush, Items.MaxKeyWidth + 5, height * i + 2);
#if DEBUG
                    Console.WriteLine(string.Format("Width{1}={2}, Height{1}={0}, Key{1}={3}, Value{1}={4}",
                        height * i + 2, i, Items.MaxKeyWidth + 5, item.Key, item.Value));
#endif
                }
            }
        }
    }
}
