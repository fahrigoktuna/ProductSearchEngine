<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Last5AddedProducts.aspx.cs" Inherits="ProductSearchEngine.CMS.Last5AddedProducts" %>

<%@ Register Src="~/Control/Last5AddedProducts.ascx" TagPrefix="uc1" TagName="Last5AddedProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<uc1:Last5AddedProducts ID="Last5AddedProductsUserControl" IsLoad="true"  runat="server" />
</asp:Content>
