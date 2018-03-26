using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initializeFileDialog();
        }
        private void initializeFileDialog()
        {
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "Text (*.txt)|*.txt|" + "All files (*.*)|*.*";
            ofd.FileName = "";

            sfd.InitialDirectory = ofd.InitialDirectory;
            sfd.Filter = ofd.Filter;
            sfd.FileName = "*.txt";
        }
        private void tsmiNew_Click(object sender, EventArgs e)
        {
            Text = "Notepad";
            txtNotepad.Text = string.Empty;
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream stream = ofd.OpenFile();
                StreamReader sr = new StreamReader(stream);

                txtNotepad.Text = sr.ReadToEnd();

                sr.Close();
                stream.Close();

                Text = Path.GetFileName(ofd.FileName);

            }
        }

    }
}
