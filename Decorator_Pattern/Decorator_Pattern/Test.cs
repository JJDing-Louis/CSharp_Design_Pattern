using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Test
    {
        public void test()
        {
            Restaurant restaurant = new Restaurant();
            SimpleCombo simpleCombo = new SimpleCombo(restaurant);
            Console.WriteLine("簡餐 : ");
            simpleCombo.order();

            BusinessLunch businessLunch = new BusinessLunch(restaurant);
            Console.WriteLine("商業午餐 :");
            businessLunch.order();

            FullCombo fullCombo = new FullCombo(restaurant);
            Console.WriteLine("全餐 :");
            fullCombo.order();

            Console.ReadKey();
        }
    }
}