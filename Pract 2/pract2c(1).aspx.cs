using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_2
{
    public partial class pract2c_1_ : System.Web.UI.Page
    {
        public delegate string dele();
        public static string Display1()
        {
            string s1 = "Uzma Shaikh";
            return s1;
        }
        public static string Display2()
        {
            string s2 = "Roll. No.: 04 (TYIT - A)";
            return s2;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            dele d1 = new dele(Display1);
            d1();
            dele d2 = new dele(Display2);
            d2();
            Label1.Text = d1();
            Label2.Text = d2();
        }
    }
}