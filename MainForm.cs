using PongNet.Game.Menu;

namespace PongNet.Game
{
	public partial class MainForm : Form
	{
		private MenuItem menu;

		public MainForm()
		{
			InitializeComponent();
			menu = new MenuItem()
			{
				new SimpleMenuItem("Nowa gra"),
				new SimpleMenuItem("Ustawienia")
				{
					new SimpleMenuItem("Pe³ny ekran"),
					new SimpleMenuItem("Limit punktów")
				},
				new SimpleMenuItem("Koniec")
			};
			menu.X = Width / 2 - 100;
			menu.Y = Height / 2 - 100;
			menu.Pack();
		}

		private void MainFormPaint(object sender, PaintEventArgs e)
		{
			e.Graphics.Clear(Color.Black);
			menu.Render(e.Graphics);
		}
	}
}
