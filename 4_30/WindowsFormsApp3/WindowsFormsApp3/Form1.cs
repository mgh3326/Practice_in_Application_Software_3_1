using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            SolidBrush clearBrush = new SolidBrush(Form1.DefaultBackColor);
            Graphics g = this.CreateGraphics();

            booksTB.Clear();
            periodicalsTB.Clear();
            foodsTB.Clear();

            g.FillEllipse(clearBrush, 130, 110, 100, 100);
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayBTN_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            decimal totalSales;
            decimal bookSales;
            decimal periodicalSales;
            decimal foodSales;

            try
            {
                bookSales = Decimal.Parse(booksTB.Text);
                try
                {
                    periodicalSales = Decimal.Parse(periodicalsTB.Text);
                    try
                    {
                        foodSales = Decimal.Parse(foodsTB.Text);
                        totalSales = bookSales + periodicalSales + foodSales;

                        SolidBrush bookBr = new SolidBrush(Color.Blue);
                        SolidBrush periodcalBr = new SolidBrush(Color.Yellow);
                        SolidBrush foodBr = new SolidBrush(Color.Red);

                        if (totalSales != 0)
                        {
                            int endBook = (int)(bookSales / totalSales * 360);
                            g.FillPie(bookBr, 130, 110, 100, 100, 0, endBook);
                            int endPeriodical = (int)(periodicalSales / totalSales * 360);
                            g.FillPie(periodcalBr, 130, 110, 100, 100, endBook, endPeriodical);
                            int endFood = (int)(foodSales / totalSales * 360);
                            g.FillPie(foodBr, 130, 110, 100, 100, endPeriodical + endBook, endFood);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Food Sales");
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Periodical Sales");
                }
            }
            catch
            {
                MessageBox.Show("Invalid Book Sales");
            }
        }
    }
}
