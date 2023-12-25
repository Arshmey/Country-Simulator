using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country_Simulator.Mechanics.Rofls.Builds
{
    internal class House
    {

        private int house = 10;
        private int MaxCivil;

        public House()
        {
            MaxCivil = house * 100;
        }

        public void BuildHouse()
        {
            house += 1;
            MaxCivil = house * 100;
        }

        public int getHouse()
        {
            return house;
        }

        public int getMaxCivil()
        {
            return MaxCivil;
        }

    }
}
