namespace GPSoft.GPMagic.GPSearch.UI
{
    partial class FormEditColor
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
            this.lbxColorList = new System.Windows.Forms.ListBox();
            this.lblColorCode = new System.Windows.Forms.Label();
            this.tbxColorCode = new System.Windows.Forms.TextBox();
            this.lblColorImage = new System.Windows.Forms.Label();
            this.ofdColorImage = new System.Windows.Forms.OpenFileDialog();
            this.tbxColorImage = new System.Windows.Forms.TextBox();
            this.btnColorImageBrowser = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.tbxComment = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbxColorList
            // 
            this.lbxColorList.FormattingEnabled = true;
            this.lbxColorList.ItemHeight = 12;
            this.lbxColorList.Location = new System.Drawing.Point(12, 12);
            this.lbxColorList.Name = "lbxColorList";
            this.lbxColorList.Size = new System.Drawing.Size(133, 184);
            this.lbxColorList.TabIndex = 0;
            // 
            // lblColorCode
            // 
            this.lblColorCode.AutoSize = true;
            this.lblColorCode.Location = new System.Drawing.Point(151, 15);
            this.lblColorCode.Name = "lblColorCode";
            this.lblColorCode.Size = new System.Drawing.Size(53, 12);
            this.lblColorCode.TabIndex = 1;
            this.lblColorCode.Text = "颜色代号";
            // 
            // tbxColorCode
            // 
            this.tbxColorCode.Location = new System.Drawing.Point(210, 12);
            this.tbxColorCode.Name = "tbxColorCode";
            this.tbxColorCode.Size = new System.Drawing.Size(86, 19);
            this.tbxColorCode.TabIndex = 2;
            // 
            // lblColorImage
            // 
            this.lblColorImage.AutoSize = true;
            this.lblColorImage.Location = new System.Drawing.Point(151, 42);
            this.lblColorImage.Name = "lblColorImage";
            this.lblColorImage.Size = new System.Drawing.Size(53, 12);
            this.lblColorImage.TabIndex = 3;
            this.lblColorImage.Text = "颜色图片";
            // 
            // ofdColorImage
            // 
            this.ofdColorImage.FileName = "选择图片";
            // 
            // tbxColorImage
            // 
            this.tbxColorImage.Location = new System.Drawing.Point(210, 39);
            this.tbxColorImage.Name = "tbxColorImage";
            this.tbxColorImage.Size = new System.Drawing.Size(57, 19);
            this.tbxColorImage.TabIndex = 4;
            this.tbxColorImage.TextChanged += new System.EventHandler(this.tbxColorImage_TextChanged);
            // 
            // btnColorImageBrowser
            // 
            this.btnColorImageBrowser.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.find;
            this.btnColorImageBrowser.Location = new System.Drawing.Point(273, 37);
            this.btnColorImageBrowser.Name = "btnColorImageBrowser";
            this.btnColorImageBrowser.Size = new System.Drawing.Size(23, 23);
            this.btnColorImageBrowser.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnColorImageBrowser, "选择一个图片");
            this.btnColorImageBrowser.UseVisualStyleBackColor = true;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(151, 69);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(53, 12);
            this.lblComment.TabIndex = 6;
            this.lblComment.Text = "说明文字";
            // 
            // tbxComment
            // 
            this.tbxComment.Location = new System.Drawing.Point(153, 88);
            this.tbxComment.Multiline = true;
            this.tbxComment.Name = "tbxComment";
            this.tbxComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxComment.Size = new System.Drawing.Size(143, 79);
            this.tbxComment.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(153, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 23);
            this.btnAdd.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnAdd, "添加");
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(182, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 23);
            this.btnDelete.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnDelete, "删除");
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.ok;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(240, 173);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确认";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FormEditColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 207);
            this.Controls.Add(this.tbxComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnColorImageBrowser);
            this.Controls.Add(this.tbxColorImage);
            this.Controls.Add(this.lblColorImage);
            this.Controls.Add(this.tbxColorCode);
            this.Controls.Add(this.lblColorCode);
            this.Controls.Add(this.lbxColorList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEditColor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxColorList;
        private System.Windows.Forms.Label lblColorCode;
        private System.Windows.Forms.TextBox tbxColorCode;
        private System.Windows.Forms.Label lblColorImage;
        private System.Windows.Forms.OpenFileDialog ofdColorImage;
        private System.Windows.Forms.TextBox tbxColorImage;
        private System.Windows.Forms.Button btnColorImageBrowser;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox tbxComment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}