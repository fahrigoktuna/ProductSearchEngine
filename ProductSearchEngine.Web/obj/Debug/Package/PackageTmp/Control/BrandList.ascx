<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BrandList.ascx.cs" Inherits="ProductSearchEngine.Web.Control.BrandList" %>

<div id="brands_module" class="s_box">
        <h2>Brands</h2>
        <asp:DropDownList ID="BrandListDropDownList" OnSelectedIndexChanged="BrandListDropDownList_SelectedIndexChanged" AutoPostBack="true" runat="server"></asp:DropDownList>
      </div>