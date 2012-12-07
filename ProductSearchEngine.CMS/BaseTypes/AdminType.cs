using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductSearchEngine.CMS.BaseTypes
{
    public class AdminType : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            CheckAdminRole();
            base.OnInit(e);
        }

        private void CheckAdminRole()
        {
            if (Session["Member"] != null)
            {
                if ((Session["Member"] as ProductSearchEngine.EntityClasses.MembershipEntity).RoleId != (int)Enums.MembershipRoles.Admin)
                    Response.Redirect("Dashboard.aspx");
            }
        }
    }
}