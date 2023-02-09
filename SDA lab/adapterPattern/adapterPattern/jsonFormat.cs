using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterPattern
{
    public class jsonFormat: newfileFormat
    {
        public void XML(string filename)
        {
            //do nothing
        }
        public void JSON(string filename)
        {
            Console.WriteLine("this is json file. name = " + filename);
        }
    }
}
