namespace GPSoft.Games.GPMagic.GPSearch.UI
{
    partial class FormFilterKeyWord
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
            this.lblKeyWordType = new System.Windows.Forms.Label();
            this.cbxKeyWordType = new System.Windows.Forms.ComboBox();
            this.lblKeyWordContent = new System.Windows.Forms.Label();
            this.tbxKeyWordContent = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKeyWordType
            // 
            this.lblKeyWordType.AutoSize = true;
            this.lblKeyWordType.Location = new System.Drawing.Point(12, 15);
            this.lblKeyWordType.Name = "lblKeyWordType";
            this.lblKeyWordType.Size = new System.Drawing.Size(65, 12);
            this.lblKeyWordType.TabIndex = 0;
            this.lblKeyWordType.Text = "关键字类型";
            // 
            // cbxKeyWordType
            // 
            this.cbxKeyWordType.FormattingEnabled = true;
            this.cbxKeyWordType.Location = new System.Drawing.Point(83, 12);
            this.cbxKeyWordType.Name = "cbxKeyWordType";
            this.cbxKeyWordType.Size = new System.Drawing.Size(121, 20);
            this.cbxKeyWordType.TabIndex = 1;
            // 
            // lblKeyWordContent
            // 
            this.lblKeyWordContent.AutoSize = true;
            this.lblKeyWordContent.Location = new System.Drawing.Point(12, 41);
            this.lblKeyWordContent.Name = "lblKeyWordContent";
            this.lblKeyWordContent.Size = new System.Drawing.Size(65, 12);
            this.lblKeyWordContent.TabIndex = 2;
            this.lblKeyWordContent.Text = "关键字内容";
            // 
            // tbxKeyWordContent
            // 
            this.tbxKeyWordContent.Location = new System.Drawing.Point(83, 38);
            this.tbxKeyWordContent.Name = "tbxKeyWordContent";
            this.tbxKeyWordContent.Size = new System.Drawing.Size(121, 19);
            this.tbxKeyWordContent.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(31, 63);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(112, 63);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormFilterKeyWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 92);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbxKeyWordContent);
            this.Controls.Add(this.lblKeyWordContent);
            this.Controls.Add(this.cbxKeyWordType);
            this.Controls.Add(this.lblKeyWordType);
            this.Name = "FormFilterKeyWord";
            this.Text = "FormFilterKeyWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeyWordType;
        private System.Windows.Forms.ComboBox cbxKeyWordType;
        private System.Windows.Forms.Label lblKeyWordContent;
        private System.Windows.Forms.TextBox tbxKeyWordContent;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}