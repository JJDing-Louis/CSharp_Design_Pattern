using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public enum EnumSingleton
    {
        INSTANCE;


    public void doSomething()
    {
        Console.WriteLine("do do !");
    }
}

//public class StaticInnerClass
//    {
//        private StaticInnerClass() { }

//        public static StaticInnerClass getInstance()
//        {
//            return StaticInnerClassHolder.instance;
//        }

//        /**
// * 靜態的內部類別
// */
//        private static class StaticInnerClassHolder
//        {
//            public static StaticInnerClass instance = new StaticInnerClass();
//        }
//    }
}