using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_2
{
    public partial class pract2c_2_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(TextBox1.Text);
                int[] b = { 10, 17, 27 };
                int result;
                result = (b[3] / a);
                Label1.Text = "The result is: " + result.ToString();
            }
            catch (System.DivideByZeroException ex)
            {
                Label1.Text = ex.ToString();
            }
            catch (System.IndexOutOfRangeException ex)
            {
                Label1.Text = ex.ToString();
            }
        }
    }
}