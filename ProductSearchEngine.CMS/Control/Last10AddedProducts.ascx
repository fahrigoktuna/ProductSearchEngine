<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Last10AddedProducts.ascx.cs" Inherits="ProductSearchEngine.CMS.Control.Last10AddedProducts" %>

<div class="grid_4">
				<div class="block-border">
					<div class="block-header">
						<h1>Last 10 Added Products</h1><span></span>
					</div>
					<div class="block-content">
                    <asp:Repeater ID="Last10AddedProductsRepeater" runat="server">
                    <HeaderTemplate>
                    <ul class="block-list with-icon">
                    
                    </HeaderTemplate>

                    <ItemTemplate>
                    	<a href='<%# GetStoreEditUrlAddress(Eval("Id")) %>'> <li class="i-16-application"><%#Eval("Title") %></li></a>
                    </ItemTemplate>
                    <FooterTemplate>
                    </ul>
                    </FooterTemplate>
                    </asp:Repeater>
						
							
						
							
						
					</div>
					<div class="block-content dark-bg">
						<p>Click any products above to view details.</p>
					</div>
				</div>
			</div>
