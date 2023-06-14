using PongNet.Common;

namespace PongNet.Game.Menu
{
	public class MenuItem : StatableGameComponent<MenuStates>
	{
		public event EventHandler Enter;
		public event EventHandler Leave;
		public string Title { get; set; }

		protected virtual void OnEnter()
		{
			Enter?.Invoke(this, EventArgs.Empty);
		}

		protected virtual void OnLeave()
		{
			Leave?.Invoke(this, EventArgs.Empty);
		}

		public override void Render(Graphics g)
		{
			base.Render(g);
			g.DrawString(Title, Default.Font, Default.PrimaryColorBrush, X, Y);
		}

		public void Pack()
		{
			Pack(this, X, Y);
		}

		public void AddMany(params MenuItem[] items)
		{
			foreach (var item in items)
			{
				Add(item);
			}
		}

		private void Pack(MenuItem parent, int baseX, int baseY)
		{
			int childIndex = 0;
			
			foreach (MenuItem child in parent)
			{
				child.X = baseX;
				child.Y = baseY + (int)(Default.Font.Size * 1.35 * childIndex++);
				Pack(child, baseX, baseY);
			}
		}
	}
}
