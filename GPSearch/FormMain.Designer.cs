namespace GPSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewDeck = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewBase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxCardImage = new System.Windows.Forms.GroupBox();
            this.tbxEnName = new System.Windows.Forms.TextBox();
            this.lblEnName = new System.Windows.Forms.Label();
            this.tbxCnName = new System.Windows.Forms.TextBox();
            this.lblCnName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvwCardList = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuCard = new System.Windows.Forms.ToolStripMenuItem();
            this.添加卡牌ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除卡牌ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑卡牌ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gbxCardImage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuCard,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewDeck,
            this.mnuNewBase,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(41, 20);
            this.mnuFile.Text = "文件";
            // 
            // mnuNewDeck
            // 
            this.mnuNewDeck.Name = "mnuNewDeck";
            this.mnuNewDeck.Size = new System.Drawing.Size(118, 22);
            this.mnuNewDeck.Text = "新建套牌";
            this.mnuNewDeck.Click += new System.EventHandler(this.mnuNewDeck_Click);
            // 
            // mnuNewBase
            // 
            this.mnuNewBase.Name = "mnuNewBase";
            this.mnuNewBase.Size = new System.Drawing.Size(118, 22);
            this.mnuNewBase.Text = "新建牌库";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(118, 22);
            this.mnuExit.Text = "退出";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(41, 20);
            this.mnuHelp.Text = "帮助";
            // 
            // gbxCardImage
            // 
            this.gbxCardImage.Controls.Add(this.tbxEnName);
            this.gbxCardImage.Controls.Add(this.lblEnName);
            this.gbxCardImage.Controls.Add(this.tbxCnName);
            this.gbxCardImage.Controls.Add(this.lblCnName);
            this.gbxCardImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxCardImage.Location = new System.Drawing.Point(0, 5);
            this.gbxCardImage.Name = "gbxCardImage";
            this.gbxCardImage.Size = new System.Drawing.Size(339, 40);
            this.gbxCardImage.TabIndex = 1;
            this.gbxCardImage.TabStop = false;
            this.gbxCardImage.Text = "0张牌";
            // 
            // tbxEnName
            // 
            this.tbxEnName.Location = new System.Drawing.Point(232, 13);
            this.tbxEnName.Name = "tbxEnName";
            this.tbxEnName.Size = new System.Drawing.Size(100, 21);
            this.tbxEnName.TabIndex = 1;
            // 
            // lblEnName
            // 
            this.lblEnName.AutoSize = true;
            this.lblEnName.Location = new System.Drawing.Point(172, 17);
            this.lblEnName.Name = "lblEnName";
            this.lblEnName.Size = new System.Drawing.Size(53, 12);
            this.lblEnName.TabIndex = 0;
            this.lblEnName.Text = "英文检索";
            // 
            // tbxCnName
            // 
            this.tbxCnName.Location = new System.Drawing.Point(63, 13);
            this.tbxCnName.Name = "tbxCnName";
            this.tbxCnName.Size = new System.Drawing.Size(100, 21);
            this.tbxCnName.TabIndex = 1;
            // 
            // lblCnName
            // 
            this.lblCnName.AutoSize = true;
            this.lblCnName.Location = new System.Drawing.Point(3, 17);
            this.lblCnName.Name = "lblCnName";
            this.lblCnName.Size = new System.Drawing.Size(53, 12);
            this.lblCnName.TabIndex = 0;
            this.lblCnName.Text = "中文检索";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvwCardList);
            this.panel1.Controls.Add(this.gbxCardImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel1.Size = new System.Drawing.Size(339, 506);
            this.panel1.TabIndex = 2;
            // 
            // lvwCardList
            // 
            this.lvwCardList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwCardList.Location = new System.Drawing.Point(0, 45);
            this.lvwCardList.Name = "lvwCardList";
            this.lvwCardList.Size = new System.Drawing.Size(339, 461);
            this.lvwCardList.TabIndex = 2;
            this.lvwCardList.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(339, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 506);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(6, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(474, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 53;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 53;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.NullValue = false;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Width = 53;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.NullValue = false;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Width = 53;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.Width = 53;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.Width = 53;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.Width = 72;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(831, 22);
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
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // mnuCard
            // 
            this.mnuCard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加卡牌ToolStripMenuItem,
            this.删除卡牌ToolStripMenuItem,
            this.编辑卡牌ToolStripMenuItem});
            this.mnuCard.Name = "mnuCard";
            this.mnuCard.Size = new System.Drawing.Size(41, 20);
            this.mnuCard.Text = "卡牌";
            // 
            // 添加卡牌ToolStripMenuItem
            // 
            this.添加卡牌ToolStripMenuItem.Name = "添加卡牌ToolStripMenuItem";
            this.添加卡牌ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加卡牌ToolStripMenuItem.Text = "添加卡牌";
            // 
            // 删除卡牌ToolStripMenuItem
            // 
            this.删除卡牌ToolStripMenuItem.Name = "删除卡牌ToolStripMenuItem";
            this.删除卡牌ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除卡牌ToolStripMenuItem.Text = "删除卡牌";
            // 
            // 编辑卡牌ToolStripMenuItem
            // 
            this.编辑卡牌ToolStripMenuItem.Name = "编辑卡牌ToolStripMenuItem";
            this.编辑卡牌ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.编辑卡牌ToolStripMenuItem.Text = "编辑卡牌";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "GPSearch - 卡牌查询工具";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxCardImage.ResumeLayout(false);
            this.gbxCardImage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.GroupBox gbxCardImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem mnuNewDeck;
        private System.Windows.Forms.ToolStripMenuItem mnuNewBase;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblCnName;
        private System.Windows.Forms.TextBox tbxCnName;
        private System.Windows.Forms.TextBox tbxEnName;
        private System.Windows.Forms.Label lblEnName;
        private System.Windows.Forms.ListView lvwCardList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        private System.Windows.Forms.DataGridViewLinkColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ToolStripMenuItem mnuCard;
        private System.Windows.Forms.ToolStripMenuItem 添加卡牌ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除卡牌ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑卡牌ToolStripMenuItem;
    }
}

