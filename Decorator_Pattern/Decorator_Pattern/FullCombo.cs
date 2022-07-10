using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class FullCombo : SimpleCombo
    {
        public FullCombo(Restaurant restaurant) : base(restaurant)
        {
        }

        public override void order()
        {
            base.order();
            sweet();
        }

        private void sweet()
        { Console.WriteLine("一份甜點"); }
    }
}