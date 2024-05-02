using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plx_reader
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}
		public string pathPLX { get; set; }
		public int length { get; set; }
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			using (StreamReader reader = new StreamReader(pathPLX))
			{
				Pen blkpen = new Pen(Color.Black, 2);
				Font drawFont = new Font("Arial", 16);
				SolidBrush drawBrush = new SolidBrush(Color.Black);
				int x = 0;
				int y = 0;
				string line;
				//filtrowanie calego pliku tekstowego 
				while ((line = reader.ReadLine()) != null)
				{
					//wyciaganie danych z lini 14 (linia odpowiedzialna za polozenie i wymiary)
					if (line.StartsWith("14:"))
					{
						string[] name = line.Split(':');
						string ItemName = name[4];
						string ItemNumber = name[1];
						e.Graphics.DrawString(ItemNumber + ":" + ItemName, drawFont, drawBrush, x, y);
						e.Graphics.DrawLine(blkpen, x, y + 25, Width, y + 25);
						y += 23;
						length = y + y;
					}
				}
				panel1.Size = new Size(250, length);
			}
		}
	}
}
