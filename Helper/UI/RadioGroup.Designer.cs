﻿namespace GPSoft.Helper.UI
{
    partial class RadioGroupBox
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxRadioGroup = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbxRadioGroup
            // 
            this.gbxRadioGroup.AutoSize = true;
            this.gbxRadioGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxRadioGroup.Location = new System.Drawing.Point(0, 0);
            this.gbxRadioGroup.Name = "gbxRadioGroup";
            this.gbxRadioGroup.Size = new System.Drawing.Size(247, 187);
            this.gbxRadioGroup.TabIndex = 0;
            this.gbxRadioGroup.TabStop = false;
            this.gbxRadioGroup.Text = "RadioGroup";
            // 
            // RadioGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.gbxRadioGroup);
            this.Name = "RadioGroupBox";
            this.Size = new System.Drawing.Size(247, 187);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRadioGroup;
    }
}
