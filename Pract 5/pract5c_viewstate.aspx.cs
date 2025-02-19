using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_5
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["clicks"] == null)
                {
                    ViewState["clicks"] = 0;
                }
                TextBox1.Text = ViewState
                ["clicks"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int clickscount = (int)ViewState["clicks"] + 1;
            TextBox1.Text = clickscount.ToString();
            ViewState["clicks"] = clickscount;
        }
    }
}