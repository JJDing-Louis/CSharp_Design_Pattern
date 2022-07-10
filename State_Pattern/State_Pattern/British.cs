using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    public class British : State
    {
        public override string tempToDisplay(double temperture)
        {
            Console.WriteLine("顯示英制");
            return twoDecPlaces(temperture * 9 / 5 + 32);
        }

        public override string tempToSave(double temperture)
        {
            Console.WriteLine("顯示英制");
            return saveForm((temperture - 32) * 5 / 9);
        }

        public override string vibToDisplay(double vibration)
        {
            Console.WriteLine("儲存英制");
            return twoDecPlaces(vibration * 25.4);
        }

        public override string vibToSave(double vibration)
        {
            Console.WriteLine("儲存英制");
            return saveForm(vibration / 25.4);
        }
    }
}