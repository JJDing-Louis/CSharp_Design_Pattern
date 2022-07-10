using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern_Tetris_Game_
{
    public abstract class ICommandTetris
    {
        //    抽象的命令
        protected Tetris tetris;

        public ICommandTetris(Tetris tetris)
        {
            this.tetris = tetris;
        }

        public abstract void execute();
    }

    public class StraightDown : ICommandTetris
    {
        public StraightDown(Tetris tetris) : base(tetris)
        {
        }

        public override void execute()
        {
            tetris.straightDown();
        }
    }

    public class TurnLeft : ICommandTetris
    {
        public TurnLeft(Tetris tetris) : base(tetris)
        {
        }

        public override void execute()
        {
            tetris.trunLeft();
        }
    }

    public class TurnRight : ICommandTetris
    {
        public TurnRight(Tetris tetris) : base(tetris)
        {
        }

        public override void execute()
        {
            tetris.turnRight();
        }
    }
}