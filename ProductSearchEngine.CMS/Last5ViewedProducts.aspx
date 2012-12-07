<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Last5ViewedProducts.aspx.cs" Inherits="ProductSearchEngine.CMS.Last5ViewedProducts" %>

<%@ Register Src="~/Control/Last5ViewedProducts.ascx" TagPrefix="uc1" TagName="Last5ViewedProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<uc1:Last5ViewedProducts ID="Last5ViewedProductsUserControl"  runat="server" />
</asp:Content>
