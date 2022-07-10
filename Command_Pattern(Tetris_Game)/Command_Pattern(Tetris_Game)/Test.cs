using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern_Tetris_Game_
{
    public class Test
    {
        public void test()
        {
            Tetris tetris = new Tetris();
            ICommandTetris commandLeft = new TurnLeft(tetris);
            ICommandTetris commandRight = new TurnRight(tetris);
            ICommandTetris commandDown = new StraightDown(tetris);

            Invoker invoker = new Invoker(commandLeft);

            invoker.invoke();

            invoker.setCommand(commandRight);

            invoker.invoke();

            invoker.setCommand(commandDown);

            invoker.invoke();
        }
    }
}