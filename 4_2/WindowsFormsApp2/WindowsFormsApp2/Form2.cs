﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Child : Form
    {
        public Child()
        {
            InitializeComponent();
        }

        //public Parent MidParent { get; internal set; }//이거 뭐하는 걸까?

        public TextBox getTextBox()
        {
            return this.textBox;
        }

        
    }
}
