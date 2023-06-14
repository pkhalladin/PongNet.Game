using PongNet.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PongNet.Game.Menu
{
	public class MainMenu : MenuItem
	{
		public MainMenu()
		{
			AddMany(
				new SimpleMenuItem("Nowa gra"),
				new SimpleMenuItem("Ustawienia")
				{
					new SimpleMenuItem("Pełny ekran", false),
					new SimpleMenuItem("Limit punktów", false)
				},
				new SimpleMenuItem("Koniec"));
			X = Default.FormClientWidth / 2 - Default.FormClientWidth / 10;
			Y = Default.FormClientHeight / 2 - Default.FormClientHeight / 10;
		    Pack();
			IsVisible = true;
		}

		public override void Render(Graphics g)
		{
			g.Clear(Default.SecondaryColor);
			base.Render(g);
		}
	}
}
