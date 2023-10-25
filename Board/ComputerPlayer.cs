using System.Numerics;

namespace PongNet.Board
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(int x, int y, int width, int height) : base(x, y, width, height)
        {
            // ...
        }

        new public Vector2 Facing { get => new Vector2(0, Math.Sign(((Board)Parent).Ball.Y + ((Board)Parent).Ball.Radius / 2 - (Y + Height / 2))); }
    }
}
