using System.Numerics;
using PongNet.Common;

namespace PongNet.Board
{
    public abstract class GameComponent : UpdatableGameComponent
    {
        public float Speed { get; set; }
        public Vector2 Facing { get; set; }
        public Vector2 Velocity
        {
            get => new Vector2(Facing.X * (float)(Speed / Math.Sqrt(Math.Pow(Facing.X, 2) + Math.Pow(Facing.Y, 2))),
                Facing.Y * (float)(Speed / Math.Sqrt(Math.Pow(Facing.X, 2) + Math.Pow(Facing.Y, 2))));
        }

        public override void Render(Graphics g)
        {
            throw new NotImplementedException();
        }

        public override void Update(double deltaTime)
        {
            throw new NotImplementedException();
        }
    }
}
