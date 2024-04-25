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
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			try
			{
				string path;
				using (StreamReader reader = new StreamReader(@"D:\\1_Michal_Sawczuk\\programming\\PLX_drowing\\A9B10434387\\A9B10434387(1270)+2%.plx"))
				{
					Pen blkpen = new Pen(Color.Black, 2);
					string line;
					//filtrowanie calego pliku tekstowego 
					while ((line = reader.ReadLine()) != null)
					{
						//usuwanie elementow ktore sa w programie ale nie sa wykorzystane
						if (line.Contains("-"))
						{
							continue;
						}
						//wyciaganie danych z lini 15 (linia odpowiedzialna za polozenie i wymiary)
						else if (line.Contains("15:"))
						{
							string[] parameters = line.Split(':');
							float xPos   = (float.Parse(parameters[2], CultureInfo.InvariantCulture) / 100);
							float yPos   = (float.Parse(parameters[4], CultureInfo.InvariantCulture) / 100);
							float width  = (float.Parse(parameters[6], CultureInfo.InvariantCulture) / 100);
							float height = (float.Parse(parameters[7], CultureInfo.InvariantCulture) / 100);
							e.Graphics.DrawRectangle(blkpen, xPos, yPos, width, height);
						}
					}

				}
			}
			catch (Exception ex)
			{
			}
		}
		private void DragOver(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Link;
			else
				e.Effect = DragDropEffects.None;
		}

		private void DragDrop(object sender, DragEventArgs e)
		{
			string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
			if (files != null && files.Any())
				textBox1.Text = files.First(); //select the first one  
		}
	}
}
