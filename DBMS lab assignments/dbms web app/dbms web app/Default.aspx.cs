using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dbms_web_app
{
    public partial class _Default : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadRecord();
            }
        }
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E5JJ4PE\ABDULSQL;Initial Catalog=ProgrammingDB;User ID=sa;Password=abdul542001");

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("insert into Studentinfo_Tab values('" + int.Parse(TextBox1.Text) + "','" + TextBox2.Text + "','" + DropDownList1.SelectedValue + "','" + double.Parse(TextBox5.Text) + "','" + TextBox4.Text + "')", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully inserted');", true);      
        }

        void LoadRecord()
        {
            SqlCommand comm = new SqlCommand("select * from Studentinfo_Tab", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();


        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("update into Studentinfo_Tab set [Student Name] = '" + TextBox2.Text + "',Adress = '" + DropDownList1.SelectedValue + "',age = '" + double.Parse(TextBox5.Text) + "',contact='" + TextBox4.Text + "'where StudentID = '" + int.Parse(TextBox1.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully updated');", true);
            LoadRecord();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("Delete Studentinfo_Tab where StudentID = '" + int.Parse(TextBox1.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully Deleted');", true);
            LoadRecord();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("select * from Studentinfo_Tab where StudentID = '" + int.Parse(TextBox1.Text) + "'", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("select * from Studentinfo_Tab where StudentID = '" + int.Parse(TextBox1.Text) + "'", con);
                   SqlDataReader r = comm.ExecuteReader();
            while(r.Read())
            {
                TextBox2.Text = r.GetValue(1).ToString();
                DropDownList1.SelectedValue = r.GetValue(2).ToString();
                TextBox5.Text = r.GetValue(3).ToString();
                TextBox4.Text = r.GetValue(4).ToString();
            }
        }

    }
}