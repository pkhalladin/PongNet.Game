using PongNet.Common;

namespace PongNet.Game.Menu
{
	public class MenuItem : UpdatableGameComponent
	{
		public event EventHandler Check;

		public event EventHandler Uncheck;

		public new IList<MenuItem> Children => base.Children.Cast<MenuItem>().ToList();

		public bool IsChecked
		{
			get => isChecked;
			set
			{
				if (value == isChecked)
				{
					return;
				}
				else if (value)
				{
					OnCheck();
				}
				else
				{
					OnUncheck();
				}
				isChecked = value;
			}
		}

		public bool Next()
		{
			throw new System.NotImplementedException();
		}

		public bool Previous()
		{
			throw new System.NotImplementedException();
		}

		public bool Enter()
		{
			throw new System.NotImplementedException();
		}

		public bool Leave()
		{
			throw new System.NotImplementedException();
		}

		public string Title { get; set; }

		public void AddMany(params MenuItem[] items)
		{
			foreach (var item in items)
			{
				Add(item);
			}
		}

		public void Pack()
		{
			Pack(this, X, Y);
		}

		public override void Render(Graphics g)
		{
			base.Render(g);
			if (IsVisible)
			{
				if (IsChecked)
				{
					g.DrawString(Default.MenuCheckedPrefix, Default.MenuFont,
						Default.PrimaryColorBrush, X - Default.MenuFont.Size * 3.0f, Y);
				}
				g.DrawString(Title, Default.MenuFont, Default.PrimaryColorBrush, X, Y);
			}
		}

		protected virtual void OnCheck()
		{
			Check?.Invoke(this, EventArgs.Empty);
		}

		protected virtual void OnUncheck()
		{
			Uncheck?.Invoke(this, EventArgs.Empty);
		}

		private bool isChecked;

		private void Pack(MenuItem parent, int baseX, int baseY)
		{
			int childIndex = 0;

			foreach (MenuItem child in parent)
			{
				child.X = baseX;
				child.Y = baseY + (int)(Default.MenuFont.Size * 1.35 * childIndex++);
				Pack(child, baseX, baseY);
			}
		}
	}
}