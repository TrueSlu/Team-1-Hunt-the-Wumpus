using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1_Wumpus
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            CaveSystem tempCaveSystem = new CaveSystem();
            //List<String> playableCaves = tempCaveSystem.getPlayableCaves();

            List<string> playableCaves = new List<string>()
            {
                "system0",
                "system1",
            };

            foreach(string cave in playableCaves)
            {
                caveList.Items.Add(cave);
            }
        }

        private void showHighScores_Click(object sender, EventArgs e)
        {
            HighScoreManager tempHighScoreManager = new HighScoreManager();

            FormHighScore HighScoreForm = new FormHighScore();
            List<HighScore> HighScores;

            //uncomment the below to test high score manager on a new machine
            //tempHighScoreManager.CreateSampleScore();

            HighScores = tempHighScoreManager.ReadScores();
            HighScoreForm.scores = HighScores;
            HighScoreForm.ShowDialog();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                MessageBox.Show("Please enter your name to play.");
            } else if (caveList.SelectedIndex >= caveList.Items.Count && caveList.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a cave to play.");
            } else
            {
                if (caveList.SelectedIndex == 0)
                {
                    Game GameManager = new Game(nameBox.Text, Properties.Resources.system0, false, 0);
                } else if (caveList.SelectedIndex == 1)
                {
                    Game GameManager = new Game(nameBox.Text, Properties.Resources.system1, false, 1);
                }
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inglemoor High School Team1");
        }

        private void getStartedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("In the spirit of Team1, select a cave, type your name, and start Hunting the Wumpus without a tutorial or prior experience.");
        }

        private void testModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game GameManager = new Game("Test Mode", Properties.Resources.system0, true, 99);
        }
    }
}
