using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductSearchEngine.CMS
{
    public partial class CategoryList : BaseTypes.AdminType
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadData();
        }

        private void LoadData()
        {
            CategoryListRepeater.DataSource = new ProductSearchEngine.Business.Adapters.CategoryAdapter().GetMainCategories();
            CategoryListRepeater.DataBind();
        }

        protected void CategoryListRepeater_DataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                DropDownList SubCategoriesDropDownList = (DropDownList)e.Item.FindControl("SubCategoriesDropDownList");
                ProductSearchEngine.EntityClasses.CategoryEntity maincategory = e.Item.DataItem as ProductSearchEngine.EntityClasses.CategoryEntity;
                SubCategoriesDropDownList.DataSource = new ProductSearchEngine.Business.Adapters.CategoryAdapter().GetSubCategories(maincategory.Id);
                SubCategoriesDropDownList.DataValueField = "Id";
                SubCategoriesDropDownList.DataTextField = "Name";
                SubCategoriesDropDownList.DataBind();
            }
        }

        protected void RemoveLinkButton_Click(object sender,EventArgs e)
        {
            LinkButton linkButton = sender as LinkButton;
            new ProductSearchEngine.Business.Adapters.CategoryAdapter().DeleteCategory(int.Parse(linkButton.CommandArgument));
            LoadData();
        }
        protected void CategoryListRepeater_ItemCommand(Object Sender, RepeaterCommandEventArgs e)
        {
            LinkButton linkButton = Sender as LinkButton;
        }

        protected void RemoveSubCategoryLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton linkButton = sender as LinkButton;

            DropDownList SubCategoriesDropDownList = (DropDownList) ((RepeaterItem)linkButton.NamingContainer).FindControl("SubCategoriesDropDownList");
      

            new ProductSearchEngine.Business.Adapters.CategoryAdapter().DeleteSubCategory(int.Parse(SubCategoriesDropDownList.SelectedValue));

            LoadData();
        }
    }
}