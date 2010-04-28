using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GP.GPMagic.GPSearch.Command;
using GP.GPMagic.GPMagicBase.Model;

namespace GP.GPMagic.GPSearch.UI
{
    public partial class FormMain : Form
    {
        FormCardInfo frmInfo;
        public FormMain()
        {
            InitializeComponent();
        }

        private void Init()
        {
            frmInfo = new FormCardInfo();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuNewDeck_Click(object sender, EventArgs e)
        {
            FormCardImage frmCardImage = new FormCardImage();
            frmCardImage.CardImage = Properties.Resources.cardDemo;
            frmCardImage.Show();
            DatabaseOperate.Init();
            DataTable table = DatabaseOperate.GetAllCardInfo();
            if (table != null)
                MessageBox.Show(table.Rows.Count.ToString());
            else
                MessageBox.Show("null");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void mnuAddCard_Click(object sender, EventArgs e)
        {
            FormCardInfo frmInfo = new FormCardInfo();
            frmInfo.EditStatus = GP.GPMagic.GPMagicBase.Model.EditStatus.Insert;
            frmInfo.Show();
        }

        private void mnuEditCard_Click(object sender, EventArgs e)
        {
            FormCardInfo frmInfo = new FormCardInfo();
            frmInfo.EditStatus = GP.GPMagic.GPMagicBase.Model.EditStatus.Update;
            frmInfo.Show();
        }

        private void ShowCardInfoForm(EditStatus editStatus)
        {
            if (null == frmInfo)
            {
                frmInfo = new FormCardInfo();
            }
            frmInfo.EditStatus = editStatus;
            frmInfo.Show();
        }
    }
}
