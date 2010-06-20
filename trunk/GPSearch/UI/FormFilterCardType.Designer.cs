namespace GPSoft.GPMagic.GPSearch.UI
{
    partial class FormFilterCardType
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
            this.lblCardType = new System.Windows.Forms.Label();
            this.cbxCardType = new System.Windows.Forms.ComboBox();
            this.lblCardSubType = new System.Windows.Forms.Label();
            this.tbxCardSubType = new System.Windows.Forms.TextBox();
            this.btnCardSubType = new System.Windows.Forms.Button();
            this.lblRarity = new System.Windows.Forms.Label();
            this.cbxRarity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Location = new System.Drawing.Point(12, 9);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(53, 12);
            this.lblCardType.TabIndex = 0;
            this.lblCardType.Text = "卡牌类别";
            // 
            // cbxCardType
            // 
            this.cbxCardType.FormattingEnabled = true;
            this.cbxCardType.Location = new System.Drawing.Point(83, 5);
            this.cbxCardType.Name = "cbxCardType";
            this.cbxCardType.Size = new System.Drawing.Size(157, 20);
            this.cbxCardType.TabIndex = 1;
            // 
            // lblCardSubType
            // 
            this.lblCardSubType.AutoSize = true;
            this.lblCardSubType.Location = new System.Drawing.Point(12, 35);
            this.lblCardSubType.Name = "lblCardSubType";
            this.lblCardSubType.Size = new System.Drawing.Size(65, 12);
            this.lblCardSubType.TabIndex = 2;
            this.lblCardSubType.Text = "卡牌子类别";
            // 
            // tbxCardSubType
            // 
            this.tbxCardSubType.Location = new System.Drawing.Point(83, 31);
            this.tbxCardSubType.Name = "tbxCardSubType";
            this.tbxCardSubType.Size = new System.Drawing.Size(120, 21);
            this.tbxCardSubType.TabIndex = 3;
            // 
            // btnCardSubType
            // 
            this.btnCardSubType.Location = new System.Drawing.Point(209, 30);
            this.btnCardSubType.Name = "btnCardSubType";
            this.btnCardSubType.Size = new System.Drawing.Size(31, 23);
            this.btnCardSubType.TabIndex = 4;
            this.btnCardSubType.Text = "...";
            this.btnCardSubType.UseVisualStyleBackColor = true;
            this.btnCardSubType.Click += new System.EventHandler(this.btnCardType_Click);
            // 
            // lblRarity
            // 
            this.lblRarity.AutoSize = true;
            this.lblRarity.Location = new System.Drawing.Point(12, 62);
            this.lblRarity.Name = "lblRarity";
            this.lblRarity.Size = new System.Drawing.Size(65, 12);
            this.lblRarity.TabIndex = 5;
            this.lblRarity.Text = "卡牌稀有度";
            // 
            // cbxRarity
            // 
            this.cbxRarity.FormattingEnabled = true;
            this.cbxRarity.Location = new System.Drawing.Point(83, 58);
            this.cbxRarity.Name = "cbxRarity";
            this.cbxRarity.Size = new System.Drawing.Size(157, 20);
            this.cbxRarity.TabIndex = 6;
            // 
            // FormFilterCardType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 394);
            this.Controls.Add(this.cbxRarity);
            this.Controls.Add(this.lblRarity);
            this.Controls.Add(this.btnCardSubType);
            this.Controls.Add(this.tbxCardSubType);
            this.Controls.Add(this.lblCardSubType);
            this.Controls.Add(this.cbxCardType);
            this.Controls.Add(this.lblCardType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormFilterCardType";
            this.Text = "卡牌种类过滤";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.ComboBox cbxCardType;
        private System.Windows.Forms.Label lblCardSubType;
        private System.Windows.Forms.TextBox tbxCardSubType;
        private System.Windows.Forms.Button btnCardSubType;
        private System.Windows.Forms.Label lblRarity;
        private System.Windows.Forms.ComboBox cbxRarity;
    }
}