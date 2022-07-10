using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    public class FrenchFries : Product
    {
        //預設有鹽巴的
        private String state = "有鹽巴";

        //預設的建構
        internal FrenchFries()
        { }

        //帶入狀態的建構
        internal FrenchFries(String state)
        {
            this.state = state;
        }

        public void describe()
        {
            Console.WriteLine($"我是{state}薯條");
        }
    }
}