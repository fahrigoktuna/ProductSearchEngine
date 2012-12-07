<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" ValidateRequest="false" AutoEventWireup="true"
    CodeBehind="ProductEdit.aspx.cs" Inherits="ProductSearchEngine.CMS.ProductEdit" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">
    function loadjscssfile(filename, filetype) {
        if (filetype == "js") { //if filename is a external JavaScript file
            var fileref = document.createElement('script')
            fileref.setAttribute("type", "text/javascript")
            fileref.setAttribute("src", filename)
        }
        else if (filetype == "css") { //if filename is an external CSS file
            var fileref = document.createElement("link")
            fileref.setAttribute("rel", "stylesheet")
            fileref.setAttribute("type", "text/css")
            fileref.setAttribute("href", filename)
        }
        if (typeof fileref != "undefined")
            document.getElementsByTagName("head")[0].appendChild(fileref)
    }
    function load() {

        Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
    }
    function EndRequestHandler() {
        // Check to see if there's an error on this request.

       
    } </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <!-- Begin of #main-content -->
    <div id="main-content">
        <div class="container_12">
            <div class="grid_12">
                <h1>
                    Product Edit Page</h1>
                <p>
                    You can update your product informations at below by filling the field sets.</p>
            </div>
            <div class="grid_6" >
                <div class="block-border">
                    <div class="block-header">
                        <h1>
                            <%=ProductTitle %>
                        </h1>
                        <span></span>
                    </div>
                    <div id="validate-form" class="block-content form" >
                    <div class="_25">
                        <p>
                            <label for="ProductTitleTextBox">
                                Product Title</label>
                            <asp:TextBox ID="ProductTitleTextBox" runat="server" CssClass="required"></asp:TextBox>
                        </p>
                    </div>
                    <div class="_25">
                        <p>
                            <label for="ProductPriceTextBox">
                                Product Price</label>
                            <asp:TextBox ID="ProductPriceTextBox"  runat="server" CssClass="required"></asp:TextBox>
                            <cc2:FilteredTextBoxExtender  ID="FilteredTextBoxExtender1" FilterType="Custom, Numbers" ValidChars="," TargetControlID="ProductPriceTextBox" runat="server">
                            </cc2:FilteredTextBoxExtender>
                        </p>
                    </div>
                    <div class="_25">
                        <p>
                            <label for="ProductRedirectUrlTextBox">
                                Product Redirect Url</label>
                            <asp:TextBox ID="ProductRedirectUrlTextBox" runat="server" CssClass="required"></asp:TextBox>
                        </p>
                    </div>
                    <asp:UpdatePanel ID="CategoryUpdatePanel" ChildrenAsTriggers="true" runat="server">
                        <ContentTemplate>
                            <div class="_25">
                                <p>
                                    <label for="CategoryDropDownList">
                                        Product Category</label>
                                    <asp:DropDownList ID="CategoryDropDownList" AutoPostBack="true"  OnSelectedIndexChanged="CategoryDropDownList_SelectedIndexChanged"
                                        runat="server">
                                    </asp:DropDownList>
                                </p>
                            </div>
                            <div class="_25">
                                <p>
                                    <label for="CategoryDropDownList">
                                        Product Sub Category</label>
                                    <asp:DropDownList ID="SubCategoryDropDownList" runat="server">
                                    </asp:DropDownList>
                                </p>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <div class="_25">
                        <p>
                            <label for="BrandDropDownList">
                                Product Brand</label>
                            <asp:DropDownList ID="BrandDropDownList" runat="server">
                            </asp:DropDownList>
                        </p>
                    </div>
                    <div class="_100">
                        <p>
                            <label for="ProductDetailTextBox">
                                Product Detail</label>
                            <asp:TextBox ID="ProductDetailTextBox" runat="server" TextMode="MultiLine" CssClass="required"
                                Rows="5" Columns="40"></asp:TextBox>
                        </p>
                    </div>
                    <div class="_25">
                        <p>
                            <label for="FileUpload1">
                                Product Image Upload a file</label>
               
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                            <asp:Button ID="FileUploadButton" CssClass="button"  OnClick="FileUploadButton_Click"
                                Text="Upload" runat="server" />
                                <asp:Label ID="FileUploadMessageLabel" runat="server"></asp:Label>
                        </p>
                    </div>
                    <div class="_25" style="width: 26%;padding-left:20px">
                        <p>
                         
                            <span class="label">Product Status</span>
                            <asp:RadioButtonList ID="ProductStatusRadioButtonList" RepeatDirection="Horizontal"
                                RepeatColumns="5" RepeatLayout="Flow" runat="server">
                                <asp:ListItem Text="NOT SHOWN" Value="0"></asp:ListItem>
                                <asp:ListItem Text="SHOWN" Value="1"></asp:ListItem>
                            </asp:RadioButtonList>
                        </p>
                    </div>
                      
                    <div class="_25">
                        <p>
                            <span class="label">Product Slider Status</span>
                            <asp:RadioButtonList ID="ProductSliderStatusRadioButtonList" RepeatDirection="Horizontal"
                                runat="server">
                                <asp:ListItem Text="NO" Value="0"></asp:ListItem>
                                <asp:ListItem Text="YES" Value="1"></asp:ListItem>
                            </asp:RadioButtonList>
                        </p>
                    </div>
                    <div class="_25">
                        <p>
                            <span class="label">Product Special Status</span>
                            <asp:RadioButtonList ID="ProductSpecialStatusRadioButtonList" RepeatDirection="Horizontal"
                                runat="server">
                                <asp:ListItem Text="NO" Value="0"></asp:ListItem>
                                <asp:ListItem Text="YES" Value="1"></asp:ListItem>
                            </asp:RadioButtonList>
                        </p>
                    </div>
                    <div class="_25">
                        <p>
                            <span class="label">Product New Item Status</span>
                            <asp:RadioButtonList ID="ProductNewItemStatusRadioButtonList" RepeatDirection="Horizontal"
                                runat="server">
                                <asp:ListItem Text="NO" Value="0"></asp:ListItem>
                                <asp:ListItem Text="YES" Value="1"></asp:ListItem>
                            </asp:RadioButtonList>
                        </p>
                    </div>
                    <div class="_25">
                        <p>
                            <span class="label">Product Free Shipping Status</span>
                            <asp:RadioButtonList ID="ProductFreeShippingStatusRadioButtonList" RepeatDirection="Horizontal"
                                runat="server">
                                <asp:ListItem Text="NO" Value="0"></asp:ListItem>
                                <asp:ListItem Text="YES" Value="1"></asp:ListItem>
                            </asp:RadioButtonList>
                        </p>
                    </div>
                    <div class="clear">
                    </div>
                    <div class="block-actions">
                        <ul class="actions-left">
                            <li><a class="button red" id="reset-validate-form" href="javascript:void(0);">Reset</a></li>
                        </ul>
                        <ul class="actions-right">
                            <li>
                                <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" CssClass="button"
                                    Text="Save Changes" />
                            </li>
                        </ul>
                    </div>
                    </div>
                </div>
            </div>

              <div class="grid_6"  >
                <div class="block-border">
                    <div class="block-header">
                        <h1>
                            <%=ProductTitle %> Specifications
                        </h1>
                        <span></span>
                    </div>
                    <div id="Div1" class="block-content form" >
                        <asp:Repeater ID="ProductSpecificationsRepeater" runat="server">
                            <HeaderTemplate>
                                <table  class="table">
                                    <thead>
                                        <tr>
                                            <th>
                                                Specification
                                            </th>
                       
                                            <th>
                                                Value
                                            </th>
                                            <th>
                                                Remove
                                            </th>
                                            
                                        </tr>
                                    </thead>
                                    <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                     <%#Eval("SpecificationName") %>
                                    </td>
                                   
                                    <td>
                                         <%#Eval("SpecificationValue") %>
                                    </td>
                                   <td>
                                   <asp:LinkButton ID="SpecificationRemoveLinkButton" runat="server" Text="Remove" CommandArgument='<%#Eval("ProductId").ToString()+","+Eval("SpecificationName").ToString()%>' OnClick="SpecificationRemoveLinkButton_Click"></asp:LinkButton>
                                   </td>
                                </tr>
                            </ItemTemplate>
                       
                            <FooterTemplate>
                                </tbody> </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>

                <div class="grid_6">
                <div class="block-border">
                    <div class="block-header">
                        <h1>
                            Add New Specification
                        </h1>
                        <span></span>
                    </div>
                    <div id="Div2" class="block-content form">
                        <table  class="table">
                            <thead>
                                <tr>
                                    <th>
                                        Specification
                                    </th>
                                    <th>
                                        Value
                                    </th>
                                    <th>
                                        Add
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="SpecificationNameTextBox" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="SpecificationValueTextBox" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:LinkButton ID="SpecificationAddLinkButton" runat="server" Text="Add" OnClick="SpecificationAddLinkButton_Click"></asp:LinkButton>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>


            <div class="grid_6"  >
                <div class="block-border">
                    <div class="block-header">
                        <h1>
                            <%=ProductTitle %> Keywords
                        </h1>
                        <span></span>
                    </div>
                    <div id="Div3" class="block-content form" >
                        <asp:Repeater ID="ProductKeywordRepeater" runat="server">
                            <HeaderTemplate>
                                <table  class="table">
                                    <thead>
                                        <tr>
                                            <th>
                                                Keyword
                                            </th>
                       
                                           
                                            <th>
                                                Remove
                                            </th>
                                            
                                        </tr>
                                    </thead>
                                    <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                     <%#Eval("Keyword.Keyword").ToString()%>
                                    </td>
                                   
                                   
                                   <td>
                                   <asp:LinkButton ID="KeywordRemoveLinkButton" runat="server" Text="Remove" CommandArgument='<%#Eval("ProductId").ToString()+","+Eval("KeywordId").ToString()%>' OnClick="KeywordRemoveLinkButton_Click"></asp:LinkButton>
                                   </td>
                                </tr>
                            </ItemTemplate>
                       
                            <FooterTemplate>
                                </tbody> </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>


            <div class="clear">
            </div>
             <div class="grid_6" >
                <div class="block-border">
                    <div class="block-header">
                        <h1>
                            <%=ProductTitle %> Photos
                        </h1>
                        <span></span>
                    </div>
                    <div id="form" class="block-content form" >
                        <asp:Repeater ID="ProductPhotosRepeater" runat="server">
                            <HeaderTemplate>
                                <table  class="table">
                                    <thead>
                                        <tr>
                                            <th>
                                                Photo
                                            </th>
                       
                                            <th>
                                                Remove
                                            </th>
                                           
                                            
                                        </tr>
                                    </thead>
                                    <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                     <asp:Image ID="ProductPhotoImage" Width="80" Height="80" ImageUrl='<%#ConfigurationManager.AppSettings["ImagePath"] +"/" + Eval("UniqueName").ToString()%>' runat="server" />
                                    </td>
                                   
                                    <td>
                                       <asp:LinkButton ID="PhotoRemoveLinkButton" CommandArgument='<%#Eval("Id").ToString() %>' OnClick="PhotoRemoveLinkButton_Click" runat="server" Text="Remove"></asp:LinkButton>
                                    </td>
                                   
                                </tr>
                            </ItemTemplate>
                       
                            <FooterTemplate>
                                </tbody> </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>

            
             <div class="grid_6">
                <div class="block-border">
                    <div class="block-header">
                        <h1>
                            Add New Keyword
                        </h1>
                        <span></span>
                    </div>
                    <div id="Div4" class="block-content form">
                        <table id="table1" class="table">
                            <thead>
                                <tr>
                                    <th>
                                        Keyword
                                    </th>
                                   
                                    <th>
                                        Add
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="ProductKeywordTextBox" runat="server"></asp:TextBox>
                                    </td>
                                    
                                    <td>
                                        <asp:LinkButton ID="ProductKeywordAddLinkButton" runat="server" Text="Add" OnClick="ProductKeywordAddLinkButton_Click"></asp:LinkButton>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            
            <div class="clear height-fix">
            </div>
        </div>
    </div>
</asp:Content>
