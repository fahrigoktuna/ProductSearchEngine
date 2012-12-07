<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RelatedProducts.ascx.cs" Inherits="ProductSearchEngine.Web.Control.RelatedProducts" %>

   <div id="related_products" class="grid_12 alpha omega">
        <h2 class="s_title_1"><span class="s_main_color">Related</span> Products</h2>
        <div class="clear"></div>
        <div class="s_grid_view s_listing clearfix">
          <asp:Repeater ID="RelatedProductsRepeater" runat="server">
          <ItemTemplate>
          <div class="s_item grid_3">
          	<a class="s_thumb" href='/ProductDetail.aspx?p=<%#Eval("Id") %>'><img src='/Images/Products/<%#GetProductUniqueName(Container.DataItem) %>' title='<%#Eval("Title") %>' alt='<%#Eval("Title") %>' /></a>
            <h3><a href="#"><%#Eval("Title") %></a></h3>
            <p class="s_model">Product <%#Eval("Id") %></p>
            <p class="s_price"><%#Eval("Price") %><span class="s_currency s_after"> TL</span></p>
          
          </div>
          </ItemTemplate>
          </asp:Repeater>
          

          <div class="clear"></div>
        </div>
      </div>