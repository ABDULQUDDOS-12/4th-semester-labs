using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterPattern
{
    public class previousFormat : fileFormat
    {
        public void data(string fileType,string fileName)
        {
            formatAdapter formatadapter;
            if (fileType.Equals("docx"))
            {
                Console.WriteLine("this is docx file.name" + fileName);
            }
            else if(fileType.Equals("xml") || fileType.Equals("json"))
            {
                formatadapter = new formatAdapter(fileType);
                formatadapter.data(fileType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid file format");
            }
        }
    }
}
