using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterDesignpattern
{
    public class mp4Player : advancedmediaPlayer
    {
        public void playVlc(string filename)
        {
            //do nothing
        }
        public void playMp4(string filename)
        {
            Console.WriteLine("playing Mp4 file. Name = " + filename);
        }
    }
}
