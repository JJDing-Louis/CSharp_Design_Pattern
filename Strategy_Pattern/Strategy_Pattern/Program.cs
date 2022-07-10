using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.setStrategy(DoType.ADD);
            int a = calculator.execute(2, 3);

            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}