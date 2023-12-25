using Country_Simulator.FrameWork.Lang;
using Country_Simulator.GameScreen.Frames;
using Country_Simulator.Mechanics;
using System.Windows.Forms;

namespace Country_Simulator.GameScreen
{

    internal class MainGameMenu
    {

        private Language language;
        private Panel container;
        private HandlerScreen handlerScreen;
        private Button bNewGame = new Button();
        private TextBox nameCountry = new TextBox();
        private Button bSettings = new Button();
        private Button bContinue = new Button();


        public MainGameMenu(Language language, Panel container, HandlerScreen handlerScreen)
        {
            this.container = container;
            this.language = language;
            this.handlerScreen = handlerScreen;
        }

        public void Menu()
        {
            // bNewGame
            bNewGame.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bNewGame.SetBounds(12, 488, 227, 33);
            bNewGame.Name = "bNewGame";
            bNewGame.Text = language.getLanguageGUI()["NEWGAME"];
            bNewGame.Click += (sender, HandledEventHandler) => { NewGame(); };

            container.Controls.Add(bNewGame);

            // nameCountry
            nameCountry.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nameCountry.SetBounds(239, 494, 256, 32);
            container.Controls.Add(nameCountry);

            // bContinue
            bContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bContinue.SetBounds(12, 527, 227, 33);
            bContinue.Text = language.getLanguageGUI()["CONTINUE"];
            container.Controls.Add(bContinue);

            // bSettings
            bSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bSettings.SetBounds(12, 566, 227, 33);
            bSettings.Text = language.getLanguageGUI()["SETTINGS"];
            container.Controls.Add(bSettings);
        }

        public void NewGame()
        {
            if (nameCountry.Text != "")
            {
                container.Controls.Clear();
                handlerScreen.NewGame("NewGame", nameCountry.Text);
            } else { MessageBox.Show(language.getLanguageGUI()["TITLE_1"], language.getLanguageGUI()["WARNING"]); }
        }
    }
}
