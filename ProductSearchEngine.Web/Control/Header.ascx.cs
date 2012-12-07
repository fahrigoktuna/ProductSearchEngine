using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.EntityClasses;

namespace ProductSearchEngine.Web.Control
{
    public partial class HeaderUserControl : System.Web.UI.UserControl
    {
       
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
            HeaderCategoriesDropDownList.DataSource = categoryAdapter.GetMainCategories();
            HeaderCategoriesDropDownList.DataTextField = "Name";
            HeaderCategoriesDropDownList.DataValueField = "Id";
            HeaderCategoriesDropDownList.DataBind();
            HeaderCategoriesDropDownList.Items.Insert(0, new ListItem("All Categories", "0"));

            HeaderCategoryRepeater.DataSource = categoryAdapter.GetMainCategories();
            HeaderCategoryRepeater.DataBind();
        }

        protected void HeaderCategoryRepeater_DataBound(object sender, RepeaterItemEventArgs e)
        {
             ProductSearchEngine.Business.Adapters.CategoryAdapter categoryAdapter = new Business.Adapters.CategoryAdapter();
            if (e.Item.ItemType == ListItemType.Item ||
              e.Item.ItemType == ListItemType.AlternatingItem)
            {
                CategoryEntity mainCategory = (CategoryEntity)e.Item.DataItem;
                Repeater insideRepeater = (Repeater)e.Item.FindControl("HeaderCategoryInsideRepeater");
                insideRepeater.DataSource = categoryAdapter.GetSubCategories(mainCategory.Id);
                insideRepeater.DataBind();
            
            }
            
        }

        protected void HeaderCategoryInsideRepeater_DataBound(object sender, RepeaterItemEventArgs e)
        {
            //if (e.Item.ItemType == ListItemType.Item ||
            //e.Item.ItemType == ListItemType.AlternatingItem)
            //{

            //}
        }

        protected void BaseCategoryLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton lnkButton = (LinkButton)sender;

            Response.Redirect("~/ProductList.aspx?qMode=2&bc=" + Business.Encryption.Encryption64.Encrypt(lnkButton.CommandArgument, "!#$a54?3"));
        }
        protected void SubCategoryLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton lnkButton = (LinkButton)sender;

            Response.Redirect("~/ProductList.aspx?qMode=1&c=" + Business.Encryption.Encryption64.Encrypt(lnkButton.CommandArgument, "!#$a54?3"));
        }

        protected void HeaderGoLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ProductList.aspx?qMode=5&bc=" + Business.Encryption.Encryption64.Encrypt(HeaderCategoriesDropDownList.SelectedValue, "!#$a54?3") + "&k=" + Business.Encryption.Encryption64.Encrypt(HeaderSearchTextBox.Text, "12345678"));
        }
    }
}