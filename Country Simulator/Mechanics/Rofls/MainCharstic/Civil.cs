using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Country_Simulator.Mechanics.Rofls
{
    internal class Civil
    {

        private int civil = 1000;

        public void AddCivil(int MaxCivil)
        {
            if (civil < MaxCivil)
            {
                civil += (civil * 10) / 100; 
            } 
            else if (civil >= MaxCivil)
            {
                int needAddCivil = MaxCivil - civil;
                civil += needAddCivil;
            }
        }

        public void setCivil(int civil)
        {
            this.civil = civil;
        }

        public int getCivil()
        {
            return civil;
        }
    }
}
