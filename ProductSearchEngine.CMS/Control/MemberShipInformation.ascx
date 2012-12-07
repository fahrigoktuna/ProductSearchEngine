<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberShipInformation.ascx.cs" Inherits="ProductSearchEngine.CMS.Control.MemberShipInformation" %>

<div class="grid_4">
    <div class="block-border">
        <div class="block-header">
            <h1>
                Membership Informations</h1>
            <span></span>
        </div>
        <div id="validate-form" class="block-content form">
            <p class="inline-mini-label">
                        	<label for="NameTextBox"> 
                    User Name
                    </label>
                    <asp:TextBox ID="UserNameTextBox" runat="server" CssClass="required"></asp:TextBox>
             
            </p>
            <p class="inline-mini-label">
                	<label for="AuthorizedNameTextBox"> 
                    Password
                    </label>
                            <asp:TextBox ID="PasswordTextBox" TextMode="Password" runat="server" CssClass="required"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" Operator="Equal" ControlToCompare="PasswordTextBox" ValidationGroup="submit" ControlToValidate="ConfirmPasswordTextBox" ErrorMessage="Passwords does not match"></asp:CompareValidator>
              
            </p>
            <p class="inline-mini-label">
                	<label for="AuthorizedNameTextBox"> 
                    Confirm Password
                    </label>
                            <asp:TextBox ID="ConfirmPasswordTextBox" TextMode="Password" runat="server" CssClass="required"></asp:TextBox>
                            
              
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
        <asp:Button ID="SubmitButton" runat="server" ValidationGroup="submit" OnClick="SubmitButton_Click" Text="Save Changes"
            CssClass="button" />
    </div>
</div>
