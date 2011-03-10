namespace GPSoft.GPMagic.GPMagicBase.UI
{
    partial class CollapsiblePanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxTitle = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxTitle
            // 
            this.pbxTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxTitle.Image = global::GPSoft.GPMagic.GPMagicBase.Properties.Resources.TriangleRight;
            this.pbxTitle.Location = new System.Drawing.Point(3, 3);
            this.pbxTitle.Name = "pbxTitle";
            this.pbxTitle.Size = new System.Drawing.Size(16, 16);
            this.pbxTitle.TabIndex = 0;
            this.pbxTitle.TabStop = false;
            this.pbxTitle.Click += new System.EventHandler(this.pbxTitle_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle.Location = new System.Drawing.Point(25, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 12);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBody.Location = new System.Drawing.Point(27, 22);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(235, 154);
            this.pnlBody.TabIndex = 2;
            this.pnlBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBody_Paint);
            // 
            // CollapsiblePanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxTitle);
            this.DoubleBuffered = true;
            this.Name = "CollapsiblePanel";
            this.Size = new System.Drawing.Size(262, 176);
            this.Resize += new System.EventHandler(this.CollapsiblePanel_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBody;


    }
}
