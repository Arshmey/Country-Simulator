using System;
using System.Collections.Generic;
using System.IO;

namespace Country_Simulator.FrameWork.Picture
{
    internal class PictureData
    {

        private Dictionary<string, string> picturePaths = new Dictionary<string, string>();

        public PictureData(string path)
        {
            setPicturePaths(path);
        }

        private void setPicturePaths(string path)
        {
            foreach (var picture in File.ReadAllLines(@path))
            {
                string[] split = picture.Split(new string[] { ">: " }, StringSplitOptions.None);
                picturePaths.Add(split[0], split[1]);
            }
        }

        public Dictionary<string, string> getPicturePaths()
        {
            return picturePaths;
        }

    }
}
