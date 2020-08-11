﻿using System.Collections.Generic;
using System.IO;

namespace CapsBallCore
{
    public class StadiumData
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public float Bounce { get; set; }
        public float Power { get; set; }
        public float Size { get; set; }
        public float Speed { get; set; }
        public List<ItemData> Items { get; set; }

        public StadiumData(string stadiumName)
        {
            string[] data = File.ReadAllLines(getStadiumPath(stadiumName);
            bool stadiumDataLoaded = false;

            foreach (string line in data)
            {
                if (line.Length > 0 && line[0] == StadConstants.COMMENT_CHAR)
                    continue;

                if (!stadiumDataLoaded)
                {
                    loadStadiumData(line);
                    stadiumDataLoaded = true;
                }
                else
                    Items.Add(new ItemData(line));
            }
        }

        string getStadiumPath(string stadiumName) => 
            $"{StadConstants.STADIUMS_PATH}{stadiumName}{StadConstants.STAD_FILE_EXTENSION}";

        void loadStadiumData(string line)
        {
            string[] data = line.Split(StadConstants.SEPARATOR_CHAR);
            Width = int.Parse(data[0]);
            Height = int.Parse(data[1]);
            Bounce = float.Parse(data[2]);
            Power = float.Parse(data[3]);
            Size = float.Parse(data[4]);
            Speed = float.Parse(data[5]);
        }
    }
}
