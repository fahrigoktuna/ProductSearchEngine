using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductSearchEngine.CMS
{
    public partial class BrandEdit : BaseTypes.AdminType
    {
        protected string BrandTitle { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(!string.IsNullOrEmpty(Request.QueryString["brandId"]))
                LoadData();
                else
                    Response.Redirect("/BrandList.aspx");
            }
        }

        private void LoadData()
        {
            int brandId = int.Parse(ProductSearchEngine.Business.Encryption.Encryption64.Decrypt(Request.QueryString["brandId"], "12345678").Replace("+", " "));
            ProductSearchEngine.EntityClasses.BrandEntity brand = new ProductSearchEngine.Business.Adapters.BrandAdapter().GetBrandById(brandId);
            BrandNameEditTextBox.Text = brand.Name;
            BrandTitle = brand.Name;
        }

        protected void BrandNameAddLinkButtonLinkButton_Click(object sender, EventArgs e)
        {
            new ProductSearchEngine.Business.Adapters.BrandAdapter().AddBrand(BrandNameTextBox.Text);
            Response.Redirect("/BrandList.aspx");
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            new ProductSearchEngine.Business.Adapters.BrandAdapter().UpdateBrand(int.Parse(ProductSearchEngine.Business.Encryption.Encryption64.Decrypt(Request.QueryString["brandId"], "12345678").Replace("+", " ")), BrandNameEditTextBox.Text);
        }
    }
}