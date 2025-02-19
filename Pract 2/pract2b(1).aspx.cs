using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_2
{
    public partial class pract2b_1_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x, y, z;
            x = add(5);
            y = add(5, 2);
            z = add(5, 2, 7);
            Label1.Text = x.ToString();
            Label2.Text = y.ToString();
            Label3.Text = z.ToString();
        }
        public int add(int a)
        {
            return a + a;
        }
        public int add(int a, int b)
        {
            return a + b;
        }
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}