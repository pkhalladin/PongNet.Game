using PongNet.Board;

namespace PongNet
{
    public partial class MainForm : Form
    {
        private Board.Board board;

        public MainForm()
        {
            InitializeComponent();
            Ball ball = new Ball(20);
            Player playerA = new RealPlayer(0, 0, 20, 80);
            Player playerB = new ComputerPlayer(0, 0, 20, 80);
            board = new Board.Board(500, 500, ball, playerA, playerB)
            {

            };
        }

        private void MainFormPaint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}