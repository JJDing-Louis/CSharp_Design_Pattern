using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    public interface Factory
    {
        //工廠返回商品
        Product getProduct();
    }
}