﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Lab4_Bai4_ViewSource : Form
    {
        public Lab4_Bai4_ViewSource()
        {
            InitializeComponent();
        }
        public string SourceCode
        {
            get { return richTextBoxSource.Text; }
            set { richTextBoxSource.Text = value; }
        }
    }
}
