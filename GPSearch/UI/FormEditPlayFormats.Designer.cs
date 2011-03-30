namespace GPSoft.Games.GPMagic.GPSearch.UI
{
    partial class FormEditPlayFormats
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditPlayFormats));
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbxPlayFormats = new System.Windows.Forms.ComboBox();
            this.lblPlayFormats = new System.Windows.Forms.Label();
            this.dgvDeckList = new System.Windows.Forms.DataGridView();
            this.colDCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDCardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDCost = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeckList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Image = global::GPSoft.Games.GPMagic.GPSearch.Properties.Resources.plus1;
            this.btnNew.Location = new System.Drawing.Point(176, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(24, 23);
            this.btnNew.TabIndex = 14;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::GPSoft.Games.GPMagic.GPSearch.Properties.Resources.pencil_tool1;
            this.btnEdit.Location = new System.Drawing.Point(206, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(24, 23);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // cbxPlayFormats
            // 
            this.cbxPlayFormats.FormattingEnabled = true;
            this.cbxPlayFormats.Location = new System.Drawing.Point(49, 12);
            this.cbxPlayFormats.Name = "cbxPlayFormats";
            this.cbxPlayFormats.Size = new System.Drawing.Size(121, 20);
            this.cbxPlayFormats.TabIndex = 18;
            // 
            // lblPlayFormats
            // 
            this.lblPlayFormats.AutoSize = true;
            this.lblPlayFormats.Location = new System.Drawing.Point(14, 15);
            this.lblPlayFormats.Name = "lblPlayFormats";
            this.lblPlayFormats.Size = new System.Drawing.Size(29, 12);
            this.lblPlayFormats.TabIndex = 17;
            this.lblPlayFormats.Text = "赛制";
            // 
            // dgvDeckList
            // 
            this.dgvDeckList.AllowDrop = true;
            this.dgvDeckList.AllowUserToAddRows = false;
            this.dgvDeckList.AllowUserToDeleteRows = false;
            this.dgvDeckList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dgvDeckList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeckList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeckList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeckList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeckList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDCount,
            this.colDSymbol,
            this.colDCardName,
            this.colDCost});
            this.dgvDeckList.Location = new System.Drawing.Point(12, 137);
            this.dgvDeckList.Name = "dgvDeckList";
            this.dgvDeckList.ReadOnly = true;
            this.dgvDeckList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvDeckList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDeckList.RowTemplate.Height = 23;
            this.dgvDeckList.Size = new System.Drawing.Size(372, 128);
            this.dgvDeckList.TabIndex = 20;
            // 
            // colDCount
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colDCount.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            this.colDCost.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDCost.HeaderText = "费用";
            this.colDCost.Name = "colDCost";
            this.colDCost.ReadOnly = true;
            this.colDCost.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 23;
            // 
            // FormEditPlayFormats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 291);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDeckList);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbxPlayFormats);
            this.Controls.Add(this.lblPlayFormats);
            this.Controls.Add(this.btnNew);
            this.Name = "FormEditPlayFormats";
            this.Text = "FormEditPlayFormats";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeckList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbxPlayFormats;
        private System.Windows.Forms.Label lblPlayFormats;
        private System.Windows.Forms.DataGridView dgvDeckList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDCardName;
        private System.Windows.Forms.DataGridViewImageColumn colDCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}