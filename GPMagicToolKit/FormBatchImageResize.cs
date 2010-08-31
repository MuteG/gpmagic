using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using GPSoft.Helper.FileOperate;

namespace GPMagicToolKit
{
    public partial class FormBatchImageResize : Form
    {
        public FormBatchImageResize()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowseSourceFolder_Click(object sender, EventArgs e)
        {
            if (tbxSourceFolder.Text.Trim().Length > 0 &&
                Directory.Exists(tbxSourceFolder.Text))
            {
                folderBrowserDialog1.SelectedPath = tbxSourceFolder.Text;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxSourceFolder.Text = folderBrowserDialog1.SelectedPath;
                if (tbxTargetFolder.Text.Trim().Length == 0)
                {
                    tbxTargetFolder.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }

        private void btnBrowseTargetFolder_Click(object sender, EventArgs e)
        {
            if (tbxTargetFolder.Text.Trim().Length > 0 &&
                Directory.Exists(tbxTargetFolder.Text))
            {
                folderBrowserDialog1.SelectedPath = tbxTargetFolder.Text;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxTargetFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void chkAutoCreateTargetFolder_CheckedChanged(object sender, EventArgs e)
        {
            tbxTargetFolder.Enabled = chkAutoCreateTargetFolder.Checked;
            btnBrowseTargetFolder.Enabled = chkAutoCreateTargetFolder.Checked;
        }

        private void FormBatchImageResize_Load(object sender, EventArgs e)
        {
            
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            SetComponentEnabled(false);
            rtbProcessRecord.Clear();
            ResizeImages();
            SetComponentEnabled(true);
        }

        private void ResizeImages()
        {
            string sourceFolder = tbxSourceFolder.Text.Trim();
            if (Directory.Exists(sourceFolder))
            {
                string targetFolder = chkAutoCreateTargetFolder.Checked ?
                Path.Combine(Path.GetDirectoryName(sourceFolder), Path.GetFileName(sourceFolder) + "_265x370") :
                tbxTargetFolder.Text;
                tbxTargetFolder.Text = targetFolder;
                FileHelper.CreateDirectory(targetFolder);
                string[] imageArray = Directory.GetFiles(sourceFolder, "*.jpg");
                pbrResize.Maximum = imageArray.Length;
                pbrResize.Value = 0;
                foreach (string image in imageArray)
                {
                    string targetPath = Path.Combine(targetFolder, Path.GetFileName(image));
                    if (chkAutoRename.Checked)
                    {
                        CheckTargetImageName(ref targetPath);
                    }
                    using (Bitmap sourceBmp = (Bitmap)Bitmap.FromFile(image))
                    {
                        System.Drawing.Size targetSize = GetTargetSize(sourceBmp);
                        using (Bitmap targetBmp = BitmapManipulator.ResizeBitmap(sourceBmp, targetSize.Width, targetSize.Height))
                        {
                            targetBmp.Save(targetPath, ImageFormat.Jpeg);
                        }
                    }
                    rtbProcessRecord.AppendText(string.Format("{0}  完毕.\n", Path.GetFileName(image)));
                    rtbProcessRecord.ScrollToCaret();
                    pbrResize.Value++;
                    lblProcess.Text = string.Format("{0}/{1}", pbrResize.Value, pbrResize.Maximum);
                    Application.DoEvents();
                }

                rtbProcessRecord.AppendText(string.Format("全部图片转换完毕。"));
            }
        }

        private void CheckTargetImageName(ref string targetPath)
        {
            if (File.Exists(targetPath))
            {
                string folder = Path.GetDirectoryName(targetPath);
                string fileName = Path.GetFileNameWithoutExtension(targetPath);
                string ext = Path.GetExtension(targetPath);
                int loop = 1;
                bool fileExists = true;
                while (fileExists)
                {
                    targetPath = Path.Combine(folder, 
                        string.Format("{0}{1}{2}", fileName, loop.ToString("000"), ext));
                    fileExists = File.Exists(targetPath);
                    loop++;
                }
            }
        }

        private Size GetTargetSize(Image source)
        {
            System.Drawing.Size result = new Size();
            double scaleWidth = 265.0 / source.Width;
            double scaleHeight = 370.0 / source.Height;

            int targetWdith = (int)Math.Round(source.Width * scaleHeight);
            int targetHeight = (int)Math.Round(source.Height * scaleWidth);
            if (targetWdith > 265)
            {
                result.Width = 265;
                result.Height = targetHeight;
            }
            else
            {
                result.Height = 370;
                result.Width = targetWdith;
            }
            return result;
        }

        private void SetComponentEnabled(bool enabled)
        {
            tbxSourceFolder.Enabled = enabled;
            tbxTargetFolder.Enabled = enabled;
            btnBrowseSourceFolder.Enabled = enabled;
            btnBrowseTargetFolder.Enabled = enabled;
            chkAutoCreateTargetFolder.Enabled = enabled;
            chkAutoRename.Enabled = enabled;
        }
    }
}
