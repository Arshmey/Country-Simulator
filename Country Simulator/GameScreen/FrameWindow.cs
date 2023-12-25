using Country_Simulator.FrameWork;
using Country_Simulator.FrameWork.Lang;
using Country_Simulator.FrameWork.Picture;
using Country_Simulator.GameScreen;
using System;
using System.Windows.Forms;

namespace Country_Simulator
{
    public partial class FrameWindow : Form
    {

        LocalizitionData localizitionData;
        Language language;
        PictureData picture;
        HandlerScreen handlerScreen;
        MainGameMenu mainGameMenu;

        public FrameWindow()
        {
            CoreFiles coreFiles = new CoreFiles();
            localizitionData = new LocalizitionData(coreFiles.getDataPaths()["LANG"]);
            language = new Language(localizitionData.getLanguagePaths()[localizitionData.getNameLanguage()["English"]]);
            picture = new PictureData(coreFiles.getDataPaths()["PIC"]);
            InitializeComponent();
            handlerScreen = new HandlerScreen(language, picture, container);

            mainGameMenu = new MainGameMenu(language, container, handlerScreen);
            mainGameMenu.Menu();
        }

        private void FrameWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
