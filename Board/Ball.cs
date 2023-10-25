using PongNet.Common;
using System.Numerics;

namespace PongNet.Board
{
    public class Ball : GameComponent
    {
        public int Speed { get => 20; }
        public int Radius { get => Radius; set => Radius = Width = Height = value; }

        public Ball(int radius)
        {
            Reset();
            Radius = radius;
        }

        public void Reset()
        {
            X = ((Board)Parent).Width / 2 - Width / 2;
            Y = ((Board)Parent).Height / 2 - Height / 2;

            Random random = new Random();
            Facing = new Vector2(random.Next() % 2 == 1 ? 1 : -1 * random.Next(10) - 1, random.Next() % 2 == 1 ? 1 : -1 * random.Next(10) - 1);
        }

        public override void Update(double deltaTime)
        {
            X += (int)(Velocity.X * deltaTime);
            Y += (int)(Velocity.Y * deltaTime);
            Board board = (Board)Parent;
            if (Y <= 0 || Y >= board.Height - Height)
            {
                Facing = new Vector2(Facing.X, -Facing.Y);
            }
            else if (Bounds.Contains(board.PlayerA.Bounds))
            {
                double angle = (1 - (board.PlayerA.Y + board.PlayerA.Height / 2 - (Y + Height / 2)) / (board.PlayerA.Height / 2)) * 90;
                double radians = angle * Math.PI / 180;
                Facing = new Vector2((float)Math.Sin(radians), (float)Math.Cos(radians));
            }
            else if (Bounds.Contains(board.PlayerB.Bounds))
            {
                double angle = (1 - (board.PlayerB.Y + board.PlayerB.Height / 2 - (Y + Height / 2)) / (board.PlayerB.Height / 2)) * 90;
                double radians = angle * Math.PI / 180;
                Facing = new Vector2((float)-Math.Sin(radians), (float)Math.Cos(radians));
            }
            else if (X <= 0)
            {
                board.PlayerB.Score++;
                Reset();
            }
            else if (X >= board.Width - Width)
            {
                board.PlayerA.Score++;
                Reset();
            }
        }

        public override void Render(Graphics g)
        {
            g.FillEllipse(Default.PrimaryColorBrush, Bounds);
        }
    }
}
