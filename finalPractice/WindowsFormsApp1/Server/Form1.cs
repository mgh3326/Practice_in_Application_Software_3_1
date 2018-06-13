using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        DataSet1 dataset;

        public Form1()
        {
            InitializeComponent();
            dataset = new DataSet1();
            dataset.Tables["Datatable1"].Rows.Add(new object[] { "라이스", "김치볶음밥", 0, 0 });
            dataset.Tables["Datatable1"].Rows.Add(new object[] { "라이스", "뚝배기불고기", 0, 0 });
            dataset.Tables["Datatable1"].Rows.Add(new object[] { "라이스", "오므라이스", 0, 0 });
            dataset.Tables["Datatable1"].Rows.Add(new object[] { "라이스", "제육덮밥", 0, 0 });
            dataset.Tables["Datatable1"].Rows.Add(new object[] { "면", "냉면", 0, 0 });
            dataset.Tables["Datatable1"].Rows.Add(new object[] { "면", "냉모밀", 0, 0 });
            dataset.Tables["Datatable1"].Rows.Add(new object[] { "면", "라볶이", 0, 0 });
            dataset.Tables["Datatable1"].Rows.Add(new object[] { "면", "유부우동", 0, 0 });
            dataset.Tables["Datatable2"].Rows.Add(new object[] { "라이스", 0, 0 });
            dataset.Tables["Datatable2"].Rows.Add(new object[] { "면", 0, 0 });
            dataset.Tables["Datatable2"].Rows.Add(new object[] { "누적금액", 0, 0 });

            dataGridView1.DataSource = dataset.Tables["Datatable1"];
            dataGridView2.DataSource = dataset.Tables["Datatable2"];
        }
    }
}
