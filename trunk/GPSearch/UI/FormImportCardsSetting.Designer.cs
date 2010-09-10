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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportCardsSetting));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpgInfoList = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpgTable = new System.Windows.Forms.TabPage();
            this.gbxTableModeStructure = new System.Windows.Forms.GroupBox();
            this.btnSetDataModel = new System.Windows.Forms.Button();
            this.tbxDataModel = new System.Windows.Forms.TextBox();
            this.chkDataModel = new System.Windows.Forms.CheckBox();
            this.lblFilterContent = new System.Windows.Forms.Label();
            this.lblSample = new System.Windows.Forms.Label();
            this.tbxSuffix = new System.Windows.Forms.TextBox();
            this.tbxFilterPrefix = new System.Windows.Forms.TextBox();
            this.chkFilterContent = new System.Windows.Forms.CheckBox();
            this.btnTableModeClose = new System.Windows.Forms.Button();
            this.btnTableModeSave = new System.Windows.Forms.Button();
            this.lbxTableModeCardProperties = new System.Windows.Forms.ListBox();
            this.btnDelTableModeStructure = new System.Windows.Forms.Button();
            this.btnAddTableModeStructure = new System.Windows.Forms.Button();
            this.cbxTableModePropertyName = new System.Windows.Forms.ComboBox();
            this.lblTableModePropertyName = new System.Windows.Forms.Label();
            this.lblStructureIndex = new System.Windows.Forms.Label();
            this.tbxStructureIndex = new System.Windows.Forms.TextBox();
            this.gbxSplitType = new System.Windows.Forms.GroupBox();
            this.tbxOtherSplitString = new System.Windows.Forms.TextBox();
            this.tbtnOther = new System.Windows.Forms.RadioButton();
            this.rbtnSpace = new System.Windows.Forms.RadioButton();
            this.rbtnTab = new System.Windows.Forms.RadioButton();
            this.rbtnComma = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbxListModeStructure = new System.Windows.Forms.GroupBox();
            this.lbxListModeCardProperties = new System.Windows.Forms.ListBox();
            this.btnDelListModeStructure = new System.Windows.Forms.Button();
            this.btnAddListModeStructure = new System.Windows.Forms.Button();
            this.cbxListModeCardPropertyName = new System.Windows.Forms.ComboBox();
            this.lblListModeCardPropertyName = new System.Windows.Forms.Label();
            this.lblPropertyDisplayText = new System.Windows.Forms.Label();
            this.tbxPropertyDisplayText = new System.Windows.Forms.TextBox();
            this.btnListModeClose = new System.Windows.Forms.Button();
            this.btnListModeSave = new System.Windows.Forms.Button();
            this.mnuImportStracture = new System.Windows.Forms.MenuStrip();
            this.模板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemNewModel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemOpenModel = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tpgInfoList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpgTable.SuspendLayout();
            this.gbxTableModeStructure.SuspendLayout();
            this.gbxSplitType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbxListModeStructure.SuspendLayout();
            this.mnuImportStracture.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpgInfoList);
            this.tabControl1.Controls.Add(this.tpgTable);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tpgInfoList
            // 
            this.tpgInfoList.Controls.Add(this.btnListModeClose);
            this.tpgInfoList.Controls.Add(this.btnListModeSave);
            this.tpgInfoList.Controls.Add(this.lblPropertyDisplayText);
            this.tpgInfoList.Controls.Add(this.tbxPropertyDisplayText);
            this.tpgInfoList.Controls.Add(this.btnDelListModeStructure);
            this.tpgInfoList.Controls.Add(this.btnAddListModeStructure);
            this.tpgInfoList.Controls.Add(this.cbxListModeCardPropertyName);
            this.tpgInfoList.Controls.Add(this.lblListModeCardPropertyName);
            this.tpgInfoList.Controls.Add(this.gbxListModeStructure);
            this.tpgInfoList.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.tpgInfoList, "tpgInfoList");
            this.tpgInfoList.Name = "tpgInfoList";
            this.tpgInfoList.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.ImportInfoListDemo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // tpgTable
            // 
            this.tpgTable.Controls.Add(this.gbxTableModeStructure);
            this.tpgTable.Controls.Add(this.gbxSplitType);
            this.tpgTable.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.tpgTable, "tpgTable");
            this.tpgTable.Name = "tpgTable";
            this.tpgTable.UseVisualStyleBackColor = true;
            // 
            // gbxTableModeStructure
            // 
            this.gbxTableModeStructure.Controls.Add(this.btnSetDataModel);
            this.gbxTableModeStructure.Controls.Add(this.tbxDataModel);
            this.gbxTableModeStructure.Controls.Add(this.chkDataModel);
            this.gbxTableModeStructure.Controls.Add(this.lblFilterContent);
            this.gbxTableModeStructure.Controls.Add(this.lblSample);
            this.gbxTableModeStructure.Controls.Add(this.tbxSuffix);
            this.gbxTableModeStructure.Controls.Add(this.tbxFilterPrefix);
            this.gbxTableModeStructure.Controls.Add(this.chkFilterContent);
            this.gbxTableModeStructure.Controls.Add(this.btnTableModeClose);
            this.gbxTableModeStructure.Controls.Add(this.btnTableModeSave);
            this.gbxTableModeStructure.Controls.Add(this.lbxTableModeCardProperties);
            this.gbxTableModeStructure.Controls.Add(this.btnDelTableModeStructure);
            this.gbxTableModeStructure.Controls.Add(this.btnAddTableModeStructure);
            this.gbxTableModeStructure.Controls.Add(this.cbxTableModePropertyName);
            this.gbxTableModeStructure.Controls.Add(this.lblTableModePropertyName);
            this.gbxTableModeStructure.Controls.Add(this.lblStructureIndex);
            this.gbxTableModeStructure.Controls.Add(this.tbxStructureIndex);
            resources.ApplyResources(this.gbxTableModeStructure, "gbxTableModeStructure");
            this.gbxTableModeStructure.Name = "gbxTableModeStructure";
            this.gbxTableModeStructure.TabStop = false;
            // 
            // btnSetDataModel
            // 
            this.btnSetDataModel.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.hammer;
            resources.ApplyResources(this.btnSetDataModel, "btnSetDataModel");
            this.btnSetDataModel.Name = "btnSetDataModel";
            this.btnSetDataModel.UseVisualStyleBackColor = true;
            // 
            // tbxDataModel
            // 
            resources.ApplyResources(this.tbxDataModel, "tbxDataModel");
            this.tbxDataModel.Name = "tbxDataModel";
            // 
            // chkDataModel
            // 
            resources.ApplyResources(this.chkDataModel, "chkDataModel");
            this.chkDataModel.Name = "chkDataModel";
            this.chkDataModel.UseVisualStyleBackColor = true;
            // 
            // lblFilterContent
            // 
            resources.ApplyResources(this.lblFilterContent, "lblFilterContent");
            this.lblFilterContent.Name = "lblFilterContent";
            // 
            // lblSample
            // 
            resources.ApplyResources(this.lblSample, "lblSample");
            this.lblSample.ForeColor = System.Drawing.Color.Salmon;
            this.lblSample.Name = "lblSample";
            // 
            // tbxSuffix
            // 
            resources.ApplyResources(this.tbxSuffix, "tbxSuffix");
            this.tbxSuffix.Name = "tbxSuffix";
            // 
            // tbxFilterPrefix
            // 
            resources.ApplyResources(this.tbxFilterPrefix, "tbxFilterPrefix");
            this.tbxFilterPrefix.Name = "tbxFilterPrefix";
            // 
            // chkFilterContent
            // 
            resources.ApplyResources(this.chkFilterContent, "chkFilterContent");
            this.chkFilterContent.Name = "chkFilterContent";
            this.chkFilterContent.UseVisualStyleBackColor = true;
            // 
            // btnTableModeClose
            // 
            resources.ApplyResources(this.btnTableModeClose, "btnTableModeClose");
            this.btnTableModeClose.Name = "btnTableModeClose";
            this.btnTableModeClose.UseVisualStyleBackColor = true;
            // 
            // btnTableModeSave
            // 
            resources.ApplyResources(this.btnTableModeSave, "btnTableModeSave");
            this.btnTableModeSave.Name = "btnTableModeSave";
            this.btnTableModeSave.UseVisualStyleBackColor = true;
            // 
            // lbxTableModeCardProperties
            // 
            this.lbxTableModeCardProperties.FormattingEnabled = true;
            resources.ApplyResources(this.lbxTableModeCardProperties, "lbxTableModeCardProperties");
            this.lbxTableModeCardProperties.Name = "lbxTableModeCardProperties";
            // 
            // btnDelTableModeStructure
            // 
            this.btnDelTableModeStructure.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.Delete;
            resources.ApplyResources(this.btnDelTableModeStructure, "btnDelTableModeStructure");
            this.btnDelTableModeStructure.Name = "btnDelTableModeStructure";
            this.btnDelTableModeStructure.UseVisualStyleBackColor = true;
            // 
            // btnAddTableModeStructure
            // 
            this.btnAddTableModeStructure.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.Add;
            resources.ApplyResources(this.btnAddTableModeStructure, "btnAddTableModeStructure");
            this.btnAddTableModeStructure.Name = "btnAddTableModeStructure";
            this.btnAddTableModeStructure.UseVisualStyleBackColor = true;
            // 
            // cbxTableModePropertyName
            // 
            this.cbxTableModePropertyName.FormattingEnabled = true;
            resources.ApplyResources(this.cbxTableModePropertyName, "cbxTableModePropertyName");
            this.cbxTableModePropertyName.Name = "cbxTableModePropertyName";
            // 
            // lblTableModePropertyName
            // 
            resources.ApplyResources(this.lblTableModePropertyName, "lblTableModePropertyName");
            this.lblTableModePropertyName.Name = "lblTableModePropertyName";
            // 
            // lblStructureIndex
            // 
            resources.ApplyResources(this.lblStructureIndex, "lblStructureIndex");
            this.lblStructureIndex.Name = "lblStructureIndex";
            // 
            // tbxStructureIndex
            // 
            resources.ApplyResources(this.tbxStructureIndex, "tbxStructureIndex");
            this.tbxStructureIndex.Name = "tbxStructureIndex";
            // 
            // gbxSplitType
            // 
            this.gbxSplitType.Controls.Add(this.tbxOtherSplitString);
            this.gbxSplitType.Controls.Add(this.tbtnOther);
            this.gbxSplitType.Controls.Add(this.rbtnSpace);
            this.gbxSplitType.Controls.Add(this.rbtnTab);
            this.gbxSplitType.Controls.Add(this.rbtnComma);
            resources.ApplyResources(this.gbxSplitType, "gbxSplitType");
            this.gbxSplitType.Name = "gbxSplitType";
            this.gbxSplitType.TabStop = false;
            // 
            // tbxOtherSplitString
            // 
            resources.ApplyResources(this.tbxOtherSplitString, "tbxOtherSplitString");
            this.tbxOtherSplitString.Name = "tbxOtherSplitString";
            // 
            // tbtnOther
            // 
            resources.ApplyResources(this.tbtnOther, "tbtnOther");
            this.tbtnOther.Name = "tbtnOther";
            this.tbtnOther.TabStop = true;
            this.tbtnOther.UseVisualStyleBackColor = true;
            // 
            // rbtnSpace
            // 
            resources.ApplyResources(this.rbtnSpace, "rbtnSpace");
            this.rbtnSpace.Name = "rbtnSpace";
            this.rbtnSpace.TabStop = true;
            this.rbtnSpace.UseVisualStyleBackColor = true;
            // 
            // rbtnTab
            // 
            resources.ApplyResources(this.rbtnTab, "rbtnTab");
            this.rbtnTab.Name = "rbtnTab";
            this.rbtnTab.TabStop = true;
            this.rbtnTab.UseVisualStyleBackColor = true;
            // 
            // rbtnComma
            // 
            resources.ApplyResources(this.rbtnComma, "rbtnComma");
            this.rbtnComma.Name = "rbtnComma";
            this.rbtnComma.TabStop = true;
            this.rbtnComma.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.ImportTableDemo;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // gbxListModeStructure
            // 
            this.gbxListModeStructure.Controls.Add(this.lbxListModeCardProperties);
            resources.ApplyResources(this.gbxListModeStructure, "gbxListModeStructure");
            this.gbxListModeStructure.Name = "gbxListModeStructure";
            this.gbxListModeStructure.TabStop = false;
            // 
            // lbxListModeCardProperties
            // 
            this.lbxListModeCardProperties.FormattingEnabled = true;
            resources.ApplyResources(this.lbxListModeCardProperties, "lbxListModeCardProperties");
            this.lbxListModeCardProperties.Name = "lbxListModeCardProperties";
            // 
            // btnDelListModeStructure
            // 
            this.btnDelListModeStructure.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.Delete;
            resources.ApplyResources(this.btnDelListModeStructure, "btnDelListModeStructure");
            this.btnDelListModeStructure.Name = "btnDelListModeStructure";
            this.btnDelListModeStructure.UseVisualStyleBackColor = true;
            // 
            // btnAddListModeStructure
            // 
            this.btnAddListModeStructure.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.Add;
            resources.ApplyResources(this.btnAddListModeStructure, "btnAddListModeStructure");
            this.btnAddListModeStructure.Name = "btnAddListModeStructure";
            this.btnAddListModeStructure.UseVisualStyleBackColor = true;
            // 
            // cbxListModeCardPropertyName
            // 
            this.cbxListModeCardPropertyName.FormattingEnabled = true;
            resources.ApplyResources(this.cbxListModeCardPropertyName, "cbxListModeCardPropertyName");
            this.cbxListModeCardPropertyName.Name = "cbxListModeCardPropertyName";
            // 
            // lblListModeCardPropertyName
            // 
            resources.ApplyResources(this.lblListModeCardPropertyName, "lblListModeCardPropertyName");
            this.lblListModeCardPropertyName.Name = "lblListModeCardPropertyName";
            // 
            // lblPropertyDisplayText
            // 
            resources.ApplyResources(this.lblPropertyDisplayText, "lblPropertyDisplayText");
            this.lblPropertyDisplayText.Name = "lblPropertyDisplayText";
            // 
            // tbxPropertyDisplayText
            // 
            resources.ApplyResources(this.tbxPropertyDisplayText, "tbxPropertyDisplayText");
            this.tbxPropertyDisplayText.Name = "tbxPropertyDisplayText";
            // 
            // btnListModeClose
            // 
            resources.ApplyResources(this.btnListModeClose, "btnListModeClose");
            this.btnListModeClose.Name = "btnListModeClose";
            this.btnListModeClose.UseVisualStyleBackColor = true;
            // 
            // btnListModeSave
            // 
            resources.ApplyResources(this.btnListModeSave, "btnListModeSave");
            this.btnListModeSave.Name = "btnListModeSave";
            this.btnListModeSave.UseVisualStyleBackColor = true;
            // 
            // mnuImportStracture
            // 
            this.mnuImportStracture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.模板ToolStripMenuItem});
            resources.ApplyResources(this.mnuImportStracture, "mnuImportStracture");
            this.mnuImportStracture.Name = "mnuImportStracture";
            this.mnuImportStracture.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // 模板ToolStripMenuItem
            // 
            this.模板ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemNewModel,
            this.mnuItemOpenModel});
            this.模板ToolStripMenuItem.Name = "模板ToolStripMenuItem";
            resources.ApplyResources(this.模板ToolStripMenuItem, "模板ToolStripMenuItem");
            // 
            // mnuItemNewModel
            // 
            this.mnuItemNewModel.Name = "mnuItemNewModel";
            resources.ApplyResources(this.mnuItemNewModel, "mnuItemNewModel");
            // 
            // mnuItemOpenModel
            // 
            this.mnuItemOpenModel.Name = "mnuItemOpenModel";
            resources.ApplyResources(this.mnuItemOpenModel, "mnuItemOpenModel");
            // 
            // FormImportCardsSetting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mnuImportStracture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuImportStracture;
            this.MaximizeBox = false;
            this.Name = "FormImportCardsSetting";
            this.tabControl1.ResumeLayout(false);
            this.tpgInfoList.ResumeLayout(false);
            this.tpgInfoList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpgTable.ResumeLayout(false);
            this.gbxTableModeStructure.ResumeLayout(false);
            this.gbxTableModeStructure.PerformLayout();
            this.gbxSplitType.ResumeLayout(false);
            this.gbxSplitType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbxListModeStructure.ResumeLayout(false);
            this.mnuImportStracture.ResumeLayout(false);
            this.mnuImportStracture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblStructureIndex;
        private System.Windows.Forms.TextBox tbxStructureIndex;
        private System.Windows.Forms.GroupBox gbxTableModeStructure;
        private System.Windows.Forms.ComboBox cbxTableModePropertyName;
        private System.Windows.Forms.Label lblTableModePropertyName;
        private System.Windows.Forms.Button btnAddTableModeStructure;
        private System.Windows.Forms.Button btnDelTableModeStructure;
        private System.Windows.Forms.ListBox lbxTableModeCardProperties;
        private System.Windows.Forms.Button btnTableModeClose;
        private System.Windows.Forms.Button btnTableModeSave;
        private System.Windows.Forms.CheckBox chkFilterContent;
        private System.Windows.Forms.TextBox tbxFilterPrefix;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.Label lblFilterContent;
        private System.Windows.Forms.TextBox tbxSuffix;
        private System.Windows.Forms.Button btnSetDataModel;
        private System.Windows.Forms.TextBox tbxDataModel;
        private System.Windows.Forms.CheckBox chkDataModel;
        private System.Windows.Forms.GroupBox gbxListModeStructure;
        private System.Windows.Forms.ListBox lbxListModeCardProperties;
        private System.Windows.Forms.Label lblPropertyDisplayText;
        private System.Windows.Forms.TextBox tbxPropertyDisplayText;
        private System.Windows.Forms.Button btnDelListModeStructure;
        private System.Windows.Forms.Button btnAddListModeStructure;
        private System.Windows.Forms.ComboBox cbxListModeCardPropertyName;
        private System.Windows.Forms.Label lblListModeCardPropertyName;
        private System.Windows.Forms.Button btnListModeClose;
        private System.Windows.Forms.Button btnListModeSave;
        private System.Windows.Forms.MenuStrip mnuImportStracture;
        private System.Windows.Forms.ToolStripMenuItem 模板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemNewModel;
        private System.Windows.Forms.ToolStripMenuItem mnuItemOpenModel;
    }
}