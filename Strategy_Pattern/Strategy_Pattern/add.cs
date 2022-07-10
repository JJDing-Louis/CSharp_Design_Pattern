using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class add : IStrategy
    {
        public int calculate(int a, int b)
        {
            return a + b;
        }
    }
}