using Country_Simulator.FrameWork.Lang;
using Country_Simulator.FrameWork.Picture;
using Country_Simulator.GameScreen.Frames;
using Country_Simulator.Mechanics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Country_Simulator.GameScreen
{
    internal class HandlerScreen
    {

        Language language;
        PictureData picture;
        Panel container;
        HandlerGame handlerGame;
        GameFrame gameFrame;

        public HandlerScreen(Language language, PictureData picture, Panel container) 
        {
            this.language = language;
            this.picture = picture;
            this.container = container;
            gameFrame = new GameFrame(language, picture, container);
            handlerGame = new HandlerGame(gameFrame);
        }

        public void NewGame(string nameFrame, string nameCountry)
        {
            gameFrame.GameFrameInit(nameCountry);
            gameFrame.setHandlerGame(handlerGame);
            handlerGame.StartGame();
        }

        public void ScreenChange(string nameFrame)
        {

        }

    }
}
