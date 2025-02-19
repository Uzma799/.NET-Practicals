using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_2
{
    public partial class pract2a_4_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conv s = new conv();
            double n = int.Parse(TextBox1.Text);
            double x = s.CtoF(n);
            Label1.Text = x.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conv s = new conv();
            double n = int.Parse(TextBox2.Text);
            double x = s.FtoC(n);
            Label2.Text = x.ToString();
        }
    }
    public class conv
    {
        public double CtoF(double temp)
        {
            temp = 9.0 / 5.0 * temp + 32;
            return temp;
        }
        public double FtoC(double temp)
        {
            temp = (temp - 32) * 5.0 / 9.0;
            return temp;
        }
    }
}