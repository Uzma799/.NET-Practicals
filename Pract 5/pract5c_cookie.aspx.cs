using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_5
{
    public partial class pract5c_cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie c = new HttpCookie("UserInfo");
            c["Name"] = TextBox1.Text;
            c["Email"] = TextBox2.Text;
            Response.Cookies.Add(c);
            Response.Redirect("pract5c_getcookie.aspx");
            c.Expires = DateTime.Now.AddMinutes(1);
        }
    }
}