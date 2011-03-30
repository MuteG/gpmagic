namespace GPSoft.Games.GPMagic.GPMagicToolKit
{
    partial class FormBatchImageResize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSourceFolder = new System.Windows.Forms.Label();
            this.tbxSourceFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseSourceFolder = new System.Windows.Forms.Button();
            this.lblTargetFolder = new System.Windows.Forms.Label();
            this.tbxTargetFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseTargetFolder = new System.Windows.Forms.Button();
            this.rtbProcessRecord = new System.Windows.Forms.RichTextBox();
            this.pbrResize = new System.Windows.Forms.ProgressBar();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkAutoRename = new System.Windows.Forms.CheckBox();
            this.chkAutoCreateTargetFolder = new System.Windows.Forms.CheckBox();
            this.lblProcess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSourceFolder
            // 
            this.lblSourceFolder.AutoSize = true;
            this.lblSourceFolder.Location = new System.Drawing.Point(12, 15);
            this.lblSourceFolder.Name = "lblSourceFolder";
            this.lblSourceFolder.Size = new System.Drawing.Size(65, 12);
            this.lblSourceFolder.TabIndex = 0;
            this.lblSourceFolder.Text = "来源文件夹";
            this.toolTip1.SetToolTip(this.lblSourceFolder, "将从这个文件夹内获得要转换尺寸的原始图片");
            // 
            // tbxSourceFolder
            // 
            this.tbxSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSourceFolder.Location = new System.Drawing.Point(83, 12);
            this.tbxSourceFolder.Name = "tbxSourceFolder";
            this.tbxSourceFolder.Size = new System.Drawing.Size(146, 19);
            this.tbxSourceFolder.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbxSourceFolder, "将从这个文件夹内获得要转换尺寸的原始图片");
            // 
            // btnBrowseSourceFolder
            // 
            this.btnBrowseSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSourceFolder.Location = new System.Drawing.Point(235, 10);
            this.btnBrowseSourceFolder.Name = "btnBrowseSourceFolder";
            this.btnBrowseSourceFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSourceFolder.TabIndex = 2;
            this.btnBrowseSourceFolder.Text = "浏览";
            this.btnBrowseSourceFolder.UseVisualStyleBackColor = true;
            this.btnBrowseSourceFolder.Click += new System.EventHandler(this.btnBrowseSourceFolder_Click);
            // 
            // lblTargetFolder
            // 
            this.lblTargetFolder.AutoSize = true;
            this.lblTargetFolder.Location = new System.Drawing.Point(12, 44);
            this.lblTargetFolder.Name = "lblTargetFolder";
            this.lblTargetFolder.Size = new System.Drawing.Size(65, 12);
            this.lblTargetFolder.TabIndex = 3;
            this.lblTargetFolder.Text = "保存文件夹";
            // 
            // tbxTargetFolder
            // 
            this.tbxTargetFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTargetFolder.Location = new System.Drawing.Point(83, 41);
            this.tbxTargetFolder.Name = "tbxTargetFolder";
            this.tbxTargetFolder.Size = new System.Drawing.Size(146, 19);
            this.tbxTargetFolder.TabIndex = 4;
            // 
            // btnBrowseTargetFolder
            // 
            this.btnBrowseTargetFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseTargetFolder.Location = new System.Drawing.Point(235, 39);
            this.btnBrowseTargetFolder.Name = "btnBrowseTargetFolder";
            this.btnBrowseTargetFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseTargetFolder.TabIndex = 5;
            this.btnBrowseTargetFolder.Text = "浏览";
            this.btnBrowseTargetFolder.UseVisualStyleBackColor = true;
            this.btnBrowseTargetFolder.Click += new System.EventHandler(this.btnBrowseTargetFolder_Click);
            // 
            // rtbProcessRecord
            // 
            this.rtbProcessRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbProcessRecord.Location = new System.Drawing.Point(12, 119);
            this.rtbProcessRecord.Name = "rtbProcessRecord";
            this.rtbProcessRecord.ReadOnly = true;
            this.rtbProcessRecord.Size = new System.Drawing.Size(298, 153);
            this.rtbProcessRecord.TabIndex = 6;
            this.rtbProcessRecord.Text = "";
            // 
            // pbrResize
            // 
            this.pbrResize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrResize.Location = new System.Drawing.Point(14, 90);
            this.pbrResize.Name = "pbrResize";
            this.pbrResize.Size = new System.Drawing.Size(298, 23);
            this.pbrResize.Step = 1;
            this.pbrResize.TabIndex = 8;
            // 
            // btnResize
            // 
            this.btnResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResize.Location = new System.Drawing.Point(154, 278);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(75, 23);
            this.btnResize.TabIndex = 9;
            this.btnResize.Text = "开始";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(235, 278);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkAutoRename
            // 
            this.chkAutoRename.AutoSize = true;
            this.chkAutoRename.Checked = true;
            this.chkAutoRename.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoRename.Location = new System.Drawing.Point(14, 68);
            this.chkAutoRename.Name = "chkAutoRename";
            this.chkAutoRename.Size = new System.Drawing.Size(84, 16);
            this.chkAutoRename.TabIndex = 12;
            this.chkAutoRename.Text = "自动重命名";
            this.toolTip1.SetToolTip(this.chkAutoRename, "如果保存文件夹中存在同名文件，则自动重命名");
            this.chkAutoRename.UseVisualStyleBackColor = true;
            // 
            // chkAutoCreateTargetFolder
            // 
            this.chkAutoCreateTargetFolder.AutoSize = true;
            this.chkAutoCreateTargetFolder.Location = new System.Drawing.Point(104, 68);
            this.chkAutoCreateTargetFolder.Name = "chkAutoCreateTargetFolder";
            this.chkAutoCreateTargetFolder.Size = new System.Drawing.Size(72, 16);
            this.chkAutoCreateTargetFolder.TabIndex = 13;
            this.chkAutoCreateTargetFolder.Text = "自动保存";
            this.toolTip1.SetToolTip(this.chkAutoCreateTargetFolder, "自动根据来源文件夹生成一个保存文件夹");
            this.chkAutoCreateTargetFolder.UseVisualStyleBackColor = true;
            this.chkAutoCreateTargetFolder.CheckedChanged += new System.EventHandler(this.chkAutoCreateTargetFolder_CheckedChanged);
            // 
            // lblProcess
            // 
            this.lblProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcess.Location = new System.Drawing.Point(210, 64);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProcess.Size = new System.Drawing.Size(100, 23);
            this.lblProcess.TabIndex = 14;
            this.lblProcess.Text = "0/0";
            this.lblProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormBatchImageResize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 313);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.chkAutoCreateTargetFolder);
            this.Controls.Add(this.chkAutoRename);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.pbrResize);
            this.Controls.Add(this.rtbProcessRecord);
            this.Controls.Add(this.btnBrowseTargetFolder);
            this.Controls.Add(this.tbxTargetFolder);
            this.Controls.Add(this.lblTargetFolder);
            this.Controls.Add(this.btnBrowseSourceFolder);
            this.Controls.Add(this.tbxSourceFolder);
            this.Controls.Add(this.lblSourceFolder);
            this.MinimumSize = new System.Drawing.Size(330, 270);
            this.Name = "FormBatchImageResize";
            this.Text = "批量图片尺寸转换工具";
            this.Load += new System.EventHandler(this.FormBatchImageResize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSourceFolder;
        private System.Windows.Forms.TextBox tbxSourceFolder;
        private System.Windows.Forms.Button btnBrowseSourceFolder;
        private System.Windows.Forms.Label lblTargetFolder;
        private System.Windows.Forms.TextBox tbxTargetFolder;
        private System.Windows.Forms.Button btnBrowseTargetFolder;
        private System.Windows.Forms.RichTextBox rtbProcessRecord;
        private System.Windows.Forms.ProgressBar pbrResize;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkAutoRename;
        private System.Windows.Forms.CheckBox chkAutoCreateTargetFolder;
        private System.Windows.Forms.Label lblProcess;
    }
}