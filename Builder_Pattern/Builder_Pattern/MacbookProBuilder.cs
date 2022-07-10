using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public abstract class MacbookProBuilder
    {
        protected MacbookPro macbookPro;

        protected MacbookProBuilder()
        {
            macbookPro = new MacbookPro();
        }

        public MacbookPro build()
        {
            return macbookPro;
        }

        public abstract MacbookProBuilder buildCPU(MacbookPro.Processor processor);

        public abstract MacbookProBuilder buildGraphics(MacbookPro.Graphics name);

        public abstract MacbookProBuilder buildKeyboard(MacbookPro.Keyboard language);

        public abstract MacbookProBuilder buildMemory(MacbookPro.Memory size);

        public abstract MacbookProBuilder buildStorage(MacbookPro.Storage size);
    }
}