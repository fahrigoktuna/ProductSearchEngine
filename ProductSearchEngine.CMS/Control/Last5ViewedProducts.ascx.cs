using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.Business.Adapters;

namespace ProductSearchEngine.CMS.Control
{
    public partial class Last5ViewedProducts : System.Web.UI.UserControl
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckUser();
            LoadData();
        }
        protected string GetProductEditUrlAddress(object id)
        {
            return "/ProductEdit.aspx?Id=" + ProductSearchEngine.Business.Encryption.Encryption64.Encrypt(id.ToString(), "12345678") + "&listType=" + ProductSearchEngine.Business.Encryption.Encryption64.Encrypt(((int)Enums.MembershipRoles.Store).ToString(), "12345678");
        }

        private void LoadData()
        {
            Last5ViewedProductsRepeater.DataSource = new ProductAdapter().GetLast5ViewedProducts((Session["Member"] as ProductSearchEngine.EntityClasses.MembershipEntity).Stores.FirstOrDefault().Id);
            Last5ViewedProductsRepeater.DataBind();
        }
        private void CheckUser()
        {
            if (Session["Member"] == null)
                Response.Redirect("/Login.aspx");
            else
            {
                if ((Session["Member"] as ProductSearchEngine.EntityClasses.MembershipEntity).RoleId == (int)Enums.MembershipRoles.Admin)
                    Response.Redirect("/DashBoard.aspx");
            }
        }
    }
}