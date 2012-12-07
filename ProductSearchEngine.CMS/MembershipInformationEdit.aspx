<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MembershipInformationEdit.aspx.cs" Inherits="ProductSearchEngine.CMS.MembershipInformationEdit" %>

<%@ Register Src="~/Control/MemberShipInformation.ascx" TagPrefix="uc1" TagName="MemberShipInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<uc1:MemberShipInformation ID="MemberShipInformationUserControl" runat="server" />
</asp:Content>
