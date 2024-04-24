using System.Drawing;
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

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			Pen blkpen = new Pen(Color.Black, 1);
			for (int i = 0; i < lineNum; i++)
			{
				e.Graphics.DrawRectangle(blkpen, i + 100, i + 100, i + 100, i + 100);
			}
		}
	}
}
