using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.CMS.Helpers;
using ProductSearchEngine.CMS.Control;

namespace ProductSearchEngine.CMS
{
    public partial class DashBoard : BaseTypes.BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RoleManager roleManager = new RoleManager();
            roleManager.SetRole(Session["Member"], new UserControl[] { StoreInformationUserControl, StoreListUserControl, Last5AddedProductsUserControl, Last10AddedProductsUserControl });
        }

        public override void CheckMemberSession()
        {
            base.CheckMemberSession();
        }
    }
}