using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern
{
    public class Sensor : Prototype
    {
        private String data;
        private int ID;

        private String name;
        private String nickname;
        private String version;
        private String wifiID;
        private String wifiPass;

        public override Prototype Clone()
        {
            return this.Clone();
            throw new NotImplementedException();
        }

        public String getData()
        {
            return data;
        }

        public int getID()
        {
            return ID;
        }

        public String getName()
        {
            return name;
        }

        public String getNickname()
        {
            return nickname;
        }

        public String getVersion()
        {
            return version;
        }

        public String getWifiID()
        {
            return wifiID;
        }

        public String getWifiPass()
        {
            return wifiPass;
        }

        public void setData(String data)
        {
            this.data = data;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setNickname(String nickname)
        {
            this.nickname = nickname;
        }

        public void setVersion(String version)
        {
            this.version = version;
        }

        public void setWifiID(String wifiID)
        {
            this.wifiID = wifiID;
        }

        public void setWifiPass(String wifiPass)
        {
            this.wifiPass = wifiPass;
        }
    }
}