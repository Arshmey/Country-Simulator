using Country_Simulator.FrameWork.Lang;
using Country_Simulator.FrameWork.Picture;
using Country_Simulator.Mechanics;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Country_Simulator.GameScreen.Frames
{
    internal class GameFrame
    {

        private Language language;
        private PictureData picture;
        private Panel container;
        private HandlerGame handlerGame;
        private Label nameCountry = new Label();
        private PictureBox civil = new PictureBox();
        private Label civilValue = new Label();
        private PictureBox treasure = new PictureBox();
        private Label treasureValue = new Label();
        private PictureBox military = new PictureBox();
        private Label militaryValue = new Label();
        private Button hireMilitary = new Button();
        private PictureBox happy = new PictureBox();
        private Label happyValue = new Label();
        private PictureBox house = new PictureBox();
        private Label houseValue = new Label();
        private Button bBuildHouse = new Button();
        private PictureBox fabric = new PictureBox();
        private Label fabricValue = new Label();
        private Button bBuildFabric = new Button();
        private PictureBox calender = new PictureBox();
        private Label calenderValue = new Label();
        private Button bNextDay = new Button();

        public GameFrame(Language language, PictureData picture, Panel container)
        {
            this.language = language;
            this.picture = picture;
            this.container = container;
            bBuildHouse.Click += (sender, EventHandler) => { bBuildHouseClicked(); };
            bBuildFabric.Click += (sender, EventHandler) => { bBuildFabricClicked(); };
            hireMilitary.Click += (sender, EventHandler) => { bHire(); };
            bNextDay.Click += (sender, EventHandler) => { bNextDayClicked(); };
        }

        public void setHandlerGame(HandlerGame handlerGame) { this.handlerGame = handlerGame; }

        public void GameFrameInit(string name)
        {

            nameCountry.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            nameCountry.Font = new Font("Arial", 10.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)0));
            nameCountry.AutoSize = true;
            nameCountry.Text = name;
            nameCountry.SetBounds(12, 30, 0, 0);
            container.Controls.Add(nameCountry);

            civil.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            civil.BackgroundImage = Image.FromFile(picture.getPicturePaths()["CIVIL"]);
            civil.BackgroundImageLayout = ImageLayout.Stretch;
            civil.SetBounds(12, 50, 40, 40);
            container.Controls.Add(civil);

            civilValue.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            civilValue.AutoSize = true;
            civilValue.SetBounds(53, 65, 0, 0);
            container.Controls.Add(civilValue);

            treasure.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            treasure.BackgroundImage = Image.FromFile(picture.getPicturePaths()["TREASURE"]);
            treasure.BackgroundImageLayout = ImageLayout.Stretch;
            treasure.SetBounds(12, 100, 34, 34);
            container.Controls.Add(treasure);

            treasureValue.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            treasureValue.AutoSize = true;
            treasureValue.SetBounds(53, 110, 0, 0);
            container.Controls.Add(treasureValue);

            military.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            military.BackgroundImage = Image.FromFile(picture.getPicturePaths()["MILITARY"]);
            military.BackgroundImageLayout = ImageLayout.Stretch;
            military.SetBounds(12, 150, 40, 40);
            container.Controls.Add(military);

            militaryValue.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            militaryValue.AutoSize = true;
            militaryValue.SetBounds(53, 165, 0, 0);
            container.Controls.Add(militaryValue);

            hireMilitary.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            hireMilitary.Text = language.getLanguageGUI()["HIRE"];
            hireMilitary.SetBounds(770, 220, 128, 32);
            container.Controls.Add(hireMilitary);

            happy.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            happy.BackgroundImage = Image.FromFile(picture.getPicturePaths()["HAPPY"]);
            happy.BackgroundImageLayout = ImageLayout.Stretch;
            happy.SetBounds(12, 200, 34, 34);
            container.Controls.Add(happy);

            happyValue.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            happyValue.AutoSize = true;
            happyValue.SetBounds(53, 210, 0, 0);
            container.Controls.Add(happyValue);

            house.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            house.BackgroundImage = Image.FromFile(picture.getPicturePaths()["HOUSE"]);
            house.BackgroundImageLayout = ImageLayout.Stretch;
            house.SetBounds(750, 50, 36, 36);
            container.Controls.Add(house);

            houseValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            houseValue.AutoSize = true;
            houseValue.SetBounds(800, 65, 0, 0);
            container.Controls.Add(houseValue);

            bBuildHouse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bBuildHouse.Text = language.getLanguageGUI()["BUILD"];
            bBuildHouse.SetBounds(770, 96, 128, 32);
            container.Controls.Add(bBuildHouse);

            fabric.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            fabric.BackgroundImage = Image.FromFile(picture.getPicturePaths()["FABRIC"]);
            fabric.BackgroundImageLayout = ImageLayout.Stretch;
            fabric.SetBounds(750, 136, 36, 36);
            container.Controls.Add(fabric);

            fabricValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            fabricValue.AutoSize = true;
            fabricValue.SetBounds(800, 148, 0, 0);
            container.Controls.Add(fabricValue);

            bBuildFabric.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bBuildFabric.Text = language.getLanguageGUI()["BUILD"];
            bBuildFabric.SetBounds(770, 178, 128, 32);
            container.Controls.Add(bBuildFabric);

            calender.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            calender.BackgroundImage = Image.FromFile(picture.getPicturePaths()["CALENDAR"]);
            calender.BackgroundImageLayout = ImageLayout.Stretch;
            calender.SetBounds(12, 570, 36, 36);
            container.Controls.Add(calender);

            calenderValue.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            calenderValue.AutoSize = true;
            calenderValue.SetBounds(53, 580, 0, 0);
            container.Controls.Add(calenderValue);

            bNextDay.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            bNextDay.Text = language.getLanguageGUI()["NEXTDAY"];
            bNextDay.SetBounds(150, 570, 128, 32);
            container.Controls.Add(bNextDay);

        }

        private void bBuildHouseClicked()
        {
            handlerGame.BuildHouse();
        }

        private void bBuildFabricClicked()
        {
            handlerGame.BuildFabric();
        }

        private void bHire()
        {
            handlerGame.Hire();
        }

        private void bNextDayClicked()
        {
            handlerGame.NextDay();
        }

        public void TextUpdate(int civil, double treasure, int military, int happy, int house, int fabric, int day)
        {
            civilValue.Invoke(new Action(() => { civilValue.Text = language.getLanguageGUI()["CIVIL"] + ": " + civil; }));
            treasureValue.Invoke(new Action(() => { treasureValue.Text = language.getLanguageGUI()["TREASURE"] + ": " + treasure; }));
            militaryValue.Invoke(new Action(() => { militaryValue.Text = language.getLanguageGUI()["MILITARY"] + ": " + military; }));
            happyValue.Invoke(new Action(() => { happyValue.Text = language.getLanguageGUI()["HAPPY"] + ": " + happy; }));
            houseValue.Invoke(new Action(() => { houseValue.Text = language.getLanguageGUI()["HOUSE"] + ": " + house; }));
            fabricValue.Invoke(new Action(() => { fabricValue.Text = language.getLanguageGUI()["FABRIC"] + ": " + fabric; }));
            calenderValue.Invoke(new Action(() => { calenderValue.Text = language.getLanguageGUI()["DAY"] + ": " + day; }));           
        }
    }
}
