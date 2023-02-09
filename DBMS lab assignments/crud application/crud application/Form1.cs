using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace crud_application
{
    public partial class Form1 : Form
    {
        Employee employee = new Employee();
        public Form1();

        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private const string InsertQuery = "Insert Into Emp_details(EmpId, EmpName, EmpAge, EmpContact, EmpGender) Values (@EmpId, @EmpName, @EmpAge, @EmpContact, @EmpGender)";
        

        public Form1()
        {
            InitializeComponent();
            dgvEmployeeDetails.DataSource = employee.GetEmployees();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
