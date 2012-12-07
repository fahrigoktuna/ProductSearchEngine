using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductSearchEngine.CMS
{
    public partial class StoreAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StoreAddLinkButton_Click(object sender, EventArgs e)
        {
            try
            {
                new ProductSearchEngine.Business.Adapters.StoreAdapter().AddStore(StoreNameTextBox.Text, StoreUserNameTextBox.Text, ProductSearchEngine.Business.Encryption.SHA1Encryption.EncryptMessage(StorePasswordTextBox.Text)
                    , StoreStatusCheckBox.Checked,(int)Enums.MembershipRoles.Store);
                SuccessInfoMessage.Text = "Succesfuly Added";
            }
            catch(Exception ex)
            {
                SuccessInfoMessage.Text = "Error: " + ex.Message;
            }
        }
    }
}