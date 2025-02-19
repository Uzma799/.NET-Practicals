using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace practical_10
{
    public partial class pract10a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            XmlTextWriter writer = new XmlTextWriter("C: \Users\\samir\\source\repos\\practical 10\\practical 10\\XMLFile.xml", null);

            writer.WriteStartDocument();
            writer.WriteStartElement("details");
            writer.WriteElementString("Id", "1");
            writer.WriteElementString("name", "Uzma");
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            Label1.Text = "data write sucessfully";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String xmlNode = "C: \\Users\\samir\\source\repos\\practical 10\\practical 10\\XMLFile.xml";
            XmlReader xreader = XmlReader.Create(xmlNode);
            while (xreader.Read())
            {
                switch (xreader.NodeType)
                {
                    case
                    XmlNodeType.Element: ListBox1.Items.Add("<" + xreader.Name + ">");
                        break;
                    case XmlNodeType.Text:
                        ListBox1.Items.Add(xreader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        ListBox1.Items.Add("<" + xreader.Name + ">");
                        break;
                }
            }
        }
    }
}