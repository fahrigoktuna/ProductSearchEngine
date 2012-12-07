using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.EntityClasses;
using ProductSearchEngine.Business.Adapters;
using ProductSearchEngine.CollectionClasses;

namespace ProductSearchEngine.Web
{
    public partial class ProductList : System.Web.UI.Page
    {
        public int QMode { get; set; }
        protected void rep1_TotalRowCountAvailable(object sender, PageEventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["qMode"]))
                    LoadData();
                else
                    Response.Redirect("~/Default.aspx");
            }
        }

        private void LoadData()
        {
            QMode = Convert.ToInt32(Request.QueryString["qMode"]);

            switch (QMode)
            {
                case 1:
                    //Search By SubCategory Id
                    GetBySubCategoryId();
                    break;

                case 2:
                    //Search By Base Category Id
                    GetByBaseCategoryId();
                    break;

                case 3:
                    //Search by BrandId
                    GetByBrandId();
                    break;

                case 4:
                    //Search by Keyword
                    GetByKeyword();
                    break;

                case 5:
                    //Search by base cat id + keyword
                    GetByKeywordAndBaseCategory();
                    break;
                default:
                    Response.Redirect("~/Default.aspx");
                    break;
            }
        }

        private void GetByKeywordAndBaseCategory()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["k"]) && !string.IsNullOrEmpty(Request.QueryString["bc"]))
            {

                string keyword = Business.Encryption.Encryption64.Decrypt(Request.QueryString["k"], "12345678").Replace("+"," ");
                int baseCatId = Convert.ToInt32(Business.Encryption.Encryption64.Decrypt(Request.QueryString["bc"], "!#$a54?3"));
                if (baseCatId != 0)
                {
                    CategoryEntity category = new CategoryAdapter().GetCategoryById(baseCatId);
                    BaseCategoryNameLabel.Text = category.Name;
                    CategoryNameLabel.Text = keyword;

                    SubCategoriesRepeater.DataSource = new CategoryAdapter().GetSubCategories(baseCatId);
                    SubCategoriesRepeater.DataBind();

                    ProductListRepeater.DataSource = new ProductAdapter().GetProductsByKeywordAndBaseCatId(keyword, baseCatId);
                    ProductCollection productList = (ProductCollection)ProductListRepeater.DataSource;
                    Session["ProductList"] = productList;
                    ProductListRepeater.DataBind();
                }
                else
                {
                    BaseCategoryNameLabel.Text = keyword;
                    CategoryNameLabel.Text = keyword;
                    ProductCollection products = new ProductAdapter().GetProductsByKeyword(keyword);
                    Session["ProductList"] = products;
                    //Disable CategorySlider
                    SubCategoriesRepeater.Visible = false;

                    ProductListRepeater.DataSource = products;
                    ProductListRepeater.DataBind();
                }
            }
            else
                Response.Redirect("~/Default.aspx");
        }

        private void GetByKeyword()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["k"]))
            {
                string keyword = Business.Encryption.Encryption64.Decrypt(Request.QueryString["k"], "12345678").Replace("+"," ");
                BaseCategoryNameLabel.Text = keyword;
                CategoryNameLabel.Text = keyword;

                //Disable CategorySlider
                SubCategoriesRepeater.Visible = false;

                ProductListRepeater.DataSource = new ProductAdapter().GetProductsByKeyword(keyword);
                ProductCollection productList = (ProductCollection)ProductListRepeater.DataSource;
                Session["ProductList"] = productList;
                ProductListRepeater.DataBind();
            }
            else
                Response.Redirect("~/Default.aspx");
        }

        private void GetByBrandId()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["b"]))
            {
                int brandId = Convert.ToInt32(Business.Encryption.Encryption64.Decrypt(Request.QueryString["b"], "!#$a54?3"));
                BaseCategoryNameLabel.Text = new BrandAdapter().GetBrandById(brandId).Name;
                CategoryNameLabel.Text = new BrandAdapter().GetBrandById(brandId).Name;

                //Disable CategorySlider
                SubCategoriesRepeater.Visible = false;

                ProductListRepeater.DataSource = new ProductAdapter().GetProductsByBrandId(brandId);
                ProductCollection productList = (ProductCollection)ProductListRepeater.DataSource;
                Session["ProductList"] = productList;
                ProductListRepeater.DataBind();
            }
            else
                Response.Redirect("~/Default.aspx");
        }

        private void GetByBaseCategoryId()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["bc"]))
            {
                int baseCatId = Convert.ToInt32(Business.Encryption.Encryption64.Decrypt(Request.QueryString["bc"], "!#$a54?3"));
                if (baseCatId != 0)
                {
                    CategoryEntity category = new CategoryAdapter().GetCategoryById(baseCatId);
                    BaseCategoryNameLabel.Text = category.Name;
                    CategoryNameLabel.Text = category.Name;

                    SubCategoriesRepeater.DataSource = new CategoryAdapter().GetSubCategories(baseCatId);
                    SubCategoriesRepeater.DataBind();

                    ProductListRepeater.DataSource = new ProductAdapter().GetProductsByMainCategoryId(baseCatId);
                    ProductCollection productList = (ProductCollection)ProductListRepeater.DataSource;
                    Session["ProductList"] = productList;
                    ProductListRepeater.DataBind();
                }
                else
                    Response.Redirect("~/Default.aspx");
            }
        }

        private void GetBySubCategoryId()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["c"]))
            {

                int subCatId = Convert.ToInt32(Business.Encryption.Encryption64.Decrypt(Request.QueryString["c"], "!#$a54?3"));
                CategoryEntity category = new CategoryAdapter().GetCategoryById(subCatId);
                BaseCategoryNameLabel.Text = category.Category.Name;
                CategoryNameLabel.Text = category.Name;

                SubCategoriesRepeater.DataSource = new CategoryAdapter().GetRelatedSubCategories(subCatId);
                SubCategoriesRepeater.DataBind();

                ProductListRepeater.DataSource = new ProductAdapter().GetProductsByCategoryId(subCatId);
                ProductCollection productList = (ProductCollection)ProductListRepeater.DataSource;
                Session["ProductList"] = productList;
                ProductListRepeater.DataBind();
            }
            else
                Response.Redirect("~/Default.aspx");
        }

        protected string GetProductPhotoUniqueName(object item)
        {
            if (item.GetType() == typeof(CategoryEntity))
            {
                CategoryEntity category = (CategoryEntity)item;
                if (category.Products.Count > 0)
                {
                    return category.Products.FirstOrDefault().ProductPhotos.FirstOrDefault().UniqueName;
                }
                else
                    return "";
            }
            else if (item.GetType() == typeof(ProductEntity))
            {
                ProductEntity product = (ProductEntity)item;

                return product.ProductPhotos.FirstOrDefault().UniqueName;
            }
            else
                return "";
        }

        protected string GetProductDetailsSubString(string desc)
        {
            if (desc.Length > 200)
                return desc.Substring(0, 200) + "...";
            else

                return desc.Substring(0, desc.Length);
        }

        protected void SortBy_Click(object sender, EventArgs e)
        {
            LinkButton lnkButton = (LinkButton)sender;
            ProductCollection productList = (ProductCollection)Session["ProductList"];

            switch (lnkButton.ID)
            {
                case "SortByTitleAscending":
                    ProductListRepeater.DataSource = new ProductAdapter().SortProductsByTitle(productList, true);
                    break;
                case "SortByTitleDescending":
                    ProductListRepeater.DataSource = new ProductAdapter().SortProductsByTitle(productList, false);
                    break;
                case "SortByPriceAscending":
                    ProductListRepeater.DataSource = new ProductAdapter().SortProductsByPrice(productList, true);
                    break;
                case "SortByPriceDescending":
                    ProductListRepeater.DataSource = new ProductAdapter().SortProductsByPrice(productList, false);
                    break;
                case "SortByRateDescending":
                    ProductListRepeater.DataSource = productList;
                    break;
                case "SortByRateAscending":
                    ProductListRepeater.DataSource = productList;
                    break;
                default:
                    ProductListRepeater.DataSource = productList;
                    break;
            }

            ProductListRepeater.DataBind();
            DataPager1.DataBind();
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "shoppica.js", "  <script type='text/javascript' src='/Assets/js/shoppica.js'></script>", true);
          
     

            //ScriptManager.RegisterStartupScript(this, this.GetType(), "shoppica.js", "alert('aasd')", false);
           
        }
    }
}