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
    public partial class HighScoreForm : Form
    {
        public HighScoreForm()
        {
            InitializeComponent();
        }

        public List<HighScore> HighScores { get; set; }

        private void HighScoreForm_Load(object sender, EventArgs e)
        {
            foreach (HighScore scoreObject in HighScores)
            {
                highScoresBox.Items.Add(scoreObject.Score);
            }
        }

        private void highScoresBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                HighScore selectedScore = HighScores[highScoresBox.SelectedIndex];

                nameBox.Text = selectedScore.Name;
                caveBox.Text = selectedScore.Cave.ToString();
                scoreBox.Text = selectedScore.Score.ToString();
            }
            catch
            {
                MessageBox.Show("Please select a valid High Score from the list box.");
            }
        }
    }
}
