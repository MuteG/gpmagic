namespace GPSoft.GPMagic.GPSearch.UI
{
    partial class FormImportCardsSetting
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpgInfoList = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpgTable = new System.Windows.Forms.TabPage();
            this.gbxAddField = new System.Windows.Forms.GroupBox();
            this.btnDeleteModel = new System.Windows.Forms.Button();
            this.btnNewModel = new System.Windows.Forms.Button();
            this.cbxCardProperties = new System.Windows.Forms.ComboBox();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.lblFieldIndex = new System.Windows.Forms.Label();
            this.tbxFieldIndex = new System.Windows.Forms.TextBox();
            this.gbxSplitType = new System.Windows.Forms.GroupBox();
            this.tbxOtherSplitString = new System.Windows.Forms.TextBox();
            this.tbtnOther = new System.Windows.Forms.RadioButton();
            this.rbtnSpace = new System.Windows.Forms.RadioButton();
            this.rbtnTab = new System.Windows.Forms.RadioButton();
            this.rbtnComma = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbxTableFrame = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbxFilterContent = new System.Windows.Forms.CheckBox();
            this.tbxFilterPrefix = new System.Windows.Forms.TextBox();
            this.lblSample = new System.Windows.Forms.Label();
            this.tbxSuffix = new System.Windows.Forms.TextBox();
            this.lblFilterContent = new System.Windows.Forms.Label();
            this.cbxDataModel = new System.Windows.Forms.CheckBox();
            this.tbxDataModel = new System.Windows.Forms.TextBox();
            this.btnSetDataModel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpgInfoList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpgTable.SuspendLayout();
            this.gbxAddField.SuspendLayout();
            this.gbxSplitType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpgInfoList);
            this.tabControl1.Controls.Add(this.tpgTable);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 320);
            this.tabControl1.TabIndex = 0;
            // 
            // tpgInfoList
            // 
            this.tpgInfoList.Controls.Add(this.pictureBox1);
            this.tpgInfoList.Location = new System.Drawing.Point(4, 21);
            this.tpgInfoList.Name = "tpgInfoList";
            this.tpgInfoList.Padding = new System.Windows.Forms.Padding(3);
            this.tpgInfoList.Size = new System.Drawing.Size(529, 271);
            this.tpgInfoList.TabIndex = 0;
            this.tpgInfoList.Text = "信息序列模式";
            this.tpgInfoList.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.ImportInfoListDemo;
            this.pictureBox1.Location = new System.Drawing.Point(171, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tpgTable
            // 
            this.tpgTable.Controls.Add(this.gbxAddField);
            this.tpgTable.Controls.Add(this.gbxSplitType);
            this.tpgTable.Controls.Add(this.pictureBox2);
            this.tpgTable.Location = new System.Drawing.Point(4, 21);
            this.tpgTable.Name = "tpgTable";
            this.tpgTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTable.Size = new System.Drawing.Size(529, 295);
            this.tpgTable.TabIndex = 1;
            this.tpgTable.Text = "表格模式";
            this.tpgTable.UseVisualStyleBackColor = true;
            // 
            // gbxAddField
            // 
            this.gbxAddField.Controls.Add(this.btnSetDataModel);
            this.gbxAddField.Controls.Add(this.tbxDataModel);
            this.gbxAddField.Controls.Add(this.cbxDataModel);
            this.gbxAddField.Controls.Add(this.lblFilterContent);
            this.gbxAddField.Controls.Add(this.lblSample);
            this.gbxAddField.Controls.Add(this.tbxSuffix);
            this.gbxAddField.Controls.Add(this.tbxFilterPrefix);
            this.gbxAddField.Controls.Add(this.cbxFilterContent);
            this.gbxAddField.Controls.Add(this.btnClose);
            this.gbxAddField.Controls.Add(this.btnSave);
            this.gbxAddField.Controls.Add(this.lbxTableFrame);
            this.gbxAddField.Controls.Add(this.btnDeleteModel);
            this.gbxAddField.Controls.Add(this.btnNewModel);
            this.gbxAddField.Controls.Add(this.cbxCardProperties);
            this.gbxAddField.Controls.Add(this.lblFieldName);
            this.gbxAddField.Controls.Add(this.lblFieldIndex);
            this.gbxAddField.Controls.Add(this.tbxFieldIndex);
            this.gbxAddField.Location = new System.Drawing.Point(3, 144);
            this.gbxAddField.Name = "gbxAddField";
            this.gbxAddField.Size = new System.Drawing.Size(523, 148);
            this.gbxAddField.TabIndex = 5;
            this.gbxAddField.TabStop = false;
            this.gbxAddField.Text = "定义数据结构";
            // 
            // btnDeleteModel
            // 
            this.btnDeleteModel.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.Delete;
            this.btnDeleteModel.Location = new System.Drawing.Point(450, 38);
            this.btnDeleteModel.Name = "btnDeleteModel";
            this.btnDeleteModel.Size = new System.Drawing.Size(24, 23);
            this.btnDeleteModel.TabIndex = 10;
            this.btnDeleteModel.UseVisualStyleBackColor = true;
            // 
            // btnNewModel
            // 
            this.btnNewModel.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.Add;
            this.btnNewModel.Location = new System.Drawing.Point(420, 38);
            this.btnNewModel.Name = "btnNewModel";
            this.btnNewModel.Size = new System.Drawing.Size(24, 23);
            this.btnNewModel.TabIndex = 10;
            this.btnNewModel.UseVisualStyleBackColor = true;
            // 
            // cbxCardProperties
            // 
            this.cbxCardProperties.FormattingEnabled = true;
            this.cbxCardProperties.Location = new System.Drawing.Point(289, 40);
            this.cbxCardProperties.Name = "cbxCardProperties";
            this.cbxCardProperties.Size = new System.Drawing.Size(125, 20);
            this.cbxCardProperties.TabIndex = 6;
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Location = new System.Drawing.Point(168, 43);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(77, 12);
            this.lblFieldName.TabIndex = 5;
            this.lblFieldName.Text = "对应卡牌属性";
            // 
            // lblFieldIndex
            // 
            this.lblFieldIndex.AutoSize = true;
            this.lblFieldIndex.Location = new System.Drawing.Point(168, 18);
            this.lblFieldIndex.Name = "lblFieldIndex";
            this.lblFieldIndex.Size = new System.Drawing.Size(115, 12);
            this.lblFieldIndex.TabIndex = 3;
            this.lblFieldIndex.Text = "数据列索引(从0开始)";
            // 
            // tbxFieldIndex
            // 
            this.tbxFieldIndex.Location = new System.Drawing.Point(289, 15);
            this.tbxFieldIndex.Name = "tbxFieldIndex";
            this.tbxFieldIndex.Size = new System.Drawing.Size(41, 19);
            this.tbxFieldIndex.TabIndex = 4;
            // 
            // gbxSplitType
            // 
            this.gbxSplitType.Controls.Add(this.tbxOtherSplitString);
            this.gbxSplitType.Controls.Add(this.tbtnOther);
            this.gbxSplitType.Controls.Add(this.rbtnSpace);
            this.gbxSplitType.Controls.Add(this.rbtnTab);
            this.gbxSplitType.Controls.Add(this.rbtnComma);
            this.gbxSplitType.Location = new System.Drawing.Point(3, 3);
            this.gbxSplitType.Name = "gbxSplitType";
            this.gbxSplitType.Size = new System.Drawing.Size(162, 135);
            this.gbxSplitType.TabIndex = 2;
            this.gbxSplitType.TabStop = false;
            this.gbxSplitType.Text = "数据分隔类型";
            // 
            // tbxOtherSplitString
            // 
            this.tbxOtherSplitString.Location = new System.Drawing.Point(107, 83);
            this.tbxOtherSplitString.Name = "tbxOtherSplitString";
            this.tbxOtherSplitString.Size = new System.Drawing.Size(38, 19);
            this.tbxOtherSplitString.TabIndex = 2;
            // 
            // tbtnOther
            // 
            this.tbtnOther.AutoSize = true;
            this.tbtnOther.Location = new System.Drawing.Point(6, 84);
            this.tbtnOther.Name = "tbtnOther";
            this.tbtnOther.Size = new System.Drawing.Size(95, 16);
            this.tbtnOther.TabIndex = 1;
            this.tbtnOther.TabStop = true;
            this.tbtnOther.Text = "其他字符分隔";
            this.tbtnOther.UseVisualStyleBackColor = true;
            // 
            // rbtnSpace
            // 
            this.rbtnSpace.AutoSize = true;
            this.rbtnSpace.Location = new System.Drawing.Point(6, 62);
            this.rbtnSpace.Name = "rbtnSpace";
            this.rbtnSpace.Size = new System.Drawing.Size(139, 16);
            this.rbtnSpace.TabIndex = 1;
            this.rbtnSpace.TabStop = true;
            this.rbtnSpace.Text = "空格(一个或多个)分隔";
            this.rbtnSpace.UseVisualStyleBackColor = true;
            // 
            // rbtnTab
            // 
            this.rbtnTab.AutoSize = true;
            this.rbtnTab.Location = new System.Drawing.Point(6, 40);
            this.rbtnTab.Name = "rbtnTab";
            this.rbtnTab.Size = new System.Drawing.Size(114, 16);
            this.rbtnTab.TabIndex = 1;
            this.rbtnTab.TabStop = true;
            this.rbtnTab.Text = "制表符(TAB)分隔";
            this.rbtnTab.UseVisualStyleBackColor = true;
            // 
            // rbtnComma
            // 
            this.rbtnComma.AutoSize = true;
            this.rbtnComma.Location = new System.Drawing.Point(6, 18);
            this.rbtnComma.Name = "rbtnComma";
            this.rbtnComma.Size = new System.Drawing.Size(71, 16);
            this.rbtnComma.TabIndex = 0;
            this.rbtnComma.TabStop = true;
            this.rbtnComma.Text = "逗号分隔";
            this.rbtnComma.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.ImportTableDemo;
            this.pictureBox2.Location = new System.Drawing.Point(171, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(355, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbxTableFrame
            // 
            this.lbxTableFrame.FormattingEnabled = true;
            this.lbxTableFrame.ItemHeight = 12;
            this.lbxTableFrame.Location = new System.Drawing.Point(3, 18);
            this.lbxTableFrame.Name = "lbxTableFrame";
            this.lbxTableFrame.Size = new System.Drawing.Size(159, 124);
            this.lbxTableFrame.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(361, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(442, 119);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // cbxFilterContent
            // 
            this.cbxFilterContent.AutoSize = true;
            this.cbxFilterContent.Location = new System.Drawing.Point(170, 68);
            this.cbxFilterContent.Name = "cbxFilterContent";
            this.cbxFilterContent.Size = new System.Drawing.Size(96, 16);
            this.cbxFilterContent.TabIndex = 14;
            this.cbxFilterContent.Text = "过滤如下内容";
            this.cbxFilterContent.UseVisualStyleBackColor = true;
            // 
            // tbxFilterPrefix
            // 
            this.tbxFilterPrefix.Location = new System.Drawing.Point(289, 66);
            this.tbxFilterPrefix.Name = "tbxFilterPrefix";
            this.tbxFilterPrefix.Size = new System.Drawing.Size(41, 19);
            this.tbxFilterPrefix.TabIndex = 15;
            // 
            // lblSample
            // 
            this.lblSample.AutoSize = true;
            this.lblSample.ForeColor = System.Drawing.Color.Salmon;
            this.lblSample.Location = new System.Drawing.Point(420, 69);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(29, 12);
            this.lblSample.TabIndex = 16;
            this.lblSample.Text = "内容";
            // 
            // tbxSuffix
            // 
            this.tbxSuffix.Location = new System.Drawing.Point(373, 66);
            this.tbxSuffix.Name = "tbxSuffix";
            this.tbxSuffix.Size = new System.Drawing.Size(41, 19);
            this.tbxSuffix.TabIndex = 15;
            // 
            // lblFilterContent
            // 
            this.lblFilterContent.AutoSize = true;
            this.lblFilterContent.Location = new System.Drawing.Point(336, 69);
            this.lblFilterContent.Name = "lblFilterContent";
            this.lblFilterContent.Size = new System.Drawing.Size(29, 12);
            this.lblFilterContent.TabIndex = 16;
            this.lblFilterContent.Text = "内容";
            // 
            // cbxDataModel
            // 
            this.cbxDataModel.AutoSize = true;
            this.cbxDataModel.Location = new System.Drawing.Point(170, 93);
            this.cbxDataModel.Name = "cbxDataModel";
            this.cbxDataModel.Size = new System.Drawing.Size(96, 16);
            this.cbxDataModel.TabIndex = 17;
            this.cbxDataModel.Text = "包含多项属性";
            this.cbxDataModel.UseVisualStyleBackColor = true;
            // 
            // tbxDataModel
            // 
            this.tbxDataModel.Location = new System.Drawing.Point(289, 91);
            this.tbxDataModel.Name = "tbxDataModel";
            this.tbxDataModel.Size = new System.Drawing.Size(125, 19);
            this.tbxDataModel.TabIndex = 18;
            // 
            // btnSetDataModel
            // 
            this.btnSetDataModel.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.hammer;
            this.btnSetDataModel.Location = new System.Drawing.Point(420, 89);
            this.btnSetDataModel.Name = "btnSetDataModel";
            this.btnSetDataModel.Size = new System.Drawing.Size(24, 23);
            this.btnSetDataModel.TabIndex = 19;
            this.btnSetDataModel.UseVisualStyleBackColor = true;
            // 
            // FormImportCardsSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 320);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormImportCardsSetting";
            this.Text = "FormImportCardsSetting";
            this.tabControl1.ResumeLayout(false);
            this.tpgInfoList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpgTable.ResumeLayout(false);
            this.gbxAddField.ResumeLayout(false);
            this.gbxAddField.PerformLayout();
            this.gbxSplitType.ResumeLayout(false);
            this.gbxSplitType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpgInfoList;
        private System.Windows.Forms.TabPage tpgTable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbxSplitType;
        private System.Windows.Forms.RadioButton rbtnTab;
        private System.Windows.Forms.RadioButton rbtnComma;
        private System.Windows.Forms.TextBox tbxOtherSplitString;
        private System.Windows.Forms.RadioButton tbtnOther;
        private System.Windows.Forms.RadioButton rbtnSpace;
        private System.Windows.Forms.Label lblFieldIndex;
        private System.Windows.Forms.TextBox tbxFieldIndex;
        private System.Windows.Forms.GroupBox gbxAddField;
        private System.Windows.Forms.ComboBox cbxCardProperties;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Button btnNewModel;
        private System.Windows.Forms.Button btnDeleteModel;
        private System.Windows.Forms.ListBox lbxTableFrame;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbxFilterContent;
        private System.Windows.Forms.TextBox tbxFilterPrefix;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.Label lblFilterContent;
        private System.Windows.Forms.TextBox tbxSuffix;
        private System.Windows.Forms.Button btnSetDataModel;
        private System.Windows.Forms.TextBox tbxDataModel;
        private System.Windows.Forms.CheckBox cbxDataModel;
    }
}