using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class Student : IObserver
    {
        private IObserverable observerable;

        public Student(IObserverable observerable)
        {
            this.observerable = observerable;
        }

        public void update()
        {
            Console.WriteLine($"聽了{((PodcastA)observerable).getName()}");
        }
    }
}