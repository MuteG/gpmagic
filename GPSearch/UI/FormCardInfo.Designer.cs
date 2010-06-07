namespace GPSoft.GPMagic.GPSearch.UI
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
            this.components = new System.ComponentModel.Container();
            this.lblCardName = new System.Windows.Forms.Label();
            this.tbxCardName = new System.Windows.Forms.TextBox();
            this.lblImageType = new System.Windows.Forms.Label();
            this.cbxImageType = new System.Windows.Forms.ComboBox();
            this.gbxCardImage = new System.Windows.Forms.GroupBox();
            this.pbxCardImage = new System.Windows.Forms.PictureBox();
            this.tbxManaCost = new System.Windows.Forms.TextBox();
            this.lblManaCost = new System.Windows.Forms.Label();
            this.btnCardImage = new System.Windows.Forms.Button();
            this.ofdCardImage = new System.Windows.Forms.OpenFileDialog();
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
            this.lblPower = new System.Windows.Forms.Label();
            this.tbxPower = new System.Windows.Forms.TextBox();
            this.lblToughness = new System.Windows.Forms.Label();
            this.tbxToughness = new System.Windows.Forms.TextBox();
            this.lblRarity = new System.Windows.Forms.Label();
            this.cbxRarity = new System.Windows.Forms.ComboBox();
            this.lblPainterName = new System.Windows.Forms.Label();
            this.lblCardPrice = new System.Windows.Forms.Label();
            this.tbxCardPrice = new System.Windows.Forms.TextBox();
            this.lblFAQ = new System.Windows.Forms.Label();
            this.tbxFAQ = new System.Windows.Forms.TextBox();
            this.btnFAQ = new System.Windows.Forms.Button();
            this.ttpCardInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbxCollectorNumber = new System.Windows.Forms.TextBox();
            this.lblCollectorNumber = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCardEnglishName = new System.Windows.Forms.Label();
            this.tbxCardEnglishName = new System.Windows.Forms.TextBox();
            this.cbxPainterName = new System.Windows.Forms.ComboBox();
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
            this.tbxCardName.TabIndex = 0;
            // 
            // lblImageType
            // 
            this.lblImageType.AutoSize = true;
            this.lblImageType.Location = new System.Drawing.Point(3, 118);
            this.lblImageType.Name = "lblImageType";
            this.lblImageType.Size = new System.Drawing.Size(53, 12);
            this.lblImageType.TabIndex = 3;
            this.lblImageType.Text = "图片形式";
            // 
            // cbxImageType
            // 
            this.cbxImageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxImageType.DropDownWidth = 180;
            this.cbxImageType.FormattingEnabled = true;
            this.cbxImageType.Items.AddRange(new object[] {
            "新建"});
            this.cbxImageType.Location = new System.Drawing.Point(71, 114);
            this.cbxImageType.Name = "cbxImageType";
            this.cbxImageType.Size = new System.Drawing.Size(158, 20);
            this.cbxImageType.TabIndex = 4;
            this.cbxImageType.SelectionChangeCommitted += new System.EventHandler(this.cbxImageType_SelectionChangeCommitted);
            // 
            // gbxCardImage
            // 
            this.gbxCardImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCardImage.Controls.Add(this.pbxCardImage);
            this.gbxCardImage.Location = new System.Drawing.Point(235, 6);
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
            this.tbxManaCost.Location = new System.Drawing.Point(71, 60);
            this.tbxManaCost.Name = "tbxManaCost";
            this.tbxManaCost.Size = new System.Drawing.Size(158, 21);
            this.tbxManaCost.TabIndex = 2;
            // 
            // lblManaCost
            // 
            this.lblManaCost.AutoSize = true;
            this.lblManaCost.Location = new System.Drawing.Point(3, 64);
            this.lblManaCost.Name = "lblManaCost";
            this.lblManaCost.Size = new System.Drawing.Size(65, 12);
            this.lblManaCost.TabIndex = 11;
            this.lblManaCost.Text = "法术力费用";
            // 
            // btnCardImage
            // 
            this.btnCardImage.AutoSize = true;
            this.btnCardImage.Location = new System.Drawing.Point(196, 86);
            this.btnCardImage.Name = "btnCardImage";
            this.btnCardImage.Size = new System.Drawing.Size(33, 23);
            this.btnCardImage.TabIndex = 3;
            this.btnCardImage.Text = "...";
            this.btnCardImage.UseVisualStyleBackColor = true;
            this.btnCardImage.Click += new System.EventHandler(this.btnCardImage_Click);
            // 
            // ofdCardImage
            // 
            this.ofdCardImage.Title = "选择卡牌图片";
            // 
            // tbxCardImage
            // 
            this.tbxCardImage.Location = new System.Drawing.Point(71, 87);
            this.tbxCardImage.Name = "tbxCardImage";
            this.tbxCardImage.Size = new System.Drawing.Size(120, 21);
            this.tbxCardImage.TabIndex = 16;
            this.tbxCardImage.TabStop = false;
            // 
            // lblCardImage
            // 
            this.lblCardImage.AutoSize = true;
            this.lblCardImage.Location = new System.Drawing.Point(3, 91);
            this.lblCardImage.Name = "lblCardImage";
            this.lblCardImage.Size = new System.Drawing.Size(53, 12);
            this.lblCardImage.TabIndex = 15;
            this.lblCardImage.Text = "卡牌图片";
            // 
            // cbxCardType
            // 
            this.cbxCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCardType.FormattingEnabled = true;
            this.cbxCardType.Items.AddRange(new object[] {
            "新建"});
            this.cbxCardType.Location = new System.Drawing.Point(71, 140);
            this.cbxCardType.Name = "cbxCardType";
            this.cbxCardType.Size = new System.Drawing.Size(158, 20);
            this.cbxCardType.TabIndex = 5;
            this.cbxCardType.SelectionChangeCommitted += new System.EventHandler(this.cbxCardType_SelectionChangeCommitted);
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Location = new System.Drawing.Point(3, 144);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(53, 12);
            this.lblCardType.TabIndex = 17;
            this.lblCardType.Text = "卡牌类型";
            // 
            // lblCardSubType
            // 
            this.lblCardSubType.AutoSize = true;
            this.lblCardSubType.Location = new System.Drawing.Point(3, 170);
            this.lblCardSubType.Name = "lblCardSubType";
            this.lblCardSubType.Size = new System.Drawing.Size(65, 12);
            this.lblCardSubType.TabIndex = 20;
            this.lblCardSubType.Text = "卡牌子类型";
            // 
            // tbxCardSubType
            // 
            this.tbxCardSubType.AcceptsReturn = true;
            this.tbxCardSubType.AcceptsTab = true;
            this.tbxCardSubType.BackColor = System.Drawing.SystemColors.Window;
            this.tbxCardSubType.Location = new System.Drawing.Point(71, 166);
            this.tbxCardSubType.Name = "tbxCardSubType";
            this.tbxCardSubType.ReadOnly = true;
            this.tbxCardSubType.Size = new System.Drawing.Size(120, 21);
            this.tbxCardSubType.TabIndex = 21;
            this.tbxCardSubType.TabStop = false;
            this.tbxCardSubType.TextChanged += new System.EventHandler(this.tbxCardSubType_TextChanged);
            // 
            // btnCardSubType
            // 
            this.btnCardSubType.AutoSize = true;
            this.btnCardSubType.Location = new System.Drawing.Point(196, 165);
            this.btnCardSubType.Name = "btnCardSubType";
            this.btnCardSubType.Size = new System.Drawing.Size(33, 23);
            this.btnCardSubType.TabIndex = 6;
            this.btnCardSubType.Text = "...";
            this.btnCardSubType.UseVisualStyleBackColor = true;
            this.btnCardSubType.Click += new System.EventHandler(this.btnCardSubType_Click);
            // 
            // cbxExpansions
            // 
            this.cbxExpansions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExpansions.FormattingEnabled = true;
            this.cbxExpansions.Items.AddRange(new object[] {
            "新建"});
            this.cbxExpansions.Location = new System.Drawing.Point(71, 193);
            this.cbxExpansions.Name = "cbxExpansions";
            this.cbxExpansions.Size = new System.Drawing.Size(158, 20);
            this.cbxExpansions.TabIndex = 7;
            this.cbxExpansions.SelectionChangeCommitted += new System.EventHandler(this.cbxExpansions_SelectionChangeCommitted);
            // 
            // lblExpansions
            // 
            this.lblExpansions.AutoSize = true;
            this.lblExpansions.Location = new System.Drawing.Point(3, 197);
            this.lblExpansions.Name = "lblExpansions";
            this.lblExpansions.Size = new System.Drawing.Size(53, 12);
            this.lblExpansions.TabIndex = 23;
            this.lblExpansions.Text = "所属系列";
            // 
            // btnAbilities
            // 
            this.btnAbilities.AutoSize = true;
            this.btnAbilities.Location = new System.Drawing.Point(196, 218);
            this.btnAbilities.Name = "btnAbilities";
            this.btnAbilities.Size = new System.Drawing.Size(33, 23);
            this.btnAbilities.TabIndex = 8;
            this.btnAbilities.Text = "...";
            this.btnAbilities.UseVisualStyleBackColor = true;
            this.btnAbilities.Click += new System.EventHandler(this.btnAbilities_Click);
            // 
            // tbxAbilities
            // 
            this.tbxAbilities.AcceptsReturn = true;
            this.tbxAbilities.AcceptsTab = true;
            this.tbxAbilities.BackColor = System.Drawing.SystemColors.Window;
            this.tbxAbilities.Location = new System.Drawing.Point(71, 219);
            this.tbxAbilities.Name = "tbxAbilities";
            this.tbxAbilities.ReadOnly = true;
            this.tbxAbilities.Size = new System.Drawing.Size(120, 21);
            this.tbxAbilities.TabIndex = 26;
            this.tbxAbilities.TabStop = false;
            this.tbxAbilities.WordWrap = false;
            this.tbxAbilities.TextChanged += new System.EventHandler(this.tbxCardSubType_TextChanged);
            // 
            // lblAbilities
            // 
            this.lblAbilities.AutoSize = true;
            this.lblAbilities.Location = new System.Drawing.Point(3, 223);
            this.lblAbilities.Name = "lblAbilities";
            this.lblAbilities.Size = new System.Drawing.Size(53, 12);
            this.lblAbilities.TabIndex = 25;
            this.lblAbilities.Text = "卡牌异能";
            // 
            // lblAbilitiesText
            // 
            this.lblAbilitiesText.AutoSize = true;
            this.lblAbilitiesText.Location = new System.Drawing.Point(3, 250);
            this.lblAbilitiesText.Name = "lblAbilitiesText";
            this.lblAbilitiesText.Size = new System.Drawing.Size(53, 12);
            this.lblAbilitiesText.TabIndex = 25;
            this.lblAbilitiesText.Text = "异能全文";
            // 
            // tbxAbilitiesText
            // 
            this.tbxAbilitiesText.AcceptsReturn = true;
            this.tbxAbilitiesText.AcceptsTab = true;
            this.tbxAbilitiesText.BackColor = System.Drawing.SystemColors.Window;
            this.tbxAbilitiesText.Location = new System.Drawing.Point(71, 246);
            this.tbxAbilitiesText.Name = "tbxAbilitiesText";
            this.tbxAbilitiesText.ReadOnly = true;
            this.tbxAbilitiesText.Size = new System.Drawing.Size(120, 21);
            this.tbxAbilitiesText.TabIndex = 26;
            this.tbxAbilitiesText.TabStop = false;
            this.tbxAbilitiesText.TextChanged += new System.EventHandler(this.tbxCardSubType_TextChanged);
            // 
            // btnAbilitiesText
            // 
            this.btnAbilitiesText.AutoSize = true;
            this.btnAbilitiesText.Location = new System.Drawing.Point(196, 245);
            this.btnAbilitiesText.Name = "btnAbilitiesText";
            this.btnAbilitiesText.Size = new System.Drawing.Size(33, 23);
            this.btnAbilitiesText.TabIndex = 9;
            this.btnAbilitiesText.Text = "...";
            this.btnAbilitiesText.UseVisualStyleBackColor = true;
            this.btnAbilitiesText.Click += new System.EventHandler(this.btnAbilitiesText_Click);
            // 
            // btnFlavorText
            // 
            this.btnFlavorText.AutoSize = true;
            this.btnFlavorText.Location = new System.Drawing.Point(196, 272);
            this.btnFlavorText.Name = "btnFlavorText";
            this.btnFlavorText.Size = new System.Drawing.Size(33, 23);
            this.btnFlavorText.TabIndex = 10;
            this.btnFlavorText.Text = "...";
            this.btnFlavorText.UseVisualStyleBackColor = true;
            this.btnFlavorText.Click += new System.EventHandler(this.btnFlavorText_Click);
            // 
            // tbxFlavorText
            // 
            this.tbxFlavorText.AcceptsReturn = true;
            this.tbxFlavorText.AcceptsTab = true;
            this.tbxFlavorText.BackColor = System.Drawing.SystemColors.Window;
            this.tbxFlavorText.Location = new System.Drawing.Point(71, 273);
            this.tbxFlavorText.Name = "tbxFlavorText";
            this.tbxFlavorText.ReadOnly = true;
            this.tbxFlavorText.Size = new System.Drawing.Size(120, 21);
            this.tbxFlavorText.TabIndex = 29;
            this.tbxFlavorText.TabStop = false;
            this.tbxFlavorText.TextChanged += new System.EventHandler(this.tbxCardSubType_TextChanged);
            // 
            // lblFlavorText
            // 
            this.lblFlavorText.AutoSize = true;
            this.lblFlavorText.Location = new System.Drawing.Point(3, 277);
            this.lblFlavorText.Name = "lblFlavorText";
            this.lblFlavorText.Size = new System.Drawing.Size(53, 12);
            this.lblFlavorText.TabIndex = 28;
            this.lblFlavorText.Text = "背景描述";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(3, 304);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(41, 12);
            this.lblPower.TabIndex = 25;
            this.lblPower.Text = "攻击力";
            // 
            // tbxPower
            // 
            this.tbxPower.Location = new System.Drawing.Point(71, 300);
            this.tbxPower.Name = "tbxPower";
            this.tbxPower.Size = new System.Drawing.Size(49, 21);
            this.tbxPower.TabIndex = 11;
            this.tbxPower.Text = "0";
            // 
            // lblToughness
            // 
            this.lblToughness.AutoSize = true;
            this.lblToughness.Location = new System.Drawing.Point(135, 304);
            this.lblToughness.Name = "lblToughness";
            this.lblToughness.Size = new System.Drawing.Size(41, 12);
            this.lblToughness.TabIndex = 25;
            this.lblToughness.Text = "防御力";
            // 
            // tbxToughness
            // 
            this.tbxToughness.Location = new System.Drawing.Point(182, 300);
            this.tbxToughness.Name = "tbxToughness";
            this.tbxToughness.Size = new System.Drawing.Size(47, 21);
            this.tbxToughness.TabIndex = 12;
            this.tbxToughness.Text = "0";
            // 
            // lblRarity
            // 
            this.lblRarity.AutoSize = true;
            this.lblRarity.Location = new System.Drawing.Point(3, 331);
            this.lblRarity.Name = "lblRarity";
            this.lblRarity.Size = new System.Drawing.Size(65, 12);
            this.lblRarity.TabIndex = 23;
            this.lblRarity.Text = "卡牌稀有度";
            // 
            // cbxRarity
            // 
            this.cbxRarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRarity.FormattingEnabled = true;
            this.cbxRarity.Items.AddRange(new object[] {
            "新建"});
            this.cbxRarity.Location = new System.Drawing.Point(71, 327);
            this.cbxRarity.Name = "cbxRarity";
            this.cbxRarity.Size = new System.Drawing.Size(158, 20);
            this.cbxRarity.TabIndex = 13;
            // 
            // lblPainterName
            // 
            this.lblPainterName.AutoSize = true;
            this.lblPainterName.Location = new System.Drawing.Point(3, 357);
            this.lblPainterName.Name = "lblPainterName";
            this.lblPainterName.Size = new System.Drawing.Size(53, 12);
            this.lblPainterName.TabIndex = 28;
            this.lblPainterName.Text = "画家姓名";
            // 
            // lblCardPrice
            // 
            this.lblCardPrice.AutoSize = true;
            this.lblCardPrice.Location = new System.Drawing.Point(123, 384);
            this.lblCardPrice.Name = "lblCardPrice";
            this.lblCardPrice.Size = new System.Drawing.Size(53, 12);
            this.lblCardPrice.TabIndex = 25;
            this.lblCardPrice.Text = "卡牌价格";
            // 
            // tbxCardPrice
            // 
            this.tbxCardPrice.Location = new System.Drawing.Point(182, 380);
            this.tbxCardPrice.Name = "tbxCardPrice";
            this.tbxCardPrice.Size = new System.Drawing.Size(47, 21);
            this.tbxCardPrice.TabIndex = 16;
            this.tbxCardPrice.Text = "0";
            // 
            // lblFAQ
            // 
            this.lblFAQ.AutoSize = true;
            this.lblFAQ.Location = new System.Drawing.Point(3, 411);
            this.lblFAQ.Name = "lblFAQ";
            this.lblFAQ.Size = new System.Drawing.Size(23, 12);
            this.lblFAQ.TabIndex = 28;
            this.lblFAQ.Text = "FAQ";
            // 
            // tbxFAQ
            // 
            this.tbxFAQ.AcceptsReturn = true;
            this.tbxFAQ.AcceptsTab = true;
            this.tbxFAQ.BackColor = System.Drawing.SystemColors.Window;
            this.tbxFAQ.Location = new System.Drawing.Point(71, 407);
            this.tbxFAQ.Name = "tbxFAQ";
            this.tbxFAQ.ReadOnly = true;
            this.tbxFAQ.Size = new System.Drawing.Size(120, 21);
            this.tbxFAQ.TabIndex = 17;
            this.tbxFAQ.TabStop = false;
            this.tbxFAQ.TextChanged += new System.EventHandler(this.tbxCardSubType_TextChanged);
            // 
            // btnFAQ
            // 
            this.btnFAQ.AutoSize = true;
            this.btnFAQ.Location = new System.Drawing.Point(196, 406);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Size = new System.Drawing.Size(33, 23);
            this.btnFAQ.TabIndex = 18;
            this.btnFAQ.Text = "...";
            this.btnFAQ.UseVisualStyleBackColor = true;
            this.btnFAQ.Click += new System.EventHandler(this.btnFAQ_Click);
            // 
            // ttpCardInfo
            // 
            this.ttpCardInfo.AutoPopDelay = 5000;
            this.ttpCardInfo.InitialDelay = 100;
            this.ttpCardInfo.ReshowDelay = 100;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(316, 406);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(23, 23);
            this.btnPrevious.TabIndex = 32;
            this.btnPrevious.Text = "↑";
            this.ttpCardInfo.SetToolTip(this.btnPrevious, "上一个");
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(345, 406);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 23);
            this.btnNext.TabIndex = 32;
            this.btnNext.Text = "↓";
            this.ttpCardInfo.SetToolTip(this.btnNext, "下一个");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbxCollectorNumber
            // 
            this.tbxCollectorNumber.Location = new System.Drawing.Point(71, 380);
            this.tbxCollectorNumber.Name = "tbxCollectorNumber";
            this.tbxCollectorNumber.Size = new System.Drawing.Size(49, 21);
            this.tbxCollectorNumber.TabIndex = 15;
            this.tbxCollectorNumber.Text = "0";
            // 
            // lblCollectorNumber
            // 
            this.lblCollectorNumber.AutoSize = true;
            this.lblCollectorNumber.Location = new System.Drawing.Point(3, 384);
            this.lblCollectorNumber.Name = "lblCollectorNumber";
            this.lblCollectorNumber.Size = new System.Drawing.Size(53, 12);
            this.lblCollectorNumber.TabIndex = 31;
            this.lblCollectorNumber.Text = "卡牌编号";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(235, 406);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "确认";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(431, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCardEnglishName
            // 
            this.lblCardEnglishName.AutoSize = true;
            this.lblCardEnglishName.Location = new System.Drawing.Point(3, 37);
            this.lblCardEnglishName.Name = "lblCardEnglishName";
            this.lblCardEnglishName.Size = new System.Drawing.Size(65, 12);
            this.lblCardEnglishName.TabIndex = 11;
            this.lblCardEnglishName.Text = "卡牌英文名";
            // 
            // tbxCardEnglishName
            // 
            this.tbxCardEnglishName.Location = new System.Drawing.Point(71, 33);
            this.tbxCardEnglishName.Name = "tbxCardEnglishName";
            this.tbxCardEnglishName.Size = new System.Drawing.Size(158, 21);
            this.tbxCardEnglishName.TabIndex = 1;
            // 
            // cbxPainterName
            // 
            this.cbxPainterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPainterName.FormattingEnabled = true;
            this.cbxPainterName.Items.AddRange(new object[] {
            "新建"});
            this.cbxPainterName.Location = new System.Drawing.Point(71, 354);
            this.cbxPainterName.Name = "cbxPainterName";
            this.cbxPainterName.Size = new System.Drawing.Size(158, 20);
            this.cbxPainterName.TabIndex = 14;
            this.cbxPainterName.SelectionChangeCommitted += new System.EventHandler(this.cbxPainterName_SelectionChangeCommitted);
            // 
            // FormCardInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 434);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbxCollectorNumber);
            this.Controls.Add(this.lblCollectorNumber);
            this.Controls.Add(this.btnFAQ);
            this.Controls.Add(this.btnFlavorText);
            this.Controls.Add(this.tbxFAQ);
            this.Controls.Add(this.lblFAQ);
            this.Controls.Add(this.lblPainterName);
            this.Controls.Add(this.tbxFlavorText);
            this.Controls.Add(this.lblFlavorText);
            this.Controls.Add(this.btnAbilitiesText);
            this.Controls.Add(this.btnAbilities);
            this.Controls.Add(this.tbxAbilitiesText);
            this.Controls.Add(this.lblAbilitiesText);
            this.Controls.Add(this.tbxToughness);
            this.Controls.Add(this.lblToughness);
            this.Controls.Add(this.tbxPower);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.tbxCardPrice);
            this.Controls.Add(this.lblCardPrice);
            this.Controls.Add(this.tbxAbilities);
            this.Controls.Add(this.lblAbilities);
            this.Controls.Add(this.cbxPainterName);
            this.Controls.Add(this.cbxRarity);
            this.Controls.Add(this.lblRarity);
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
            this.Controls.Add(this.tbxCardEnglishName);
            this.Controls.Add(this.lblCardEnglishName);
            this.Controls.Add(this.tbxManaCost);
            this.Controls.Add(this.lblManaCost);
            this.Controls.Add(this.gbxCardImage);
            this.Controls.Add(this.cbxImageType);
            this.Controls.Add(this.lblImageType);
            this.Controls.Add(this.tbxCardName);
            this.Controls.Add(this.lblCardName);
            this.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCardInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "卡牌信息 - 添加";
            this.Load += new System.EventHandler(this.FormCardInfo_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCardInfo_FormClosed);
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
        private System.Windows.Forms.PictureBox pbxCardImage;
        private System.Windows.Forms.GroupBox gbxCardImage;
        private System.Windows.Forms.TextBox tbxManaCost;
        private System.Windows.Forms.Label lblManaCost;
        private System.Windows.Forms.Button btnCardImage;
        private System.Windows.Forms.OpenFileDialog ofdCardImage;
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
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.TextBox tbxPower;
        private System.Windows.Forms.Label lblToughness;
        private System.Windows.Forms.TextBox tbxToughness;
        private System.Windows.Forms.Label lblRarity;
        private System.Windows.Forms.ComboBox cbxRarity;
        private System.Windows.Forms.Label lblPainterName;
        private System.Windows.Forms.Label lblCardPrice;
        private System.Windows.Forms.TextBox tbxCardPrice;
        private System.Windows.Forms.Label lblFAQ;
        private System.Windows.Forms.TextBox tbxFAQ;
        private System.Windows.Forms.Button btnFAQ;
        private System.Windows.Forms.ToolTip ttpCardInfo;
        private System.Windows.Forms.TextBox tbxCollectorNumber;
        private System.Windows.Forms.Label lblCollectorNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCardEnglishName;
        private System.Windows.Forms.TextBox tbxCardEnglishName;
        private System.Windows.Forms.ComboBox cbxPainterName;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
    }
}