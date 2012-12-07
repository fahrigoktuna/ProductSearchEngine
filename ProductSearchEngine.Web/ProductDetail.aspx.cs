using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.EntityClasses;
using ProductSearchEngine.Business.Adapters;

namespace ProductSearchEngine.Web
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        public int ProductId
        { get; set; }

       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadData();

        }

        private void LoadData()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["p"]))
            {
                ProductId = Convert.ToInt32(Request.QueryString["p"]);
                ViewState["ProductId"] = ProductId;
                new ProductAdapter().AddLastViewedProduct(ProductId, DateTime.Now, Request.ServerVariables["REMOTE_ADDR"]);
            }
            ProductRepeater.DataSource = new ProductAdapter().GetDetailedProduct(ProductId);
            ProductRepeater.DataBind();
        }

        protected string GetCategoryRedirectUrl(int id)
        {
            return "/ProductList.aspx?qMode=1&c=" + Business.Encryption.Encryption64.Encrypt(id.ToString(), "!#$a54?3");
        }
        protected string GetBrandRedirectUrl(int id)
        {
            return "/ProductList.aspx?qMode=3&b=" + Business.Encryption.Encryption64.Encrypt(id.ToString(), "!#$a54?3");
        }

        protected void ProductRepeater_DataBound(object sender, RepeaterItemEventArgs e)
        {
            Repeater ProductReviewsRepeater = (Repeater)e.Item.FindControl("ProductReviewsRepeater");
            Repeater ProductPhotosRepeater = (Repeater)e.Item.FindControl("ProductPhotosRepeater");
            Repeater ProductSpecificationsRepeater = (Repeater)e.Item.FindControl("ProductSpecificationsRepeater");

            ProductEntity product = (ProductEntity)e.Item.DataItem;

           
            ProductReviewsRepeater.DataSource = product.Comments;
            ProductReviewsRepeater.DataBind();

            ProductPhotosRepeater.DataSource = product.ProductPhotos;
            ProductPhotosRepeater.DataBind();

            ProductSpecificationsRepeater.DataSource = product.ProductSpecifications;
            ProductSpecificationsRepeater.DataBind();

            Control.RelatedProducts RelatedProductsUserControl = (Control.RelatedProducts)e.Item.FindControl("RelatedProductsUserControl");
            Control.ProductTags ProductTagsUserControl = (Control.ProductTags)e.Item.FindControl("ProductTagsUserControl");
            ProductTagsUserControl.Product = product;
            RelatedProductsUserControl.ProductId = product.Id;
           

        }
        protected string GetProductUniqueName(object dataItem)
        {
            ProductEntity product = (ProductEntity)dataItem;

            return product.ProductPhotos.FirstOrDefault().UniqueName;
        }

        protected string GetRatePercentage(object item)
        {
            if (item.GetType() == typeof(ProductEntity))
            {
                ProductEntity p = (ProductEntity)item;
                int rateCount = 0;
                int totalRate = 0;
                foreach (var itemComments in p.Comments)
                {
                    rateCount++;
                    totalRate += (int)itemComments.Rate.Value;
                }
                if (rateCount > 0)
                {
                    int rate = totalRate / rateCount;

                    switch (rate)
                    {
                        case 5:

                            return "width: 100%;";

                        case 4:

                            return "width: 80%;";

                        case 3:

                            return "width: 60%;";

                        case 2:
                            return "width: 40%;";
                        case 1:
                            return "width: 20%;";
                        default:
                            return "";

                    }
                }
                else
                {

                    return "";
                }
            }
            else if (item.GetType() == typeof(CommentEntity))
            {
                CommentEntity c = (CommentEntity)item;
                switch (c.Rate.Value)
                {
                    case 5:

                        return "width: 100%;";

                    case 4:

                        return "width: 80%;";

                    case 3:

                        return "width: 60%;";

                    case 2:
                        return "width: 40%;";
                    case 1:
                        return "width: 20%;";
                    default:
                        return "";
                }

            }
            else
                return "";
        }

        protected void AddReview_Click(object sender, EventArgs e)
        {
            TextBox ReviewTitleTextBox = null;
            TextBox ReviewTextBox = null;
            RadioButtonList ReviewRateRadioButtonList = null;
            foreach (RepeaterItem item in ProductRepeater.Items)
            {
                ReviewTitleTextBox = (TextBox)item.FindControl("ReviewTitleTextBox");
                ReviewTextBox = (TextBox)item.FindControl("ReviewTextBox")
                    ;
                ReviewRateRadioButtonList = (RadioButtonList)item.FindControl("ReviewRateRadioButtonList");
            }

           

            CommentEntity comment = new CommentEntity();
            comment.ProductId = Convert.ToInt32(ViewState["ProductId"]);
            comment.Title = ReviewTitleTextBox.Text;
            comment.Content = ReviewTextBox.Text;
            comment.RateId = GetRateIdByRadioButtonListSelection(Convert.ToInt32(ReviewRateRadioButtonList.SelectedValue));
            comment.Status = false;
            comment.Save();

            LoadData();
        }

        private int? GetRateIdByRadioButtonListSelection(int rate)
        {
            switch (rate)
            {
                case 5:
                    return 1;
                case 4:
                    return 2;
                case 3:
                    return 3;
                case 2:
                    return 4;
                case 1:
                    return 5;
                default:
                    return 1;
            }
        }

    }
}