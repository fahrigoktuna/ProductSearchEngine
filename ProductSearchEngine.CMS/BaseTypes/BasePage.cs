using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductSearchEngine.CMS.BaseTypes
{
    public class BasePage : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            CheckMemberSession();
            base.OnInit(e);
        }

        public virtual void CheckMemberSession()
        {
            if (Session["Member"] == null)
                Response.Redirect("Login.aspx");
        }
    }
}