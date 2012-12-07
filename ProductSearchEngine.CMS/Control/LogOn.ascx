<%@ Control Language="C#" AutoEventWireup="true" EnableViewState="true" CodeBehind="LogOn.ascx.cs" Inherits="ProductSearchEngine.CMS.Control.LogOn" %>

<!-- Begin of #login-details -->
		<section id="login-details">
    		<img class="img-left framed" src="/img/misc/avatar_small.png" alt="Hello Admin">
    		<h3>Logged in as</h3>
    		<h2><a class="user-button" href="javascript:void(0);"><%=UserName %>&nbsp;<span class="arrow-link-down"></span></a></h2>
    		<ul class="dropdown-username-menu">
    			<li><a href="#">Profile</a></li>
    			<li><a href="#">Settings</a></li>
    			<li><a href="#">Messages</a></li>
              
    			<li><asp:LinkButton ID="LogOutLinkButton" CausesValidation="false" ClientIDMode="AutoID" EnableViewState="true"  OnClick="LogOutLinkButton_Click" runat="server">Logout</asp:LinkButton></li>
    		</ul>
    		
    		<div class="clearfix"></div>
  		</section>
         <!--! end of #login-details -->