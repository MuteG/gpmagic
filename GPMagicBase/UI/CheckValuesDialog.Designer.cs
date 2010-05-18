namespace GPSoft.GPMagic.GPMagicBase.UI
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
            this.components = new System.ComponentModel.Container();
            this.lvwValues = new System.Windows.Forms.ListView();
            this.colCheckBox = new System.Windows.Forms.ColumnHeader();
            this.colValues = new System.Windows.Forms.ColumnHeader();
            this.lvwResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlContnet = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ctxMnuValuesControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContnet.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ctxMnuValuesControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwValues
            // 
            this.lvwValues.AllowDrop = true;
            this.lvwValues.CheckBoxes = true;
            this.lvwValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCheckBox,
            this.colValues});
            this.lvwValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwValues.HideSelection = false;
            this.lvwValues.LabelWrap = false;
            this.lvwValues.Location = new System.Drawing.Point(163, 3);
            this.lvwValues.MultiSelect = false;
            this.lvwValues.Name = "lvwValues";
            this.lvwValues.Size = new System.Drawing.Size(155, 229);
            this.lvwValues.TabIndex = 0;
            this.lvwValues.UseCompatibleStateImageBehavior = false;
            this.lvwValues.View = System.Windows.Forms.View.Details;
            this.lvwValues.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvwValues_ItemChecked);
            this.lvwValues.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvwValues_DragDrop);
            this.lvwValues.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvwValues_DragEnter);
            // 
            // colCheckBox
            // 
            this.colCheckBox.Text = "";
            this.colCheckBox.Width = 22;
            // 
            // colValues
            // 
            this.colValues.Text = "备选值";
            this.colValues.Width = 100;
            // 
            // lvwResults
            // 
            this.lvwResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwResults.HideSelection = false;
            this.lvwResults.LabelWrap = false;
            this.lvwResults.Location = new System.Drawing.Point(3, 3);
            this.lvwResults.Name = "lvwResults";
            this.lvwResults.Size = new System.Drawing.Size(154, 229);
            this.lvwResults.TabIndex = 0;
            this.lvwResults.UseCompatibleStateImageBehavior = false;
            this.lvwResults.View = System.Windows.Forms.View.Details;
            this.lvwResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwResults_KeyDown);
            this.lvwResults.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvwResults_ItemDrag);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 120;
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
            this.tbxSearch.Size = new System.Drawing.Size(100, 21);
            this.tbxSearch.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(233, 271);
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
            this.btnOK.Location = new System.Drawing.Point(152, 271);
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
            this.pnlContnet.Controls.Add(this.btnNew);
            this.pnlContnet.Controls.Add(this.btnSearch);
            this.pnlContnet.Controls.Add(this.lblSearch);
            this.pnlContnet.Controls.Add(this.tbxSearch);
            this.pnlContnet.Controls.Add(this.tableLayoutPanel1);
            this.pnlContnet.Location = new System.Drawing.Point(0, 0);
            this.pnlContnet.Name = "pnlContnet";
            this.pnlContnet.Size = new System.Drawing.Size(321, 265);
            this.pnlContnet.TabIndex = 6;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(234, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "新建";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(153, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lvwValues, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lvwResults, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 235);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // ctxMnuValuesControl
            // 
            this.ctxMnuValuesControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemDelete});
            this.ctxMnuValuesControl.Name = "ctxMnuValuesControl";
            this.ctxMnuValuesControl.Size = new System.Drawing.Size(95, 26);
            // 
            // mnuItemDelete
            // 
            this.mnuItemDelete.Name = "mnuItemDelete";
            this.mnuItemDelete.Size = new System.Drawing.Size(94, 22);
            this.mnuItemDelete.Text = "删除";
            this.mnuItemDelete.Click += new System.EventHandler(this.mnuItemDelete_Click);
            // 
            // CheckValuesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 300);
            this.Controls.Add(this.pnlContnet);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckValuesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CheckValuesDialog";
            this.pnlContnet.ResumeLayout(false);
            this.pnlContnet.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ctxMnuValuesControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwValues;
        private System.Windows.Forms.ColumnHeader colCheckBox;
        private System.Windows.Forms.ColumnHeader colValues;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel pnlContnet;
        private System.Windows.Forms.ListView lvwResults;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ContextMenuStrip ctxMnuValuesControl;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDelete;
    }
}