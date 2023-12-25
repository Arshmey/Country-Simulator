using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country_Simulator.Mechanics.Rofls
{
    internal class Army
    {

        private int military = 0;

        public void HireMilitary()
        {
            military += 100;
        }

        public int getMilitary() 
        {  
            return military; 
        }
    }
}
