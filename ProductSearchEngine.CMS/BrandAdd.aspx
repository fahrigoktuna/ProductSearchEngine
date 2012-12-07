<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" EnableViewState="true" AutoEventWireup="true" CodeBehind="BrandAdd.aspx.cs" Inherits="ProductSearchEngine.CMS.BrandAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                                     <th>
                                        Success Info
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="BrandNameTextBox" EnableViewState="true" runat="server"></asp:TextBox>
                                    </td>
                                    
                                    <td>
                                        <asp:LinkButton ID="BrandNameAddLinkButton" EnableViewState="true" runat="server" Text="Add" OnClick="BrandNameAddLinkButtonLinkButton_Click"></asp:LinkButton>
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
