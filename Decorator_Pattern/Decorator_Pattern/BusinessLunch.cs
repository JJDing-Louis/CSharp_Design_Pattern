using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class BusinessLunch : Restaurant
    {
        private Restaurant restaurant;

        public BusinessLunch(Restaurant restaurant)
        {
            this.restaurant = restaurant;
        }

        public override void order()
        {
            base.order();
            salad();
            mainMeal();
        }

        private void mainMeal()
        {
            Console.WriteLine("一份主餐");
        }

        private void salad()
        {
            Console.WriteLine("一盤沙拉");
        }
    }
}