using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductSearchEngine.CMS
{
    public partial class StoreList : BaseTypes.AdminType
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadData();
        }

        private void LoadData()
        {
            StoreListRepeater.DataSource = new ProductSearchEngine.Business.Adapters.StoreAdapter().GetAllStores();
            StoreListRepeater.DataBind();
        }
        protected void RemoveLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton deleteLinkButton = sender as LinkButton;
            new ProductSearchEngine.Business.Adapters.StoreAdapter().DeleteStore(int.Parse(deleteLinkButton.CommandArgument));
            LoadData();
        }

        protected void ChangeStatusLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton linkButton = sender as LinkButton;

            int id = int.Parse(linkButton.CommandArgument);

            if (linkButton.Text=="Add List")
           
                new ProductSearchEngine.Business.Adapters.StoreAdapter().ChangeStoreStatus(id, true);
           
            else
      
                new ProductSearchEngine.Business.Adapters.StoreAdapter().ChangeStoreStatus(id, false);

            LoadData();
        }
    }
}