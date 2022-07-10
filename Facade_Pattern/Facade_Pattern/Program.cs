using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Test test = new Test();
            test.test();
            Console.ReadKey();
        }
    }
}