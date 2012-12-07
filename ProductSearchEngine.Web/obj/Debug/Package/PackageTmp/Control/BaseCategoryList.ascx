<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BaseCategoryList.ascx.cs" Inherits="ProductSearchEngine.Web.Control.BaseCategoryList" %>

<div id="categories_module" class="s_box">
        <h2>Categories</h2>
        
        <div class="s_list_1">

        <asp:Repeater ID="BaseCategoryListRepeater" runat="server">
        <HeaderTemplate>
        <ul>
        </HeaderTemplate>

        <ItemTemplate>
         <li><asp:LinkButton ID="BaseCategoryNameLinkButton" runat="server" OnClick="BaseCategoryNameLinkButton_Click" CommandArgument='<%#Eval("Id").ToString() %>'> <%#Eval("Name").ToString() %> </asp:LinkButton></li>
        </ItemTemplate>
        <FooterTemplate>
        </ul>
        </FooterTemplate>
        </asp:Repeater>
         
      	</div>
			</div>

