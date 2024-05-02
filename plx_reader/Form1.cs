using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace plx_reader
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			string TextBoxPathPLX = textBox1.Text;
			Form2 DrawForm = new Form2();
			Form3 Items = new Form3();
			DrawForm.pathPLX = TextBoxPathPLX;
			DrawForm.Show();
			Items.pathPLX = TextBoxPathPLX;
			Items.Show();
		}
		private void textBox_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}
		private void textBox_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
				textBox1.Text = filePaths[0];
			}
		}
	}
}
