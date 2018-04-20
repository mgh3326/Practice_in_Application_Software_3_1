using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void testFileBtn_Click(object sender, EventArgs e)
		{
			string file_path = "testFile.txt";
			if (File.Exists(file_path))
			{
				File.Delete(file_path);
				MessageBox.Show("파일을 삭제합니다.");
			}
			else
			{
				MessageBox.Show("파일이 존재 하지 않습니다.");
			}
		}

		private void testDirBtn_Click(object sender, EventArgs e)
		{
			string directory_path = "testDirectory";
			if (Directory.Exists(directory_path))
			{
				//true 로 설정하는 경로, 해당 디덕터리의 한뤼 디렉터리 및 파일들도 모두 삭제한다.
				Directory.Delete(directory_path, true);
				MessageBox.Show("디렉터리를 삭제합니다");
			}
			else
			{

				MessageBox.Show("디렉터리가 존재하지 않습니다.");
			}
		}
	}
}