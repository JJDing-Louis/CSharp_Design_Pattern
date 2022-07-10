using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Pattern
{
    public abstract class BossMethod
    {
        public void completeSoftware()
        {
            Console.WriteLine(
                    bossThink() + UI_Design() + "\n" +
                    bossThink() + systemAnalysis() + "\n" +
                    bossThink() + systemDesign() + "\n" +
                    bossThink() + programming() + "\n" +
                    bossThink() + test()
            );
        }

        public abstract String programming();

        public void redoSoftware()
        {
            Console.WriteLine(bossRedo());
            completeSoftware();
        }

        public abstract String systemAnalysis();

        public abstract String systemDesign();

        public abstract String test();

        public abstract String UI_Design();

        //老闆說你們這個不好重新做
        private String bossRedo()
        {
            return "你們這個跟我想做得不一樣重新做。";
        }

        //老闆有老闆的想法
        private String bossThink()
        {
            return "我覺得呢，這個東西應該要這樣做這樣做。 ： ";
        }
    }
}