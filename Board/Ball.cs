using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace PongNet.Board
{
    public class Ball : GameComponent
    {
        public int Radius
        {
            get => Radius;
            protected set => Radius = Width = Height = value;
        }
    }
}
