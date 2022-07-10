using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public abstract class People
    {
        private string name;

        public People(string name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public abstract void hello();

        public abstract void selfIntro();
    }
}