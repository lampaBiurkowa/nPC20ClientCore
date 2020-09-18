using CapsBallShared;
using GeoLib;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace CapsBallCore
{
    public class StadiumData
    {
        public string BackgroundPath { get; set; }
        public Vector2 BallDefaultPosition { get; set; } = new Vector2();
        public int BonusChangeSeconds { get; set; }
        public int BonusesCount { get; set; }
        public Environment Environment { get; set; }
        public List<ItemData> Items { get; set; } = new List<ItemData>();
        public int Height { get; set; }
        public List<TargetData> Targets { get; set; } = new List<TargetData>();
        public int Width { get; set; }

        public StadiumData(string stadiumName)
        {
            string[] data = File.ReadAllLines(getStadiumPath(stadiumName));
            bool stadiumDataLoaded = false;

            foreach (string line in data) //TODO trim
            {
                if (line.Length > 0 && line[0] == StadConstants.COMMENT_CHAR || string.IsNullOrWhiteSpace(line))
                    continue;

                if (!stadiumDataLoaded)
                {
                    loadStadiumData(stadiumName, line);
                    stadiumDataLoaded = true;
                }
                else if (line[0] == StadConstants.TARGET_ID)
                    loadTargetData(line);
                else
                    Items.Add(new ItemData(stadiumName, line));
            }
        }

        string getStadiumPath(string stadiumName) =>
            $"{StadConstants.STADIUMS_PATH}{stadiumName}/{StadConstants.STAD_FILE_NAME}";

        void loadStadiumData(string name, string line)
        {
            string[] data = line.Split(StadConstants.SEPARATOR_CHAR);
            Width = int.Parse(data[0]);
            Height = int.Parse(data[1]);
            float footballerMass = float.Parse(data[2], CultureInfo.InvariantCulture);
            float power = float.Parse(data[3], CultureInfo.InvariantCulture);
            float playerRadius = float.Parse(data[4], CultureInfo.InvariantCulture);
            float speed = float.Parse(data[5], CultureInfo.InvariantCulture);
            BonusChangeSeconds = int.Parse(data[6]);
            BonusesCount = int.Parse(data[7]);
            float ballMass = float.Parse(data[8], CultureInfo.InvariantCulture);
            float ballX = float.Parse(data[9], CultureInfo.InvariantCulture);
            float ballY = float.Parse(data[10], CultureInfo.InvariantCulture);
            BallDefaultPosition = new Vector2(ballX, ballY);
            BackgroundPath = $"{StadConstants.STADIUMS_PATH}/{name}/{StadConstants.RESOURCES_PATH}/{data[11]}";

            Environment = new Environment()
            {
                BallMass = ballMass,
                FootballerBounce = footballerMass,
                Power = power,
                PlayerRadius = playerRadius,
                Speed = speed
            };
        }

        void loadTargetData(string data)
        {
            data = data.Substring(StadConstants.TARGET_ID.ToString().Length);

            string[] components = data.Split(StadConstants.SEPARATOR_CHAR);
            float x = float.Parse(components[0], CultureInfo.InvariantCulture);
            float y = float.Parse(components[1], CultureInfo.InvariantCulture);
            float w = float.Parse(components[2], CultureInfo.InvariantCulture);
            float h = float.Parse(components[3], CultureInfo.InvariantCulture);
            TeamType owner = components[4][0] == StadConstants.BLUE_TEAM_ID ? TeamType.BLUE : TeamType.RED;
            Targets.Add(new TargetData(new RectStruct(x, y, w, h), owner));
        }
    }
}
