using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class pract1c : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Student Id: " + TextBox1.Text;
            Label2.Text = "Student Name: " + TextBox2.Text;
            Label3.Text = "Course Name: " + TextBox3.Text;
            Label4.Text = "Date of Birth: " + Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            Calendar1.SelectedDates.Clear();

        }
    }
}