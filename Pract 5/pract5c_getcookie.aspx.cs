using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_5
{
    public partial class pract5c_getcookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie c = Request.Cookies["UserInfo"];
            if (c != null)
            {
                Label1.Text = c["Name"];
                Label2.Text = c["Email"];
            }
        }
    }
}