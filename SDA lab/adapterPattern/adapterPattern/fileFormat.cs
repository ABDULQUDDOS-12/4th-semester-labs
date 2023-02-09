using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterPattern
{
    public interface fileFormat
    {
        public void data(string fileType,string fileName);
    }
}
