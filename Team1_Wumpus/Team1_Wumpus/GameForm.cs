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
        public bool TestMode { get; set; }

        public GameForm()
        {
            InitializeComponent();
        }

        private void ReinitializePlayerInfoBox()
        {
            if (TestMode)
            {
                ReinitializeTestObjects();
            }
            availableCaveMoves.Items.Clear();
            AvailableCavesList.Clear();
            playerInfoNameBox.Text = GameObject.Name;
            playerInfoCoinsBox.Text = GameObject.PlayerManager.GoldCoins.ToString();
            playerInfoArrowsBox.Text = GameObject.PlayerManager.Arrows.ToString();
            playerInfoTurnsBox.Text = GameObject.PlayerManager.TurnsTaken.ToString();
            roomNumber.Text = GameObject.LocationManager.Player.ToString();
            foreach(int AvailableCave in GameObject.CaveManager.GetConnectedList(GameObject.LocationManager.Player))
            {
                availableCaveMoves.Items.Add(AvailableCave);
                AvailableCavesList.Add(AvailableCave);
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            if (TestMode)
            {
                InitializeTestObjects();
            }
            ReinitializePlayerInfoBox();
        }

        private void InitializeTestObjects()
        {
            WumpusLabel.Visible = true;
            BatsLabel.Visible = true;
            PitsLabel.Visible = true;
            WumpusBox.Visible = true;
            BatsBox.Visible = true;
            PitsBox.Visible = true;
        }

        private void ReinitializeTestObjects()
        {
            WumpusBox.Text = GameObject.LocationManager.Wumpus.ToString();
            BatsBox.Text = GameObject.LocationManager.Bats[0].ToString() + ", " + GameObject.LocationManager.Bats[1].ToString();
            PitsBox.Text = GameObject.LocationManager.Pits[0].ToString() + ", " + GameObject.LocationManager.Pits[1].ToString();
        }

        private void movePlayerButton_Click(object sender, EventArgs e)
        {
            if (availableCaveMoves.SelectedIndex >= AvailableCavesList.Count || availableCaveMoves.SelectedIndex < 0) {
                MessageBox.Show("Please select a cave to move to.");
            } else
            {
                int desiredRoom = AvailableCavesList[availableCaveMoves.SelectedIndex];
                string message = GameObject.MovePlayer(desiredRoom);

                ReinitializePlayerInfoBox();
                MessageBox.Show(message);


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

        private void buyArrowButtonClick_Click(object sender, EventArgs e)
        {
            bool didBuyArrow = GameObject.PlayerManager.PurchaseArrow();
            if (didBuyArrow)
            {
                ReinitializePlayerInfoBox();
            } else
            {
                MessageBox.Show("You need 1 coin to buy an arrow.");
            }
        }

        private void buySecretButtonClick_Click(object sender, EventArgs e)
        {
            bool didBuySecret = GameObject.PlayerManager.PurchaseSecret();
            if (didBuySecret)
            {
                string secret = GameObject.TriviaObject.GetSecret();
                MessageBox.Show(secret);
            } else
            {
                MessageBox.Show("You need 2 coins to buy a secret.");
            }
        }
    }
}
