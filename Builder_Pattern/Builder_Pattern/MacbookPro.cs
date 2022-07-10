using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class MacbookPro
    {
        private Graphics graphics;
        private Keyboard keyboard;
        private Memory memory;
        private Processor processor;
        private Storage storage;

        public MacbookPro()
        {
        }

        public Graphics getGraphics()
        {
            return graphics;
        }

        public Keyboard getKeyboard()
        {
            return keyboard;
        }

        public Memory getMemory()
        {
            return memory;
        }

        public Processor getProcessor()
        {
            return processor;
        }

        public Storage getStorage()
        {
            return storage;
        }

        public void setGraphics(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public void setKeyboard(Keyboard keyboard)
        {
            this.keyboard = keyboard;
        }

        public void setMemory(Memory memory)
        {
            this.memory = memory;
        }

        public void setProcessor(Processor processor)
        {
            this.processor = processor;
        }

        public void setStorage(Storage storage)
        {
            this.storage = storage;
        }

        public virtual string toString()
        {
            return "{ Macbook : " + "\n" +
           "Processor : " + this.getProcessor().name + "\n" +
           "Memory size : " + this.getMemory().size + "GB" + "\n" +
           "Graphics : " + this.getGraphics().name + "\n" +
           "Storage size : " + this.getStorage().size + "GB" + "\n" +
           "Keyboard language : " + this.getKeyboard().language +
           " }";
        }

        public class Graphics
        {
            public string name;

            public Graphics(string name)
            {
                this.name = name;
            }
        }

        public class Keyboard
        {
            public string language;

            public Keyboard(string language)
            {
                this.language = language;
            }
        }

        public class Memory
        {
            public int size;

            public Memory(int size)
            {
                this.size = size;
            }
        }

        public class Processor
        {
            public string name;

            public Processor(string name)
            {
                this.name = name;
            }
        }

        public class Storage
        {
            public int size;

            public Storage(int size)
            {
                this.size = size;
            }
        }
    }
}