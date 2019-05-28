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
    public partial class GameForm : System.Windows.Forms.Form
    {

        public Game GameObject { get; set; }
        public GameForm()
        {
            InitializeComponent();
        }

        private void ReinitializePlayerInfoBox()
        {
            playerInfoNameBox.Text = GameObject.Name;
            playerInfoCoinsBox.Text = GameObject.PlayerManager.GoldCoins.ToString();
            playerInfoArrowsBox.Text = GameObject.PlayerManager.Arrows.ToString();
            playerInfoTurnsBox.Text = GameObject.PlayerManager.TurnsTaken.ToString();
            playerInfoScoreBox.Text = GameObject.PlayerManager.Score.ToString();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
