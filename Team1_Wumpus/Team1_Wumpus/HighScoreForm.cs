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
    public partial class FormHighScore : System.Windows.Forms.Form
    {
        Random rnd = new Random();

        List<HighScore> scores = new List<HighScore>();
        public FormHighScore()
        {
            InitializeComponent();
        }

        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            HighScore s = scores[listBoxScores.SelectedIndex];

            textBoxName.Text = s.Name;
            textBoxCave.Text = s.Cave;
            textBoxScore.Text = s.Score.ToString();


        }

        private void UpdateListBox()
        {
            listBoxScores.Items.Clear();
            foreach (HighScore s in scores)
            {
                listBoxScores.Items.Add(s);
            }

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            String cave = textBoxCave.Text;
            int score = int.Parse(textBoxScore.Text);

            HighScore hs = new HighScore(name, cave, score);

            scores.Add(hs);

            scores = scores.OrderByDescending(x => x.Score).ToList();
            UpdateListBox();

            if (listBoxScores.Items.Count > 10)
            {
                listBoxScores.Items.Remove(scores[10]);
            }
        }
    }
}
