namespace GPSoft.GPMagic.GPSearch.UI
{
    partial class FormFilterExpansions
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lvwExpansionsList = new System.Windows.Forms.ListView();
            this.cbxExpansions = new System.Windows.Forms.ComboBox();
            this.lblExpansions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.ok;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(324, 223);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 23);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "确认";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.pencil_tool1;
            this.btnEdit.Location = new System.Drawing.Point(203, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(24, 23);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Image = global::GPSoft.GPMagic.GPSearch.Properties.Resources.plus1;
            this.btnNew.Location = new System.Drawing.Point(173, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(24, 23);
            this.btnNew.TabIndex = 16;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // lvwExpansionsList
            // 
            this.lvwExpansionsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwExpansionsList.CheckBoxes = true;
            this.lvwExpansionsList.Location = new System.Drawing.Point(13, 40);
            this.lvwExpansionsList.Name = "lvwExpansionsList";
            this.lvwExpansionsList.Size = new System.Drawing.Size(367, 177);
            this.lvwExpansionsList.TabIndex = 15;
            this.lvwExpansionsList.UseCompatibleStateImageBehavior = false;
            // 
            // cbxExpansions
            // 
            this.cbxExpansions.FormattingEnabled = true;
            this.cbxExpansions.Location = new System.Drawing.Point(46, 12);
            this.cbxExpansions.Name = "cbxExpansions";
            this.cbxExpansions.Size = new System.Drawing.Size(121, 20);
            this.cbxExpansions.TabIndex = 14;
            // 
            // lblExpansions
            // 
            this.lblExpansions.AutoSize = true;
            this.lblExpansions.Location = new System.Drawing.Point(11, 15);
            this.lblExpansions.Name = "lblExpansions";
            this.lblExpansions.Size = new System.Drawing.Size(29, 12);
            this.lblExpansions.TabIndex = 13;
            this.lblExpansions.Text = "系列";
            // 
            // FormFilterExpansions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 258);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lvwExpansionsList);
            this.Controls.Add(this.cbxExpansions);
            this.Controls.Add(this.lblExpansions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFilterExpansions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormFilterExpansions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ListView lvwExpansionsList;
        private System.Windows.Forms.ComboBox cbxExpansions;
        private System.Windows.Forms.Label lblExpansions;
    }
}