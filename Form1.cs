using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rad_assignment3
{
    public partial class Form1 : Form
    {

        private List<Player> players;
        public Form1()
        {
            InitializeComponent();
            LoadPlayers();
            lblPlayerDetails.Text = "";
        }

        private void LoadPlayers()
        {
            players = new List<Player>
            {
            // Team: Lakers
            new Player("LeBron James", "Lakers", "Small Forward", 27.5, 7.9, 7.4, 1.6, "Purple"),
            new Player("Anthony Davis", "Lakers", "Power Forward", 24.1, 2.9, 10.5, 2.1, "Purple"),
            new Player("Russell Westbrook", "Lakers", "Point Guard", 22.7, 8.4, 7.1, 1.7, "Purple"),
            new Player("Dwight Howard", "Lakers", "Center", 6.2, 1.0, 5.9, 0.9, "Purple"),
            new Player("Carmelo Anthony", "Lakers", "Power Forward", 13.3, 1.1, 4.2, 0.7, "Purple"),
            new Player("Kent Bazemore", "Lakers", "Shooting Guard", 6.4, 1.0, 3.1, 0.9, "Purple"),
            new Player("Malik Monk", "Lakers", "Shooting Guard", 11.7, 2.4, 2.9, 0.8, "Purple"),
            new Player("Austin Reaves", "Lakers", "Shooting Guard", 7.3, 1.8, 3.2, 0.5, "Purple"),
            new Player("Talen Horton-Tucker", "Lakers", "Small Forward", 10.0, 2.7, 3.2, 1.0, "Purple"),
            new Player("Stanley Johnson", "Lakers", "Small Forward", 6.7, 1.7, 3.2, 0.7, "Purple"),

            // Team: Bulls
            new Player("Zach LaVine", "Bulls", "Shooting Guard", 25.3, 4.4, 4.8, 1.0, "Red"),
            new Player("DeMar DeRozan", "Bulls", "Small Forward", 23.2, 4.9, 4.5, 1.0, "Red"),
            new Player("Nikola Vucevic", "Bulls", "Center", 18.6, 3.4, 11.0, 1.0, "Red"),
            new Player("Lonzo Ball", "Bulls", "Point Guard", 13.0, 5.4, 5.5, 1.8, "Red"),
            new Player("Coby White", "Bulls", "Point Guard", 12.7, 2.9, 3.0, 0.5, "Red"),
            new Player("Patrick Williams", "Bulls", "Power Forward", 9.2, 1.1, 4.6, 0.7, "Red"),
            new Player("Javonte Green", "Bulls", "Small Forward", 7.2, 1.1, 4.2, 1.0, "Red"),
            new Player("Derrick Jones Jr.", "Bulls", "Power Forward", 6.9, 0.8, 3.4, 0.6, "Red"),
            new Player("Alex Caruso", "Bulls", "Shooting Guard", 8.0, 4.0, 3.6, 1.7, "Red"),
            new Player("Tony Bradley", "Bulls", "Center", 3.5, 0.6, 4.1, 0.3, "Red"),

            // Team: Warriors
            new Player("Stephen Curry", "Warriors", "Point Guard", 29.3, 6.5, 5.4, 1.5, "Blue"),
            new Player("Klay Thompson", "Warriors", "Shooting Guard", 21.5, 2.2, 4.1, 0.9, "Blue"),
            new Player("Draymond Green", "Warriors", "Power Forward", 8.0, 6.9, 7.4, 1.4, "Blue"),
            new Player("Andrew Wiggins", "Warriors", "Small Forward", 18.5, 2.2, 4.3, 0.9, "Blue"),
            new Player("Jordan Poole", "Warriors", "Shooting Guard", 18.3, 4.0, 3.4, 0.5, "Blue"),
            new Player("James Wiseman", "Warriors", "Center", 11.5, 0.7, 5.8, 0.3, "Blue"),
            new Player("Otto Porter Jr.", "Warriors", "Small Forward", 8.2, 1.5, 5.3, 1.1, "Blue"),
            new Player("Kevon Looney", "Warriors", "Center", 6.0, 1.5, 7.3, 0.5, "Blue"),
            new Player("Juan Toscano-Anderson", "Warriors", "Power Forward", 4.2, 2.0, 3.0, 0.7, "Blue"),
            new Player("Nemanja Bjelica", "Warriors", "Power Forward", 6.1, 2.2, 4.1, 0.5, "Blue")
            };
        }

        private void DisplayPlayers(string teamName)
        {
            var teamPlayers = players.Where(p => p.Team == teamName).ToList();
            listBoxPlayers.DataSource = teamPlayers;
            listBoxPlayers.DisplayMember = "Name";

            listBoxPlayers.SelectedIndex = -1;

            if (teamPlayers.Count == 0)
            {
                MessageBox.Show($"No available players found for the team {teamName}.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedTeam = comboBoxTeams.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedTeam))
            {
                DisplayPlayers(selectedTeam);
            }
            else
            {
                MessageBox.Show("Please select a team from the dropdown.");
            }
        }

        private void listBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem is Player selectedPlayer)
            {
                // Display player details
                lblPlayerDetails.Text = $"{selectedPlayer.Name} - {selectedPlayer.Team}\n" +
                                        $"Position: {selectedPlayer.Position}\n" +
                                        $"Points: {selectedPlayer.PointsPerGame:F1}\n" +
                                        $"Assists: {selectedPlayer.AssistsPerGame:F1}\n" +
                                        $"Rebounds: {selectedPlayer.ReboundsPerGame:F1}\n" +
                                        $"Steals: {selectedPlayer.StealsPerGame:F1}";
            }
            else
            {
                // Clear player details if no player is selected
                lblPlayerDetails.Text = string.Empty;
            }
        }
    }
}
