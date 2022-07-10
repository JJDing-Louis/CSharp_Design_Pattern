using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class TaiwanMan
    {
        private People people;

        public TaiwanMan(People people)
        {
            this.people = people;
        }

        public void hello()
        {
            people.hello();
        }

        public void selfIntro()
        {
            people.selfIntro();
        }
    }
}