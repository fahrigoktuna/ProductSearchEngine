<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="CategoryAdd.aspx.cs" Inherits="ProductSearchEngine.CMS.CategoryAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div id="main-content">
        <div class="container_12">
            <div class="grid_12">
                <h1>
                    Category Add Page</h1>
                <p>
                    You can add your category informations at below by filling the field sets.</p>
            </div>
            <div class="grid_6" >
                <div class="block-border">
                    <div class="block-header">
                        <h1>
                          Main Category Adding
                        </h1>
                        <span></span>
                    </div>
                    <div id="validate-form" class="block-content form" >
                    <div class="_25">
                        <p>
                            <label for="ProductTitleTextBox">
                                Main Category</label>
                            <asp:TextBox ID="MainCategoryNameTextBox" runat="server" CssClass="required"></asp:TextBox>
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
         <div class="clear height-fix">
            </div>
             <div class="grid_12">
                <div class="block-border">
                    <div class="block-header">
                        <h1>
                            Add Sub Category
                        </h1>
                        <span></span>
                    </div>
                    <div  class="block-content form">
                        <table   class="table">
                            <thead>
                                <tr>
                                    <th>
                                        Main Category
                                    </th>
                                   
                                    <th>
                                        Sub Category
                                    </th>
                                     <th>
                                        Add
                                    </th>
                                    <th>
                                        Success Info
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                           
                                <tr>
                                
                                    <td style="width:150px">
                                       <asp:DropDownList ID="MainCategoryDropDownList"  runat="server"></asp:DropDownList>
                                    </td>
                                    
                                    
                                    <td class="center">
                                      <asp:TextBox ID="SubCategoryNameTextBox" runat="server"></asp:TextBox>
                                    </td>
                                     <td class="center">
                                     <asp:LinkButton ID="SubCategoryAddLinkButton" runat="server" OnClick="SubCategoryAddLinkButton_Click">Add</asp:LinkButton>
                                    </td>
                                    <td class="center">
                                    <asp:Label ID="SuccessInfoLabel" runat="server"></asp:Label>
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
