using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Practical_6
{
    public partial class pract6a : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           cmd.CommandText = "select*from Table where name='" + TextBox1.Text + "';";
            ds = cmd.ExecuteReader();
            while(ds.Read())
            {
                TextBox2.Text += ds[0].ToString() + "\t" + ds[1].ToString() + "\t" + ds[2].ToString() + "\n";
            }

        }
    }
}