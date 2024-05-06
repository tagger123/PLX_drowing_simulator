using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace plx_reader
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		public string pathPLX { get; set; }
		public int length { get; set; }
		public int width { get; set; }
		public int ItemNumber14 { get; set; }
		public int ItemNumber15 { get; set; }
		public string ItemName { get; set; }
		public float xPos { get; set; }
		public float yPos { get; set; }	
		public void panel1_Paint_1(object sender, PaintEventArgs e)
		{
			using (StreamReader reader = new StreamReader(pathPLX))
			{
				Pen blkpen = new Pen(Color.Black, 2);
				Font drawFont = new Font("Arial", 16);
				SolidBrush drawBrush = new SolidBrush(Color.Black);
				string line;
				//filtrowanie calego pliku tekstowego 
				while ((line = reader.ReadLine()) != null)
				{
					//usuwanie elementow ktore sa w programie ale nie sa wykorzystane
					if (line.Contains("-"))
					{
						continue;
					}
					else if (line.StartsWith("5:"))
					{
						string[] xlen = line.Split(':');
						int x = int.Parse(xlen[3]);
						length = x / 50;
					}
					else if (line.StartsWith("7:"))
					{
						string[] ylen = line.Split(":");
						int y = int.Parse(ylen[2]);
						width = y / 50;
					}
					else if (line.StartsWith("14:"))
					{
						string[] parameters = line.Split(":");
						string ItemNumberHelp14 = parameters[1];
						string ItemNameHelp = parameters[4];
						ItemNumber14 = int.Parse(ItemNumberHelp14);
						ItemName = ItemNameHelp;
					}
					//wyciaganie danych z lini 15 (linia odpowiedzialna za polozenie i wymiary)
					else if (line.StartsWith("15:"))
					{
						string[] parameters2 = line.Split(':');
						string ItemNumberHelp15 = parameters2[1];
						ItemNumber15 = int.Parse(ItemNumberHelp15);
						float xPosHelp = (float.Parse(parameters2[2], CultureInfo.InvariantCulture) / 50);
						float yPosHelp = (float.Parse(parameters2[4], CultureInfo.InvariantCulture) / 50);
						xPos = xPosHelp;
						yPos = yPosHelp;
						float x2Pos = (float.Parse(parameters2[6], CultureInfo.InvariantCulture) / 50);
						float y2Pos = (float.Parse(parameters2[7], CultureInfo.InvariantCulture) / 50);
						e.Graphics.DrawRectangle(blkpen, xPosHelp, yPosHelp, x2Pos, y2Pos);
						e.Graphics.DrawString(ItemNumberHelp15, drawFont, drawBrush, xPos, yPos);
					}
				}
				e.Graphics.DrawRectangle(blkpen, 0, 0, length, width);
				panel1.Size = new Size(length + 100, width);
			}
		}
	}
}