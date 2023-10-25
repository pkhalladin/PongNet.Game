using PongNet.Common;

//wywołanie tej klasy
namespace PongNet.Board
{
    public class Board : GameComponent
    {
        public Ball Ball { get; set; }
        public Player PlayerA { get; set; }
        public Player PlayerB { get; set; }

        public Board(int width, int height, Ball ball, Player playerA, Player playerB)
        {
            X = 0;
            Y = 0;
            Width = width;
            Height = height;

            AddChild(ball);
            AddChild(playerA);
            AddChild(playerB);

            Ball = ball;
            PlayerA = playerA;
            PlayerB = playerB;
        }

        public override void Update(double deltaTime)
        {
            base.Update(deltaTime);
        }

        public override void Render(Graphics g)
        {
            g.DrawRectangle(Default.PrimaryColorPen, Bounds);
            g.DrawLine(Default.PrimaryColorPen, new Point(Width / 2, 0), new Point(Width / 2, Height));
            g.DrawString($"{PlayerA.Score} : {PlayerB.Score}", Default.GameFont, Default.PrimaryColorBrush, new Point(20, 20));
            base.Render(g);
        }
    }
}
