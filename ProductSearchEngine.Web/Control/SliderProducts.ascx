<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SliderProducts.ascx.cs"
    Inherits="ProductSearchEngine.Web.Control.SliderProducts" %>
<!-- ********************** -->
<!--     I N T R O          -->
<!-- ********************** -->

<div id="intro">
    <div id="intro_wrap">
        <div id="product_intro" class="container_12">
            <div id="product_intro_info" class="grid_5">
            <asp:Repeater ID="SliderProductsRepeater" runat="server" OnItemDataBound="SliderProductsRepeater_DataBound">
            <ItemTemplate>
             <div style='position: <%# Container.ItemIndex == 0 ? "relative;" : "position: relative; display: none;"%>'>
                    <h2>
                        <a href='/ProductDetail.aspx?p=<%#Eval("Id") %>'><%#Eval("Title") %></a></h2>
                    <div class="s_rating_holder" runat="server" ID="RatingHolderDiv" style="display:none">
                        <p class="s_rating s_rating_big s_rating_5">
                            <span style='width:<%#GetRatePercentage(Container.DataItem) %>%;' class="s_percent"></span>
                        </p>
                        <span class="s_average"><%#GetRate(Container.DataItem) %> out of 5</span>
                    </div>
                    <p class="s_desc">
                        <%#GetDetailDescription(Container.DataItem) %></p>
                    <div class="s_price_holder">
                        <p class="s_price">
                            <span class="s_currency s_before">TL </span><%#Eval("Price") %>
                        </p>
                    </div>
                </div>
            </ItemTemplate>
            </asp:Repeater>
               

            </div>
            <div id="product_intro_preview">
                <div class="slides_container">
               <asp:Repeater ID="SliderProductPhotosRepeater" runat="server">
               <ItemTemplate>
               <div class="slideItem" style="display: none">
                        <a href='/ProductDetail.aspx?p=<%#Eval("Product.Id") %>'>
                            <img src='/Images/Products/<%#Eval("UniqueName") %>' width="134" height="220" alt="" /></a>
                            
                            </div>
               </ItemTemplate>
               </asp:Repeater>
                    
                </div>
                <a class="s_button_prev" href="javascript:;"></a><a class="s_button_next" href="javascript:;">
                </a>
            </div>
        </div>
    </div>
</div>
 <script type="text/javascript" src="/Assets/js/jquery/jquery.slides.js"></script>
<script type="text/javascript" src="/Assets/js/shoppica.products_slide.js"></script>
<!-- end of intro -->
