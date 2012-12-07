<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="deneme3.aspx.cs" Inherits="ProductSearchEngine.CMS.deneme3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:LinkButton ID="LinkButton1"
            runat="server" onclick="LinkButton1_Click">LinkButton</asp:LinkButton>
    <asp:Label ID="MessageLabel" runat="server"></asp:Label>
    </div>
</asp:Content>
