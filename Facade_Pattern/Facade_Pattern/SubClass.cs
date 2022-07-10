using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public class ClassOne
    {
        public void MethodFour()
        {
            Console.WriteLine(4);
        }
    }

    public class SubClassOne
    {
        public void MethodOne()
        {
            Console.WriteLine(1);
        }
    }

    public class SubClassThree
    {
        public void MethodThree()
        {
            Console.WriteLine(3);
        }
    }

    public class SubClassTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine(2);
        }
    }
}