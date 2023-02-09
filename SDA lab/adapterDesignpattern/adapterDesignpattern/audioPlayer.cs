using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterDesignpattern
{
    public class audioPlayer : mediaPlayer
    {
        mediaAdapter mediaadapter;
        public void play(string audiotype,string filename)
        {
            if (audiotype.Equals("mp3"))
            {
                Console.WriteLine("playing mp3 file. name = " + filename);
            }
            else if (audiotype.Equals("vlc") || audiotype.Equals("mp4"))
            {
                mediaadapter = new mediaAdapter(audiotype);
                mediaadapter.play(audiotype, filename);
            }
            else
            {
                Console.WriteLine("invalid media " +audiotype+ " format not supported" );
            }
        }

    }
}
