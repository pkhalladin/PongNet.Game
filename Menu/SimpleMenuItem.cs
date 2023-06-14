namespace PongNet.Game.Menu
{
	public class SimpleMenuItem : MenuItem
	{
		public SimpleMenuItem(string title, bool isVisible = true)
		{
			Title = title;
			IsVisible = isVisible;
		}
	}
}
