using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13_1
{
    class MultiBuilding : Building
    {
        int floor;
        public MultiBuilding(string adress, int lenBuild, int widthBuild, int heightBuild, int floor)
            :base(adress, lenBuild, widthBuild, heightBuild)
        {
            this.floor = floor;
        }
        new public string Print()
        {
            string res = base.Print();
            res += $"{floor} эт.";
            return res;
        }
    }
}
