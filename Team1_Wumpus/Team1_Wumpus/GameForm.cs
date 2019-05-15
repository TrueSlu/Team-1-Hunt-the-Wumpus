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
    public partial class GameForm : Form
    {

        public Game GameObject { get; set; }
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            while (true)
            {
                MessageBox.Show("Hi");
            }
        }
    }
}
