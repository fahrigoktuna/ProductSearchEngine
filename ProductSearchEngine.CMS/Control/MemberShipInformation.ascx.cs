using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.EntityClasses;

namespace ProductSearchEngine.CMS.Control
{
    public partial class MemberShipInformation : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MembershipEntity member = (MembershipEntity)Session["Member"];

                UserNameTextBox.Text = member.UserName;
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
             MembershipEntity member = (MembershipEntity)Session["Member"];
             member.UserName = UserNameTextBox.Text;
             member.Password = ProductSearchEngine.Business.Encryption.SHA1Encryption.EncryptMessage(ConfirmPasswordTextBox.Text);
             new ProductSearchEngine.Business.Adapters.MemberShipAdapter().UpdateMember(member);
        }
    }
}