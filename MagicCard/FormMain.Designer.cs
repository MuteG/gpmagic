namespace GPSoft.GPMagic.MagicDemo
{
    partial class FormMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadCard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.collapsiblePanel1 = new GPSoft.GPMagic.GPMagicBase.UI.CollapsiblePanel();
            this.countPanel1 = new GPSoft.GPMagic.GPMagic.UI.CountPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadCard
            // 
            this.btnLoadCard.Location = new System.Drawing.Point(12, 12);
            this.btnLoadCard.Name = "btnLoadCard";
            this.btnLoadCard.Size = new System.Drawing.Size(114, 23);
            this.btnLoadCard.TabIndex = 0;
            this.btnLoadCard.Text = "载入一张卡牌";
            this.btnLoadCard.UseVisualStyleBackColor = true;
            this.btnLoadCard.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 383);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(132, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(401, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 79);
            this.panel1.TabIndex = 5;
            // 
            // collapsiblePanel1
            // 
            this.collapsiblePanel1.Collapsed = false;
            this.collapsiblePanel1.Location = new System.Drawing.Point(372, 56);
            this.collapsiblePanel1.Name = "collapsiblePanel1";
            this.collapsiblePanel1.Size = new System.Drawing.Size(262, 176);
            this.collapsiblePanel1.TabIndex = 4;
            // 
            // countPanel1
            // 
            this.countPanel1.Count = 0;
            this.countPanel1.Image = null;
            this.countPanel1.Location = new System.Drawing.Point(314, 13);
            this.countPanel1.Name = "countPanel1";
            this.countPanel1.Size = new System.Drawing.Size(109, 22);
            this.countPanel1.TabIndex = 3;
            this.countPanel1.Tip = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 590);
            this.Controls.Add(this.collapsiblePanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.countPanel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoadCard);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMain";
            this.Text = "卡牌测试";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadCard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private GPMagic.UI.CountPanel countPanel1;
        private GPSoft.GPMagic.GPMagicBase.UI.CollapsiblePanel collapsiblePanel1;
        private System.Windows.Forms.Panel panel1;
    }
}

