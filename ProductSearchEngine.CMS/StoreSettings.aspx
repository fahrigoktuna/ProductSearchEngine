<%@ Page Title="" Language="C#" MasterPageFile="/Admin.Master" AutoEventWireup="true" CodeBehind="StoreSettings.aspx.cs" Inherits="ProductSearchEngine.CMS.StoreSettings" %>

<%@ Register Src="/Control/MemberShipInformation.ascx" TagPrefix="uc1" TagName="MemberShipInformation" %>

<%@ Register Src="/Control/StoreInformation.ascx" TagName="StoreInformation" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<uc1:MemberShipInformation ID="MemberShipInformationUserControl" runat="server" />

<uc1:StoreInformation ID="StoreInformationUserControl" Width="50%" IsLoad="true" runat="server" />
</asp:Content>
