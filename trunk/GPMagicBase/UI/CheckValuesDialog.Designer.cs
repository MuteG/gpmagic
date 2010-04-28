namespace GP.GPMagic.GPMagicBase.UI
{
    partial class CheckValuesDialog
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
            this.lvwValues = new System.Windows.Forms.ListView();
            this.colCheckBox = new System.Windows.Forms.ColumnHeader();
            this.colValues = new System.Windows.Forms.ColumnHeader();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlContnet = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlBottom.SuspendLayout();
            this.pnlContnet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwValues
            // 
            this.lvwValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwValues.CheckBoxes = true;
            this.lvwValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCheckBox,
            this.colValues});
            this.lvwValues.Location = new System.Drawing.Point(152, 0);
            this.lvwValues.Name = "lvwValues";
            this.lvwValues.Size = new System.Drawing.Size(154, 243);
            this.lvwValues.TabIndex = 0;
            this.lvwValues.UseCompatibleStateImageBehavior = false;
            this.lvwValues.View = System.Windows.Forms.View.Details;
            // 
            // colCheckBox
            // 
            this.colCheckBox.Text = "";
            this.colCheckBox.Width = 22;
            // 
            // colValues
            // 
            this.colValues.Width = 100;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBottom.Controls.Add(this.lvwValues);
            this.pnlBottom.Controls.Add(this.listView1);
            this.pnlBottom.Location = new System.Drawing.Point(0, 30);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(307, 243);
            this.pnlBottom.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(29, 12);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "查找";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(47, 5);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(166, 21);
            this.tbxSearch.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(219, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(138, 279);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlContnet
            // 
            this.pnlContnet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContnet.Controls.Add(this.btnSearch);
            this.pnlContnet.Controls.Add(this.lblSearch);
            this.pnlContnet.Controls.Add(this.tbxSearch);
            this.pnlContnet.Controls.Add(this.pnlBottom);
            this.pnlContnet.Location = new System.Drawing.Point(0, 0);
            this.pnlContnet.Name = "pnlContnet";
            this.pnlContnet.Size = new System.Drawing.Size(307, 273);
            this.pnlContnet.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(153, 243);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 120;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(219, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // CheckValuesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 308);
            this.Controls.Add(this.pnlContnet);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckValuesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CheckValuesDialog";
            this.pnlBottom.ResumeLayout(false);
            this.pnlContnet.ResumeLayout(false);
            this.pnlContnet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwValues;
        private System.Windows.Forms.ColumnHeader colCheckBox;
        private System.Windows.Forms.ColumnHeader colValues;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel pnlContnet;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnSearch;
    }
}