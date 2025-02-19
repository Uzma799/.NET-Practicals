using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_3
{
    public partial class pract3b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.Caption = "Uzma Shaikh";
            Calendar1.FirstDayOfWeek = FirstDayOfWeek.Sunday;
            Calendar1.NextPrevFormat = NextPrevFormat.ShortMonth;
            Calendar1.TitleFormat = TitleFormat.Month;
            Label1.Text = Calendar1.SelectedDate.Date.ToString();
            Label2.Text = Calendar1.TodaysDate.ToShortDateString();
            Label3.Text = "10-24-2022";
            TimeSpan d1 = new DateTime(2022, 10, 24) - DateTime.Now;
            Label4.Text = d1.Days.ToString();
            TimeSpan d2 = new DateTime(2022, 12, 25) - DateTime.Now;
            Label5.Text = d2.Days.ToString();
            if (Calendar1.SelectedDate.ToShortDateString() == "10-24-2022")
                Label3.Text = "<b>Ganpati Festival Start</b>";
            if (Calendar1.SelectedDate.ToShortDateString() == "4-18-2022")
                Label3.Text = "<b>Ganpati Festival End</b>";
        }

        protected void Calendar1_DayRender(object sender, System.Web.UI.WebControls.DayRenderEventArgs e)
        {
            if (e.Day.Date.Day == 31 && e.Day.Date.Month == 8)
            {
                Label lb2 = new Label();
                lb2.Text = "<br>Ganpati";
                e.Cell.Controls.Add(lb2);
                Image g2 = new Image();
                g2.ImageUrl = "td.jpg";
                g2.Height = 20;
                g2.Width = 20;
                e.Cell.Controls.Add(g2);
            }
            if (e.Day.Date.Day == 5 && e.Day.Date.Month == 9)
            {
                e.Cell.BackColor = System.Drawing.Color.Yellow;
                Label lb1 = new Label();
                lb1.Text = "<br>Teachers day!";
                e.Cell.Controls.Add(lb1);
                Image g1 = new Image();
                g1.ImageUrl = "td.jpg";
                g1.Height = 20;
                g1.Width = 20;
                e.Cell.Controls.Add(g1);
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            Label5.Text = "";
            Calendar1.SelectedDates.Clear();
        }
    }
}