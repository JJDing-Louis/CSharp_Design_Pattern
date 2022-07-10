using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    internal class Test
    {
        public void test()
        {
            Facade facade = new Facade();

            Console.WriteLine("MethodA : ");
            facade.MethodA();

            Console.WriteLine("MethodB : ");
            facade.MethodB();
        }
    }
}