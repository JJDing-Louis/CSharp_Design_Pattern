using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public interface IObserver
    {
        void update();
    }

    public interface IObserverable
    {
        void add(IObserver observer);

        void notifyObservers();

        void remove(IObserver observer);
    }
}