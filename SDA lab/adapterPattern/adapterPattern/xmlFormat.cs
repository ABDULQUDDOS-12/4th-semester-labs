using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterPattern
{
    public class xmlFormat : newfileFormat
    {
        public void XML(string filename)
        {
            Console.WriteLine("this is xml file. name = " + filename);
        }
        public void JSON(string filename)
        {
            //do nothing
        }
    }
}
