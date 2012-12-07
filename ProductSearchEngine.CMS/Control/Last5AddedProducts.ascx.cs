using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.Business.Adapters;

namespace ProductSearchEngine.CMS.Control
{
    public partial class Last5AddedProducts : System.Web.UI.UserControl
    {

        public bool IsLoad
        {
            get
            ;
            set;
        }

        public string Width { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadData();
        }

        private void LoadData()
        {
            if (IsLoad)
            {
                if (!string.IsNullOrEmpty(Width))
                    DivGrid.Style.Add("width", Width);
                
                Last5AddedProductsRepeater.DataSource = new ProductAdapter().GetLast5AddedProducts(Session["Member"]);
                Last5AddedProductsRepeater.DataBind();
            }
        }

        protected string GetProductEditUrlAddress(object id)
        {
            return "/ProductEdit.aspx?Id=" + ProductSearchEngine.Business.Encryption.Encryption64.Encrypt(id.ToString(), "12345678") + "&listType=" + ProductSearchEngine.Business.Encryption.Encryption64.Encrypt(((int)Enums.MembershipRoles.Store).ToString(), "12345678");
        }
    }
}