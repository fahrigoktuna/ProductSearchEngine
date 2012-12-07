using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductSearchEngine.CMS.BaseTypes
{
    public class StoreType : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            CheckStoreRole();
            base.OnInit(e);
        }

        private void CheckStoreRole()
        {
            if (Session["Member"] != null)
            {
                if ((Session["Member"] as ProductSearchEngine.EntityClasses.MembershipEntity).RoleId != (int)Enums.MembershipRoles.Store)
                    Response.Redirect("Dashboard.aspx");
            }
        }

        
    }
}