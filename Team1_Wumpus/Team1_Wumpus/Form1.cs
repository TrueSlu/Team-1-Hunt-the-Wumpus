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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                MessageBox.Show("Please enter your name to play.");
            }


            int numberOfAvailableCaves

            Game gameObject = new Game(caveSystem, nameBox.Text);
        }

        private void highScores_Click(object sender, EventArgs e)
        {
            List<HighScore> highScores = HighScoreManager.getHighScores();
        }
    }
}
