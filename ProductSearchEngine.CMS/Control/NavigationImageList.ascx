<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NavigationImageList.ascx.cs"
    Inherits="ProductSearchEngine.CMS.Control.NavigationImageList" %>
<asp:Panel ID="AdminPanel" runat="server">
    <div class="grid_12">
        <div class="block-border">
            <div class="block-content">
                <ul class="shortcut-list">
                    <li><a href='<%=ProductListAdminUrl %>'>
                        <img src="img/icons/packs/crystal/48x48/apps/kedit.png">
                        Products </a></li>
                    <li><a href="/BrandList.aspx">
                        <img src="img/icons/packs/crystal/48x48/apps/penguin.png">
                        Brands </a></li>
                    <li><a href="/CategoryList.aspx">
                        <img src="img/icons/packs/crystal/48x48/apps/wifi.png">
                        Categories </a></li>
                    <li><a href="/StoreList.aspx">
                        <img src="img/icons/packs/crystal/48x48/apps/mailreminder.png">
                        Stores </a></li>
                    <li><a href="/CommentList.aspx">
                        <img src="img/icons/packs/crystal/48x48/apps/Volume Manager.png">
                        Comments </a></li>
                    <li><a href="javascript:void(0);">
                        <img src="img/icons/packs/crystal/48x48/apps/terminal.png">
                        Settings </a></li>
                    <li><a href="javascript:void(0);">
                        <img src="img/icons/packs/crystal/48x48/apps/knotes.png">
                        Reports </a></li>
                </ul>
                <div class="clear">
                </div>
            </div>
        </div>
    </div>
</asp:Panel>

<asp:Panel ID="StorePanel" runat="server">
    <div class="grid_12">
        <div class="block-border">
            <div class="block-content">
                <ul class="shortcut-list">
                    <li><a href="/ProductAdd.aspx">
                        <img src="img/icons/packs/crystal/48x48/apps/kedit.png">
                        New Product</a></li>
                    <li><a href='<%=ProductListStoreUrl %>'>
                        <img src="img/icons/packs/crystal/48x48/apps/penguin.png">
                        My Products</a></li>
                    <li><a href="/MembershipInformationEdit.aspx">
                        <img src="img/icons/packs/crystal/48x48/apps/wifi.png">
                        Membership</a></li>
                    <li><a href="/StoreInformationEdit.aspx">
                        <img src="img/icons/packs/crystal/48x48/apps/mailreminder.png">
                        Store</a></li>
                    
                    <li><a href="/StoreSettings.aspx">
                        <img src="img/icons/packs/crystal/48x48/apps/terminal.png">
                        Settings</a></li>
                    <li><a href="javascript:void(0);">
                        <img src="img/icons/packs/crystal/48x48/apps/knotes.png">
                        Reports</a></li>
                </ul>
                <div class="clear">
                </div>
            </div>
        </div>
    </div>
</asp:Panel>
