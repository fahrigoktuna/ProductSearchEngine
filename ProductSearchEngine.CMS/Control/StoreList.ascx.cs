using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.Business.Adapters;

namespace ProductSearchEngine.CMS.Control
{
    public partial class StoreList : System.Web.UI.UserControl
    {
        public bool IsLoad { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadData();
        }

        private void LoadData()
        {
            if (IsLoad)
            {
                StoreListRepeater.DataSource = new StoreAdapter().GetAllStores();
                StoreListRepeater.DataBind();
            }
        }
       
    }
}