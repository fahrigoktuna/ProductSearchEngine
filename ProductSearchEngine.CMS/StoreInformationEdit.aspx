<%@ Page Title="" Language="C#" MasterPageFile="/Admin.Master" AutoEventWireup="true" CodeBehind="StoreInformationEdit.aspx.cs" Inherits="ProductSearchEngine.CMS.StoreInformationEdit" %>


<%@ Register Src="/Control/StoreInformation.ascx" TagName="StoreInformation" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<uc1:StoreInformation ID="StoreInformationUserControl" IsLoad="true" Width="50%"  runat="server" />
</asp:Content>
