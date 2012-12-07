<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Last5ViewedProducts.ascx.cs"
    Inherits="ProductSearchEngine.CMS.Control.Last5ViewedProducts" %>
<div class="grid_6" style="width: 50%">
    <div class="block-border">
        <div class="block-header">
            <h1>
                Last 5 Viewed Products</h1>
            <span></span>
        </div>
        <div id="form" class="block-content form">
            <asp:Repeater ID="Last5ViewedProductsRepeater"  runat="server">
                <HeaderTemplate>
                 <table  class="table">
                    <thead>
                        <tr>
                            <th>
                                Product
                            </th>
                            <th>
                                Visit Date
                            </th>
                            <th>
                                Visit IP
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                          <a href='<%# GetProductEditUrlAddress(Eval("ProductId")) %>'>  <%#Eval("Product.Title") %> </a>
                        </td>
                        <td>
                            <%#((DateTime)Eval("ViewedTime")).ToShortDateString() %>
                        </td>
                        <td>
                            <%#Eval("IpAdrees") %>
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody> </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    <div class="block-content dark-bg">
        <p>
            Click any products above to view details.</p>
    </div>
    </div>
</div>
<table id="table-example" class="table">
