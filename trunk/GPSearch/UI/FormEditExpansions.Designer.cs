namespace GPSoft.GPMagic.GPSearch.UI
{
    partial class FormEditExpansions
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
            this.lblExpansions = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lvwExpansionsList = new System.Windows.Forms.ListView();
            this.btnEditExpansions = new System.Windows.Forms.Button();
            this.btnNewExpansions = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnEditPlayFormats = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbxPlayFormats = new System.Windows.Forms.ComboBox();
            this.lblPlayFormats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExpansions
            // 
            this.lblExpansions.AutoSize = true;
            this.lblExpansions.Location = new System.Drawing.Point(12, 41);
            this.lblExpansions.Name = "lblExpansions";
            this.lblExpansions.Size = new System.Drawing.Size(29, 12);
            this.lblExpansions.TabIndex = 0;
            this.lblExpansions.Text = "系列";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(47, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // lvwExpansionsList
            // 
            this.lvwExpansionsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwExpansionsList.CheckBoxes = true;
            this.lvwExpansionsList.Location = new System.Drawing.Point(14, 208);
            this.lvwExpansionsList.Name = "lvwExpansionsList";
            this.lvwExpansionsList.Size = new System.Drawing.Size(498, 152);
            this.lvwExpansionsList.TabIndex = 2;
            this.lvwExpansionsList.UseCompatibleStateImageBehavior = false;
            // 
            // btnEditExpansions
            // 
            this.btnEditExpansions.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.pencil_tool1;
            this.btnEditExpansions.Location = new System.Drawing.Point(204, 37);
            this.btnEditExpansions.Name = "btnEditExpansions";
            this.btnEditExpansions.Size = new System.Drawing.Size(24, 23);
            this.btnEditExpansions.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnEditExpansions, "编辑");
            this.btnEditExpansions.UseVisualStyleBackColor = true;
            // 
            // btnNewExpansions
            // 
            this.btnNewExpansions.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.plus1;
            this.btnNewExpansions.Location = new System.Drawing.Point(174, 37);
            this.btnNewExpansions.Name = "btnNewExpansions";
            this.btnNewExpansions.Size = new System.Drawing.Size(24, 23);
            this.btnNewExpansions.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnNewExpansions, "新建");
            this.btnNewExpansions.UseVisualStyleBackColor = true;
            // 
            // btnEditPlayFormats
            // 
            this.btnEditPlayFormats.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.pencil_tool1;
            this.btnEditPlayFormats.Location = new System.Drawing.Point(174, 11);
            this.btnEditPlayFormats.Name = "btnEditPlayFormats";
            this.btnEditPlayFormats.Size = new System.Drawing.Size(24, 23);
            this.btnEditPlayFormats.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnEditPlayFormats, "编辑");
            this.btnEditPlayFormats.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.ok;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(456, 366);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "确认";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // cbxPlayFormats
            // 
            this.cbxPlayFormats.FormattingEnabled = true;
            this.cbxPlayFormats.Location = new System.Drawing.Point(47, 12);
            this.cbxPlayFormats.Name = "cbxPlayFormats";
            this.cbxPlayFormats.Size = new System.Drawing.Size(121, 20);
            this.cbxPlayFormats.TabIndex = 14;
            // 
            // lblPlayFormats
            // 
            this.lblPlayFormats.AutoSize = true;
            this.lblPlayFormats.Location = new System.Drawing.Point(12, 15);
            this.lblPlayFormats.Name = "lblPlayFormats";
            this.lblPlayFormats.Size = new System.Drawing.Size(29, 12);
            this.lblPlayFormats.TabIndex = 13;
            this.lblPlayFormats.Text = "赛制";
            // 
            // FormEditExpansions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 399);
            this.Controls.Add(this.btnEditPlayFormats);
            this.Controls.Add(this.cbxPlayFormats);
            this.Controls.Add(this.lblPlayFormats);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnEditExpansions);
            this.Controls.Add(this.btnNewExpansions);
            this.Controls.Add(this.lvwExpansionsList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblExpansions);
            this.Name = "FormEditExpansions";
            this.Text = "FormAddExpansions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpansions;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView lvwExpansionsList;
        private System.Windows.Forms.Button btnEditExpansions;
        private System.Windows.Forms.Button btnNewExpansions;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnEditPlayFormats;
        private System.Windows.Forms.ComboBox cbxPlayFormats;
        private System.Windows.Forms.Label lblPlayFormats;
    }
}