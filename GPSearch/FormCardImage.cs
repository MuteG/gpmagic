﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSearch
{
    public partial class FormCardImage : Form
    {
        public FormCardImage()
        {
            InitializeComponent();
        }

        public Image CardImage
        {
            get { return pbxCardImage.Image; }
            set { pbxCardImage.Image = value; }
        }
    }
}
