using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace ProductSearchEngine.CMS
{
    public partial class ProductEdit : BaseTypes.BasePage
    {
        protected string ProductTitle { get; set; }

       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(!string.IsNullOrEmpty(Request.QueryString["listType"]) && !string.IsNullOrEmpty(Request.QueryString["Id"]))
                LoadData();
            }
        }

        private void LoadData()
        {
            int listType = int.Parse(ProductSearchEngine.Business.Encryption.Encryption64.Decrypt(Request.QueryString["listType"], "12345678").Replace("+", " "));
            int productId = int.Parse(ProductSearchEngine.Business.Encryption.Encryption64.Decrypt(Request.QueryString["Id"], "12345678").Replace("+", " "));
            ViewState["ProductId"] = productId;
            GetData(productId);
            SetControlRole(listType);

            int[] typeListArray = { (int)Enums.MembershipRoles.Admin, (int)Enums.MembershipRoles.Store };

            if (!typeListArray.Contains(listType))
           
                Response.Redirect("/DashBoard.aspx");
           
        }

        private void SetControlRole(int type)
        {
            if (type == (int)Enums.MembershipRoles.Admin)
            {
                ProductSliderStatusRadioButtonList.Enabled = true;
                ProductSpecialStatusRadioButtonList.Enabled = true;
                ProductStatusRadioButtonList.Enabled = true;
            }
            else
            {
                ProductSliderStatusRadioButtonList.Enabled = false;
                ProductSpecialStatusRadioButtonList.Enabled = false;
                ProductStatusRadioButtonList.Enabled = false;
            }

        }

        private void GetData(int id)
        {
            ProductSearchEngine.EntityClasses.ProductEntity product = new ProductSearchEngine.Business.Adapters.ProductAdapter().GetProductById(id);

            ProductTitle = product.Title;
            ProductTitleTextBox.Text = product.Title;
            ProductDetailTextBox.Text = product.DetailDescription;
            ProductFreeShippingStatusRadioButtonList.SelectedIndex = (bool)product.IsFreeShipping ? 1 : 0;
            ProductNewItemStatusRadioButtonList.SelectedIndex = (bool)product.IsNewItem ? 1 : 0;
            ProductRedirectUrlTextBox.Text = product.RedirectUrl;
            ProductPriceTextBox.Text = product.Price.ToString();
            ProductStatusRadioButtonList.SelectedIndex = (bool)product.Status ? 1 : 0;

            CategoryDropDownList.DataSource = new ProductSearchEngine.Business.Adapters.CategoryAdapter().GetMainCategories();
            CategoryDropDownList.DataTextField = "Name";
            CategoryDropDownList.DataValueField = "Id";
            CategoryDropDownList.DataBind();

            CategoryDropDownList.Items.FindByValue(((int)new ProductSearchEngine.Business.Adapters.CategoryAdapter().GetMainCatehoryIdBySubCategoryId((int)product.CategoryId)).ToString()).Selected = true;
            CategoryDropDownList_DataBound();
            ListItem liSubCategory = SubCategoryDropDownList.Items.FindByValue(product.CategoryId.ToString());
            if (liSubCategory != null)
                liSubCategory.Selected = true;
            BrandDropDownList.DataSource = new ProductSearchEngine.Business.Adapters.BrandAdapter().GetBrandList();
            BrandDropDownList.DataTextField = "Name";
            BrandDropDownList.DataValueField = "Id";
            BrandDropDownList.DataBind();

            ListItem li = BrandDropDownList.Items.FindByValue(product.BrandId.ToString());
            if (li != null)
                li.Selected = true;

            ProductPhotosRepeater.DataSource = product.ProductPhotos;
            ProductPhotosRepeater.DataBind();

            ProductSpecificationsRepeater.DataSource = product.ProductSpecifications;
            ProductSpecificationsRepeater.DataBind();

            ProductKeywordRepeater.DataSource = product.ProductKeywords;
            ProductKeywordRepeater.DataBind();
        }

        protected void CategoryDropDownList_DataBound()
        {
            SubCategoryDropDownList.DataSource = new ProductSearchEngine.Business.Adapters.CategoryAdapter().GetSubCategories(int.Parse(CategoryDropDownList.SelectedValue));
            SubCategoryDropDownList.DataTextField = "Name";
            SubCategoryDropDownList.DataValueField = "Id";
            SubCategoryDropDownList.DataBind();
        }

        protected void CategoryDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubCategoryDropDownList.DataSource = new ProductSearchEngine.Business.Adapters.CategoryAdapter().GetSubCategories(int.Parse(CategoryDropDownList.SelectedValue));
            SubCategoryDropDownList.DataTextField = "Name";
            SubCategoryDropDownList.DataValueField = "Id";
            SubCategoryDropDownList.DataBind();
        }

       

        protected void FileUploadButton_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile == true)
            {
                try
                {
                    string uniqueName = Guid.NewGuid().ToString() + ".jpg";
                    string photoPath = ConfigurationManager.AppSettings["ImagePhysicalPath"] + "\\"+uniqueName;
                    FileUpload1.SaveAs(photoPath);
                    new ProductSearchEngine.Business.Adapters.ProductAdapter().AddProductPhoto(int.Parse(ViewState["ProductId"].ToString()), uniqueName);
                    FileUploadMessageLabel.Text = "Saved Succesfully";
                }

                catch (Exception ex)
                {
                    FileUploadMessageLabel.Text = ex.Message;
                    return;
                }
            }
            else
                FileUploadMessageLabel.Text = "Please Select The File";

            GetData(int.Parse(ViewState["ProductId"].ToString()));
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            new ProductSearchEngine.Business.Adapters.ProductAdapter().UpdateProduct(int.Parse(ViewState["ProductId"].ToString()), ProductTitleTextBox.Text, double.Parse(ProductPriceTextBox.Text)
                , ProductRedirectUrlTextBox.Text, int.Parse(SubCategoryDropDownList.SelectedValue), int.Parse(BrandDropDownList.SelectedValue), ProductDetailTextBox.Text,
                ProductStatusRadioButtonList.SelectedValue == "1" ? true : false, ProductSliderStatusRadioButtonList.SelectedValue == "1" ? true : false,ProductSpecialStatusRadioButtonList.SelectedValue == "1" ? true : false
                , ProductNewItemStatusRadioButtonList.SelectedValue == "1" ? true : false, ProductFreeShippingStatusRadioButtonList.SelectedValue == "1" ? true : false);

            GetData(int.Parse(ViewState["ProductId"].ToString()));
        }

        protected void SpecificationAddLinkButton_Click(object sender, EventArgs e)
        {
            string name = SpecificationNameTextBox.Text;
            string value = SpecificationValueTextBox.Text;
            new ProductSearchEngine.Business.Adapters.ProductAdapter().AddProductSpecification(int.Parse(ViewState["ProductId"].ToString()),name,value);

            GetData(int.Parse(ViewState["ProductId"].ToString()));
        }

        protected void SpecificationRemoveLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton lnkButton = sender as LinkButton;
           
            new ProductSearchEngine.Business.Adapters.ProductAdapter().DeleteProductSpecification(int.Parse(lnkButton.CommandArgument.Split(',')[0]),lnkButton.CommandArgument.Split(',')[1]);

            GetData(int.Parse(ViewState["ProductId"].ToString()));
           
        }

        protected void PhotoRemoveLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton lnkButton = sender as LinkButton;

            string path = ConfigurationManager.AppSettings["ImagePhysicalPath"] + "\\" + new ProductSearchEngine.Business.Adapters.ProductAdapter().GetProductPhotoUniqueName(int.Parse(lnkButton.CommandArgument));

            if (new ProductSearchEngine.Business.Adapters.ProductAdapter().DeleteProductPhoto(int.Parse(lnkButton.CommandArgument)))
            {          
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
            }

            GetData(int.Parse(ViewState["ProductId"].ToString()));
        }

        protected void KeywordRemoveLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton lnkButton = sender as LinkButton;

            new ProductSearchEngine.Business.Adapters.ProductAdapter().DeleteProductKeyword(int.Parse(lnkButton.CommandArgument.Split(',')[0]),int.Parse(lnkButton.CommandArgument.Split(',')[1]));

            GetData(int.Parse(ViewState["ProductId"].ToString()));
        }

        protected void ProductKeywordAddLinkButton_Click(object sender, EventArgs e)
        {
            string keyword = ProductKeywordTextBox.Text;

            new ProductSearchEngine.Business.Adapters.ProductAdapter().AddProductKeyword(int.Parse(ViewState["ProductId"].ToString()), keyword);

            GetData(int.Parse(ViewState["ProductId"].ToString()));
        }
    }
}