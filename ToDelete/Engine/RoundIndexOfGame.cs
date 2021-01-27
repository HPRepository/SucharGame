using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class RoundIndexOfGame
    {
        public int Index
        {
            get; private set;
        }

       public RoundIndexOfGame()
        {
            this.Index = 0;
        }
       public void MoveIndexOfOnePosition()
        {
            this.Index += 1;
        }
    }
}
