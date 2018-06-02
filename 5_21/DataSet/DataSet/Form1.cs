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
//  DataSet 객체
//  기능
//  하나의 Database
//  테이블 구조 정보, 필드 정보, 기본키, 데이터 관계 규약 정보

//  DataTable 
//  DataSet 의 여러 테이블 중 특정 Table 에는 Indexer 를 이용하여 접근 함
//  Table 의 이름을 string 형으로 넣음

//  데이터의 속성을 나타내는 열(Column) 부분은 Table.Column.Add(new DataColumn(“name”, typeof(type)) 으로 추가

//  실제 데이터들을 나타내는 행(Row) 부분은 Table.Row.Add(new object[] { data1, data2, data3/… }} 으로 추가

