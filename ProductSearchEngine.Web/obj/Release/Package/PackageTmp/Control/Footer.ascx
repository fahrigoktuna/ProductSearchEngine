<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Footer.ascx.cs" Inherits="ProductSearchEngine.Web.Control.Footer" %>
<!-- ********************** -->
<!--      F O O T E R       -->
<!-- ********************** -->
<div id="footer" class="container_12">
    <div id="footer_categories" class="clearfix">
        <asp:Repeater ID="FooterCategoryRepeater" runat="server" OnItemDataBound="FooterCategoryRepeater_DataBound">
            <ItemTemplate>
                <div class="grid_2">
                    <h2>
                        <%#Eval("Name") %></h2>
                    <asp:Repeater ID="FooterCategoryInsideRepeater"  runat="server">
                        <HeaderTemplate>
                            <ul class="s_list_1">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li><asp:LinkButton ID="CategoryLinkButton"   OnClick="CategoryLinkButton_Click" CommandArgument='<%#Eval("Id") %>' runat="server">
                                <%#Eval("Name") %></asp:LinkButton></li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <div class="clear">
        </div>
        <div class="grid_12 border_eee">
        </div>
    </div>
    <div id="payments" class="right clearfix">
        <img src="/Assets/images/payments/discover_straight_32px.png" alt="" />
        <img src="/Assets/images/payments/american_express_straight_32px.png" alt="" />
        <img src="/Assets/images/payments/moneybookers_straight_32px.png" alt="" />
        <img src="/Assets/images/payments/paypal_straight_32px.png" alt="" />
        <img src="/Assets/images/payments/visa_straight_32px.png" alt="" />
        <img src="/Assets/images/payments/american_express_straight_32px.png" alt="" />
    </div>
    <p id="copy">
        &copy; Copyright 2011. Developed by <a class="blue" href="#">Fahri Kaan Göktuna</a>.<br />
    </p>
</div>
<!-- end of FOOTER -->
