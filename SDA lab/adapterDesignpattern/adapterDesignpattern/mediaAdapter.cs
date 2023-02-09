using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterDesignpattern
{
    public class mediaAdapter : mediaPlayer
    {
        advancedmediaPlayer advancedmusicPlayer;
        public  mediaAdapter(string audiotype)
        {
            if (audiotype.Equals("vlc")) 
            {

                advancedmusicPlayer = new vlcPlayer();
            }
            else if(audiotype.Equals("mp4"))
            {
                advancedmusicPlayer = new mp4Player();
            }
           
        }
        public void play(string audioType,string filename)
        {
            if (audioType.Equals("vlc"))
            {
                advancedmusicPlayer.playVlc(filename);
            }
            else if (audioType.Equals("mp4"))
            {
                advancedmusicPlayer.playMp4(filename);
            }
        }
    }
}
