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
    public partial class GameEndForm : Form
    {

        public Player PlayerObject { get; set; }

        public GameEndForm()
        {
            InitializeComponent();
        }

        private void GameEndForm_Load(object sender, EventArgs e)
        {
            if (PlayerObject.IsWumpusDead)
            {
                gameLabel.Text = "Congratulations!";
            } else
            {
                gameLabel.Text = "Game Over!";
            }

            playerInfoArrowsBox.Text = PlayerObject.Arrows.ToString();
            playerInfoCoinsBox.Text = PlayerObject.GoldCoins.ToString();
            playerInfoTurnsBox.Text = PlayerObject.TurnsTaken.ToString();
            playerInfoScoreBox.Text = PlayerObject.Score.ToString();
        }   

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
