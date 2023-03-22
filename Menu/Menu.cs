using PongNet.Common;

namespace PongNet.Menu
{
	public class Menu : StatableGameComponent<MenuStates>
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
	}
}
