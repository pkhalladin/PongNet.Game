using PongNet.Common;
using System.Numerics;
using System.Windows.Forms.Design;

namespace PongNet.Game.Menu
{
	public class MenuItem : StatableGameComponent<MenuStates>
	{
		public static readonly Font Font = new Font("Courier New", 15.0f, FontStyle.Bold);

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
			g.DrawString(Title, Font, Brushes.White, X, Y);
		}

		// TODO: oprogramować właściwość IsVisible
		public void Pack()
		{
			Pack(this, X, Y);
		}

		private void Pack(MenuItem parent, int baseX, int baseY)
		{
			int childIndex = 0;
			foreach (MenuItem child in parent)
			{
				child.X = baseX;
				child.Y = baseY + (int)(Font.Size * 1.35 * childIndex++);
				Pack(child, baseX, baseY);
			}
		}
	}
}
