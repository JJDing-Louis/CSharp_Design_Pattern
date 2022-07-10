using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoto_Pattern
{
    public class ComputerCareTaker
    {
        public List<ComputerMemoto> saves = new List<ComputerMemoto>();

        //    最多備份15筆
        private const int MAX = 15;

        //    獲取電腦資訊
        public ComputerMemoto getSave(int index)
        {
            if (index > saves.Count - 1)
            {
                index = saves.Count - 1;
            }

            return saves[index];
        }

        public void saveMemoto(ComputerMemoto memoto)
        {
            if (saves.Count > MAX)
            {
                saves.RemoveAt(0);
            }
            saves.Add(memoto);
        }
    }
}