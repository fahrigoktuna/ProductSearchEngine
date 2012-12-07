<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="StoreAdd.aspx.cs" Inherits="ProductSearchEngine.CMS.StoreAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="grid_6">
                <div class="block-border">
                    <div class="block-header">
                        <h1>
                            Add New Store
                        </h1>
                        <span></span>
                    </div>
                    <div id="Div4" class="block-content form">
                        <table id="table1" class="table">
                            <thead>
                                <tr>
                                    <th>
                                        Store Name
                                    </th>
                                   
                                    <th>
                                        User Name
                                    </th>
                                    <th>
                                       Password
                                    </th>
                                     <th>
                                       Status
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
                                    <td>
                                        <asp:TextBox ID="StoreNameTextBox" EnableViewState="true" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="StoreUserNameTextBox" EnableViewState="true" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="StorePasswordTextBox" EnableViewState="true" runat="server"></asp:TextBox>
                                    </td>
                                    
                                    <td>
                                       <asp:CheckBox ID="StoreStatusCheckBox" runat="server" Checked="true" />
                                    </td>
                                    <td>
                                       <asp:LinkButton ID="StoreAddLinkButton" runat="server" OnClick="StoreAddLinkButton_Click">Add</asp:LinkButton>
                                    </td>
                                    <td>
                                       <asp:Label ID="SuccessInfoMessage" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            
            <div class="clear height-fix">
            </div>
</asp:Content>
