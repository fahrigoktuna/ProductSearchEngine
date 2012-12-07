using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.Business.Adapters;

namespace ProductSearchEngine.Web.Control
{
    public partial class BaseCategoryList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)     
                LoadData();
            
        }

        private void LoadData()
        {
            CategoryAdapter categoryAdapter = new CategoryAdapter();
            BaseCategoryListRepeater.DataSource = categoryAdapter.GetMainCategories();
            BaseCategoryListRepeater.DataBind();
        }
        protected void BaseCategoryNameLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton lnkButton = (LinkButton)sender;

            Response.Redirect("~/ProductList.aspx?qMode=2&bc=" + Business.Encryption.Encryption64.Encrypt(lnkButton.CommandArgument, "!#$a54?3"));
        }
    }
}