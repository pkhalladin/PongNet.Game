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

		private void MainFormKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
			{
				mainMenu.Previous();
			}
			else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
			{
				mainMenu.Next();
			}
			else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
			{
				mainMenu.Enter();
			}
			else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Escape || e.KeyCode == Keys.Back)
			{
				mainMenu.Leave();
			}
		}
	}
}
