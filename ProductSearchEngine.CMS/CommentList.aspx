<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="CommentList.aspx.cs" Inherits="ProductSearchEngine.CMS.CommentList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div id="main-content">
        <div class="container_12">
            <div class="grid_12">
                <h1>
                    Comment List</h1>
                <p>
                   You can view,and remove your comments at below.</p>
            </div>
            <div class="grid_12">
                <div class="block-border">
                    <div class="block-header">
                        <h1>
                            <asp:Label ID="DataTableNameLabel" runat="server"></asp:Label></h1>
                        <span></span>
                    </div>
                    <div class="block-content">
                        <asp:Repeater ID="CommentListRepeater" runat="server">
                            <HeaderTemplate>
                                <table id="table-example" class="table">
                                    <thead>
                                        <tr>
                                            <th>
                                                Product
                                            </th>
                                            <th>
                                                Comment Title
                                            </th>
                                            <th>
                                                Comment
                                            </th>
                                            <th>
                                                Rate
                                            </th>
                                            <th>
                                                Status
                                            </th>                                          
                                            <th>
                                                Remove
                                            </th>
                                            <th>
                                                Change Status
                                            </th>
                                              
                                        </tr>
                                    </thead>
                                    <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                     <%#Eval("Product.Title") %>
                                    </td>
                                    <td>
                                   
                                       <%#Eval("Title")%>
                                    </td>
                                    <td>
                                          <%#Eval("Content")%>
                                    </td>
                                    <td class="center">
                                    <%#Eval("Rate.Value")%>
                                    </td>
                                    <td class="center">
                                   <%#bool.Parse(Eval("Status").ToString()) ? "SHOWN" :"NOT SHOWN"%>
                                    </td>
                                   
                                    <td class="center">
                                    <asp:LinkButton ID="RemoveLinkButton" runat="server" CommandArgument='<%#Eval("Id") %>' OnClick="RemoveLinkButton_Click" >Remove</asp:LinkButton>
                                    </td>
                                     <td class="center">
                                    <asp:LinkButton ID="ChangeStatusLinkButton" runat="server" CommandArgument='<%#Eval("Id") %>' OnClick="ChangeStatusLinkButton_Click" Text='<%#bool.Parse(Eval("Status").ToString()) ? "Remove List" :"Add List"%>' ></asp:LinkButton>
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
