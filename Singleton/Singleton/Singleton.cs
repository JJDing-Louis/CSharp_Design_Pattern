using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private static object m_objLock = new object();

        //私有的建構式讓別人不能創造
        private Singleton()
        { }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                lock (m_objLock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }

        ////因為整個系統都要存取這個類別，很可能有多個process或thread同時存取
        ////為了讓線程安全添加synchronized在多線程下確保物件唯一性
        //public static Singleton getInstance()
        //{
        //    if (instance == null)
        //    {
        //        lock (m_objLock)
        //        {
        //            instance = new Singleton();
        //        }
        //    }
        //    return instance;
        //}
    }
}