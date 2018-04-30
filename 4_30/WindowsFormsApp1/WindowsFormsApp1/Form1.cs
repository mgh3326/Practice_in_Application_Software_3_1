using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        private Random rand;
        private int X;
        private int Y;

        Pen WhitePen = new Pen(Color.White, 2);
        //Random generateRandom = new Random();

        //Random GetRandom;

        //DateTime dtmCurrent = DateTime.Now;
        //generateRandom = new Random(dtmCurrent.Millisecond);
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            X = (int)this.Width / 2;
            Y = (int)this.Height - 140;

            DateTime currentTime = DateTime.Now;
            rand = new Random(currentTime.Millisecond);

            timer1.Interval = 2000;
            timer1.Enabled = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen redPen = new Pen(Color.IndianRed);
            SolidBrush redBr = new SolidBrush(Color.IndianRed);
            SolidBrush whiteBr = new SolidBrush(Color.White);

            g.FillEllipse(whiteBr, X, Y, 100, 100);
            Y -= 80;
            X += 10;
            g.FillEllipse(whiteBr, X, Y, 80, 80);
            Y -= 60;
            X += 10;
            g.FillEllipse(whiteBr, X, Y, 60, 60);

            g.DrawLine(redPen, X - 10, Y, 60, 60);
            g.FillRectangle(redBr, X + 10, Y - 40, 40, 40);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            for(int i=0;i<400;i++)
            {
                X = rand.Next(1, this.Width);
                Y = rand.Next(1, this.Height);
                g.DrawLine(WhitePen, X, Y, X + 1, Y + 1);
            }
        }
    }
}
