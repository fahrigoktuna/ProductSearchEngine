using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.EntityClasses;
using ProductSearchEngine.Business.Adapters;
using System.Text;

namespace ProductSearchEngine.CMS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //runjQueryCode("alert('a')");
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string uName = UserNameTextBox.Value;
            string password = PasswordTextBox.Value;

            MembershipEntity member = new MemberShipAdapter().GetMember(uName, password);

            if (member != null)
            {
                //Success

                Session["Member"] = member;

                Response.Redirect("/DashBoard.aspx");
            }
            else
            {
                //Failed

               // runjQueryCode("$('#login_form').alertBox('Wrong Username or Password', { type: 'error' });");

                //runjQueryCode("alert('a')");

                alert.Style.Add("display", "block");
            }
        }

        private void runjQueryCode(string jsCodetoRun)
        {

            ScriptManager requestSM = ScriptManager.GetCurrent(this);
            if (requestSM != null && requestSM.IsInAsyncPostBack)
            {
                ScriptManager.RegisterClientScriptBlock(this,
                                                        typeof(Page),
                                                        Guid.NewGuid().ToString(),
                                                        getjQueryCode(jsCodetoRun),
                                                        true);
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(typeof(Page),
                                                       Guid.NewGuid().ToString(),
                                                       getjQueryCode(jsCodetoRun),
                                                       true);
            }
        }
        private string getjQueryCode(string jsCodetoRun)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("$(document).ready(function() {");
            sb.AppendLine(jsCodetoRun);
            sb.AppendLine(" });");

            return sb.ToString();
        }
    }
}