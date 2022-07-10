using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Factory friesFac = new FrenchFriesFactory();
            Product fries = friesFac.getProduct();
            Product myfries = ((FrenchFriesFactory)friesFac).getProduct("無鹽的");
            //Product myfries =friesFac.getProduct("無鹽的");

            fries.describe();//我是有鹽巴薯條
            myfries.describe();//我是無鹽的薯條

            Console.ReadKey();
        }
    }
}