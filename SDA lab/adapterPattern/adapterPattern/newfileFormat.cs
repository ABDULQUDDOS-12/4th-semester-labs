using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterPattern
{
    public interface newfileFormat
    {
        public void XML(string fileName);
        public void JSON(string fileName);
    }
}
