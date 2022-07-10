using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoto_Pattern
{
    public class ComputerOriginator
    {
        private String hardisk = "ssd";
        private String system = "macOS";
        private String userApp = "pages,numbers...";
        private String userDoc = "desk";

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

        public void restore(ComputerMemoto memoto)
        {
            this.hardisk = memoto.getHardisk();
            this.system = memoto.getSystem();
            this.userApp = memoto.getUserApp();
            this.userDoc = memoto.getUserDoc();
        }

        public ComputerMemoto save()
        {
            return new ComputerMemoto(system, hardisk, userDoc, userApp);
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