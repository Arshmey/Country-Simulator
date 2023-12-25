using Country_Simulator.GameScreen.Frames;
using Country_Simulator.Mechanics.Rofls;
using Country_Simulator.Mechanics.Rofls.Builds;
using System.Threading;

namespace Country_Simulator.Mechanics
{
    internal class HandlerGame
    {

        Civil civil = new Civil();
        Treasure treasure = new Treasure();
        Army army = new Army();
        NextDay nextDay = new NextDay();
        House house = new House();
        Fabric fabric = new Fabric();
        private bool isNewDay = false;
        private bool isBuildHouse = false;
        private bool isBuildFabric = false;
        private bool isHire = false;
        GameFrame gameFrame;
        Thread readAction;

        public HandlerGame(GameFrame gameFrame)
        {
            this.gameFrame = gameFrame;
            readAction = new Thread(Updater);
        }

        public void StartGame() { readAction.Start(); }

        public void Updater()
        {
            while (true)
            {
                gameFrame.TextUpdate(civil.getCivil(), treasure.getTreasure(), army.getMilitary(), 0, house.getHouse(), fabric.getFabric(), nextDay.getDay());
                if (isBuildHouse)
                {
                    if (treasure.getTreasure() >= 50)
                    {
                        house.BuildHouse();
                        treasure.setTreasure(treasure.getTreasure() - 50);
                    }
                    isBuildHouse = false;
                }

                if (isBuildFabric)
                {
                    if (treasure.getTreasure() >= 100)
                    {
                        fabric.BuildFabric();
                        treasure.setTreasure(treasure.getTreasure() - 100);
                    }
                    isBuildFabric = false;
                }

                if (isHire)
                {
                    if (treasure.getTreasure() >= 75 & (army.getMilitary() + 100) <= civil.getCivil())
                    {
                        army.HireMilitary();
                        treasure.setTreasure(treasure.getTreasure() - 75);
                    }
                    isHire = false;
                }

                if (isNewDay)
                {
                    civil.AddCivil(house.getMaxCivil());
                    treasure.countTreasure(civil.getCivil(), army.getMilitary(), fabric.getFabric());
                    nextDay.nextDay();
                    gameFrame.TextUpdate(civil.getCivil(), treasure.getTreasure(), army.getMilitary(), 0, house.getHouse(), fabric.getFabric(), nextDay.getDay());
                    isNewDay = false;
                }
            }
        }
        
        public void BuildHouse()
        {
            isBuildHouse = true;
        }

        public void BuildFabric()
        {
            isBuildFabric = true;
        }

        public void Hire()
        {
            isHire = true;
        }

        public void NextDay()
        {
            isNewDay = true;
        }
    }
}
