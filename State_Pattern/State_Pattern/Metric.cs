using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    public class Metric : State
    {
        public override string tempToDisplay(double temperture)
        {
            Console.WriteLine("顯示公制");
            return twoDecPlaces(temperture);
        }

        public override string tempToSave(double temperture)
        {
            Console.WriteLine("儲存公制");
            return saveForm(temperture);
        }

        public override string vibToDisplay(double vibration)
        {
            Console.WriteLine("顯示公制");
            return twoDecPlaces(vibration);
        }

        public override string vibToSave(double vibration)
        {
            Console.WriteLine("儲存公制");
            return saveForm(vibration);
        }
    }
}