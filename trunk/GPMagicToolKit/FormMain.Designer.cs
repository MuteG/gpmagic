namespace GPSoft.Games.GPMagic.GPMagicToolKit
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemBatchImageResize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemTools});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(377, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuItemTools
            // 
            this.mnuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemBatchImageResize});
            this.mnuItemTools.Name = "mnuItemTools";
            this.mnuItemTools.Size = new System.Drawing.Size(41, 20);
            this.mnuItemTools.Text = "工具";
            // 
            // mnuItemBatchImageResize
            // 
            this.mnuItemBatchImageResize.Name = "mnuItemBatchImageResize";
            this.mnuItemBatchImageResize.Size = new System.Drawing.Size(166, 22);
            this.mnuItemBatchImageResize.Text = "批量图片尺寸转换";
            this.mnuItemBatchImageResize.Click += new System.EventHandler(this.mnuItemBatchImageResize_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 306);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FormMain";
            this.Text = "GPMagic工具箱";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuItemTools;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBatchImageResize;
    }
}

