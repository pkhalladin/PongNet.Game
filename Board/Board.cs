using System.Runtime.InteropServices;
using System.Transactions;

namespace PongNet.Board
{
    public class Board : GameComponent
    {
        //public Player PlayerA { get; }
        //public Player PlayerB { get; }
        //public Ball Ball { get; }

        public Board(int width, int height, Player playerA, Player playerB, Ball ball) : base()
        {
            X = 0;
            Y = 0;
            Width = width;
            Height = height;

            //PlayerA = playerA;
            //PlayerB = playerB;
            //Ball = ball;

            AddChild(playerA);
            AddChild(playerB);
            AddChild(ball);
        }
    }
}
