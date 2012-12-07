<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true"
    CodeBehind="ProductList.aspx.cs" Inherits="ProductSearchEngine.CMS.ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="main-content">
        <div class="container_12">
            <div class="grid_12">
                <h1>
                    Product List</h1>
                <p>
                    You can view, and edit your products at below.</p>
            </div>
            <div class="grid_12">
                <div class="block-border">
                    <div class="block-header">
                        <h1>
                            <asp:Literal ID="DataTableNameLiteral" runat="server"></asp:Literal></h1>
                        <span></span>
                    </div>
                    <div class="block-content">
                        <asp:Repeater ID="ProductListRepeater" runat="server">
                            <HeaderTemplate>
                                <table id="table-example" class="table">
                                    <thead>
                                        <tr>
                                            <th>
                                                Category
                                            </th>
                                            <th>
                                                Store
                                            </th>
                                            <th>
                                                Title
                                            </th>
                                            <th>
                                                Price
                                            </th>
                                            <th>
                                                Status
                                            </th>
                                            <th>
                                                Slider Product
                                            </th>
                                            <th>
                                                Special Product
                                            </th>
                                            <th>
                                                Edit
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <%#Eval("Category.Name") %>
                                    </td>
                                    <td>
                                        <%#Eval("Store.Name") %>
                                    </td>
                                    <td>
                                        <%#Eval("Title") %>
                                    </td>
                                    <td class="center">
                                        <%#Eval("Price").ToString() +" TL" %>
                                    </td>
                                    <td class="center">
                                        <%# bool.Parse(Eval("Status").ToString()) ? "SHOWN" :"NOT SHOWN" %>
                                    </td>
                                    <td class="center">
                                        <%# bool.Parse(Eval("IsSliderProduct").ToString()) ? "YES" :"NO" %>
                                    </td>
                                    <td class="center">
                                        <%# bool.Parse(Eval("IsSpeacialProduct").ToString()) ? "YES" :"NO" %>
                                    </td>
                                    <td class="center">
                                        <asp:LinkButton ID="EditProductLinkButton" runat="server" Text="Edit" CommandName="EditProduct"
                                            OnClick="EditProductLinkButton_Click" CommandArgument='<%#Eval("Id")%>'></asp:LinkButton>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <AlternatingItemTemplate>
                                <tr>
                                    <td>
                                        <%#Eval("Category.Name") %>
                                    </td>
                                    <td>
                                        <%#Eval("Store.Name") %>
                                    </td>
                                    <td>
                                        <%#Eval("Title") %>
                                    </td>
                                    <td class="center">
                                        <%#Eval("Price").ToString() +" TL" %>
                                    </td>
                                    <td class="center">
                                        <%# bool.Parse(Eval("Status").ToString()) ? "SHOWN" :"NOT SHOWN" %>
                                    </td>
                                    <td class="center">
                                        <%# bool.Parse(Eval("IsSliderProduct").ToString()) ? "YES" :"NO" %>
                                    </td>
                                    <td class="center">
                                        <%# bool.Parse(Eval("IsSpeacialProduct").ToString()) ? "YES" :"NO" %>
                                    </td>
                                    <td class="center">
                                        <asp:LinkButton ID="EditProductLinkButton" runat="server" Text="Edit" CommandName="EditProduct"
                                            OnClick="EditProductLinkButton_Click" CommandArgument='<%#Eval("Id")%>'></asp:LinkButton>
                                    </td>
                                </tr>
                            </AlternatingItemTemplate>
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
