using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.EntityClasses;
using System.Web.UI.HtmlControls;

namespace ProductSearchEngine.Web.Control
{
    public partial class LastAddedProducts : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadData();
        }

        private void LoadData()
        {
            ProductSearchEngine.Business.Adapters.ProductAdapter productAdapter = new Business.Adapters.ProductAdapter();
            LastAddedProductsRepeater.DataSource = productAdapter.GetLastAddedProducts(5);
            LastAddedProductsRepeater.DataBind();
        }
        protected void LastAddedProductsRepeater_DataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                ProductEntity p = (ProductEntity)e.Item.DataItem;

                if (p.Comments != null)
                {
                    if (p.Comments.Count > 0)
                    {
                        (e.Item.FindControl("RatingHolderDiv") as HtmlControl).Style.Add("display", "block");
                    }
                }
            }
        }
        protected string GetRatePercentage(object item)
        {
            ProductEntity p = (ProductEntity)item;
            int rateCount = 0;
            int totalRate = 0;
            foreach (var itemComments in p.Comments)
            {
                if (itemComments.Status == true)
                {
                    rateCount++;
                    totalRate += (int)itemComments.Rate.Value;
                }
            }
            if (rateCount > 0)
            {
                int rate = totalRate / rateCount;

                switch (rate)
                {
                    case 1:

                        return "20";

                    case 2:

                        return "40";

                    case 3:

                        return "60";

                    case 4:
                        return "80";
                    case 5:
                        return "100";
                    default:
                        return "";

                }
            }
            else
            {

                return "";
            }
        }
        protected string GetRate(object item)
        {
            ProductEntity p = (ProductEntity)item;
            int rateCount = 0;
            int totalRate = 0;
            foreach (var itemComments in p.Comments)
            {
                if (itemComments.Status == true)
                {
                    rateCount++;
                    totalRate += (int)itemComments.Rate.Value;
                }
            }
            if (rateCount > 0)
            {
                int rate = totalRate / rateCount;

                return rate.ToString();
            }
            else
                return "";

        }
        protected string GetProductUniqueName(object item)
        {
            ProductEntity p = (ProductEntity)item;
            return p.ProductPhotos.FirstOrDefault().UniqueName;
        }
    }
}