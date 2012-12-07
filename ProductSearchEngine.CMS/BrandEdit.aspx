<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="BrandEdit.aspx.cs" Inherits="ProductSearchEngine.CMS.BrandEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <div id="main-content">
        <div class="container_12">
            <div class="grid_12">
                <h1>
                    Brand Edit Page</h1>
                <p>
                    You can update your brand informations at below by filling the field sets.</p>
            </div>
            <div class="grid_6" >
                <div class="block-border">
                    <div class="block-header">
                        <h1>
                            <%=BrandTitle %>
                        </h1>
                        <span></span>
                    </div>
                    <div id="validate-form" class="block-content form" >
                    <div class="_25">
                        <p>
                            <label for="ProductTitleTextBox">
                                Brand Title</label>
                            <asp:TextBox ID="BrandNameEditTextBox" runat="server" CssClass="required"></asp:TextBox>
                        </p>
                    </div>
                  
                    <div class="clear">
                    </div>
                    <div class="block-actions">
                        <ul class="actions-left">
                            <li><a class="button red" id="reset-validate-form" href="javascript:void(0);">Reset</a></li>
                        </ul>
                        <ul class="actions-right">
                            <li>
                                <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" CssClass="button"
                                    Text="Save Changes" />
                            </li>
                        </ul>
                    </div>
                    </div>
                </div>
            </div>

        
            <div class="clear">
            </div>
        
             <div class="grid_6">
                <div class="block-border">
                    <div class="block-header">
                        <h1>
                            Add New Brand
                        </h1>
                        <span></span>
                    </div>
                    <div id="Div4" class="block-content form">
                        <table id="table1" class="table">
                            <thead>
                                <tr>
                                    <th>
                                        Brand
                                    </th>
                                   
                                    <th>
                                        Add
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="BrandNameTextBox" runat="server"></asp:TextBox>
                                    </td>
                                    
                                    <td>
                                        <asp:LinkButton ID="BrandNameAddLinkButton" runat="server" Text="Add" OnClick="BrandNameAddLinkButtonLinkButton_Click"></asp:LinkButton>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            
            <div class="clear height-fix">
            </div>
        </div>
    </div>


</asp:Content>
