using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_2
{
    public partial class pract2b_3_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            add obj1 = new add(5);
            add obj2 = new add(5, 2);
            add obj3 = new add(5, 2, 7);
            Label1.Text = obj1.x.ToString();
            Label2.Text = obj2.x.ToString();
            Label3.Text = obj3.x.ToString();
        }
    }
    public class add
    {
        public int x;
        public add(int a)
        {
            x = a + a;
        }
        public add(int a, int b)
        {
            x = a + b;
        }
        public add(int a, int b, int c)
        {
            x = a + b + c;
        }

    }
}
