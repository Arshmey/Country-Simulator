using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country_Simulator.Mechanics
{
    internal class CountryName
    {

        private string nameCountry;

        public void setNameCountry(string nameCountry)
        {
            this.nameCountry = nameCountry;
        }

        public string getNameCountry() 
        {
            return nameCountry;
        }

    }
}
