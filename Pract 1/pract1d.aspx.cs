using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class pract1d : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a, b, c, i, n;
            a = 0;
            b = 1;
            Label1.Text = a.ToString() + b.ToString();
            n = int.Parse(TextBox1.Text);
            for (i = 1; i <= n; i++)
            {
                c = a + b;
                Label1.Text = Label1.Text + c.ToString();
                a = b;
                b = c;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int i, c = 0, j, n;
            n = int.Parse(TextBox2.Text);
            for (j = 1; j <= n; j++)
            {
                i = n % j;
                if (1 == 0)
                {
                    c = c + 1;
                }
            }
            if (c == 2)
                Label2.Text = "The Given Number is Prime";
            else
                Label2.Text = "The Given Number is not Prime";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string ch;
            int count = 0;
            ch = TextBox3.Text;
            for (int i = 0; i < ch.Length; i++)
            {
                if ((ch.Substring(i, 1) == "a") || (ch.Substring(i, 1) == "e") || (ch.Substring(i, 1) == "i") || (ch.Substring(i, 1) == "o") || (ch.Substring(i, 1) == "u") || (ch.Substring(i, 1) == "A") || (ch.Substring(i, 1) == "E") || (ch.Substring(i, 1) == "I") || (ch.Substring(i, 1) == "O") || (ch.Substring(i, 1) == "U"))
                {
                    count++;
                }
            }
            
            Label3.Text = "Total number of vowels:" + count;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            long n, i, sum = 0;
            n = int.Parse(TextBox4.Text);
            while (n > 0)
            {
                i = n % 10;
                sum = i + sum * 10;
                n = n / 10;
            }
            Label4.Text = sum.ToString();

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            long n, i, sum = 0;
            n = int.Parse(TextBox5.Text);
            while (n > 0)
            {
                i = n % 10;
                sum = 1 + sum;
                n = n / 10;
            }
            Label5.Text = sum.ToString();

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Label6.Text = "";
            string[] Names = new string[] { "Uzma", "Zainab", "Sabeeha", "Ashfiya", "Rifa", "Zara" };
            foreach (string Name in Names)
            {
                Label6.Text = Label6.Text + " " + Name.ToString();
            }

        }
    }
}