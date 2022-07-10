using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class PodcastA : IObserverable
    {
        //節目名稱
        public string name = "英文廣播";

        private List<IObserver> list = new List<IObserver>();

        public void add(IObserver observer)
        {
            list.Add(observer);
        }

        public string getName()
        {
            return this.name;
        }

        public void notifyObservers()
        {
            foreach (var o in list)
            {
                o.update();
            }
        }

        public void remove(IObserver observer)
        {
            list.Remove(observer);
        }
    }
}