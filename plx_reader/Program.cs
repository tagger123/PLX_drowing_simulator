using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
namespace plx_reader
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}

		public class numLine
		{
			StreamReader reader = new StreamReader(@"D:\\1_Michal_Sawczuk\\programming\\PLX_drowing\\602\\test.plx");
			string line;
			int lineNum = 0;
			//filtrowanie calego pliku tekstowego 
			while 
		}
	}
}