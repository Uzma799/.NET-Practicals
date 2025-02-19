using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_5
{
    public partial class application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Application["clicks"] == null)
                {
                    Application["clicks"] = 0;
                }
                TextBox1.Text = Application["clicks"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int clickscount = (int)Application["clicks"] + 1;
            TextBox1.Text = clickscount.ToString();
            Application["clicks"] = clickscount;
        }
    }
}