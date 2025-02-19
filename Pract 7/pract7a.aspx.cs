using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Practical_7
{
    public partial class pract7a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string connStr =
ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Select * from Bank_Details", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DropDownList1.DataSource = reader;
                DropDownList1.DataTextField = "state";
                DropDownList1.DataBind();
                reader.Close();
                con.Close();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "The You Have Selected : " + DropDownList1.SelectedValue;

        }
    }
}