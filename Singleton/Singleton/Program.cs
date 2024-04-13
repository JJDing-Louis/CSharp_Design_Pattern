using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // 使用單例模式的唯一實例
            Singleton singletonInstance1 = Singleton.Instance;
            Singleton singletonInstance2 = Singleton.Instance;

            // 驗證是否是同一個實例
            Console.WriteLine("Are both instances the same? " + (singletonInstance1 == singletonInstance2));

            // 使用單例實例的方法
            singletonInstance1.SomeMethod();
            Console.ReadKey();  
        }
    }
}
