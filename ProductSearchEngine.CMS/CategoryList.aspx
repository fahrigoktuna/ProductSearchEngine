<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="CategoryList.aspx.cs" Inherits="ProductSearchEngine.CMS.CategoryList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div id="main-content">
        <div class="container_12">
            <div class="grid_12">
                <h1>
                    Category List</h1>
                <p>
                   You can view,and remove your categories at below.</p>
            </div>
            <div class="grid_12">
                <div class="block-border">
                    <div class="block-header">
                        <h1>
                           Category List</h1>
                        <span></span>
                    </div>
                    <div class="block-content">
                        <asp:Repeater ID="CategoryListRepeater" OnItemDataBound="CategoryListRepeater_DataBound" OnItemCommand="CategoryListRepeater_ItemCommand" runat="server">
                            <HeaderTemplate>
                                <table id="table-example" class="table">
                                    <thead>
                                        <tr>
                                            <th>
                                                Main Category
                                            </th>
                                            <th>
                                                Sub Categories
                                            </th>
                                            <th>
                                                Remove Sub Category
                                            </th>
                                            <th>
                                                Remove Categories
                                            </th>                                     
                                        </tr>
                                    </thead>
                                    <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                     <%#Eval("Name") %>
                                    </td>
                                    <td class="center">
                                    <asp:DropDownList ID="SubCategoriesDropDownList" runat="server"></asp:DropDownList>
                                    </td>
                                    <td class="center">
                                    <asp:LinkButton ID="RemoveSubCategoryLinkButton" runat="server"  OnClick="RemoveSubCategoryLinkButton_Click" >Remove</asp:LinkButton>
                                    </td>
                                      <td class="center">
                                    <asp:LinkButton ID="RemoveLinkButton" runat="server" CommandArgument='<%#Eval("Id").ToString() %>' OnClick="RemoveLinkButton_Click" >Remove</asp:LinkButton>
                                    </td>
                                    
                                </tr>
                            </ItemTemplate>
                          
                            <FooterTemplate>
                                </tbody> </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
            <div class="clear height-fix">
            </div>
        </div>
    </div>
</asp:Content>
