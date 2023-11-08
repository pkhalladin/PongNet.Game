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
			DoubleBuffered = true;
			Text = Default.Title;
			ClientSize = new Size(Default.FormClientWidth, Default.FormClientHeight);
			mainMenu = new MainMenu();
			mainMenu.Children[0].Apply += StartGameApply;
			mainMenu.Children[1].Apply += ExitGameApply; ;
		}

		private void StartGameApply(object sender, EventArgs e)
		{
			mainMenu.IsVisible = false;
		}

		private void ExitGameApply(object sender, EventArgs e)
		{
			Close();
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
			else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right
				|| e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
			{
				mainMenu.Enter();
			}
		}

		private void TimerTick(object sender, EventArgs e)
		{
			Invalidate();
		}
	}
}
