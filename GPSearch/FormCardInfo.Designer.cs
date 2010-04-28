namespace GPSearch
{
    partial class FormCardInfo
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
            this.lblCardName = new System.Windows.Forms.Label();
            this.tbxCardName = new System.Windows.Forms.TextBox();
            this.lblImageType = new System.Windows.Forms.Label();
            this.cbxImageType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gbxCardImage = new System.Windows.Forms.GroupBox();
            this.pbxCardImage = new System.Windows.Forms.PictureBox();
            this.tbxManaCost = new System.Windows.Forms.TextBox();
            this.lblManaCost = new System.Windows.Forms.Label();
            this.btnCardImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbxCardImage = new System.Windows.Forms.TextBox();
            this.lblCardImage = new System.Windows.Forms.Label();
            this.cbxCardType = new System.Windows.Forms.ComboBox();
            this.lblCardType = new System.Windows.Forms.Label();
            this.lblCardSubType = new System.Windows.Forms.Label();
            this.tbxCardSubType = new System.Windows.Forms.TextBox();
            this.btnCardSubType = new System.Windows.Forms.Button();
            this.cbxExpansions = new System.Windows.Forms.ComboBox();
            this.lblExpansions = new System.Windows.Forms.Label();
            this.btnAbilities = new System.Windows.Forms.Button();
            this.tbxAbilities = new System.Windows.Forms.TextBox();
            this.lblAbilities = new System.Windows.Forms.Label();
            this.lblAbilitiesText = new System.Windows.Forms.Label();
            this.tbxAbilitiesText = new System.Windows.Forms.TextBox();
            this.btnAbilitiesText = new System.Windows.Forms.Button();
            this.btnFlavorText = new System.Windows.Forms.Button();
            this.tbxFlavorText = new System.Windows.Forms.TextBox();
            this.lblFlavorText = new System.Windows.Forms.Label();
            this.gbxCardImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Location = new System.Drawing.Point(3, 10);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(53, 12);
            this.lblCardName.TabIndex = 0;
            this.lblCardName.Text = "卡牌名称";
            // 
            // tbxCardName
            // 
            this.tbxCardName.Location = new System.Drawing.Point(71, 6);
            this.tbxCardName.Name = "tbxCardName";
            this.tbxCardName.Size = new System.Drawing.Size(158, 21);
            this.tbxCardName.TabIndex = 1;
            // 
            // lblImageType
            // 
            this.lblImageType.AutoSize = true;
            this.lblImageType.Location = new System.Drawing.Point(3, 91);
            this.lblImageType.Name = "lblImageType";
            this.lblImageType.Size = new System.Drawing.Size(53, 12);
            this.lblImageType.TabIndex = 3;
            this.lblImageType.Text = "图片形式";
            // 
            // cbxImageType
            // 
            this.cbxImageType.FormattingEnabled = true;
            this.cbxImageType.Items.AddRange(new object[] {
            "新建"});
            this.cbxImageType.Location = new System.Drawing.Point(71, 87);
            this.cbxImageType.Name = "cbxImageType";
            this.cbxImageType.Size = new System.Drawing.Size(158, 20);
            this.cbxImageType.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(83, 359);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 8;
            // 
            // gbxCardImage
            // 
            this.gbxCardImage.Controls.Add(this.pbxCardImage);
            this.gbxCardImage.Location = new System.Drawing.Point(249, 6);
            this.gbxCardImage.Name = "gbxCardImage";
            this.gbxCardImage.Size = new System.Drawing.Size(271, 390);
            this.gbxCardImage.TabIndex = 10;
            this.gbxCardImage.TabStop = false;
            this.gbxCardImage.Text = "卡牌图片";
            // 
            // pbxCardImage
            // 
            this.pbxCardImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxCardImage.Location = new System.Drawing.Point(3, 17);
            this.pbxCardImage.Name = "pbxCardImage";
            this.pbxCardImage.Size = new System.Drawing.Size(265, 370);
            this.pbxCardImage.TabIndex = 9;
            this.pbxCardImage.TabStop = false;
            // 
            // tbxManaCost
            // 
            this.tbxManaCost.Location = new System.Drawing.Point(71, 33);
            this.tbxManaCost.Name = "tbxManaCost";
            this.tbxManaCost.Size = new System.Drawing.Size(158, 21);
            this.tbxManaCost.TabIndex = 12;
            // 
            // lblManaCost
            // 
            this.lblManaCost.AutoSize = true;
            this.lblManaCost.Location = new System.Drawing.Point(3, 37);
            this.lblManaCost.Name = "lblManaCost";
            this.lblManaCost.Size = new System.Drawing.Size(65, 12);
            this.lblManaCost.TabIndex = 11;
            this.lblManaCost.Text = "法术力费用";
            // 
            // btnCardImage
            // 
            this.btnCardImage.AutoSize = true;
            this.btnCardImage.Location = new System.Drawing.Point(196, 59);
            this.btnCardImage.Name = "btnCardImage";
            this.btnCardImage.Size = new System.Drawing.Size(33, 23);
            this.btnCardImage.TabIndex = 13;
            this.btnCardImage.Text = "...";
            this.btnCardImage.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbxCardImage
            // 
            this.tbxCardImage.Location = new System.Drawing.Point(71, 60);
            this.tbxCardImage.Name = "tbxCardImage";
            this.tbxCardImage.Size = new System.Drawing.Size(120, 21);
            this.tbxCardImage.TabIndex = 16;
            // 
            // lblCardImage
            // 
            this.lblCardImage.AutoSize = true;
            this.lblCardImage.Location = new System.Drawing.Point(3, 64);
            this.lblCardImage.Name = "lblCardImage";
            this.lblCardImage.Size = new System.Drawing.Size(53, 12);
            this.lblCardImage.TabIndex = 15;
            this.lblCardImage.Text = "卡牌图片";
            // 
            // cbxCardType
            // 
            this.cbxCardType.FormattingEnabled = true;
            this.cbxCardType.Items.AddRange(new object[] {
            "新建"});
            this.cbxCardType.Location = new System.Drawing.Point(71, 113);
            this.cbxCardType.Name = "cbxCardType";
            this.cbxCardType.Size = new System.Drawing.Size(158, 20);
            this.cbxCardType.TabIndex = 18;
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Location = new System.Drawing.Point(3, 117);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(53, 12);
            this.lblCardType.TabIndex = 17;
            this.lblCardType.Text = "卡牌类型";
            // 
            // lblCardSubType
            // 
            this.lblCardSubType.AutoSize = true;
            this.lblCardSubType.Location = new System.Drawing.Point(3, 143);
            this.lblCardSubType.Name = "lblCardSubType";
            this.lblCardSubType.Size = new System.Drawing.Size(65, 12);
            this.lblCardSubType.TabIndex = 20;
            this.lblCardSubType.Text = "卡牌子类型";
            // 
            // tbxCardSubType
            // 
            this.tbxCardSubType.Location = new System.Drawing.Point(71, 139);
            this.tbxCardSubType.Name = "tbxCardSubType";
            this.tbxCardSubType.Size = new System.Drawing.Size(120, 21);
            this.tbxCardSubType.TabIndex = 21;
            // 
            // btnCardSubType
            // 
            this.btnCardSubType.AutoSize = true;
            this.btnCardSubType.Location = new System.Drawing.Point(196, 139);
            this.btnCardSubType.Name = "btnCardSubType";
            this.btnCardSubType.Size = new System.Drawing.Size(33, 23);
            this.btnCardSubType.TabIndex = 22;
            this.btnCardSubType.Text = "...";
            this.btnCardSubType.UseVisualStyleBackColor = true;
            // 
            // cbxExpansions
            // 
            this.cbxExpansions.FormattingEnabled = true;
            this.cbxExpansions.Items.AddRange(new object[] {
            "新建"});
            this.cbxExpansions.Location = new System.Drawing.Point(71, 166);
            this.cbxExpansions.Name = "cbxExpansions";
            this.cbxExpansions.Size = new System.Drawing.Size(158, 20);
            this.cbxExpansions.TabIndex = 24;
            // 
            // lblExpansions
            // 
            this.lblExpansions.AutoSize = true;
            this.lblExpansions.Location = new System.Drawing.Point(3, 170);
            this.lblExpansions.Name = "lblExpansions";
            this.lblExpansions.Size = new System.Drawing.Size(53, 12);
            this.lblExpansions.TabIndex = 23;
            this.lblExpansions.Text = "所属系列";
            // 
            // btnAbilities
            // 
            this.btnAbilities.AutoSize = true;
            this.btnAbilities.Location = new System.Drawing.Point(196, 192);
            this.btnAbilities.Name = "btnAbilities";
            this.btnAbilities.Size = new System.Drawing.Size(33, 23);
            this.btnAbilities.TabIndex = 27;
            this.btnAbilities.Text = "...";
            this.btnAbilities.UseVisualStyleBackColor = true;
            // 
            // tbxAbilities
            // 
            this.tbxAbilities.Location = new System.Drawing.Point(71, 192);
            this.tbxAbilities.Name = "tbxAbilities";
            this.tbxAbilities.Size = new System.Drawing.Size(120, 21);
            this.tbxAbilities.TabIndex = 26;
            // 
            // lblAbilities
            // 
            this.lblAbilities.AutoSize = true;
            this.lblAbilities.Location = new System.Drawing.Point(3, 196);
            this.lblAbilities.Name = "lblAbilities";
            this.lblAbilities.Size = new System.Drawing.Size(53, 12);
            this.lblAbilities.TabIndex = 25;
            this.lblAbilities.Text = "卡牌异能";
            // 
            // lblAbilitiesText
            // 
            this.lblAbilitiesText.AutoSize = true;
            this.lblAbilitiesText.Location = new System.Drawing.Point(3, 223);
            this.lblAbilitiesText.Name = "lblAbilitiesText";
            this.lblAbilitiesText.Size = new System.Drawing.Size(53, 12);
            this.lblAbilitiesText.TabIndex = 25;
            this.lblAbilitiesText.Text = "异能全文";
            // 
            // tbxAbilitiesText
            // 
            this.tbxAbilitiesText.Location = new System.Drawing.Point(71, 219);
            this.tbxAbilitiesText.Name = "tbxAbilitiesText";
            this.tbxAbilitiesText.Size = new System.Drawing.Size(120, 21);
            this.tbxAbilitiesText.TabIndex = 26;
            // 
            // btnAbilitiesText
            // 
            this.btnAbilitiesText.AutoSize = true;
            this.btnAbilitiesText.Location = new System.Drawing.Point(196, 219);
            this.btnAbilitiesText.Name = "btnAbilitiesText";
            this.btnAbilitiesText.Size = new System.Drawing.Size(33, 23);
            this.btnAbilitiesText.TabIndex = 27;
            this.btnAbilitiesText.Text = "...";
            this.btnAbilitiesText.UseVisualStyleBackColor = true;
            // 
            // btnFlavorText
            // 
            this.btnFlavorText.AutoSize = true;
            this.btnFlavorText.Location = new System.Drawing.Point(196, 246);
            this.btnFlavorText.Name = "btnFlavorText";
            this.btnFlavorText.Size = new System.Drawing.Size(33, 23);
            this.btnFlavorText.TabIndex = 30;
            this.btnFlavorText.Text = "...";
            this.btnFlavorText.UseVisualStyleBackColor = true;
            // 
            // tbxFlavorText
            // 
            this.tbxFlavorText.Location = new System.Drawing.Point(71, 246);
            this.tbxFlavorText.Name = "tbxFlavorText";
            this.tbxFlavorText.Size = new System.Drawing.Size(120, 21);
            this.tbxFlavorText.TabIndex = 29;
            // 
            // lblFlavorText
            // 
            this.lblFlavorText.AutoSize = true;
            this.lblFlavorText.Location = new System.Drawing.Point(3, 250);
            this.lblFlavorText.Name = "lblFlavorText";
            this.lblFlavorText.Size = new System.Drawing.Size(53, 12);
            this.lblFlavorText.TabIndex = 28;
            this.lblFlavorText.Text = "背景描述";
            // 
            // FormCardInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 405);
            this.Controls.Add(this.btnFlavorText);
            this.Controls.Add(this.tbxFlavorText);
            this.Controls.Add(this.lblFlavorText);
            this.Controls.Add(this.btnAbilitiesText);
            this.Controls.Add(this.btnAbilities);
            this.Controls.Add(this.tbxAbilitiesText);
            this.Controls.Add(this.lblAbilitiesText);
            this.Controls.Add(this.tbxAbilities);
            this.Controls.Add(this.lblAbilities);
            this.Controls.Add(this.cbxExpansions);
            this.Controls.Add(this.lblExpansions);
            this.Controls.Add(this.btnCardSubType);
            this.Controls.Add(this.tbxCardSubType);
            this.Controls.Add(this.lblCardSubType);
            this.Controls.Add(this.cbxCardType);
            this.Controls.Add(this.lblCardType);
            this.Controls.Add(this.tbxCardImage);
            this.Controls.Add(this.lblCardImage);
            this.Controls.Add(this.btnCardImage);
            this.Controls.Add(this.tbxManaCost);
            this.Controls.Add(this.lblManaCost);
            this.Controls.Add(this.gbxCardImage);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxImageType);
            this.Controls.Add(this.lblImageType);
            this.Controls.Add(this.tbxCardName);
            this.Controls.Add(this.lblCardName);
            this.Name = "FormCardInfo";
            this.Text = "卡牌信息 - 添加";
            this.Load += new System.EventHandler(this.FormCardInfo_Load);
            this.gbxCardImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCardImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.TextBox tbxCardName;
        private System.Windows.Forms.Label lblImageType;
        private System.Windows.Forms.ComboBox cbxImageType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pbxCardImage;
        private System.Windows.Forms.GroupBox gbxCardImage;
        private System.Windows.Forms.TextBox tbxManaCost;
        private System.Windows.Forms.Label lblManaCost;
        private System.Windows.Forms.Button btnCardImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbxCardImage;
        private System.Windows.Forms.Label lblCardImage;
        private System.Windows.Forms.ComboBox cbxCardType;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.Label lblCardSubType;
        private System.Windows.Forms.TextBox tbxCardSubType;
        private System.Windows.Forms.Button btnCardSubType;
        private System.Windows.Forms.ComboBox cbxExpansions;
        private System.Windows.Forms.Label lblExpansions;
        private System.Windows.Forms.Button btnAbilities;
        private System.Windows.Forms.TextBox tbxAbilities;
        private System.Windows.Forms.Label lblAbilities;
        private System.Windows.Forms.Label lblAbilitiesText;
        private System.Windows.Forms.TextBox tbxAbilitiesText;
        private System.Windows.Forms.Button btnAbilitiesText;
        private System.Windows.Forms.Button btnFlavorText;
        private System.Windows.Forms.TextBox tbxFlavorText;
        private System.Windows.Forms.Label lblFlavorText;
    }
}