using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    public class Test
    {
        public void test()
        {
            MetricSystem metricSystem = new MetricSystem();
            metricSystem.setState(new Metric());

            metricSystem.tempView(50d);
            metricSystem.vibView(10d);
            metricSystem.tempSave(50d);
            metricSystem.vibSave(10d);

            metricSystem.setState(new British());

            metricSystem.tempView(50d);
            metricSystem.vibView(10d);
            metricSystem.tempSave(50d);
            metricSystem.vibSave(10d);
        }
    }
}