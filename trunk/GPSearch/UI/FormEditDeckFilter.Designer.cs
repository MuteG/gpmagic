﻿namespace GPSoft.GPMagic.GPSearch.UI
{
    partial class FormEditDeckFilter
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
            this.lbxFilterList = new System.Windows.Forms.ListBox();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.cbxFieldName = new System.Windows.Forms.ComboBox();
            this.lblFieldValue = new System.Windows.Forms.Label();
            this.tbxFieldValue = new System.Windows.Forms.TextBox();
            this.btnFieldValue = new System.Windows.Forms.Button();
            this.cbxIsReverse = new System.Windows.Forms.CheckBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.tbxDisplayName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxIsShow = new System.Windows.Forms.CheckBox();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pbxBackgroundColor = new System.Windows.Forms.PictureBox();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxFieldSetting = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackgroundColor)).BeginInit();
            this.gbxFieldSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxFilterList
            // 
            this.lbxFilterList.FormattingEnabled = true;
            this.lbxFilterList.ItemHeight = 12;
            this.lbxFilterList.Location = new System.Drawing.Point(12, 12);
            this.lbxFilterList.Name = "lbxFilterList";
            this.lbxFilterList.Size = new System.Drawing.Size(97, 172);
            this.lbxFilterList.TabIndex = 0;
            this.lbxFilterList.SelectedIndexChanged += new System.EventHandler(this.lbxFilterList_SelectedIndexChanged);
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Location = new System.Drawing.Point(6, 19);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(53, 12);
            this.lblFieldName.TabIndex = 1;
            this.lblFieldName.Text = "统计对象";
            this.toolTip1.SetToolTip(this.lblFieldName, "在此对象上根据制定的条件进行统计，符合条件的数据总数作为统计结果");
            // 
            // cbxFieldName
            // 
            this.cbxFieldName.FormattingEnabled = true;
            this.cbxFieldName.Items.AddRange(new object[] {
            "卡牌类别",
            "卡牌子类别"});
            this.cbxFieldName.Location = new System.Drawing.Point(65, 16);
            this.cbxFieldName.Name = "cbxFieldName";
            this.cbxFieldName.Size = new System.Drawing.Size(121, 20);
            this.cbxFieldName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbxFieldName, "在此对象上根据制定的条件进行统计，符合条件的数据总数作为统计结果");
            // 
            // lblFieldValue
            // 
            this.lblFieldValue.AutoSize = true;
            this.lblFieldValue.Location = new System.Drawing.Point(6, 45);
            this.lblFieldValue.Name = "lblFieldValue";
            this.lblFieldValue.Size = new System.Drawing.Size(53, 12);
            this.lblFieldValue.TabIndex = 3;
            this.lblFieldValue.Text = "对象取值";
            this.toolTip1.SetToolTip(this.lblFieldValue, "统计对象的值符合设定的取值时，对这样的数据进行技术统计，并作为统计结果");
            // 
            // tbxFieldValue
            // 
            this.tbxFieldValue.Location = new System.Drawing.Point(65, 42);
            this.tbxFieldValue.Name = "tbxFieldValue";
            this.tbxFieldValue.Size = new System.Drawing.Size(91, 19);
            this.tbxFieldValue.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbxFieldValue, "统计对象的值符合设定的取值时，对这样的数据进行技术统计，并作为统计结果");
            // 
            // btnFieldValue
            // 
            this.btnFieldValue.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.config;
            this.btnFieldValue.Location = new System.Drawing.Point(162, 39);
            this.btnFieldValue.Name = "btnFieldValue";
            this.btnFieldValue.Size = new System.Drawing.Size(24, 24);
            this.btnFieldValue.TabIndex = 5;
            this.btnFieldValue.UseVisualStyleBackColor = true;
            // 
            // cbxIsReverse
            // 
            this.cbxIsReverse.AutoSize = true;
            this.cbxIsReverse.Location = new System.Drawing.Point(8, 67);
            this.cbxIsReverse.Name = "cbxIsReverse";
            this.cbxIsReverse.Size = new System.Drawing.Size(72, 16);
            this.cbxIsReverse.TabIndex = 6;
            this.cbxIsReverse.Text = "反向统计";
            this.toolTip1.SetToolTip(this.cbxIsReverse, "将上面设置好的条件以外的数据作为统计对新爱国");
            this.cbxIsReverse.UseVisualStyleBackColor = true;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(115, 15);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(65, 12);
            this.lblDisplayName.TabIndex = 7;
            this.lblDisplayName.Text = "统计项名称";
            // 
            // tbxDisplayName
            // 
            this.tbxDisplayName.Location = new System.Drawing.Point(186, 12);
            this.tbxDisplayName.Name = "tbxDisplayName";
            this.tbxDisplayName.Size = new System.Drawing.Size(50, 19);
            this.tbxDisplayName.TabIndex = 8;
            this.toolTip1.SetToolTip(this.tbxDisplayName, "建议使用简短的名称（比如：生物）");
            // 
            // cbxIsShow
            // 
            this.cbxIsShow.AutoSize = true;
            this.cbxIsShow.Location = new System.Drawing.Point(243, 14);
            this.cbxIsShow.Name = "cbxIsShow";
            this.cbxIsShow.Size = new System.Drawing.Size(72, 16);
            this.cbxIsShow.TabIndex = 9;
            this.cbxIsShow.Text = "是否显示";
            this.cbxIsShow.UseVisualStyleBackColor = true;
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Location = new System.Drawing.Point(115, 139);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(41, 12);
            this.lblBackgroundColor.TabIndex = 10;
            this.lblBackgroundColor.Text = "背景色";
            this.toolTip1.SetToolTip(this.lblBackgroundColor, "套牌列表中数据行的背景色");
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // pbxBackgroundColor
            // 
            this.pbxBackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxBackgroundColor.Location = new System.Drawing.Point(162, 134);
            this.pbxBackgroundColor.Name = "pbxBackgroundColor";
            this.pbxBackgroundColor.Size = new System.Drawing.Size(123, 23);
            this.pbxBackgroundColor.TabIndex = 11;
            this.pbxBackgroundColor.TabStop = false;
            this.toolTip1.SetToolTip(this.pbxBackgroundColor, "套牌列表中数据行的背景色");
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.select_color;
            this.btnBackgroundColor.Location = new System.Drawing.Point(291, 134);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(24, 24);
            this.btnBackgroundColor.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnBackgroundColor, "套牌列表中数据行的背景色");
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(159, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(240, 164);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbxFieldSetting
            // 
            this.gbxFieldSetting.Controls.Add(this.lblFieldName);
            this.gbxFieldSetting.Controls.Add(this.cbxFieldName);
            this.gbxFieldSetting.Controls.Add(this.lblFieldValue);
            this.gbxFieldSetting.Controls.Add(this.tbxFieldValue);
            this.gbxFieldSetting.Controls.Add(this.btnFieldValue);
            this.gbxFieldSetting.Controls.Add(this.cbxIsReverse);
            this.gbxFieldSetting.Location = new System.Drawing.Point(115, 37);
            this.gbxFieldSetting.Name = "gbxFieldSetting";
            this.gbxFieldSetting.Size = new System.Drawing.Size(200, 91);
            this.gbxFieldSetting.TabIndex = 15;
            this.gbxFieldSetting.TabStop = false;
            this.gbxFieldSetting.Text = "统计对象设置";
            // 
            // FormEditDeckFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 197);
            this.Controls.Add(this.gbxFieldSetting);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBackgroundColor);
            this.Controls.Add(this.pbxBackgroundColor);
            this.Controls.Add(this.lblBackgroundColor);
            this.Controls.Add(this.cbxIsShow);
            this.Controls.Add(this.tbxDisplayName);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.lbxFilterList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditDeckFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置套牌列表统计项";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackgroundColor)).EndInit();
            this.gbxFieldSetting.ResumeLayout(false);
            this.gbxFieldSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxFilterList;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.ComboBox cbxFieldName;
        private System.Windows.Forms.Label lblFieldValue;
        private System.Windows.Forms.TextBox tbxFieldValue;
        private System.Windows.Forms.Button btnFieldValue;
        private System.Windows.Forms.CheckBox cbxIsReverse;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.TextBox tbxDisplayName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cbxIsShow;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pbxBackgroundColor;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbxFieldSetting;
    }
}