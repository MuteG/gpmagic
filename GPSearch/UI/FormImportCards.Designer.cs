namespace GPSoft.Games.GPMagic.GPSearch.UI
{
    partial class FormImportCards
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportCards));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvCardList = new System.Windows.Forms.DataGridView();
            this.dgvColExpansions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCNName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColENName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxOverwrite = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnNewModel = new System.Windows.Forms.Button();
            this.btnEditModel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择模板";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "导入文件";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 19);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Image = global::GPSoft.Games.GPMagic.GPSearch.Properties.Resources.find;
            this.button1.Location = new System.Drawing.Point(348, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvCardList
            // 
            this.dgvCardList.AllowUserToAddRows = false;
            this.dgvCardList.AllowUserToDeleteRows = false;
            this.dgvCardList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCardList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCardList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvColENName});
            this.dgvCardList.Location = new System.Drawing.Point(11, 120);
            this.dgvCardList.Name = "dgvCardList";
            this.dgvCardList.ReadOnly = true;
            this.dgvCardList.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCardList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCardList.RowTemplate.Height = 20;
            this.dgvCardList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCardList.Size = new System.Drawing.Size(361, 146);
            this.dgvCardList.TabIndex = 5;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxOverwrite);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(14, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 48);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "补充现有数据";
            // 
            // cbxOverwrite
            // 
            this.cbxOverwrite.AutoSize = true;
            this.cbxOverwrite.Location = new System.Drawing.Point(188, 23);
            this.cbxOverwrite.Name = "cbxOverwrite";
            this.cbxOverwrite.Size = new System.Drawing.Size(120, 16);
            this.cbxOverwrite.TabIndex = 3;
            this.cbxOverwrite.Text = "是否覆盖既存数据";
            this.cbxOverwrite.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(53, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "关联项";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "补充现有数据";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "系列";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(292, 12);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(80, 20);
            this.comboBox3.TabIndex = 8;
            // 
            // btnNewModel
            // 
            this.btnNewModel.Image = global::GPSoft.Games.GPMagic.GPSearch.Properties.Resources.plus1;
            this.btnNewModel.Location = new System.Drawing.Point(195, 11);
            this.btnNewModel.Name = "btnNewModel";
            this.btnNewModel.Size = new System.Drawing.Size(24, 23);
            this.btnNewModel.TabIndex = 9;
            this.btnNewModel.UseVisualStyleBackColor = true;
            // 
            // btnEditModel
            // 
            this.btnEditModel.Image = global::GPSoft.Games.GPMagic.GPSearch.Properties.Resources.pencil_tool1;
            this.btnEditModel.Location = new System.Drawing.Point(225, 11);
            this.btnEditModel.Name = "btnEditModel";
            this.btnEditModel.Size = new System.Drawing.Size(24, 23);
            this.btnEditModel.TabIndex = 9;
            this.btnEditModel.UseVisualStyleBackColor = true;
            // 
            // FormImportCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 277);
            this.Controls.Add(this.btnEditModel);
            this.Controls.Add(this.btnNewModel);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCardList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImportCards";
            this.Text = "FormImportCards";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgvCardList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColExpansions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCNName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColENName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btnNewModel;
        private System.Windows.Forms.Button btnEditModel;
        private System.Windows.Forms.CheckBox cbxOverwrite;
    }
}