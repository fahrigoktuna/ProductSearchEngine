using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductSearchEngine.CMS
{
    public partial class ProductList : BaseTypes.BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(!string.IsNullOrEmpty(Request.QueryString["listType"]))
                LoadData();
            }
        }

        private void LoadData()
        {
            int listType = int.Parse(ProductSearchEngine.Business.Encryption.Encryption64.Decrypt(Request.QueryString["listType"], "12345678").Replace("+", " "));
            ViewState["ListType"] = listType;
            if (listType == (int)Enums.MembershipRoles.Admin)
            {
                DataTableNameLiteral.Text = "Admin&View";
                GetData();
            }
            else if (listType == (int)Enums.MembershipRoles.Store)
            {
                DataTableNameLiteral.Text = "Store&View";
                GetData(((ProductSearchEngine.EntityClasses.MembershipEntity)Session["Member"]).Stores.FirstOrDefault().Id);
            }
            else
            {
                Response.Redirect("/DashBoard.aspx");
            }
        }

        private void GetData()
        {
            ProductListRepeater.DataSource = new ProductSearchEngine.Business.Adapters.ProductAdapter().GetAllProducts();
            ProductListRepeater.DataBind();
        }
        private void GetData(int storeId)
        {
            ProductListRepeater.DataSource = new ProductSearchEngine.Business.Adapters.ProductAdapter().GetProductsByStoreId(storeId);
            ProductListRepeater.DataBind();
        }

        protected void EditProductLinkButton_Click(object sender, EventArgs e)
        {
            int id =  int.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("/ProductEdit.aspx?Id=" + ProductSearchEngine.Business.Encryption.Encryption64.Encrypt(id.ToString(), "12345678") + "&listType=" + ProductSearchEngine.Business.Encryption.Encryption64.Encrypt(ViewState["ListType"].ToString(), "12345678"));
        }

       
    }
}