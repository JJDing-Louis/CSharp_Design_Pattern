using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public class Test
    {
        public void test()
        {
            IBuyHouse littleEngineer = new LittleEngineer();

            IBuyHouse estateAgent = new EstateAgent(littleEngineer);

            estateAgent.findHouse();
            estateAgent.priceTooHigh();
            estateAgent.defendPrice();
            estateAgent.finish();
        }
    }
}