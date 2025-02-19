using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_2
{
    public partial class pract2a_2_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Conv s = new Conv();
            double r = Convert.ToDouble(TextBox1.Text);
            double rate = s.Dol(r);
            Label1.Text = rate.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Conv s = new Conv();
            double r = Convert.ToDouble(TextBox1.Text);
            double rate = s.Eur(r);
            Label2.Text = rate.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Conv s = new Conv();
            double r = Convert.ToDouble(TextBox1.Text);
            double rate = s.BP(r);
            Label3.Text = rate.ToString();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Conv s = new Conv();
            double r = Convert.ToDouble(TextBox1.Text);
            double rate = s.Yen(r);
            Label4.Text = rate.ToString();
        }
    }
    public class Conv
    {
        public double Dol(double r)
        {
            r = r * 0.013;
            return r;
        }
        public double Eur(double r)
        {
            r = r * 0.012;
            return r;
        }
        public double BP(double r)
        {
            r = r * 0.011;
            return r;
        }
        public double Yen(double r)
        {
            r = r * 1.74;
            return r;
        }
    }
}