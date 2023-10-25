using PongNet.Common;
using System.Xaml.Permissions;

namespace PongNet.Board
{
    public abstract class Player : GameComponent
    {
        public int Speed { get => ((Board)Parent).Ball.Speed / 2; }
        public int Score { get; set; } = 0;

        public Player(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public override void Update(double deltaTime)
        {
            Y += (int)(Velocity.Y * deltaTime);
        }

        public override void Render(Graphics g)
        {
            g.FillRectangle(Default.PrimaryColorBrush, Bounds);
        }
    }
}
