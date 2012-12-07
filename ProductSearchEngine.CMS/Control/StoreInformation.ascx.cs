using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductSearchEngine.EntityClasses;
using ProductSearchEngine.Business.Adapters;

namespace ProductSearchEngine.CMS.Control
{
    public partial class StoreInformation : System.Web.UI.UserControl
    {
        public bool IsLoad { get; set; }
        public string Width { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                LoadData();
        }

        private void LoadData()
        {
            if (IsLoad)
            {
                if (!string.IsNullOrEmpty(Width)) { GridDiv.Style.Add("width", Width); }

                MembershipEntity member = (MembershipEntity)Session["Member"];

                NameTextBox.Text = member.UserName;
                if (member.StoreInformation != null)
                {
                    AuthorizedNameTextBox.Text = member.StoreInformation.AuthorizedName;
                    TelephoneTextBox.Text = member.StoreInformation.Telephone;
                    post.Text = member.StoreInformation.Address;//Post = Address
                    EmailTextBox.Text = member.StoreInformation.Email;
                    WebAddressTextBox.Text = member.StoreInformation.WebAddress;
                }


                CitiesDropDownList.DataSource = new CityAdapter().GetCities();
                CitiesDropDownList.DataTextField = "Name";
                CitiesDropDownList.DataValueField = "Id";
                CitiesDropDownList.DataBind();
                if (member.StoreInformation != null)
                {
                    CitiesDropDownList.SelectedValue = member.StoreInformation.CityId.ToString();
                }
                
            }
        }

        protected void SubmitButton_Click(object sender,EventArgs e)
        {
            MembershipEntity member = (MembershipEntity)Session["Member"];

            member.UserName = NameTextBox.Text;
            if (member.StoreInformation != null)
            {
                member.StoreInformation.AuthorizedName = AuthorizedNameTextBox.Text;
                member.StoreInformation.CityId = Convert.ToInt32(CitiesDropDownList.SelectedValue);
                member.StoreInformation.Address = post.Text;
                member.StoreInformation.WebAddress = WebAddressTextBox.Text;
                member.StoreInformation.Email = EmailTextBox.Text;
                member.StoreInformation.Telephone = TelephoneTextBox.Text;
                member.StoreInformationId = member.StoreInformation.Id;
            }
            else
            {
                member.StoreInformation = new StoreInformationEntity();
                member.StoreInformation.AuthorizedName = AuthorizedNameTextBox.Text;
                member.StoreInformation.CityId = Convert.ToInt32(CitiesDropDownList.SelectedValue);
                member.StoreInformation.Address = post.Text;
                member.StoreInformation.WebAddress = WebAddressTextBox.Text;
                member.StoreInformation.Email = EmailTextBox.Text;
                member.StoreInformation.Telephone = TelephoneTextBox.Text;
               
                member.StoreInformation.Save();
            }

           Session["Member"] = new MemberShipAdapter().UpdateMember(member);
        }
    }
}