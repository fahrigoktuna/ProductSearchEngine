using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.Business.Adapters;

namespace ProductSearchEngine.CMS.Control
{
    public partial class Last10AddedProducts : System.Web.UI.UserControl
    {
        public bool IsLoad
        {
            get
            ;
            set;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            LoadData();
        }

        private void LoadData()
        {
            if(IsLoad)
            Last10AddedProductsRepeater.DataSource = new ProductAdapter().GetLast10AddedProducts();
            Last10AddedProductsRepeater.DataBind();
         
        }
        protected string GetStoreEditUrlAddress(object id)
        {
            return "/ProductEdit.aspx?Id=" + ProductSearchEngine.Business.Encryption.Encryption64.Encrypt(id.ToString(), "12345678") + "&listType=" + ProductSearchEngine.Business.Encryption.Encryption64.Encrypt(((int)Enums.MembershipRoles.Admin).ToString(), "12345678");
        }
    }
}