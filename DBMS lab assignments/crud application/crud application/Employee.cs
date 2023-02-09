using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace crud_application
{
    internal class Employee
    {
        
        public string EmpId { get; set; }
        public string EmpName { get; set; }    
        public int Age { get; set; }
        public string ContactNo { get; set; }

    }
}
