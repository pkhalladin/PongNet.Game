namespace PongNet
{
	public partial class MainForm : Form
	{
		private Menu.Menu menu;

		public MainForm()
		{
			InitializeComponent();
			menu = new Menu.Menu()
			{

			};
		}

		private void MainFormPaint(object sender, PaintEventArgs e)
		{

		}
	}
}