using System;

namespace rad_assignment3
{
    internal class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public double PointsPerGame { get; set; }
        public double AssistsPerGame { get; set; }
        public double ReboundsPerGame { get; set; }
        public double StealsPerGame { get; set; }
        public string CardColor { get; set; }

        public string PhotoPath { get; set; }

        public Player(string name, string team, string position, double points, double assists, double rebounds, double steals, string cardColor, string photoPath = "")
        {
            Name = name;
            Team = team;
            Position = position;
            PointsPerGame = points;
            AssistsPerGame = assists;
            ReboundsPerGame = rebounds;
            StealsPerGame = steals;
            CardColor = cardColor;
            PhotoPath = photoPath;
        }
    }
}
