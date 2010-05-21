namespace GPSoft.GPMagic.GPSearch.UI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnuStpMain = new System.Windows.Forms.MenuStrip();
            this.mnuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemNewDeck = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemNewBase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddCard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEditCard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDeleteCard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxCardImage = new System.Windows.Forms.GroupBox();
            this.cbxSearchLanguage = new System.Windows.Forms.ComboBox();
            this.tbxCardName = new System.Windows.Forms.TextBox();
            this.pnlNameList = new System.Windows.Forms.Panel();
            this.dgvCardList = new System.Windows.Forms.DataGridView();
            this.dgvDeckList = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.colDCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDCardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDCost = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvColExpansions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCNName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColENName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColSubType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColAbilities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColToughness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuStpMain.SuspendLayout();
            this.gbxCardImage.SuspendLayout();
            this.pnlNameList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeckList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStpMain
            // 
            this.mnuStpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemFile,
            this.mnuItemCard,
            this.mnuItemHelp});
            this.mnuStpMain.Location = new System.Drawing.Point(0, 0);
            this.mnuStpMain.Name = "mnuStpMain";
            this.mnuStpMain.Size = new System.Drawing.Size(761, 24);
            this.mnuStpMain.TabIndex = 0;
            this.mnuStpMain.Text = "menuStrip1";
            // 
            // mnuItemFile
            // 
            this.mnuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemNewDeck,
            this.mnuItemNewBase,
            this.toolStripMenuItem1,
            this.mnuItemExit});
            this.mnuItemFile.Name = "mnuItemFile";
            this.mnuItemFile.Size = new System.Drawing.Size(41, 20);
            this.mnuItemFile.Text = "文件";
            // 
            // mnuItemNewDeck
            // 
            this.mnuItemNewDeck.Name = "mnuItemNewDeck";
            this.mnuItemNewDeck.Size = new System.Drawing.Size(118, 22);
            this.mnuItemNewDeck.Text = "新建套牌";
            this.mnuItemNewDeck.Click += new System.EventHandler(this.mnuNewDeck_Click);
            // 
            // mnuItemNewBase
            // 
            this.mnuItemNewBase.Name = "mnuItemNewBase";
            this.mnuItemNewBase.Size = new System.Drawing.Size(118, 22);
            this.mnuItemNewBase.Text = "新建牌库";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 6);
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(118, 22);
            this.mnuItemExit.Text = "退出";
            this.mnuItemExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuItemCard
            // 
            this.mnuItemCard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAddCard,
            this.mnuItemEditCard,
            this.mnuItemDeleteCard});
            this.mnuItemCard.Name = "mnuItemCard";
            this.mnuItemCard.Size = new System.Drawing.Size(41, 20);
            this.mnuItemCard.Text = "卡牌";
            // 
            // mnuItemAddCard
            // 
            this.mnuItemAddCard.Name = "mnuItemAddCard";
            this.mnuItemAddCard.Size = new System.Drawing.Size(118, 22);
            this.mnuItemAddCard.Text = "添加卡牌";
            this.mnuItemAddCard.Click += new System.EventHandler(this.mnuAddCard_Click);
            // 
            // mnuItemEditCard
            // 
            this.mnuItemEditCard.Name = "mnuItemEditCard";
            this.mnuItemEditCard.Size = new System.Drawing.Size(118, 22);
            this.mnuItemEditCard.Text = "编辑卡牌";
            this.mnuItemEditCard.Click += new System.EventHandler(this.mnuEditCard_Click);
            // 
            // mnuItemDeleteCard
            // 
            this.mnuItemDeleteCard.Name = "mnuItemDeleteCard";
            this.mnuItemDeleteCard.Size = new System.Drawing.Size(118, 22);
            this.mnuItemDeleteCard.Text = "删除卡牌";
            // 
            // mnuItemHelp
            // 
            this.mnuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAbout});
            this.mnuItemHelp.Name = "mnuItemHelp";
            this.mnuItemHelp.Size = new System.Drawing.Size(41, 20);
            this.mnuItemHelp.Text = "帮助";
            // 
            // mnuItemAbout
            // 
            this.mnuItemAbout.Name = "mnuItemAbout";
            this.mnuItemAbout.Size = new System.Drawing.Size(94, 22);
            this.mnuItemAbout.Text = "关于";
            this.mnuItemAbout.Click += new System.EventHandler(this.mnuItemAbout_Click);
            // 
            // gbxCardImage
            // 
            this.gbxCardImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCardImage.Controls.Add(this.cbxSearchLanguage);
            this.gbxCardImage.Controls.Add(this.tbxCardName);
            this.gbxCardImage.Location = new System.Drawing.Point(3, 5);
            this.gbxCardImage.Name = "gbxCardImage";
            this.gbxCardImage.Size = new System.Drawing.Size(755, 40);
            this.gbxCardImage.TabIndex = 1;
            this.gbxCardImage.TabStop = false;
            this.gbxCardImage.Text = "0张牌";
            // 
            // cbxSearchLanguage
            // 
            this.cbxSearchLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchLanguage.FormattingEnabled = true;
            this.cbxSearchLanguage.Items.AddRange(new object[] {
            "中文检索",
            "英文检索"});
            this.cbxSearchLanguage.Location = new System.Drawing.Point(6, 13);
            this.cbxSearchLanguage.Name = "cbxSearchLanguage";
            this.cbxSearchLanguage.Size = new System.Drawing.Size(97, 20);
            this.cbxSearchLanguage.TabIndex = 2;
            // 
            // tbxCardName
            // 
            this.tbxCardName.Location = new System.Drawing.Point(109, 13);
            this.tbxCardName.Name = "tbxCardName";
            this.tbxCardName.Size = new System.Drawing.Size(141, 21);
            this.tbxCardName.TabIndex = 1;
            // 
            // pnlNameList
            // 
            this.pnlNameList.Controls.Add(this.gbxCardImage);
            this.pnlNameList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNameList.Location = new System.Drawing.Point(0, 24);
            this.pnlNameList.Name = "pnlNameList";
            this.pnlNameList.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlNameList.Size = new System.Drawing.Size(761, 51);
            this.pnlNameList.TabIndex = 2;
            // 
            // dgvCardList
            // 
            this.dgvCardList.AllowUserToAddRows = false;
            this.dgvCardList.AllowUserToDeleteRows = false;
            this.dgvCardList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dgvCardList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCardList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCardList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCardList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCardList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColExpansions,
            this.dgvColCNName,
            this.dgvColENName,
            this.dgvColType,
            this.dgvColSubType,
            this.dgvColAbilities,
            this.dgvColCost,
            this.dgvColPower,
            this.dgvColToughness,
            this.dgvColPrice});
            this.dgvCardList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCardList.Location = new System.Drawing.Point(0, 0);
            this.dgvCardList.Name = "dgvCardList";
            this.dgvCardList.ReadOnly = true;
            this.dgvCardList.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvCardList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCardList.RowTemplate.Height = 20;
            this.dgvCardList.Size = new System.Drawing.Size(458, 445);
            this.dgvCardList.TabIndex = 2;
            // 
            // dgvDeckList
            // 
            this.dgvDeckList.AllowUserToAddRows = false;
            this.dgvDeckList.AllowUserToDeleteRows = false;
            this.dgvDeckList.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Lavender;
            this.dgvDeckList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDeckList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeckList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDeckList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeckList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDCount,
            this.colDSymbol,
            this.colDCardName,
            this.colDCost});
            this.dgvDeckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeckList.Location = new System.Drawing.Point(0, 0);
            this.dgvDeckList.Name = "dgvDeckList";
            this.dgvDeckList.ReadOnly = true;
            this.dgvDeckList.RowHeadersVisible = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.dgvDeckList.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDeckList.RowTemplate.Height = 23;
            this.dgvDeckList.Size = new System.Drawing.Size(299, 445);
            this.dgvDeckList.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 520);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(761, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoSize = false;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(300, 16);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 75);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvCardList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDeckList);
            this.splitContainer1.Size = new System.Drawing.Size(761, 445);
            this.splitContainer1.SplitterDistance = 458;
            this.splitContainer1.TabIndex = 1;
            // 
            // colDCount
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colDCount.DefaultCellStyle = dataGridViewCellStyle9;
            this.colDCount.HeaderText = "数量";
            this.colDCount.Name = "colDCount";
            this.colDCount.ReadOnly = true;
            this.colDCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDCount.Width = 40;
            // 
            // colDSymbol
            // 
            this.colDSymbol.HeaderText = "系列";
            this.colDSymbol.Name = "colDSymbol";
            this.colDSymbol.ReadOnly = true;
            this.colDSymbol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDSymbol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDSymbol.Width = 40;
            // 
            // colDCardName
            // 
            this.colDCardName.HeaderText = "卡牌名";
            this.colDCardName.Name = "colDCardName";
            this.colDCardName.ReadOnly = true;
            this.colDCardName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDCardName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDCardName.Width = 120;
            // 
            // colDCost
            // 
            this.colDCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle10.NullValue")));
            this.colDCost.DefaultCellStyle = dataGridViewCellStyle10;
            this.colDCost.HeaderText = "费用";
            this.colDCost.Name = "colDCost";
            this.colDCost.ReadOnly = true;
            this.colDCost.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvColExpansions
            // 
            this.dgvColExpansions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColExpansions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvColExpansions.Frozen = true;
            this.dgvColExpansions.HeaderText = "系列";
            this.dgvColExpansions.Name = "dgvColExpansions";
            this.dgvColExpansions.ReadOnly = true;
            this.dgvColExpansions.Width = 40;
            // 
            // dgvColCNName
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColCNName.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvColCNName.HeaderText = "中文名";
            this.dgvColCNName.Name = "dgvColCNName";
            this.dgvColCNName.ReadOnly = true;
            this.dgvColCNName.Width = 120;
            // 
            // dgvColENName
            // 
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColENName.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvColENName.HeaderText = "英文名";
            this.dgvColENName.Name = "dgvColENName";
            this.dgvColENName.ReadOnly = true;
            this.dgvColENName.Width = 150;
            // 
            // dgvColType
            // 
            this.dgvColType.HeaderText = "类别";
            this.dgvColType.Name = "dgvColType";
            this.dgvColType.ReadOnly = true;
            this.dgvColType.Width = 80;
            // 
            // dgvColSubType
            // 
            this.dgvColSubType.HeaderText = "子类别";
            this.dgvColSubType.Name = "dgvColSubType";
            this.dgvColSubType.ReadOnly = true;
            // 
            // dgvColAbilities
            // 
            this.dgvColAbilities.HeaderText = "异能";
            this.dgvColAbilities.Name = "dgvColAbilities";
            this.dgvColAbilities.ReadOnly = true;
            // 
            // dgvColCost
            // 
            this.dgvColCost.HeaderText = "费用";
            this.dgvColCost.Name = "dgvColCost";
            this.dgvColCost.ReadOnly = true;
            // 
            // dgvColPower
            // 
            this.dgvColPower.HeaderText = "攻击";
            this.dgvColPower.Name = "dgvColPower";
            this.dgvColPower.ReadOnly = true;
            this.dgvColPower.Width = 40;
            // 
            // dgvColToughness
            // 
            this.dgvColToughness.HeaderText = "防御";
            this.dgvColToughness.Name = "dgvColToughness";
            this.dgvColToughness.ReadOnly = true;
            this.dgvColToughness.Width = 40;
            // 
            // dgvColPrice
            // 
            this.dgvColPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColPrice.HeaderText = "参考价格";
            this.dgvColPrice.Name = "dgvColPrice";
            this.dgvColPrice.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 542);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlNameList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuStpMain);
            this.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.mnuStpMain;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPSearch - 卡牌查询工具";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.mnuStpMain.ResumeLayout(false);
            this.mnuStpMain.PerformLayout();
            this.gbxCardImage.ResumeLayout(false);
            this.gbxCardImage.PerformLayout();
            this.pnlNameList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeckList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStpMain;
        private System.Windows.Forms.ToolStripMenuItem mnuItemFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHelp;
        private System.Windows.Forms.GroupBox gbxCardImage;
        private System.Windows.Forms.Panel pnlNameList;
        private System.Windows.Forms.ToolStripMenuItem mnuItemNewDeck;
        private System.Windows.Forms.ToolStripMenuItem mnuItemNewBase;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.TextBox tbxCardName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.DataGridView dgvDeckList;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCard;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddCard;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDeleteCard;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEditCard;
        private System.Windows.Forms.DataGridView dgvCardList;
        private System.Windows.Forms.ComboBox cbxSearchLanguage;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAbout;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDCardName;
        private System.Windows.Forms.DataGridViewImageColumn colDCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColExpansions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCNName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColENName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColSubType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColAbilities;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColToughness;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPrice;
    }
}

