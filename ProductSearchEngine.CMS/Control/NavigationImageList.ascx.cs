using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.CMS.Helpers;

namespace ProductSearchEngine.CMS.Control
{
    public partial class NavigationImageList : System.Web.UI.UserControl
    {
        protected string ProductListStoreUrl { get; set; }
        protected string ProductListAdminUrl { get; set; }

        protected override void OnInit(EventArgs e)
        {
            ProductListAdminUrl = "/ProductList.aspx?listType="+ProductSearchEngine.Business.Encryption.Encryption64.Encrypt(((int)Enums.MembershipRoles.Admin).ToString(), "12345678");
            ProductListStoreUrl = "/ProductList.aspx?listType="+ProductSearchEngine.Business.Encryption.Encryption64.Encrypt(((int)Enums.MembershipRoles.Store).ToString(), "12345678");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            new RoleManager().SetRole(AdminPanel, StorePanel,Session["Member"]);
        }
    }
}