using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.EntityClasses;

namespace ProductSearchEngine.Web.Control
{
    public partial class LatestProducts : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadLatestProducts();
            }
        }

        private void LoadLatestProducts()
        {
            ProductSearchEngine.Business.Adapters.ProductAdapter productAdapter = new Business.Adapters.ProductAdapter();

            LatestProductsRepeater.DataSource = productAdapter.GetLatestProducts();
            LatestProductsRepeater.DataBind();
        }
        protected string GetProductUniqueName(object dataItem)
        {
            ProductEntity p = dataItem as ProductEntity;
            return p.ProductPhotos.FirstOrDefault().UniqueName;
        }
    }
}