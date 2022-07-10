using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public class EstateAgent : IBuyHouse
    {
        private IBuyHouse iBuyHouse;

        public EstateAgent(IBuyHouse iBuyHouse)
        {
            this.iBuyHouse = iBuyHouse;
        }

        public void defendPrice()
        {
            iBuyHouse.defendPrice();
            Console.WriteLine("#房仲強力喬價錢");
        }

        public void findHouse()
        {
            iBuyHouse.findHouse();
            Console.WriteLine("#房仲幫忙找房子");
        }

        public void finish()
        {
            Console.WriteLine("#成交的話房仲幫忙付訂、簽約、用印、完稅、交屋");
            iBuyHouse.finish();
        }

        public void priceTooHigh()
        {
            iBuyHouse.priceTooHigh();
            Console.WriteLine("#房仲幫忙喬價錢");
        }
    }
}