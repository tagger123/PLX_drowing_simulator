using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Diagnostics;

class Program
{
	public static void Main()
	{
		try
		{
			using (StreamReader reader = new StreamReader(@"D:\1_Michal_Sawczuk\programming\PLX_drowing\PLX_drowing_simulator\PLX_reader_console\bin\Debug\net8.0\A9B10458713\713(1270)+2%.plx"))
			{
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
						Console.WriteLine(line);
						Console.WriteLine("x:" + float.Parse(parameters[2], CultureInfo.InvariantCulture));
						Console.WriteLine("y:" + float.Parse(parameters[4], CultureInfo.InvariantCulture));
						Console.WriteLine("Element lenght:" + float.Parse(parameters[6], CultureInfo.InvariantCulture));
						Console.WriteLine("Element width:" + float.Parse(parameters[7], CultureInfo.InvariantCulture));
					}
				}
					
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}

	}

}
