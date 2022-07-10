using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public interface IBuyHouse
    {
        //    屋主防禦價錢
        void defendPrice();

        //    找適合的房子
        void findHouse();

        //    成交後，簡化從付訂金到交屋的過程。
        void finish();

        //    跟屋主說太貴
        void priceTooHigh();
    }
}