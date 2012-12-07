<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ProductDetail.aspx.cs" Inherits="ProductSearchEngine.Web.ProductDetail" %>

<%@ Register Src="~/Control/BaseCategoryList.ascx" TagName="BaseCategoryList" TagPrefix="uc" %>
<%@ Register Src="~/Control/BrandList.ascx" TagName="BrandList" TagPrefix="uc" %>
<%@ Register Src="~/Control/SpecialProductList.ascx" TagName="SpecialProductList"
    TagPrefix="uc" %>
<%@ Register Src="~/Control/LastAddedProducts.ascx" TagName="LastAddedProducts" TagPrefix="uc" %>
<%@ Register Src="~/Control/ProductTags.ascx" TagName="ProductTags" TagPrefix="uc" %>
<%@ Register Src="~/Control/RelatedProducts.ascx" TagName="RelatedProducts" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="/Assets/stylesheet/prettyPhoto.css"
        media="all" />
    <script type="text/javascript" src="/Assets/js/jquery/jquery.prettyPhoto.js"></script>
    <script type="text/javascript" src="/Assets/js/shoppica.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {

            $(".s_tabs").tabs({ fx: { opacity: 'toggle', duration: 300} });

            $("#product_images a[rel^='prettyPhoto'], #product_gallery a[rel^='prettyPhoto']").prettyPhoto({
                theme: 'light_square',
                opacity: 0.5
            });

        });

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- ********************** -->
    <!--     I N T R O          -->
    <!-- ********************** -->
    <div id="intro">
        <div id="intro_wrap">
        </div>
    </div>
    <!-- end of intro -->
    <!-- ********************** -->
    <!--      C O N T E N T     -->
    <!-- ********************** -->
    <div id="content" class="product_view container_16">
        <!-- CENTER DETAIL-->
        <asp:Repeater ID="ProductRepeater" OnItemDataBound="ProductRepeater_DataBound" runat="server">
            <ItemTemplate>
                <div id="product" class="grid_12">
                    <div id="product_images" class="grid_6 alpha">
                        <a id="product_image_preview" rel="prettyPhoto[gallery]" href='/Images/Products/<%#GetProductUniqueName(Container.DataItem) %>'>
                            <img id="image" width="300" height="300" src='/Images/Products/<%#GetProductUniqueName(Container.DataItem) %>' /></a>
                    </div>
                    <div id="product_info" class="grid_6 omega">
                        <p class="s_price">
                            <%#Eval("Price").ToString() %><span class="s_currency s_after"> TL</span></p>
                        <dl class="clearfix">
                            <dt>Free Shipping</dt>
                            <dd>
                                <%#Convert.ToBoolean(Eval("IsFreeShipping")) ? "YES" : "NO" %></dd>
                            <dt>Used Condition</dt>
                            <dd>
                                <%#Convert.ToBoolean(Eval("IsNewItem")) ? "New Item" : "Used" %></dd>
                            <dt>Brand</dt>
                            <dd>
                                <a href="#">
                                    <%#Eval("Brand.Name") %></a></dd>
                            <dt>Average Rating</dt>
                            <dd>
                                <p class="s_rating s_rating_5">
                                    <span style='<%#GetRatePercentage(Container.DataItem) %>' class="s_percent"></span>
                                </p>
                            </dd>
                        </dl>
                        <div id="product_options">
                            <h3>
                                Available Options</h3>
                            <label>
                                <dt style="width: 100%">Go To Store: </dt>
                            </label>
                            <dd style="padding-top: 4px">
                                <a href='<%#Eval("RedirectUrl") %>' target="_blank">
                                    <%#Eval("Store.Name") %></a></dd>
                            <span class="clear"></span>
                        </div>
                    </div>
                    <div class="clear">
                    </div>
                    <div class="s_tabs grid_12 alpha omega">
                        <ul class="s_tabs_nav clearfix">
                            <li><a href="#product_description">Description</a></li>
                            <li><a href="#product_reviews">Reviews (<%#Eval("Comments.Count").ToString() %>)</a></li>
                            <li><a href="#product_gallery">Photos (<%#Eval("ProductPhotos.Count").ToString() %>)</a></li>
                        </ul>
                        <div class="s_tab_box">
                            <div id="product_description">
                                <div class="cpt_product_description ">
                                    <center style="color: #7EBD1E">
                                        <h4>
                                            Detail Descriptions</h4>
                                    </center>
                                    <p style="padding-top: 5px">
                                        <%#Eval("DetailDescription") %></p>
                                    <center style="padding-top: 10px; color: #7EBD1E">
                                        <h4>
                                            Specifiations</h4>
                                    </center>
                                    <asp:Repeater ID="ProductSpecificationsRepeater" runat="server">
                                        <HeaderTemplate>
                                            <table class="s_table_1" style="padding: 10px" width="100%" cellpadding="0" cellspacing="0"
                                                border="0">
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <tr>
                                                <td style="font-weight: bold">
                                                    <%#Eval("SpecificationName").ToString() %>
                                                </td>
                                                <td>
                                                    <%#Eval("SpecificationValue").ToString() %>
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            </table>
                                        </FooterTemplate>
                                    </asp:Repeater>
                                </div>
                                <!-- cpt_container_end -->
                            </div>
                            <!-- PRODUCT REVIEWS-->
                            <div id="product_reviews" class="s_listing">
                                <asp:Repeater ID="ProductReviewsRepeater" runat="server">
                                    <ItemTemplate>
                                        <div class="s_review last">
                                            <p class="s_author">
                                                <strong>
                                                    <%#Eval("Title") %></strong></p>
                                            <div class="right">
                                                <div class="s_rating_holder">
                                                    <p class="s_rating s_rating_5">
                                                        <span class="s_percent" style='<%#GetRatePercentage(Container.DataItem) %>'></span>
                                                    </p>
                                                    <span class="s_average">
                                                        <%#Eval("Rate.Value") %>
                                                        out of 5 Stars!</span>
                                                </div>
                                            </div>
                                            <div class="clear">
                                            </div>
                                            <p>
                                                <%#Eval("Content") %></p>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                                <h2 class="s_title_1">
                                    <span class="s_main_color">Write</span> Review</h2>
                                <div id="review_title" class="clear">
                                </div>
                                <div class="s_row_3 clearfix">
                                    <label>
                                        <strong>Review Title:</strong></label>
                                    <asp:TextBox ID="ReviewTitleTextBox" runat="server"></asp:TextBox>
                                </div>
                                <div class="s_row_3 clearfix">
                                    <label>
                                        <strong>Your Review:</strong></label>
                                    <asp:TextBox Width="98%" Rows="8" Columns="50" TextMode="MultiLine" ID="ReviewTextBox"
                                        runat="server"></asp:TextBox>
                                    <p class="s_legend">
                                        <span style="color: #FF0000;">Note:</span> HTML is not translated!</p>
                                </div>
                                <div class="s_row_3 clearfix">
                                    <label>
                                        <strong>Rating</strong></label>
                                    <asp:RadioButtonList runat="server" RepeatDirection="Horizontal" CellSpacing="20"
                                        ID="ReviewRateRadioButtonList">
                                        <asp:ListItem Value="1"></asp:ListItem>
                                        <asp:ListItem Value="2"></asp:ListItem>
                                        <asp:ListItem Value="3"></asp:ListItem>
                                        <asp:ListItem Value="4"></asp:ListItem>
                                        <asp:ListItem Value="5"></asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <span class="clear border_ddd"></span>
                                <asp:LinkButton runat="server" OnClick="AddReview_Click" ID="AddReviewLinkButton"
                                    CssClass="s_button_1 s_main_color_bgr">
                                 <span
                                    class="s_text">Add Review</span>
                                </asp:LinkButton>
                                <span class="clear"></span>
                            </div>
                            <!-- END PRODUCT REVIEWS-->
                            <!-- PRODUCT PHOTOS-->
                            <asp:Repeater ID="ProductPhotosRepeater" runat="server">
                                <HeaderTemplate>
                                    <div id="product_gallery">
                                        <ul class="s_thumbs clearfix">
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <li><a class="s_thumb" href='/Images/Products/<%#Eval("UniqueName").ToString() %>'
                                        rel="prettyPhoto[gallery]">
                                        <img src='/Images/Products/<%#Eval("UniqueName").ToString() %>' width="120" /></a></li>
                                </ItemTemplate>
                                <FooterTemplate>
                                    </ul> </div>
                                </FooterTemplate>
                            </asp:Repeater>
                            <!--END PRODUCT PHOTOS-->
                        </div>
                    </div>
                    <uc:RelatedProducts ID="RelatedProductsUserControl" runat="server" />
                    <uc:ProductTags ID="ProductTagsUserControl" runat="server" />
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <!--END CENTER DETAIL-->
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
    <!-- end of content -->
</asp:Content>
