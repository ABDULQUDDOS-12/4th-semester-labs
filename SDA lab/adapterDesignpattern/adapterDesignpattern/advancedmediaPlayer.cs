using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterDesignpattern
{
    public interface advancedmediaPlayer
    {
        public void playVlc(string filename);
        public void playMp4(string filename);
    }
}
