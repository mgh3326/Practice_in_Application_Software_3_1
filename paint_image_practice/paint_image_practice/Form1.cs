using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint_image_practice
{

    public partial class Form1 : Form
    {
        OpenFileDialog odlg;
        ImageHandler imageHandler = new ImageHandler();
        double ZoomFactor = 0.9;
        public Form1()
        {
            InitializeComponent();
            odlg = new OpenFileDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(odlg.ShowDialog()==DialogResult.OK)
            {
                imageHandler.CurrentBitmap = (Bitmap)Bitmap.FromFile(odlg.FileName);
                imageHandler.BitmapPath = odlg.FileName;
                this.AutoScroll = true;
                this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * ZoomFactor),
                Convert.ToInt32(imageHandler.CurrentBitmap.Height * ZoomFactor));
                this.Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(imageHandler.CurrentBitmap, new Rectangle(this.AutoScrollPosition.X, AutoScrollPosition.Y,
                Convert.ToInt32(imageHandler.CurrentBitmap.Width * ZoomFactor),
                Convert.ToInt32(imageHandler.CurrentBitmap.Height * ZoomFactor
                )));
        }
    }
}
