using PongNet.Common;
using PongNet.Game.Menu;

namespace PongNet.Game
{
	public partial class MainForm : Form
	{
		private MainMenu mainMenu;

		public MainForm()
		{
			InitializeComponent();
			Text = Default.Title;
			ClientSize = new Size(Default.FormClientWidth, Default.FormClientHeight);
			mainMenu = new MainMenu();
		}

		private void MainFormPaint(object sender, PaintEventArgs e)
		{
			mainMenu.Render(e.Graphics);
		}
	}
}
