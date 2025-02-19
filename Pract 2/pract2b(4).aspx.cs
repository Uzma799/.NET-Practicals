using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_2
{

    public partial class pract2b_4_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Rect r = new Rect();
            double x = r.show(5, 7);
            Circle c = new Circle();
            double y = c.show(5, 7);
            Label1.Text = x.ToString();
            Label2.Text = y.ToString();
        }
        interface Area
        {
            double show(double s, double t);
        }
        class Rect : Area
        {
            public double show(double s, double t)
            {
                return s * t;
            }
        }
        class Circle : Area
        {
            public double show(double s, double t)
            {
                return (3.14 * s * s);
            }

        }
    }
}