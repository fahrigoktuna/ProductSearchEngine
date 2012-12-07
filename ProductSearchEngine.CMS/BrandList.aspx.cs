using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductSearchEngine.CMS
{
    public partial class BrandList : BaseTypes.AdminType
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            BrandListRepeater.DataSource = new ProductSearchEngine.Business.Adapters.BrandAdapter().GetBrandList();
            BrandListRepeater.DataBind();
        }

        protected void EditLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton editLinkButton = sender as LinkButton;

            Response.Redirect("/BrandEdit.aspx?brandId=" + ProductSearchEngine.Business.Encryption.Encryption64.Encrypt(editLinkButton.CommandArgument, "12345678"));
        }
        protected void RemoveLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton removeLinkButton = sender as LinkButton;
            new ProductSearchEngine.Business.Adapters.BrandAdapter().RemoveBrand(int.Parse(removeLinkButton.CommandArgument));
            LoadData();
        }
    }
}