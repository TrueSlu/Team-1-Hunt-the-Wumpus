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

        List<int> AvailableCavesList = new List<int>();

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
            roomNumber.Text = GameObject.LocationManager.Player.ToString();
            messageLabel.Text = "Time to Hunt!";
            foreach(int AvailableCave in GameObject.CaveManager.GetConnectedList(GameObject.LocationManager.Wumpus))
            {
                availableCaveMoves.Items.Add(AvailableCave);
                AvailableCavesList.Add(AvailableCave);
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            ReinitializePlayerInfoBox();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void playerInfoBox_Enter(object sender, EventArgs e)
        {

        }

        private void movePlayerButton_Click(object sender, EventArgs e)
        {
            if (availableCaveMoves.SelectedIndex >= AvailableCavesList.Count || availableCaveMoves.SelectedIndex < 0) {
                MessageBox.Show("Please select a cave to move to.");
            } else
            {
                int desiredRoom = AvailableCavesList[availableCaveMoves.SelectedIndex];
                GameObject.MovePlayer(desiredRoom);

                ReinitializePlayerInfoBox();


            }
        }

        private void fireArrowButtonClick_Click(object sender, EventArgs e)
        {
            if (availableCaveMoves.SelectedIndex >= AvailableCavesList.Count || availableCaveMoves.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a cave to arrow at.");
            }
            else
            {
                int desiredRoom = AvailableCavesList[availableCaveMoves.SelectedIndex];
                GameObject.FireArrow(desiredRoom);
                ReinitializePlayerInfoBox();
            }
        }
    }
}
