namespace GPSoft.Games.GPMagic.GPSearch.UI
{
    partial class FormSetHeader
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
            this.lbxDisplayField = new System.Windows.Forms.ListBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbxTotalField = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxDisplayField
            // 
            this.lbxDisplayField.AllowDrop = true;
            this.lbxDisplayField.FormattingEnabled = true;
            this.lbxDisplayField.ItemHeight = 12;
            this.lbxDisplayField.Location = new System.Drawing.Point(143, 24);
            this.lbxDisplayField.Name = "lbxDisplayField";
            this.lbxDisplayField.Size = new System.Drawing.Size(123, 208);
            this.lbxDisplayField.TabIndex = 1;
            this.lbxDisplayField.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbxDisplayField_DragDrop);
            this.lbxDisplayField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbxDisplayField_MouseDown);
            this.lbxDisplayField.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbxDisplayField_DragEnter);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(212, 238);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(24, 23);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(242, 238);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(24, 23);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(14, 238);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "确认";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(95, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbxTotalField
            // 
            this.lbxTotalField.AllowDrop = true;
            this.lbxTotalField.FormattingEnabled = true;
            this.lbxTotalField.ItemHeight = 12;
            this.lbxTotalField.Location = new System.Drawing.Point(14, 24);
            this.lbxTotalField.Name = "lbxTotalField";
            this.lbxTotalField.Size = new System.Drawing.Size(123, 208);
            this.lbxTotalField.TabIndex = 6;
            this.lbxTotalField.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbxTotalField_DragDrop);
            this.lbxTotalField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbxTotalField_MouseDown);
            this.lbxTotalField.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbxDisplayField_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "可以选择的列";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "当前显示的列";
            // 
            // FormSetHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 266);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxTotalField);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lbxDisplayField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetHeader";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSetHeader";
            this.Load += new System.EventHandler(this.FormSetHeader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxDisplayField;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lbxTotalField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}