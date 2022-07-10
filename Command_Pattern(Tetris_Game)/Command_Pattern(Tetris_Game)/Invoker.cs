using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern_Tetris_Game_
{
    internal class Invoker
    {
        private ICommandTetris command;

        public Invoker(ICommandTetris command)
        {
            this.command = command;
        }

        public void invoke()
        {
            command.execute();
        }

        public void setCommand(ICommandTetris command)
        {
            this.command = command;
        }
    }
}