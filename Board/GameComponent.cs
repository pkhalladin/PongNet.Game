using System.Numerics;
using PongNet.Common;

namespace PongNet.Board
{
    public abstract class GameComponent : UpdatableGameComponent
    {
        public int X { get => X; set => X = Math.Max(Math.Min(value, 0), ((Board)Parent).Width - Width); }
        public int Y { get => Y; set => Y = Math.Max(Math.Min(value, 0), ((Board)Parent).Height - Height); }
        public float Speed { get; set; }
        public Vector2 Facing { get; set; }
        public Vector2 Velocity { get => new Vector2(Facing.X * (float)(Speed / Math.Sqrt(Math.Pow(Facing.X, 2) + Math.Pow(Facing.Y, 2))),
                Facing.Y * (float)(Speed / Math.Sqrt(Math.Pow(Facing.X, 2) + Math.Pow(Facing.Y, 2)))); }

        public override void Render(Graphics g)
        {
            base.Render(g);
        }

        public override void Update(double deltaTime)
        {
            base.Update(deltaTime);
        }
    }
}
