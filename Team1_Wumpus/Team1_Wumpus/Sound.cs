using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Wumpus
{


    public class Sound
    {
        MediaPlayer player = new MediaPlayer();
        //soundplayer = new sound
        public void PlayBats()
        {
            player.Open(new Uri(AppDomain.CurrentDomain.BaseDirectory + "\\batschatter.wav"));

            player.Play();
        }


    }
}
