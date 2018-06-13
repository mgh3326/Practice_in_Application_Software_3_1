using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//주문 취소
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) - Int32.Parse(listView1.Items[i].SubItems[1].Text) * Int32.Parse(listView1.Items[i].SubItems[2].Text)).ToString();

                    listView1.Items[i].Remove();
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)//라이스 버튼
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)//밥 버튼
        {

            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)//김치볶음밥
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == "김치볶음밥")
                {
                    listView1.Items[i].SubItems[1].Text = (Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                    textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) + 2500).ToString();
                    return;
                }
            }
            ListViewItem lvi = new ListViewItem("김치볶음밥");
            lvi.SubItems.Add("1");
            lvi.SubItems.Add("2500");
            textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) + 2500).ToString();
            listView1.Items.Add(lvi);
        }

        private void button7_Click(object sender, EventArgs e)//제육덮밥
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == "제육덮밥")
                {
                    listView1.Items[i].SubItems[1].Text = (Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                    textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) + 2500).ToString();
                    return;
                }
            }
            ListViewItem lvi = new ListViewItem("제육덮밥");
            lvi.SubItems.Add("1");
            lvi.SubItems.Add("2500");
            textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) + 2500).ToString();
            listView1.Items.Add(lvi);
        }

        private void button8_Click(object sender, EventArgs e)//오므라이스
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == "오므라이스")
                {
                    listView1.Items[i].SubItems[1].Text = (Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                    textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) + 2500).ToString();

                    return;
                }
            }
            ListViewItem lvi = new ListViewItem("오므라이스");
            lvi.SubItems.Add("1");
            lvi.SubItems.Add("2500");
            textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) + 2500).ToString();

            listView1.Items.Add(lvi);
        }

        private void button9_Click(object sender, EventArgs e)//뚝배기불고기
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == "뚝배기불고기")
                {
                    listView1.Items[i].SubItems[1].Text = (Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                    textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) + 2500).ToString();

                    return;
                }
            }
            ListViewItem lvi = new ListViewItem("뚝배기불고기");
            lvi.SubItems.Add("1");
            lvi.SubItems.Add("2500");
            textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) + 2500).ToString();

            listView1.Items.Add(lvi);
        }

        private void button15_Click(object sender, EventArgs e)//냉면
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == "냉면")
                {
                    listView1.Items[i].SubItems[1].Text = (Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                    textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) + 2500).ToString();

                    return;
                }
            }
            ListViewItem lvi = new ListViewItem("냉면");
            lvi.SubItems.Add("1");
            lvi.SubItems.Add("2500");
            textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) + 2500).ToString();

            listView1.Items.Add(lvi);
        }

        private void button16_Click(object sender, EventArgs e)//냉모밀
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == "냉모밀")
                {
                    listView1.Items[i].SubItems[1].Text = (Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                    textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) + 2500).ToString();

                    return;
                }
            }
            ListViewItem lvi = new ListViewItem("냉모밀");
            lvi.SubItems.Add("1");
            lvi.SubItems.Add("2500");
            textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) + 2500).ToString();

            listView1.Items.Add(lvi);
        }

        private void button17_Click(object sender, EventArgs e)//라볶이
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == "라볶이")
                {
                    listView1.Items[i].SubItems[1].Text = (Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                    textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) + 2500).ToString();

                    return;
                }
            }
            ListViewItem lvi = new ListViewItem("라볶이");
            lvi.SubItems.Add("1");
            lvi.SubItems.Add("2500");
            textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) + 2500).ToString();

            listView1.Items.Add(lvi);
        }

        private void button14_Click(object sender, EventArgs e)//유부우동
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == "유부우동")
                {
                    listView1.Items[i].SubItems[1].Text = (Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                    textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) + 2500).ToString();

                    return;
                }
            }
            ListViewItem lvi = new ListViewItem("유부우동");
            lvi.SubItems.Add("1");
            lvi.SubItems.Add("2500");
            textBoxTotal.Text = (Int32.Parse(textBoxTotal.Text) + 2500).ToString();

            listView1.Items.Add(lvi);
        }

        private void button2_Click(object sender, EventArgs e)//주문 초기화
        {
            listView1.Items.Clear();
            textBoxTotal.Text = "0";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            string output = "";
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"test.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                output += line;
                counter++;
            }

            file.Close();

            //MessageBox.Show(output);
            Form2 DetailForm = new Form2();
            DetailForm.image = ((PictureBox)sender).Image;

            StreamReader sr = new StreamReader(@"test.txt");
            DetailForm.txt = sr.ReadLine();
            DetailForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxTotal.Text + "이 결제가 완료되었습니다.");
            listView1.Items.Clear();
            textBoxTotal.Text = "0";
        }
    }
}
