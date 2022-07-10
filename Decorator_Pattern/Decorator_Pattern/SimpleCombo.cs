using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class SimpleCombo : BusinessLunch
    {
        public SimpleCombo(Restaurant restaurant) : base(restaurant)
        {
        }

        public override void order()
        {
            base.order();
            soup();
        }

        private void soup()
        {
            Console.WriteLine("一份湯品");
        }
    }
}