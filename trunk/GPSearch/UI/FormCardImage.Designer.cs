namespace GPSoft.GPMagic.GPSearch.UI
{
    partial class FormCardImage
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
            this.pbxCardImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCardImage
            // 
            this.pbxCardImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxCardImage.Location = new System.Drawing.Point(0, 0);
            this.pbxCardImage.Name = "pbxCardImage";
            this.pbxCardImage.Size = new System.Drawing.Size(265, 370);
            this.pbxCardImage.TabIndex = 0;
            this.pbxCardImage.TabStop = false;
            // 
            // FormCardImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 370);
            this.Controls.Add(this.pbxCardImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCardImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "卡牌图像";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCardImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCardImage;
    }
}