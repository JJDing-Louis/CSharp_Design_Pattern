using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern
{
    internal class Test
    {
        public void test()
        {
            Sensor[] sensors = new Sensor[5000];
            sensors[0] = new Sensor();
            sensors[0].setID(1);
            sensors[0].setName("Sensor第一版");
            sensors[0].setNickname("我的空氣探測器");
            sensors[0].setVersion("1.0.0");
            sensors[0].setWifiID("MYSENSORWIFIID1.0.0");
            sensors[0].setWifiPass("THISisWiFiPasssOuO");
            sensors[0].setData("None");

            for (int i = 1; i < 5000; i++)
            {
                try
                {
                    sensors[i] = (Sensor)sensors[0].Clone();
                    sensors[i].setID(i + 1);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }

            //for (int i = 0; i < 5000; i++)
            //{
            //    //            測試是否每個感測器ID如我們所想要的
            //    Assertions.assertEquals(i + 1, sensors[i].getID());
            //}
        }
    }
}