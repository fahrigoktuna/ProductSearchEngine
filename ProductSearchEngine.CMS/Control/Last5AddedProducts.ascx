<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Last5AddedProducts.ascx.cs" Inherits="ProductSearchEngine.CMS.Control.Last5AddedProducts" %>


<div class="grid_6" id="DivGrid" runat="server">
    <div class="block-border">
        <div class="block-header">
            <h1>
                Last 5 Added Products</h1>
            <span></span>
        </div>
        <div id="form" class="block-content form">
            <asp:Repeater ID="Last5AddedProductsRepeater"  runat="server">
                <HeaderTemplate>
                 <table  class="table">
                    <thead>
                        <tr>
                            <th>
                                Product
                            </th>
                            <th>
                                Added Date
                            </th>
                            
                        </tr>
                    </thead>
                    <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                          <a href='<%# GetProductEditUrlAddress(Eval("Id")) %>'>  <%#Eval("Title") %> </a>
                        </td>
                        <td>
                            <%#((DateTime)Eval("AddedDate")).ToShortDateString() %>
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





