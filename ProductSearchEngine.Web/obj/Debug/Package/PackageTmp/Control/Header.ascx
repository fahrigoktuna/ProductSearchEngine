<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="ProductSearchEngine.Web.Control.HeaderUserControl" %>
<link href="/Assets/plugin/autocomplete/jquery.autocomplete.css" rel="stylesheet"
    type="text/css" />
<script src="/Assets/plugin/autocomplete/jquery.autocomplete.js" type="text/javascript"></script>
<script src="/Assets/plugin/autocomplete/jquery.autocomplete.min.js" type="text/javascript"></script>
<script src="/Assets/plugin/autocomplete/jquery.autocomplete.pack.js" type="text/javascript"></script>
<script type="text/javascript">
    $(document).ready(function () {
        $("#<%=HeaderSearchTextBox.ClientID%>").autocomplete('/Handler/AutoComplete.ashx');
    });      
</script>
<!-- ********************** -->
<!--      H E A D E R       -->
<!-- ********************** -->
<div id="header" class="container_12">
    <div class="grid_12">
        <a id="site_logo" href="/Default.aspx"></a>
        <div id="site_search">
            <div id="search_bar" class="clearfix">
                <asp:TextBox ID="HeaderSearchTextBox" runat="server" CssClass="filter_keyword"></asp:TextBox>
                <asp:DropDownList ID="HeaderCategoriesDropDownList" CssClass="filter_category_id"
                    runat="server">
                </asp:DropDownList>
                <asp:LinkButton ID="HeaderGoLinkButton" runat="server" OnClick="HeaderGoLinkButton_Click"
                    CssClass="s_button_1 s_secondary_color_bgr"><span class="s_text">Go</span></asp:LinkButton>
            </div>
        </div>
        <div id="categories" class="s_nav">
            <ul>
                <li id="menu_home"><a href="/Default.aspx">Home</a> </li>
                <asp:Repeater ID="HeaderCategoryRepeater" OnItemDataBound="HeaderCategoryRepeater_DataBound"
                    runat="server">
                    <ItemTemplate>
                        <li>
                            <asp:LinkButton ID="BaseCategoryLinkButton" OnClick="BaseCategoryLinkButton_Click"
                                CommandArgument='<%#Eval("Id") %>' runat="server">
                            <%#Eval("Name") %></asp:LinkButton>
                            <div class="s_submenu">
                                <h3>
                                    Inside
                                    <%#Eval("Name") %></h3>
                                <asp:Repeater ID="HeaderCategoryInsideRepeater" OnItemDataBound="HeaderCategoryInsideRepeater_DataBound"
                                    runat="server">
                                    <HeaderTemplate>
                                        <ul class="s_list_1 clearfix">
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <li>
                                            <asp:LinkButton OnClick="SubCategoryLinkButton_Click" ID="SubCategoryLinkButton"
                                                runat="server" CommandArgument='<%#Eval("Id") %>'>
                                            <%#Eval("Name") %></asp:LinkButton>
                                        </li>
                                        <%--<span class="clear border_eee"></span>
                                <h3>
                                    Electronics Brands</h3>
                                <ul class="s_list_1 clearfix">
                                    <li><a href="listing_1.html">Canon</a></li>
                                    <li><a href="listing_1.html">Hugo Boss</a></li>
                                    <li><a href="listing_1.html">Panasonic</a></li>
                                    <li><a href="listing_1.html">Samsung</a></li>
                                    <li><a href="listing_1.html">Sony</a></li>
                                </ul>--%>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        </ul> </div>
                                    </FooterTemplate>
                                </asp:Repeater>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
    </div>
</div>
<!-- end of header -->
