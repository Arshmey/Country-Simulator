using System;
using System.Collections.Generic;
using System.IO;

namespace Country_Simulator.FrameWork
{
    internal class CoreFiles
    {

        private string pathCore = @"CoreData.necars";
        private Dictionary<string, string> dataPaths = new Dictionary<string, string>();

        public CoreFiles() 
        {
            setDataPaths();
        }

        private void setDataPaths()
        {
            foreach (var path in File.ReadAllLines(pathCore))
            {
                string[] split = path.Split(new string[] { ">: " }, StringSplitOptions.None);
                dataPaths.Add(split[0], split[1]);
            }
        }

        public Dictionary<string, string> getDataPaths()
        {
            return dataPaths;
        }
    }
}
