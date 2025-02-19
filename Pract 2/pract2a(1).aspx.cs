using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_2
{
    public partial class pract2a_1_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i, fact = 1, num;
            num = int.Parse(TextBox1.Text);
            for (i = 1; i <= num; i++)
                fact = fact * i;
            Label1.Text = fact.ToString();
        }
    }
}