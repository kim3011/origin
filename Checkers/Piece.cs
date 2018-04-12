using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    public class Piece : IPiece
    {
        public virtual IEnumerable<int> NormalMoves(IBoard board) { List<int> x = new List<int>(); return x; }
        public virtual IEnumerable<int> CapturingMoves(IBoard board) { List<int> x = new List<int>(); return x; }
        public virtual void Move(int destination) { }
        //all methods must be virtual
        public Piece(Color c, int pos)
        {
            Status = Status.Active;
            Position = pos;
            Color = c;
        }
        public virtual Status Status { get; set; }
        public virtual Color Color { get; private set; }
        public virtual int Position { get; private set; }       

    }
   


}
