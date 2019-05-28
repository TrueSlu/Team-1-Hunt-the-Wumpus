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

        public void background()
        {
            //background music
            player.Open(new Uri(AppDomain.CurrentDomain.BaseDirectory + "\\2019-04-18_-_The_Epic_Boss_Fight_-_David_Fesliyan.mp3"));
            player.Open(new Uri(AppDomain.CurrentDomain.BaseDirectory + "\\2019-05-09_-_Escape_Chase_-_David_Fesliyan.mp3"));
            player.Play();

        }

    }
}
