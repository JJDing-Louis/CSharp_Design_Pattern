using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoto_Pattern
{
    public class Test
    {
        public void test()
        {
            ComputerCareTaker careTaker = new ComputerCareTaker();
            ComputerOriginator originator = new ComputerOriginator();

            careTaker.saveMemoto(originator.save());

            Console.WriteLine(careTaker.getSave(0).getSystem());

            originator.setSystem("windows");

            careTaker.saveMemoto(originator.save());

            Console.WriteLine(careTaker.getSave(1).getSystem());
        }
    }
}