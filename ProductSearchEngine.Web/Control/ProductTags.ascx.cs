using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.EntityClasses;

namespace ProductSearchEngine.Web.Control
{
    public partial class ProductTags : System.Web.UI.UserControl
    {
        public ProductEntity Product { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                LoadData();
        }

        private void LoadData()
        {
            ProductTagsRepeater.DataSource = Product.ProductKeywords;
            ProductTagsRepeater.DataBind();
        }
        protected void KeywordLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton linkButton = (LinkButton)sender;
            string keyword = linkButton.CommandArgument;

            Response.Redirect("~/ProductList.aspx?qMode=4&k=" + Business.Encryption.Encryption64.Encrypt(keyword, "12345678"));
        }
        protected override void Render(HtmlTextWriter writer)
        {
            LoadData();
            base.Render(writer);
        }
    }
}