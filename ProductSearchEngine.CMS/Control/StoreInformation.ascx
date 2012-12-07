<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StoreInformation.ascx.cs"
    Inherits="ProductSearchEngine.CMS.Control.StoreInformation" %>
<div class="grid_4" runat="server" id="GridDiv">
    <div class="block-border">
        <div class="block-header">
            <h1>
                Store Informations</h1>
            <span></span>
        </div>
        <div id="validate-form" class="block-content form">
            <p class="inline-mini-label">
                        	<label for="NameTextBox"> 
                    Name
                    </label>
                    <asp:TextBox ID="NameTextBox" runat="server" CssClass="required"></asp:TextBox>
             
            </p>
            <p class="inline-mini-label">
                	<label for="AuthorizedNameTextBox"> 
                    Authorized
                    </label>
                            <asp:TextBox ID="AuthorizedNameTextBox" runat="server" CssClass="required"></asp:TextBox>
              
            </p>
            <p class="inline-mini-label">
          	<label for="TelephoneTextBox"> 
                    Telephone
                    </label>
                         <asp:TextBox ID="TelephoneTextBox" runat="server" CssClass="required"></asp:TextBox>
             
            </p>
            <p class="inline-mini-label">
              	<label for="WebAddressTextBox">Web</label>
                 
                      <asp:TextBox ID="WebAddressTextBox" runat="server" CssClass="required"></asp:TextBox>
              
            </p>
            <p class="inline-mini-label">
                     	<label for="EmailTextBox"> 
                    Email
                    </label>
                     <asp:TextBox ID="EmailTextBox" runat="server" CssClass="required"></asp:TextBox>
              
            </p>
            <p class="inline-mini-label">
             <label for="CitiesDropDownList">
                City
                </label>
                <asp:DropDownList ID="CitiesDropDownList" runat="server">
                </asp:DropDownList>
            </p>
            <p class="inline-mini-label">
                <p>
                    <label for="post">
                        Address</label>
                           <asp:TextBox ID="post" Rows="5" Columns="40" TextMode="MultiLine" runat="server" CssClass="required"></asp:TextBox>
                   
                </p>
            </p>
            <div class="clear">
            </div>
            <!-- Buttons with actionbar  -->
            <div class="block-actions">
                <ul class="actions-left">
                    <li><a class="button red" id="reset-validate-form" href="javascript:void(0);">Cancel</a></li>
                </ul>
                <ul class="actions-right">
                    <li></li>
                </ul>
            </div>
            <!--! end of #block-actions -->
        </div>
        <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Save Changes"
            CssClass="button" />
    </div>
</div>
