using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Design_Pattern
{
    public class Test
    {
        public void test()
        {
            DrinkOrder drinkOrder = new DrinkOrder();
            drinkOrder.addDrink(new Coffee(165));
            drinkOrder.addDrink(new MilkTea(55, new MinusDiscount(20)));
            double price = drinkOrder.getTotalPrice(new NoneDiscount(1));
            //200
            Console.WriteLine(price);
            price = drinkOrder.getTotalPrice(new MultiplyStrategy(0.9));
            //打九折
            Console.WriteLine(price);
        }
    }
}