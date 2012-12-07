using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.Business.Adapters;

namespace ProductSearchEngine.Web.Control
{
    public partial class BrandList : System.Web.UI.UserControl
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
            BrandListDropDownList.DataSource = new BrandAdapter().GetBrandList();
            BrandListDropDownList.DataTextField = "Name";
            BrandListDropDownList.DataValueField = "Id";
           
            BrandListDropDownList.DataBind();
            BrandListDropDownList.Items.Insert(0, new ListItem("Please Select Brand", "0"));
        }

        protected void BrandListDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("~/ProductList.aspx?qMode=3&b=" +Business.Encryption.Encryption64.Encrypt(BrandListDropDownList.SelectedValue, "!#$a54?3"));
        }
    }
}