using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_2
{
    public partial class pract2b_2__single_inheritance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            B s = new B();
            int n = int.Parse(TextBox1.Text);
            int x = s.sqr(n);
            int y = s.cub(n);
            Label1.Text = x.ToString();
            Label2.Text = y.ToString();
        }
    }
    public class A
    {
        public int sqr(int n1)
        {
            return n1 * n1;
        }
    }
    public class B : A
    {
        public int cub(int n1)
        {
            int s1 = sqr(n1);
            return s1 * n1;
        }
    }
}