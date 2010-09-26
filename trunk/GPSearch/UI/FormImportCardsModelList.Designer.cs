namespace GPSoft.GPMagic.GPSearch.UI
{
    partial class FormImportCardsModelList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportCardsModelList));
            this.rtbModelInfo = new System.Windows.Forms.RichTextBox();
            this.lbxModelList = new System.Windows.Forms.ListBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbModelInfo
            // 
            this.rtbModelInfo.BackColor = System.Drawing.SystemColors.Control;
            this.rtbModelInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbModelInfo.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbModelInfo.Location = new System.Drawing.Point(188, 12);
            this.rtbModelInfo.Name = "rtbModelInfo";
            this.rtbModelInfo.ReadOnly = true;
            this.rtbModelInfo.Size = new System.Drawing.Size(180, 220);
            this.rtbModelInfo.TabIndex = 1;
            this.rtbModelInfo.Text = "";
            // 
            // lbxModelList
            // 
            this.lbxModelList.FormattingEnabled = true;
            this.lbxModelList.ItemHeight = 12;
            this.lbxModelList.Location = new System.Drawing.Point(12, 12);
            this.lbxModelList.Name = "lbxModelList";
            this.lbxModelList.Size = new System.Drawing.Size(170, 220);
            this.lbxModelList.TabIndex = 2;
            this.lbxModelList.SelectedIndexChanged += new System.EventHandler(this.lbxModelList_SelectedIndexChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(212, 238);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "选择";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(293, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormImportCardsModelList
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(380, 273);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lbxModelList);
            this.Controls.Add(this.rtbModelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportCardsModelList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择一个现有模板";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbModelInfo;
        private System.Windows.Forms.ListBox lbxModelList;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;

    }
}