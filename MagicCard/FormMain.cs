using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GPSoft.Helper.FileOperate;
using GPSoft.GPMagic.GPMagic.UI;
using GPSoft.GPMagic.GPMagicBase.UI;

namespace GPSoft.GPMagic.MagicDemo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 缩小图片 
        /// </summary> 
        /// <param name="strOldPic">源图文件名(包括路径)</param> 
        /// <param name="strNewPic">缩小后保存为文件名(包括路径)</param> 
        /// <param name="intWidth">缩小至宽度</param> 
        /// <param name="intHeight">缩小至高度</param> 
        public void SmallPic(string strOldPic, string strNewPic, int intWidth, int intHeight)
        {

            System.Drawing.Bitmap objPic, objNewPic;
            try
            {
                objPic = new System.Drawing.Bitmap(strOldPic);
                objNewPic = new System.Drawing.Bitmap(objPic, intWidth, intHeight);
                objNewPic.Save(strNewPic);

            }
            catch (Exception exp) { throw exp; }
            finally
            {
                objPic = null;
                objNewPic = null;
            }
        }

        /// <summary> 
        /// 按比例缩小图片，自动计算高度 
        /// </summary> 
        /// <param name="strOldPic">源图文件名(包括路径)</param> 
        /// <param name="strNewPic">缩小后保存为文件名(包括路径)</param> 
        /// <param name="intWidth">缩小至宽度</param> 
        public void SmallPic(string strOldPic, string strNewPic, int intWidth)
        {

            System.Drawing.Bitmap objPic, objNewPic;
            try
            {
                objPic = new System.Drawing.Bitmap(strOldPic);
                int intHeight = (intWidth / objPic.Width) * objPic.Height;
                objNewPic = new System.Drawing.Bitmap(objPic, intWidth, intHeight);
                objNewPic.Save(strNewPic);

            }
            catch (Exception exp) { throw exp; }
            finally
            {
                objPic = null;
                objNewPic = null;
            }
        }


        /// <summary> 
        /// 按比例缩小图片，自动计算宽度 
        /// </summary> 
        /// <param name="strOldPic">源图文件名(包括路径)</param> 
        /// <param name="strNewPic">缩小后保存为文件名(包括路径)</param> 
        /// <param name="intHeight">缩小至高度</param> 
        public void SmallPic2(string strOldPic, string strNewPic, int intHeight)
        {

            System.Drawing.Bitmap objPic, objNewPic;
            try
            {
                objPic = new System.Drawing.Bitmap(strOldPic);
                int intWidth = (intHeight / objPic.Height) * objPic.Width;
                objNewPic = new System.Drawing.Bitmap(objPic, intWidth, intHeight);
                objNewPic.Save(strNewPic);

            }
            catch (Exception exp) { throw exp; }
            finally
            {
                objPic = null;
                objNewPic = null;
            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            //OrganismCard oc = new OrganismCard();
            //oc.Location = new Point(btnLoadCard.Left, btnLoadCard.Top + btnLoadCard.Height + 15);
            //oc.Image = Properties.Resources._0119_MTGWWK_CS_LR;
            //this.Controls.Add(oc);
            //oc.Show();

            //WindowPanel wp = new WindowPanel();
            //wp.Location = new Point(btnLoadCard.Left, btnLoadCard.Top + btnLoadCard.Height + 15);
            //this.Controls.Add(wp);
            //wp.Show();
            //wp.BringToFront();

            //Image img = new Bitmap((Image)this.pictureBox1.Image.Clone(), 20, 20);
            ////SmallPic(
            //countPanel1.Image = img;
            //countPanel1.Tip = "tip";
            //countPanel1.Count = 10;
            collapsiblePanel1.Items.Clear();
            for (int i = 1; i < 10; i++)
            {
                CollapsiblePanel.Item item = new CollapsiblePanel.Item();
                item.Key = new string('k', i);
                item.Value = new string('v', i);
                collapsiblePanel1.Items.Add(item);
            }
            collapsiblePanel1.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
