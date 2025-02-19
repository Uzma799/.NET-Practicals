using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_2
{
    public partial class pract2b_2__multilevel_inheritance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            child1 s = new child1();
            int n = int.Parse(TextBox1.Text);
            int x = s.pow2(n);
            int y = s.pow3(n);
            int z = s.pow4(n);
            Label1.Text = x.ToString();
            Label2.Text = y.ToString();
            Label3.Text = z.ToString();
        }
    }
    public class Base
    {
        public int pow2(int v1)
        {
            return v1 * v1;
        }
    }
    public class child : Base
    {
        public int pow3(int v1)
        {
            int v2 = pow2(v1);
            return v2 * v1;
        }
    }
    public class child1 : child
    {
        public int pow4(int v1)
        {
            int v2 = pow3(v1);
            return v2 * v1;

        }
    }
}