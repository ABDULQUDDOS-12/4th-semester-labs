using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterDesignpattern
{
    public class vlcPlayer : advancedmediaPlayer
    {
        public void playVlc(string filename)
        {
            Console.WriteLine("playing vlc file. Name = " + filename);
        }
        public  void playMp4(string filename)
        {
            //do nothing
        }
    }
}
