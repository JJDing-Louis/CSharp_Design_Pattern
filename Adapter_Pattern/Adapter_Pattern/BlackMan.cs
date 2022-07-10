using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class BlackMan
    {
        internal string name;

        public BlackMan(string name)
        {
            this.name = name;
        }

        public void helloEnglish()
        {
            Console.WriteLine("yo~ what's up!! niga~");
        }

        public void selfIntroEnglish()
        {
            Console.WriteLine($"Hello, I living in taipei. My name is { this.name}.");
        }
    }
}