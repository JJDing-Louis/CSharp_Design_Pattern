using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern2
{
    public class Test
    {
        public void test()
        {
            //Order order = new Order();
            //Drink drink = new Drink();
            //MainMeal mainMeal = new MainMeal();
            //Soup soup = new Soup();

            //drink.decorate(order);
            //mainMeal.decorate(drink);
            //soup.decorate(mainMeal);

            //soup.show();

            SimpleSet simpleSet = new SimpleSet();
            simpleSet.show();
        }
    }
}