using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country_Simulator.Mechanics.Rofls
{
    internal class NextDay
    {

        private int day = 1;
        
        public void nextDay()
        {
            day += 1;
        }

        public int getDay() 
        {
            return day; 
        }

    }
}
