<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true"
    CodeBehind="DashBoard.aspx.cs" Inherits="ProductSearchEngine.CMS.DashBoard" %>

<%@ Register Src="~/Control/NavigationImageList.ascx" TagName="NavigationImageList"
    TagPrefix="uc1" %>
<%@ Register Src="~/Control/OverViewList.ascx" TagName="OverViewList" TagPrefix="uc1" %>

<%@ Register Src="~/Control/Last10AddedProducts.ascx" TagName="Last10AddedProducts" TagPrefix="uc1" %>
<%@ Register Src="~/Control/Last5AddedProducts.ascx" TagName="Last5AddedProducts" TagPrefix="uc1" %>

<%@ Register Src="~/Control/StoreList.ascx" TagName="StoreList" TagPrefix="uc1" %>
<%@ Register Src="~/Control/StoreInformation.ascx" TagName="StoreInformation" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="main-content">
        <div class="container_12">
            <div class="grid_12">
                <h1>
                    Dashboard</h1>
                <p>
                    Here you have a quick overview of some features</p>
                <div class="alert info">
                    <span class="hide">x</span><strong>Hey there! Welcome to the professional and flexible
                        admin template &quot;Grape&quot;. I hope you enjoy your stay and please make sure,
                        that you visit the other pages.</strong></div>
            </div>
            <uc1:NavigationImageList ID="NavigationImageListUserControl" runat="server" />
        
                <uc1:OverViewList ID="OverViewListUserControl"  runat="server" />

                <uc1:Last10AddedProducts ID="Last10AddedProductsUserControl" runat="server" />

                <uc1:Last5AddedProducts ID="Last5AddedProductsUserControl" Width="30%" runat="server" />

                 <uc1:StoreInformation ID="StoreInformationUserControl" runat="server" />

                  <uc1:StoreList ID="StoreListUserControl" runat="server" />
          
            <div class="clear height-fix">
            </div>
        </div>
    </div>
    
</asp:Content>
