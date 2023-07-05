using PongNet.Common;

namespace PongNet.Board
{
    public abstract class Player : GameComponent
    {
        public override void Render(Graphics g)
        {
            g.FillRectangle(Default.PrimaryColorBrush, Bounds);
        }
    }
}
