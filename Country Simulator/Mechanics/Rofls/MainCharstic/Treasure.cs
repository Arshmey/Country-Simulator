using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country_Simulator.Mechanics.Rofls
{
    internal class Treasure
    {

        private double treasure = 1000;


        public void countTreasure(int civil, int military, int fabric)
        {
            double needCivil = ((civil - military) * 5) / 100;
            double needMilitary = (military * 15) / 100;
            double effencyFabric = fabric * 10;
            treasure += effencyFabric - (needCivil + needMilitary);
        }

        public void setTreasure(double treasure)
        {
            this.treasure = treasure;
        }

        public double getTreasure() 
        {
            return treasure;
        }

    }
}
