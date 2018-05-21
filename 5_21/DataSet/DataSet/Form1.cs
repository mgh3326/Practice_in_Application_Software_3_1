using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSet
{
    public partial class Form1 : Form
    {
        DataSet1 dataset;
        public Form1()
        {
            InitializeComponent();
            dataset = new DataSet1();
            dataset.Tables["Person"].Rows.Add(new object[] { 1, "Kim", 30 });
            dataset.Tables["Person"].Rows.Add(new object[] { 2, "Kong", 35 });
            dataset.Tables["Person"].Rows.Add(new object[] { 3, "Park", 20 });
            dataset.Tables["Person"].Rows.Add(new object[] { 4, "Lee", 22 });

            dataGridView1.DataSource = dataset.Tables["Person"];
        }

        private void button_add_Click_Click(object sender, EventArgs e)
        {
            dataset.Tables["Person"].Rows.Add(new object[]{
                dataset.Tables["Person"].Rows.Count+1,textbox_name.Text,
                Convert.ToInt32(textbox_age.Text) });

        }
    }
}
