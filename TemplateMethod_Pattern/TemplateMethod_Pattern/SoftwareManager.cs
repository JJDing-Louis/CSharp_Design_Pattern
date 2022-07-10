using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Pattern
{
    public class SoftwareManager : BossMethod
    {
        public override string programming()
        {
            Console.WriteLine("找一個軟體工程師做");
            return "程式成果";
        }

        public override string systemAnalysis()
        {
            Console.WriteLine("找一個軟體分析師做");
            return "軟體分析成果";
        }

        public override string systemDesign()
        {
            Console.WriteLine("找一個系統設計師做");
            return "系統設計成果";
        }

        public override string test()
        {
            Console.WriteLine("找一個測試工程師做");
            return "測試成果";
        }

        public override string UI_Design()
        {
            Console.WriteLine("找一個UI Design做");
            return "UI成果";
        }
    }
}