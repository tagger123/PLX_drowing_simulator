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
					else if (line.StartsWith("7:"))
					{
						string[] xlen = line.Split(':');
						int x1 = int.Parse(xlen[3]);
						int x2 = x1 / 100;
						panel1.Size = new Size(x2, 425);
					}
					//wyciaganie danych z lini 15 (linia odpowiedzialna za polozenie i wymiary)
					else if (line.StartsWith("15:"))
					{
						string[] parameters = line.Split(':');
						string nameNumber = parameters[1];
						float xPos = (float.Parse(parameters[2], CultureInfo.InvariantCulture) / 100);
						float yPos = (float.Parse(parameters[4], CultureInfo.InvariantCulture) / 100);
						float width = (float.Parse(parameters[6], CultureInfo.InvariantCulture) / 100);
						float height = (float.Parse(parameters[7], CultureInfo.InvariantCulture) / 100);
						e.Graphics.DrawRectangle(blkpen, xPos, yPos, width, height);
						e.Graphics.DrawString(nameNumber, drawFont, drawBrush, xPos, yPos);
					}
				}
			}
		}
	}
}
