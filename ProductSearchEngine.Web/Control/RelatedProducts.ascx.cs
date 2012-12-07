using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.EntityClasses;
using ProductSearchEngine.Business.Adapters;

namespace ProductSearchEngine.Web.Control
{
    public partial class RelatedProducts : System.Web.UI.UserControl
    {
        public int ProductId {get;set;}
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadData();
        }

        private void LoadData()
        {
            ProductAdapter productAdapter = new ProductAdapter();
            RelatedProductsRepeater.DataSource = productAdapter.GetRelatedProducts(ProductId);
            RelatedProductsRepeater.DataBind();
        }

        protected string GetProductUniqueName(object item)
        {
            ProductEntity p = (ProductEntity)item;
            return p.ProductPhotos.FirstOrDefault().UniqueName;
        }
        protected override void Render(HtmlTextWriter writer)
        {
            LoadData();
            base.Render(writer);
        }
    }
}