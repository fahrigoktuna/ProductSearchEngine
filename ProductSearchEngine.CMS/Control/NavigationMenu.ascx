<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NavigationMenu.ascx.cs"
    Inherits="ProductSearchEngine.CMS.Control.NavigationMenu" %>
<!-- Begin of Navigation -->
<asp:Panel ID="AdminPanel" CssClass="panel" runat="server">
    <nav id="nav">
	    	<ul class="menu collapsible shadow-bottom">
	    		<li><a href="/DashBoard.aspx" class="current"><img src="/img/icons/packs/fugue/16x16/dashboard.png" alt=""/>Dashboard<span class="badge"></span></a></li>
	    		<li><a href='<%=ProductListAdminUrl %>'><img src="/img/icons/packs/fugue/16x16/application-form.png" alt=""/>Products</a>
                <ul class="sub">
                
                	<li><a href='<%=ProductListAdminUrl %>'>All Products</a></li>
                    <li><a href="#">Last 10 Added</a></li>
                
                </ul>
                </li>
                <li><a href="/StoreList.aspx"><img src="/img/icons/packs/fugue/16x16/application-form.png" alt=""/>Stores</a>
                <ul class="sub">
                
                	<li><a href="/StoreList.aspx">All Stores</a></li>
              <li><a href="/StoreAdd.aspx">Store Add</a></li>
                </ul>
                </li>

                <li><a href="/BrandList.aspx"><img src="/img/icons/packs/fugue/16x16/application-form.png" alt=""/>Brands</a>
                <ul class="sub">
               
                	<li><a href="/BrandList.aspx">All Brands</a></li>
                    <li><a href="/BrandAdd.aspx">Add New Brand</a></li>
             
                </ul>
                </li>

                <li><a href="/CategoryList.aspx"><img src="/img/icons/packs/fugue/16x16/application-form.png" alt=""/>Categories</a>
                <ul class="sub">
                
                	<li><a href="/CategoryList.aspx">All Categories</a></li>
                             <li><a href="/CategoryAdd.aspx">Add New Category</a></li>
             
                </ul>
                </li>
                    <li><a href="/CommentList.aspx"><img src="/img/icons/packs/fugue/16x16/application-form.png" alt=""/>Comments</a>
                <ul class="sub">
                     
                	<li><a href="/CommentList.aspx">All Comments</a></li>
                             
                
                </ul>
                </li>

	    		
	    	</ul>
    	</nav>
</asp:Panel>
<asp:Panel ID="StorePanel" CssClass="panel" runat="server">
    <nav id="nav">
	    	<ul class="menu collapsible shadow-bottom">
	    		<li><a href="/DashBoard.aspx" class="current"><img src="/img/icons/packs/fugue/16x16/dashboard.png"/>Dashboard<span class="badge"></span></a></li>
	    		<li><a href='<%=ProductListStoreUrl %>'><img src="/img/icons/packs/fugue/16x16/application-form.png/">Products</a>
                <ul class="sub">
              
                	<li><a href='<%=ProductListStoreUrl %>'>My Products</a></li>
                    <li><a href="/Last5AddedProducts.aspx">Last 5 Added</a></li>
                      <li><a href="/Last5ViewedProducts.aspx">Last 5 Viewed</a></li>
                      <li><a href="/ProductAdd.aspx">Add New Product</a></li>
              
                </ul>
                </li>
                
                
                <li><a href="/StoreSettings.aspx"><img src="/img/icons/packs/fugue/16x16/application-form.png">Settings</a>
                <ul class="sub">
               
                	<li><a href="/MembershipInformationEdit.aspx">Membership Information</a></li>
                    <li><a href="/StoreInformationEdit.aspx">Store Information</a></li>
                
                </ul>
                </li>

                <li><a href="#"><img src="/img/icons/packs/fugue/16x16/application-form.png">Reports</a>
              
                </li>

                

	    		
	    	</ul>
    	</nav>
</asp:Panel>
<!--! end of #nav -->
