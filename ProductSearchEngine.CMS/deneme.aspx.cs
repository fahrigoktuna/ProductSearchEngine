using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductSearchEngine.CMS
{
    public partial class deneme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text ="SERVER MAP PATH : "+ Server.MapPath("~/");
            MessageLabel.Text+=Environment.NewLine+" REQUEST MAP PATH: "+ Request.MapPath("~/");
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string s = TextBox1.Text;
        }
    }
}