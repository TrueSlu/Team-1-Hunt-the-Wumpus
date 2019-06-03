using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Team1_Wumpus
{
    public class Sound
    {
        public List<SoundPlayer> Sounds= new List<SoundPlayer>();
        public void PlayBats()
        {
            SoundPlayer BatSound = new SoundPlayer(Properties.Resources.bat);
            BatSound.Play();
            Sounds.Add(BatSound);
            PlayBackground();
        }

        public void PlayWumpus()
        {

        }

        public void PlayPit()
        {
            SoundPlayer PitSound = new SoundPlayer(Properties.Resources.scream);
            PitSound.Play();
            Sounds.Add(PitSound);
            PlayBackground();
        }

        public void PlayBackground()
        {
            //background music
            SoundPlayer Background = new SoundPlayer(Properties.Resources.background);
            Background.PlayLooping();
            Sounds.Add(Background);
        }

        public void StopAll()
        {
            foreach(SoundPlayer Sound in Sounds)
            {
                Sound.Stop();
            }
        }

    }
}
