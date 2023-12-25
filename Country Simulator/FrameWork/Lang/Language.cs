using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country_Simulator.FrameWork.Lang
{
    internal class Language
    {

        private Dictionary<string, string> languageGUi;

        public Language(string path) 
        {
            setLanguageGUI(path);
        }

        public void setLanguageGUI(string path)
        {
            languageGUi = new Dictionary<string, string>();
            foreach (var languageWord in File.ReadAllLines(@path))
            {
                string[] split = languageWord.Split(new string[] { ">: " }, StringSplitOptions.None);
                languageGUi.Add(split[0], split[1]);
            }
        }

        public Dictionary<string, string> getLanguageGUI()
        {
            return languageGUi;
        }

    }
}
