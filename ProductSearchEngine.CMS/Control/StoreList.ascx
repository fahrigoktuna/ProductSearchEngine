<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StoreList.ascx.cs" Inherits="ProductSearchEngine.CMS.Control.StoreList" %>


<div class="grid_4">
				<div class="block-border">
					<div class="block-header">
						<h1>Store List</h1><span></span>
					</div>
					<div class="block-content">
                    <asp:Repeater ID="StoreListRepeater" runat="server">
                    <HeaderTemplate>
                    <ul class="block-list with-icon">
                    
                    </HeaderTemplate>

                    <ItemTemplate>
                   <li class="i-16-application"><%#Eval("Name") %>, Id:<%#Eval("Id") %></li>
                    </ItemTemplate>
                    <FooterTemplate>
                    </ul>
                    </FooterTemplate>
                    </asp:Repeater>
						
							
						
							
						
					</div>
					<div class="block-content dark-bg">
						<p>You can see store list at above</p>
					</div>
				</div>
			</div>
