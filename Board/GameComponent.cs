using PongNet.Common;
using System.Numerics;

namespace PongNet.Board
{
    public abstract class GameComponent : UpdatableGameComponent
    {
        public Vector<double> Facing { get; }
        public Vector<double> Velocity { get; }

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
