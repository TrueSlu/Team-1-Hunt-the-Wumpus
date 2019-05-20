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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                caveSystemBox.Items.Add("Cave " + i);
            }
        }

        private void Start_Game_Button(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                MessageBox.Show("Please enter your name to play.");
                return;
            }

            int chosenCaveSystem = caveSystemBox.SelectedIndex;

            Game gameObject = new Game(nameBox.Text, chosenCaveSystem);
            this.Close();
        }

        private void Show_High_Scores_Button(object sender, EventArgs e)
        {
            //List<HighScore> highScores = HighScoreManager.getHighScores();

        }

        private void Cave_Box_Change(object sender, EventArgs e)
        {

        }
    }
}
