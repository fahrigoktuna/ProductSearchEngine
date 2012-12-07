<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ProductList.aspx.cs" EnableEventValidation="false" Inherits="ProductSearchEngine.Web.ProductList" %>

<%@ Register Src="~/Control/BaseCategoryList.ascx" TagName="BaseCategoryList" TagPrefix="uc" %>
<%@ Register Src="~/Control/BrandList.ascx" TagName="BrandList" TagPrefix="uc" %>
<%@ Register Src="~/Control/SpecialProductList.ascx" TagName="SpecialProductList"
    TagPrefix="uc" %>
<%@ Register Src="~/Control/LastAddedProducts.ascx" TagName="LastAddedProducts" TagPrefix="uc" %>
<%@ Register Assembly="ExtensionWebControls" Namespace="ExtensionWebControls" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="/Assets/js/shoppica.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- ********************** -->
    <!--     I N T R O          -->
    <!-- ********************** -->
    <div id="intro">
        <div id="intro_wrap">
            <div class="container_12">
                <div id="breadcrumbs" class="grid_12">
                    <a href="">Home</a> &gt; <a href="">
                        <asp:Label ID="BaseCategoryNameLabel" runat="server"></asp:Label></a>
                </div>
                <h1>
                    <asp:Label ID="CategoryNameLabel" runat="server"></asp:Label></h1>
            </div>
        </div>
    </div>
    <!-- end of intro -->
    <div id="content" class="container_16">
        <div id="category" class="grid_12">
            <div class="s_subcategories s_grid_view s_listing clearfix">
                <asp:Repeater ID="SubCategoriesRepeater" runat="server">
                    <ItemTemplate>
                        <div class="s_subcategory">
                            <a href="#">
                                <img src='/Images/Products/<%#GetProductPhotoUniqueName(Container.DataItem) %>' width="100"
                                    height="100" style="margin-bottom: 3px;" /></a> <a href="#">
                                        <%#Eval("Name").ToString() %></a>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <div class="clear">
                </div>
            </div>
            <asp:UpdatePanel ID="UpdatePanel1" ViewStateMode="Enabled" runat="server">
                <ContentTemplate>
                    <div id="listing_options">
                        <div id="listing_sort" class="s_switcher">
                            <span class="s_selected">
                                <asp:Label ID="CurrentSortExpression" runat="server" Text="Default"></asp:Label></span>
                            <ul class="s_options" style="display: none;">
                                <li>
                                    <asp:LinkButton ID="SortByTitleAscending" runat="server" OnClick="SortBy_Click">Name A - Z</asp:LinkButton></li>
                                <li>
                                    <asp:LinkButton ID="SortByTitleDescending" runat="server" OnClick="SortBy_Click">Name Z - A</asp:LinkButton></li>
                                <li>
                                    <asp:LinkButton ID="SortByPriceAscending" runat="server" OnClick="SortBy_Click">Price Low &gt; High</asp:LinkButton></li>
                                <li>
                                    <asp:LinkButton ID="SortByPriceDescending" runat="server" OnClick="SortBy_Click">Price High &gt; Low</asp:LinkButton></li>
                                <li>
                                    <asp:LinkButton ID="SortByRateDescending" runat="server" OnClick="SortBy_Click">Rating Highest</asp:LinkButton></li>
                                <li>
                                    <asp:LinkButton ID="SortByRateAscending" runat="server" OnClick="SortBy_Click">Rating Lowest</asp:LinkButton></li>
                            </ul>
                        </div>
                        <%--<div id="view_mode" class="s_nav">
                <ul class="clearfix">
                    <li id="view_grid"><a href="listing_4.html"><span class="s_icon"></span>Grid</a></li>
                    <li id="view_list" class="s_selected"><a href="listing_3.html"><span class="s_icon">
                    </span>List</a></li>
                </ul>
            </div>--%>
            
                    </div>
                    <div class="clear">
                    </div>
                    <div class="s_listing s_list_view clearfix">
                        <cc1:DataPagerRepeater ID="ProductListRepeater"    ontotalrowcountavailable="rep1_TotalRowCountAvailable" runat="server" >
                            <ItemTemplate>
                                <div class="s_item clearfix">
                                    <div class="grid_3 alpha">
                                        <a class="s_thumb" href='ProductDetail.aspx?p=<%#Eval("Id").ToString() %>'>
                                            <img src='Images/Products/<%#GetProductPhotoUniqueName(Container.DataItem) %>' width="140"
                                                height="140" title="<%#Eval("Title").ToString() %>" alt="<%#Eval("Title").ToString() %>" /></a>
                                    </div>
                                    <div class="grid_9 omega">
                                        <h3>
                                            <a href='ProductDetail.aspx?p=<%#Eval("Id").ToString() %>'>
                                                <%#Eval("Title").ToString() %></a></h3>
                                        <p class="s_model">
                                            Product
                                            <%#Eval("Id") %></p>
                                        <p class="s_price">
                                            <span class="s_currency s_before">TL</span><%#Eval("Price").ToString() %></p>
                                        <p class="s_description">
                                            <%#GetProductDetailsSubString(Eval("DetailDescription").ToString()) %></p>
                                        <a class="s_button_add_to_cart" href='ProductDetail.aspx?p=<%#Eval("Id").ToString() %>'>
                                            <span class="s_icon_16"><span class="s_icon"></span>View Details</span></a>
                                    </div>
                                </div>
                                <div class="clear">
                                </div>
                            </ItemTemplate>
                        </cc1:DataPagerRepeater>
                    </div>
                    <div class="pagination">
                        <div class="results">
                            <asp:DataPager ID="DataPager1" PagedControlID="ProductListRepeater" PageSize="4" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ShowFirstPageButton="True" ShowNextPageButton="False"
                                        ShowPreviousPageButton="False" />
                                    <asp:NumericPagerField />
                                    <asp:NextPreviousPagerField ShowLastPageButton="True" ShowNextPageButton="False"
                                        ShowPreviousPageButton="False" />
                                </Fields>
                            </asp:DataPager>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <!-- RIGHT COLUMNN-->
        <div id="right_col" class="grid_3">
            <uc:BaseCategoryList ID="BaseCategoryListUserControl" runat="server" />
            <uc:BrandList ID="BrandListtUserControl" runat="server" />
            <uc:SpecialProductList ID="SpecialProductListUserControl" runat="server" />
            <div id="information_module" class="s_box">
                <h2>
                    Information</h2>
                <ul class="s_list_1">
                    <li><a href="#">About Product Search Engine Project</a></li>
                    <li><a href="#">Contact</a></li>
                    <li><a href="#">Site Map</a></li>
                </ul>
            </div>
            <uc:LastAddedProducts ID="LastAddedProductsUserControl" runat="server" />
        </div>
        <!--END RIGHT COLUMNN-->
    </div>
</asp:Content>
