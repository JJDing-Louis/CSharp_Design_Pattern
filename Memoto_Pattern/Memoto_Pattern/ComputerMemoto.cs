using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoto_Pattern
{
    public class ComputerMemoto
    {
        private String hardisk;
        private String system;
        private String userApp;
        private String userDoc;

        public ComputerMemoto(String system, String hardisk, String userDoc, String userApp)
        {
            this.system = system;
            this.hardisk = hardisk;
            this.userDoc = userDoc;
            this.userApp = userApp;
        }

        public String getHardisk()
        {
            return hardisk;
        }

        public String getSystem()
        {
            return system;
        }

        public String getUserApp()
        {
            return userApp;
        }

        public String getUserDoc()
        {
            return userDoc;
        }

        public void setHardisk(String hardisk)
        {
            this.hardisk = hardisk;
        }

        public void setSystem(String system)
        {
            this.system = system;
        }

        public void setUserApp(String userApp)
        {
            this.userApp = userApp;
        }

        public void setUserDoc(String userDoc)
        {
            this.userDoc = userDoc;
        }
    }
}