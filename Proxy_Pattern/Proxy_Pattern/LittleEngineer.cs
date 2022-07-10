using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public class LittleEngineer : IBuyHouse
    {
        public void defendPrice()
        {
            //屋主反擊說價錢已經很便宜
            Console.WriteLine("未來人口越來越少，我們也是自住而已！打我五折吧！");
        }

        public void findHouse()
        {
            //小小工程師想找在民生社區的房子
            Console.WriteLine("民生社區機能特好！當然找那邊的房子！");
        }

        public void finish()
        {
            //沒想到屋主同意買到了
            Console.WriteLine("辛苦還房貸幾十年");
        }

        public void priceTooHigh()
        {
            //價錢實在太貴
            Console.WriteLine("現在台灣薪水那麼低，屋主開那麼高賣不掉啦！");
        }
    }
}