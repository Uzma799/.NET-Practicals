using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Practical_7
{
    public partial class pract7c : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            string insertquery = "insert into student values(@accountnumber,@customername,@bankbranchname,@state,@zipcode)";
            SqlCommand cmd = new SqlCommand(insertquery, con);
            cmd.Parameters.AddWithValue("@accountnumber", TextBox1.Text);
            cmd.Parameters.AddWithValue("@customername", TextBox2.Text);
            cmd.Parameters.AddWithValue("@bankbranchname", TextBox3.Text);
            cmd.Parameters.AddWithValue("@state", TextBox4.Text);
            cmd.Parameters.AddWithValue("@zipcode", TextBox5.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            Label1.Text = "Record Inserted Successfully!";
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnetionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            string InsertQuery = "delete from student where accountnumber=@accountnumber";
            SqlCommand cmd = new SqlCommand(InsertQuery, con);
            cmd.Parameters.AddWithValue("@accountnumber", TextBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            Label1.Text = "Record Deleted Successfuly.";
            con.Close();
        }
    }
}