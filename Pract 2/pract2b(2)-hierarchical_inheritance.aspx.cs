using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_2
{
    public partial class pract2b_2__hierarchical_inheritance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public class Base
        {
            public int a;
            public int b;
        }
        public class child : Base
        {
            public int add(int v1, int v2)
            {
                a = v1;
                b = v2;
                return a + b;
            }
        }
        public class child1 : Base
        {
            public int sub(int v1, int v2)
            {
                a = v1;
                b = v2;
                return a - b;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            child b = new child();
            child1 c = new child1();
            int m = int.Parse(TextBox1.Text);
            int n = int.Parse(TextBox2.Text);
            int x = b.add(m, n);
            int y = c.sub(m, n);
            Label1.Text = x.ToString();
            Label2.Text = y.ToString();
        }
    }
}
