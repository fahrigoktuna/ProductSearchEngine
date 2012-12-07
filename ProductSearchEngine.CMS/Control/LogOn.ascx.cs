using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.EntityClasses;

namespace ProductSearchEngine.CMS.Control
{
    public partial class LogOn : System.Web.UI.UserControl
    {
        public string UserName { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                UserName = (Session["Member"] as MembershipEntity).UserName;
            }
            catch
            { Response.Redirect("/Login.aspx"); }
        }

        protected void LogOutLinkButton_Click(object sender, EventArgs e)
        {
            
            Session["Member"] = null;
            Response.Redirect("/Login.aspx");
        }
    }
}