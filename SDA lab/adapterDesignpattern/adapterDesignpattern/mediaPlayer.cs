using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterDesignpattern
{
    public interface mediaPlayer
    {
        public void play(string audioType, string fileName);
    }
}
