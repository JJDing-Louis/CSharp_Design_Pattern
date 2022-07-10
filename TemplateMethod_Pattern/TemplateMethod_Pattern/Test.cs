using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Pattern
{
    public class Test
    {
        public void test()
        {
            SoftwareManager softwareManager = new SoftwareManager();

            softwareManager.completeSoftware();

            softwareManager.redoSoftware();
        }
    }
}