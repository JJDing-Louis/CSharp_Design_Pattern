using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    public class MetricSystem
    {
        private State state;

        public void setState(State state)
        {
            this.state = state;
        }

        public void tempSave(Double temp)
        {
            Console.WriteLine(state.tempToSave(temp));
        }

        public void tempView(Double temp)
        {
            Console.WriteLine(state.tempToDisplay(temp));
        }

        public void vibSave(Double vib)
        {
            Console.WriteLine(state.vibToSave(vib));
        }

        public void vibView(Double vib)
        {
            Console.WriteLine(state.vibToDisplay(vib));
        }
    }
}