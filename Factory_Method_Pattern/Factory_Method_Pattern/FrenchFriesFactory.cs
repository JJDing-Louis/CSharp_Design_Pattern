using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    public class FrenchFriesFactory : Factory
    {
        //返回一般的薯條
        public Product getProduct()
        {
            return new FrenchFries();
        }

        //返回我們想要的狀態的薯條..
        public Product getProduct(String state)
        {
            return new FrenchFries(state);
        }
    }
}