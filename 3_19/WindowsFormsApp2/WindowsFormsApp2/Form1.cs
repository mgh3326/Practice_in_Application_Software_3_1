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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList2Checked_Click(object sender, EventArgs e)
        {
            if (lstLanguages.SelectedItem != null)// listBox1.SelectedIndex >= 0
            {
                ck1Languages.Items.Add(lstLanguages.SelectedItem, false);
                lstLanguages.Items.Remove(lstLanguages.SelectedItem);
            }
        }

        private void btnChecked2List_Click(object sender, EventArgs e)
        {
            while (ck1Languages.CheckedItems.Count > 0)
            {
				// object item = checkedListBox1.CheckedItems[0];
                string item = (string)ck1Languages.CheckedItems[0];//checkedListBox1.CheckedItems[0].ToString();
                lstLanguages.Items.Add(item);
                ck1Languages.Items.Remove(item);
            }
        }

        private void btnChecked2TextBox_Click(object sender, EventArgs e)
        {
            foreach (string item in ck1Languages.CheckedItems)
                txtNote.Text += item + "\r\n";
        }
    }
}
