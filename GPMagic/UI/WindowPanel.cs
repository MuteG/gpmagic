using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GP.GPMagic.GPMagic.UI
{
    public partial class WindowPanel : UserControl
    {
        private bool canMove = true;
        /// <summary>
        /// 此窗口允许移动
        /// </summary>
        public bool CanMove
        {
            get { return canMove; }
            set { canMove = value; }
        }
        private bool startMove = false;
        private int baseX, baseY, nowX, nowY;
        public WindowPanel()
        {
            InitializeComponent();
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1 && canMove)
            {
                this.startMove = true;
                baseX = e.X;
                baseY = e.Y;
            }
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (startMove && canMove)
            {
                Graphics.FromHwndInternal(this.FindForm().Handle);
                int nowX = this.Left + e.X - baseX;
                int nowY = this.Top + e.Y - baseY;
                if (nowX < 0) nowX = 0;
                else if (nowX > this.Parent.ClientSize.Width - this.Width) 
                    nowX = this.Parent.ClientSize.Width - this.Width;
                if (nowY < 0) nowY = 0;
                else if (nowY > this.Parent.ClientSize.Height - this.Height) 
                    nowY = this.Parent.ClientSize.Height - this.Height;
                this.Location = new Point(nowX, nowY);
                //this.FindForm().Update();
                //Graphics.FromHwnd(this.FindForm().Handle).DrawRectangle(new Pen(Color.Blue), new Rectangle(new Point(nowX, nowY), this.Size));
            }
        }

        private void pnlTitle_MouseUp(object sender, MouseEventArgs e)
        {
            this.startMove = false;
            baseX = 0;
            baseY = 0;
            //ShowBackGround();
        }

        private void ShowBackGround()
        {
            this.Visible = false;
            Application.DoEvents();
            Bitmap parentBackBmp = new Bitmap(this.Parent.Width, this.Parent.Height);
            Graphics g1 = Graphics.FromImage(parentBackBmp);
            this.Parent.DrawToBitmap(parentBackBmp, new Rectangle(0, 0, this.Parent.Width, this.Parent.Height));
            Bitmap thisBackBmp = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(thisBackBmp);
            int x, y;
            if (this.FindForm().FormBorderStyle == FormBorderStyle.None)
            {
                x = this.Left + this.Parent.Width - this.Parent.ClientSize.Width;
                y = this.Top + this.Parent.Height - this.Parent.ClientSize.Height;
            }
            else
            {
                x = this.Left + (this.Parent.Width - this.Parent.ClientSize.Width) / 2;
                y = this.Top + this.Parent.Height - this.Parent.ClientSize.Height + this.Left - x;
            }
            g.DrawImage(parentBackBmp, 0, 0, new Rectangle(x, y, this.Width, this.Height), GraphicsUnit.Pixel);
            this.BackgroundImage = thisBackBmp;
            this.Visible = true;
            Application.DoEvents();
        }

        private void WindowPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //画一个圆角矩形作为边框
            // 确定圆角矩形的轨迹
            GraphicsPath path = CreateRoundedRectanglePath(new Rectangle(0, 0, this.Bounds.Width - 1, this.Bounds.Height - 1), 8);
            //GraphicsPath path2 = CreateRoundedRectanglePath(new Rectangle(1, 1, this.Bounds.Width - 3, this.Bounds.Height - 3), 8);
            // 描绘圆角矩形的边界
            g.DrawPath(new Pen(Color.Black, 3), path);
            //g.FillPath(new Pen(Color.FromArgb(100, 255, 255, 255), 3).Brush, path);
            //g.DrawPath(new Pen(this.BackColor), path2);
        }

        private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int cornerRadius)
        {
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius * 2, rect.Y);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Y + rect.Height - cornerRadius * 2);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRect.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
            roundedRect.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.AddLine(rect.X, rect.Bottom - cornerRadius * 2, rect.X, rect.Y + cornerRadius * 2);
            roundedRect.CloseFigure();
            return roundedRect;
        }

        private void WindowPanel_Load(object sender, EventArgs e)
        {
            //ShowBackGround();
        }
    }
}
