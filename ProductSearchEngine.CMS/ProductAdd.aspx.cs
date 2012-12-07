using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace ProductSearchEngine.CMS
{
    public partial class ProductAdd : BaseTypes.StoreType
    {
        public string ProductTitle { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckUser();
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void CheckUser()
        {
            if(Session["Member"]!=null)
            if ((Session["Member"] as ProductSearchEngine.EntityClasses.MembershipEntity).RoleId != (int)Enums.MembershipRoles.Store)
                Response.Redirect("/Dashboard.aspx");
        }

        private void LoadData()
        {
            CategoryDropDownList.DataSource = new ProductSearchEngine.Business.Adapters.CategoryAdapter().GetMainCategories();
            CategoryDropDownList.DataTextField = "Name";
            CategoryDropDownList.DataValueField = "Id";
            CategoryDropDownList.DataBind();

            BrandDropDownList.DataSource = new ProductSearchEngine.Business.Adapters.BrandAdapter().GetBrandList();
            BrandDropDownList.DataTextField = "Name";
            BrandDropDownList.DataValueField = "Id";
            BrandDropDownList.DataBind();

            CategoryDropDownList.SelectedIndex = 0;

            SubCategoryDropDownList.DataSource = new ProductSearchEngine.Business.Adapters.CategoryAdapter().GetSubCategories(int.Parse(CategoryDropDownList.SelectedValue));
            SubCategoryDropDownList.DataTextField = "Name";
            SubCategoryDropDownList.DataValueField = "Id";
            SubCategoryDropDownList.DataBind();

            SubmitButton.Click += new EventHandler(SubmitButton_Click);
        }

        protected override void OnInit(EventArgs e)
        {
            
            //if (Session["PageType"] != null)
            //{
            //    if (Session["PageType"].ToString() == "Update")
            //    {
            //        SubmitButton.Click -= new EventHandler(SubmitButton_Click);
            //        SubmitButton.Click += new EventHandler(SubmitButtonUpdate_Click);
            //    }
            //    else
            //    {
            //        SubmitButton.Click += new EventHandler(SubmitButton_Click);

            //    }
            //}
        }

        

        protected void CategoryDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubCategoryDropDownList.DataSource = new ProductSearchEngine.Business.Adapters.CategoryAdapter().GetSubCategories(int.Parse(CategoryDropDownList.SelectedValue));
            SubCategoryDropDownList.DataTextField = "Name";
            SubCategoryDropDownList.DataValueField = "Id";
            SubCategoryDropDownList.DataBind();
        }
        private void GetData(ProductSearchEngine.EntityClasses.ProductEntity product)
        {
            ProductTitle = product.Title;
            ProductTitleTextBox.Text = product.Title;
            ProductDetailTextBox.Text = product.DetailDescription;
            ProductFreeShippingStatusRadioButtonList.SelectedIndex = (bool)product.IsFreeShipping ? 1 : 0;
            ProductNewItemStatusRadioButtonList.SelectedIndex = (bool)product.IsNewItem ? 1 : 0;
            ProductRedirectUrlTextBox.Text = product.RedirectUrl;
            ProductPriceTextBox.Text = product.Price.ToString();


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

        private void GetData(int id)
        {
            ProductSearchEngine.EntityClasses.ProductEntity product = new EntityClasses.ProductEntity(id);
            ProductTitle = product.Title;
            ProductTitleTextBox.Text = product.Title;
            ProductDetailTextBox.Text = product.DetailDescription;
            ProductFreeShippingStatusRadioButtonList.SelectedIndex = (bool)product.IsFreeShipping ? 1 : 0;
            ProductNewItemStatusRadioButtonList.SelectedIndex = (bool)product.IsNewItem ? 1 : 0;
            ProductRedirectUrlTextBox.Text = product.RedirectUrl;
            ProductPriceTextBox.Text = product.Price.ToString();


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
        protected void FileUploadButton_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile == true)
            {
                try
                {
                    if (SubmitButton.Text == "Add Product")
                    {
                        string uniqueName = Guid.NewGuid().ToString() + ".jpg";
                        string photoPath = ConfigurationManager.AppSettings["ImagePhysicalPath"] + "\\" + uniqueName;
                        FileUpload1.SaveAs(photoPath);

                        ViewState["PhotoUniqueName"] = uniqueName;
                        //new ProductSearchEngine.Business.Adapters.ProductAdapter().AddProductPhoto(int.Parse(ViewState["ProductId"].ToString()), uniqueName);
                        FileUploadMessageLabel.Text = "Saved Succesfully";
                    }
                    else
                    {
                        string uniqueName = Guid.NewGuid().ToString() + ".jpg";
                        string photoPath = ConfigurationManager.AppSettings["ImagePhysicalPath"] + "\\" + uniqueName;
                        FileUpload1.SaveAs(photoPath);

                        //ViewState["PhotoUniqueName"] = uniqueName;
                        new ProductSearchEngine.Business.Adapters.ProductAdapter().AddProductPhoto(int.Parse(ViewState["ProductId"].ToString()), uniqueName);
                        FileUploadMessageLabel.Text = "Saved Succesfully";
                    }
                }

                catch (Exception ex)
                {
                    FileUploadMessageLabel.Text = ex.Message;
                    return;
                }
            }
            else
                FileUploadMessageLabel.Text = "Please Select The File";
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            if (SubmitControls())
            {
                try
                {
                    ProductSearchEngine.EntityClasses.ProductEntity product = new ProductSearchEngine.Business.Adapters.ProductAdapter().AddProduct(ProductTitleTextBox.Text, double.Parse(ProductPriceTextBox.Text), ProductRedirectUrlTextBox.Text
                        , int.Parse(SubCategoryDropDownList.SelectedValue), int.Parse(BrandDropDownList.SelectedValue), ProductDetailTextBox.Text, ProductNewItemStatusRadioButtonList.SelectedValue == "1" ? true : false
                        , ProductFreeShippingStatusRadioButtonList.SelectedValue == "1" ? true : false, (Session["Member"] as ProductSearchEngine.EntityClasses.MembershipEntity).Stores.FirstOrDefault().Id);
                    ViewState["ProductId"] = product.Id;

                    new ProductSearchEngine.Business.Adapters.ProductAdapter().AddProductPhoto(product.Id, ViewState["PhotoUniqueName"].ToString());
                    GetData(product);

                    SubmitButton.Text = "Save Changes";
                    //Session["PageType"] = "Update";

                    ProductKeywordAddPanel.Visible = true;
                    ProductPhotoPanel.Visible = true;
                    ProductSpecificationAddPanel.Visible = true;
                    ProductKeywordPanel.Visible = true;
                    ProductSpecificationPanel.Visible = true;
                    SubmitEditButton.Visible = true;
                    SubmitButton.Visible = false;
                }
                catch
                {
                    ShowAlertMessage("Alanalrı Kontrol");
                }
            }
            else
                ShowAlertMessage("Alanalrı Kontrol");

        }

        protected bool SubmitControls()
        {
            if (ViewState["PhotoUniqueName"] == null || string.IsNullOrEmpty(ProductPriceTextBox.Text) || ProductNewItemStatusRadioButtonList.SelectedIndex == -1 || ProductFreeShippingStatusRadioButtonList.SelectedIndex == -1)
                return false;
            else
                return true;
            
        }
        public static void ShowAlertMessage(string error)
        {

            Page page = HttpContext.Current.Handler as Page;
            if (page != null)
            {
                error = error.Replace("'", "\'");
                ScriptManager.RegisterStartupScript(page, page.GetType(), "err_msg", "alert('" + error + "');", true);
            }
        }

        protected void SubmitButtonUpdate_Click(object sender, EventArgs e)
        {
            new ProductSearchEngine.Business.Adapters.ProductAdapter().UpdateProduct(int.Parse(ViewState["ProductId"].ToString()), ProductTitleTextBox.Text, double.Parse(ProductPriceTextBox.Text)
                , ProductRedirectUrlTextBox.Text, int.Parse(SubCategoryDropDownList.SelectedValue), int.Parse(BrandDropDownList.SelectedValue), ProductDetailTextBox.Text,
                false, false, false
                , ProductNewItemStatusRadioButtonList.SelectedValue == "1" ? true : false, ProductFreeShippingStatusRadioButtonList.SelectedValue == "1" ? true : false);

            GetData(int.Parse(ViewState["ProductId"].ToString()));
        }

        protected void SpecificationAddLinkButton_Click(object sender, EventArgs e)
        {
            string name = SpecificationNameTextBox.Text;
            string value = SpecificationValueTextBox.Text;
            new ProductSearchEngine.Business.Adapters.ProductAdapter().AddProductSpecification(int.Parse(ViewState["ProductId"].ToString()), name, value);

            GetData(int.Parse(ViewState["ProductId"].ToString()));
        }

        protected void SpecificationRemoveLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton lnkButton = sender as LinkButton;

            new ProductSearchEngine.Business.Adapters.ProductAdapter().DeleteProductSpecification(int.Parse(lnkButton.CommandArgument.Split(',')[0]), lnkButton.CommandArgument.Split(',')[1]);

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

            new ProductSearchEngine.Business.Adapters.ProductAdapter().DeleteProductKeyword(int.Parse(lnkButton.CommandArgument.Split(',')[0]), int.Parse(lnkButton.CommandArgument.Split(',')[1]));

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