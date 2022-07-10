using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class BlackmanTranslator : People
    {
        public BlackmanTranslator(string name) : base(name)
        {
        }

        public override void hello()
        {
            Console.WriteLine(getName() + ":哩甲霸咩～真的假的！？");
        }

        public override void selfIntro()
        {
            Console.WriteLine("大家好我是" + getName() +
                    "，現在台北工作。");
        }
    }
}