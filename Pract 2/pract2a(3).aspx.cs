using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_2
{
    public partial class pract2a_3_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Demo();
        }
        public void Demo()
        {
            double a, b, c, r1, r2, x;
            double det;
            a = int.Parse(TextBox1.Text);
            b = int.Parse(TextBox2.Text);
            c = int.Parse(TextBox3.Text);
            det = (b * b) - (4 * a * c);
            if (det > 0)
            {
                x = Math.Sqrt(det);
                r1 = (-b + x) / (2 * a);
                r2 = (-b - x) / (2 * a);
                Label1.Text = "There are two roots: ";
                Label2.Text = r1.ToString() + ", ";
                Label3.Text = r2.ToString();
            }
            else if (det == 0)
            {
                x = Math.Sqrt(det);
                r1 = (-b + x) / (2 * a);
                Label1.Text = "There is only one root: ";
                Label2.Text = r1.ToString();
            }
            else
            {
                Label1.Text = "There is no root.";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }
}