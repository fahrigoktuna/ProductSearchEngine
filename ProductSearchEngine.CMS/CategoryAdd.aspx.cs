using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductSearchEngine.CMS
{
    public partial class CategoryAdd : BaseTypes.AdminType
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadData();
        }

        private void LoadData()
        {
            MainCategoryDropDownList.DataSource = new ProductSearchEngine.Business.Adapters.CategoryAdapter().GetMainCategories();
            MainCategoryDropDownList.DataValueField = "Id";
            MainCategoryDropDownList.DataTextField = "Name";
            MainCategoryDropDownList.DataBind();
        }

        protected void SubCategoryAddLinkButton_Click(object sender, EventArgs e)
        {
            try
            {
                new ProductSearchEngine.Business.Adapters.CategoryAdapter().AddSubCategory(int.Parse(MainCategoryDropDownList.SelectedValue), SubCategoryNameTextBox.Text);
            }
            catch
            {
                SuccessInfoLabel.Text = "Error";
                return;
            }
            SuccessInfoLabel.Text = "Succesfuly Added";
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            new ProductSearchEngine.Business.Adapters.CategoryAdapter().AddMainCategory(MainCategoryNameTextBox.Text);
            LoadData();
        }

    }
}