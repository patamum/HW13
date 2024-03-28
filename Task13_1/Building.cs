using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13_1
{
    class Building
    {
        string? adress;
        int lenBuild;
        int widthBuild;
        int heightBuild;
        
        int HeightBuild
        {
            get
            {
                return heightBuild;
            }
            set
            {
                if (value > 100)
                    heightBuild = 100;
                else if (value <= 0)
                    heightBuild = 5;
                else
                    heightBuild = value;
            }
        }
        public Building(string adress, int lenBuild, int widthBuild, int heightBuild)
        {
            this.adress = adress;
            this.lenBuild = lenBuild;
            this.widthBuild = widthBuild;
            this.HeightBuild = heightBuild;
        }
        public string Print()
        {
            return $"адрес ({adress}), длина здания {lenBuild}, ширина здания {widthBuild}, высота {heightBuild}, " ;
        }
    }
}
