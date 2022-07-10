using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    internal class Test
    {
        public void test()
        {
            BlackMan blackMan = new BlackMan("black");

            blackMan.helloEnglish();
            blackMan.selfIntroEnglish();

            TaiwanMan taiwanMan = new TaiwanMan(new BlackmanTranslator(blackMan.name));

            taiwanMan.hello();
            taiwanMan.selfIntro();
        }
    }
}