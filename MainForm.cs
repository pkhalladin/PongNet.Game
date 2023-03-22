using PongNet.Game.Menu;

namespace PongNet.Game
{
	public partial class MainForm : Form
	{
		private MenuItem menu;

		public MainForm()
		{
			InitializeComponent();
			// TODO: dokoñczyæ
			menu = new MenuItem()
			{
				new SimpleMenuItem() {  }
			};
		}

		private void MainFormPaint(object sender, PaintEventArgs e)
		{

		}
	}
}

/*
 A = [x, y]
 B = [x', y']
 C = A - B
*/