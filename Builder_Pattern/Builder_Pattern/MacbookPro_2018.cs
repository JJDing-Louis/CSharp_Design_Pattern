using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class MacbookPro_2018 : MacbookProBuilder
    {
        public MacbookPro_2018() : base()
        {
        }

        public override MacbookProBuilder buildCPU(MacbookPro.Processor processor)
        {
            this.macbookPro.setProcessor(processor);
            return this;
        }

        public override MacbookProBuilder buildGraphics(MacbookPro.Graphics name)
        {
            this.macbookPro.setGraphics(name);
            return this;
        }

        public override MacbookProBuilder buildKeyboard(MacbookPro.Keyboard language)
        {
            this.macbookPro.setKeyboard(language);
            return this;
        }

        public override MacbookProBuilder buildMemory(MacbookPro.Memory size)
        {
            this.macbookPro.setMemory(size);
            return this;
        }

        public override MacbookProBuilder buildStorage(MacbookPro.Storage size)
        {
            this.macbookPro.setStorage(size);
            return this;
        }

        private MacbookPro build()
        {
            return base.build();
        }
    }
}