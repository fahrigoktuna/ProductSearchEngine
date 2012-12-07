<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="BrandList.aspx.cs" Inherits="ProductSearchEngine.CMS.BrandList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript" src="js/libs/modernizr-2.0.6.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div id="main-content">
        <div class="container_12">
            <div class="grid_12">
                <h1>
                    Store List</h1>
                <p>
                   You can view,edit and remove your stores at below.</p>
            </div>
            <div class="grid_12">
                <div class="block-border">
                    <div class="block-header">
                        <h1>
                           Brand List</h1>
                        <span></span>
                    </div>
                    <div class="block-content">
                        <asp:Repeater ID="BrandListRepeater" runat="server">
                            <HeaderTemplate>
                                <table id="table-example" class="table">
                                    <thead>
                                        <tr>
                                            <th>
                                                Brand
                                            </th>
                                            <th>
                                                Edit
                                            </th>
                                            <th>
                                                Remove
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
                                    <asp:LinkButton ID="EditLinkButton" runat="server" CommandArgument='<%#Eval("Id").ToString() %>' OnClick="EditLinkButton_Click" >Edit</asp:LinkButton>
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
