using System.Numerics;

namespace PongNet.Board
{
    public class RealPlayer : Player
    {
        public RealPlayer(int x, int y, int width, int height) : base(x, y, width, height)
        {
            // ...
        }

        // wykrywanie klawiszy
        new public Vector2 Facing { get => new Vector2(0, false ? 1 : false ? -1 : 0); }
    }
}
