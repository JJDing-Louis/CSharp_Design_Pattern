using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern_Tetris_Game_
{
    public class Tetris
    {
        public Tetris()
        {
        }

        public void straightDown()
        {
            Console.WriteLine("直接下降");
        }

        public void trunLeft()
        {
            Console.WriteLine("向左轉");
        }

        public void turnRight()
        {
            Console.WriteLine("向右轉");
        }
    }
}