using System;
using System.Collections.Generic;
using System.IO;

namespace Country_Simulator.FrameWork
{
    internal class LocalizitionData
    {

        private Dictionary<string, string> languagePaths = new Dictionary<string, string>();
        private Dictionary<string, string> nameLanguage = new Dictionary<string, string>();

        public LocalizitionData(string path)
        {
            setLanguagePaths(path);
        }

        private void setLanguagePaths(string path)
        {
            foreach (var languageFiles in File.ReadAllLines(@path)) 
            {
                string[] ID_LANGUAGE = languageFiles.Split(new string[] { ">: " }, StringSplitOptions.None);
                string[] SPLIT_PATH_AND_NAME = ID_LANGUAGE[1].Split(new string[] { " :NAME: " }, StringSplitOptions.None);
                languagePaths.Add(ID_LANGUAGE[0], SPLIT_PATH_AND_NAME[0]);
                nameLanguage.Add(SPLIT_PATH_AND_NAME[1], ID_LANGUAGE[0]);
            }
        }

        public Dictionary<string, string> getLanguagePaths()
        {
            return languagePaths;
        }

        public Dictionary<string, string> getNameLanguage()
        {
            return nameLanguage;
        }
    }
}
