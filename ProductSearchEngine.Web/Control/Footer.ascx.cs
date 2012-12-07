using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.EntityClasses;

namespace ProductSearchEngine.Web.Control
{
    public partial class Footer : System.Web.UI.UserControl
    {
        protected string UrlEncode { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadMainCategories();

            }
        }

        private void LoadMainCategories()
        {
            ProductSearchEngine.Business.Adapters.CategoryAdapter categoryAdapter = new Business.Adapters.CategoryAdapter();
            FooterCategoryRepeater.DataSource = categoryAdapter.GetMainCategories().Take(6);
            FooterCategoryRepeater.DataBind();
        }
        protected void FooterCategoryRepeater_DataBound(object sender, RepeaterItemEventArgs e)
        {
            ProductSearchEngine.Business.Adapters.CategoryAdapter categoryAdapter = new Business.Adapters.CategoryAdapter();
            if (e.Item.ItemType == ListItemType.Item ||
              e.Item.ItemType == ListItemType.AlternatingItem)
            {
                CategoryEntity mainCategory = (CategoryEntity)e.Item.DataItem;
                Repeater insideRepeater = (Repeater)e.Item.FindControl("FooterCategoryInsideRepeater");

                insideRepeater.DataSource = categoryAdapter.GetSubCategories(mainCategory.Id);
                insideRepeater.DataBind();

            }

        }

        protected void CategoryLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton lnkButton = (LinkButton)sender;

            Response.Redirect("~/ProductList.aspx?qMode=1&c=" + Business.Encryption.Encryption64.Encrypt(lnkButton.CommandArgument, "!#$a54?3"));
        }

    }
}