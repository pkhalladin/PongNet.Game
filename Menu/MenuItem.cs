using PongNet.Common;

namespace PongNet.Game.Menu
{
	public class MenuItem : UpdatableGameComponent
	{
		public event EventHandler Apply;

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

		public string Title { get; set; }

		public void AddMany(params MenuItem[] items)
		{
			foreach (var item in items)
			{
				Add(item);
			}
		}

		public bool Enter()
		{
			MenuItem checkedChild = FindCheckedChild();

			if (checkedChild.Children.Count == 0)
			{
				return false;
			}

			

			return true;
		}

		public bool Leave()
		{
			throw new System.NotImplementedException();
		}

		public bool Next()
		{
			return Advance(+1);
		}

		public void Pack()
		{
			Pack(this, X, Y);
		}

		public bool Previous()
		{
			return Advance(-1);
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

		protected virtual void OnApply()
		{
			Apply?.Invoke(this, EventArgs.Empty);
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

		private bool Advance(int direction)
		{
			if (Children.Count == 0)
			{
				return false;
			}

			int checkedChildIndex = FindCheckedChildIndex();
			int advanceChildIndex = (checkedChildIndex + direction) % Children.Count;
			if (advanceChildIndex < 0)
			{
				advanceChildIndex = Children.Count - 1;
			}
			Children[checkedChildIndex].IsChecked = false;
			Children[advanceChildIndex].IsChecked = true;

			return true;
		}

		private int FindCheckedChildIndex()
		{
			for (int i = 0; i < Children.Count; i++)
			{
				if (Children[i].IsChecked)
				{
					return i;
				}
			}
			throw new InvalidOperationException();
		}

		private MenuItem FindCheckedChild()
		{
			return Children[FindCheckedChildIndex()];
		}

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