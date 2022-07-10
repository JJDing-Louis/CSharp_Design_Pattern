using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Restaurant
    {
        //低消是一杯飲料
        public virtual void order()
        {
            minimumOrder();
        }

        private void minimumOrder()
        {
            Console.WriteLine("一杯飲料");
        }
    }
}