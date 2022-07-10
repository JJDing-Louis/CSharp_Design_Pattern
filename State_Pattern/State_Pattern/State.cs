using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    public abstract class State
    {
        public static String saveForm(Double value)
        {
            return String.Format("%f", value);
        }

        //    精準到小數點下兩位
        public static String twoDecPlaces(Double value)
        {
            return String.Format("%.2f", value);
        }

        //    顯示的數值
        public abstract String tempToDisplay(Double temperture);

        //    儲存的數值
        public abstract String tempToSave(Double temperture);

        public abstract String vibToDisplay(Double vibration);

        public abstract String vibToSave(Double vibration);
    }
}