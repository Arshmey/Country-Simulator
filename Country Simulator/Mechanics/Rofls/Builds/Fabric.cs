using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country_Simulator.Mechanics.Rofls.Builds
{
    internal class Fabric
    {

        private int fabric = 100;

        public void BuildFabric()
        {
            fabric += 1;
        }

        public int getFabric()
        { 
            return fabric;
        }

    }
}
