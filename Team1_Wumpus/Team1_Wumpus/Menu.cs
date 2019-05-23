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

        }

        private void showHighScores_Click(object sender, EventArgs e)
        {
            HighScoreManager tempHighScoreManager = new HighScoreManager();

            FormHighScore HighScoreForm = new FormHighScore();
            List<HighScore> HighScores = tempHighScoreManager.GetHighScores();
            HighScoreForm.scores = HighScores;

            HighScoreForm.ShowDialog();


        }
    }
}
