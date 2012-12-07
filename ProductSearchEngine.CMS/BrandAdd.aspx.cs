using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductSearchEngine.CMS
{
    public partial class BrandAdd : BaseTypes.AdminType
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BrandNameAddLinkButtonLinkButton_Click(object sender, EventArgs e)
        {
            try
            {
                new ProductSearchEngine.Business.Adapters.BrandAdapter().AddBrand(BrandNameTextBox.Text);
            }
            catch
            {
                SuccessInfoMessage.Text = "Error";
                return;
            }
            SuccessInfoMessage.Text = "Succesfully Added";
        }
    }
}