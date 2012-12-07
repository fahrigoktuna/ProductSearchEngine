<%@ Page Title="" Language="C#" MasterPageFile="/Admin.Master" AutoEventWireup="true" CodeBehind="StoreList.aspx.cs" Inherits="ProductSearchEngine.CMS.StoreList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
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
                           All Stores</h1>
                        <span></span>
                    </div>
                    <div class="block-content">
                        <asp:Repeater ID="StoreListRepeater" runat="server">
                            <HeaderTemplate>
                                <table id="table-example" class="table">
                                    <thead>
                                        <tr>
                                            <th>
                                                Store
                                            </th>
                                            <th>
                                                Authorized Person
                                            </th>
                                            <th>
                                                Telephone
                                            </th>
                                            <th>
                                                Email
                                            </th>
                                            <th>
                                                Web Address
                                            </th>
                                             <th>
                                                Change Status
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
                                    <td>
                                   
                                       <%#Eval(" Membership.StoreInformation.AuthorizedName")%>
                                    </td>
                                    <td>
                                          <%#Eval(" Membership.StoreInformation.Telephone")%>
                                    </td>
                                    <td class="center">
                                    <%#Eval(" Membership.StoreInformation.Email")%>
                                    </td>
                                    <td class="center">
                                   <%#Eval(" Membership.StoreInformation.WebAddress")%>
                                    </td>
                                     <td class="center">
                                    <asp:LinkButton ID="ChangeStatusLinkButton" runat="server" CommandArgument='<%#Eval("Membership.Id") %>' Text='<%#bool.Parse(Eval("Membership.Status").ToString()) == true ? "Remove From List" : "Add List" %>'  OnClick="ChangeStatusLinkButton_Click" ></asp:LinkButton>
                                    </td>
                                   
                                    <td class="center">
                                    <asp:LinkButton ID="RemoveLinkButton" runat="server" CommandArgument='<%#Eval("Id") %>' OnClick="RemoveLinkButton_Click" >Remove</asp:LinkButton>
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
