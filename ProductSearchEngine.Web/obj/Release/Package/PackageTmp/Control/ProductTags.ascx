<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductTags.ascx.cs" Inherits="ProductSearchEngine.Web.Control.ProductTags" %>

   <div id="product_tags" class="grid_12 alpha omega">
        <h2 class="s_title_1"><span class="s_main_color">Product</span> Tags</h2>
        <div class="clear"></div>
        <asp:Repeater ID="ProductTagsRepeater" runat="server">
        <HeaderTemplate>
          <ul class="clearfix">
        </HeaderTemplate>
        <ItemTemplate>
               <li><asp:LinkButton ID="KeywordLinkButton" runat="server" CommandArgument='<%#Eval("Keyword.Keyword") %>' OnClick="KeywordLinkButton_Click"><%#Eval("Keyword.Keyword") %></asp:LinkButton></li>
        </ItemTemplate>
        <FooterTemplate>
         </ul>
        </FooterTemplate>
        </asp:Repeater>
      
   
          
       
      </div>