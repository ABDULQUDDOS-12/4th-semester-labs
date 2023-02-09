using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterPattern
{
    public class formatAdapter : fileFormat
    {
        newfileFormat newfileformat;
        public formatAdapter(string fileType)
        {
            if (fileType.Equals("xml"))
            {
                newfileformat = new xmlFormat();
            }
            else if (fileType.Equals("json"))
            {
                newfileformat = new jsonFormat();
            }
        }
        public void data(string fileType,string fileName)
        {
            if (fileType.Equals("xml"))
            {
                newfileformat.XML(fileName);
            }
            else if (fileType.Equals("json"))
            {
                newfileformat.JSON(fileName);
            }
        }

    }
}
