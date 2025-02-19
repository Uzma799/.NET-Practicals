using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class pract1b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = TextBox1.Text;
            Label1.Text = "String Length:" + s.Length;
            Label2.Text = "Substring:" + s.Substring(4,8);
            Label3.Text = "Upper String:" + s.ToUpper();
            Label4.Text = "Lower String:" + s.ToLower();
            Label5.Text = "Reverse String:" + s.ToString();
            Label6.Text = "Replace a by z:" + s.Replace('a','z');
            Label7.Text = "String Truncate:" + s.Trim();
            Label8.Text = "Remove String:" + s.Remove(5);
            Label9.Text = "Index of String:" + s.IndexOf('e');
            Label10.Text = "Insert 'h' into string:" + s.Insert(3,"h");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            Label5.Text = "";
            Label6.Text = "";
            Label7.Text = "";
            Label8.Text = "";
            Label9.Text = "";
            Label10.Text = "";
            TextBox1.Text = "";
        }
    }
}