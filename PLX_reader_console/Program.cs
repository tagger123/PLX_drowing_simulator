using System;
using System.IO;
using System.Linq;

class Program
{
	public static void Main()
	{
		try
		{
			using (StreamReader reader = new StreamReader(@"D:\1_Michal_Sawczuk\programming\PLX_reader_console\bin\Debug\net8.0\A9B10458713\713(1270)+2%.plx"))
			{
				string line;
				string name;
				//filtrowanie calego pliku tekstowego 
				while ((line = reader.ReadLine()) != null && (name = reader.ReadLine()) != null)
				{
					//usuwanie elementow ktore sa w programie ale nie sa wykorzystane
					if (line.Contains("-"))
					{

						continue;
					}
					//wyciaganie danych z lini 15 (linia odpowiedzialna za polozenie i wymiary)
					else if (line.Contains("15:"))
					{

						Console.WriteLine(line);
						string[] part_name = name.Split(':');
						string[] collection = line.Split(':');
						Console.WriteLine("x:"+collection[2]);
						Console.WriteLine("y:"+collection[4]);
						Console.WriteLine("Element lenght:"+collection[6]);
						Console.WriteLine("Element width:" + collection[7]);
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
