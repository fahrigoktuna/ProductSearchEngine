<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ProductSearchEngine.Web.Default" %>


    <%@ Register Src="~/Control/SpecialProducts.ascx"  TagName="SpecialProducts" TagPrefix="uc" %>
      <%@ Register Src="~/Control/LatestProducts.ascx"  TagName="LatestProducts" TagPrefix="uc" %>
           <%@ Register Src="~/Control/SliderProducts.ascx"  TagName="SliderProducts" TagPrefix="uc" %>
     
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <uc:SliderProducts ID="SliderProductsUserControl" runat="server" />
 
 
    <!-- ********************** -->
    <!--      C O N T E N T     -->
    <!-- ********************** -->
    <div id="content" class="container_12">
        <div id="welcome" class="grid_12">
            <h2>
                Welcome to Product Search Engine Web Application</h2>
            <p>
                Product Search Engine is a product search wizard on web as it name says. The project
                idea given by <b>Selçuk BAKTIR</b> and project developed by <b>Fahri Kaan Göktuna</b>.</p>
            <p>
                Project Detail:
            </p>
            <ul>
                <li>Development Environment: Visual Studio 2010 with .NET</li>
                <li>Used Technology: ASP.NET 4.0</li>
                <li>Running On: IIS 7.5</li>
                <li>Used Orm tool: LLBLGEN Pro v3.1</li>
                <li>Used Query Language: LLBLGEN Pro Run Time Framework</li>
                <li>Also wiil be developed on Android Devices.</li>
            </ul>
        </div>
        <div class="clear">
        </div>
       

       <uc:SpecialProducts ID="SpecialProductsUserControl" runat="server" />

        <uc:LatestProducts ID="LatestProductsUserControl" runat="server" />


     
    </div>
    <!-- end of content -->

    <!-- ********************** -->
        <!--   S H O P   I N F O    -->
        <!-- ********************** -->
        <div id="shop_info">
            <div id="shop_info_wrap">
                <div class="container_12">
                    <div id="shop_description" class="grid_3">
                        <h2>
                            Product Search Engine Project</h2>
                        <p>
                            This web application deveoped by Fahri Kaan Göktuna using Asp.Net 4.0 technology
                            with C# language.Also this project, will be developed as a Android application on
                            mobile systems with Java. This is a Bahçeşehir University Capstone Project 2011
                            for 1nd semester with the help of Selçuk BAKTIR that is instructor of Computer Engineering
                            department.</p>
                    </div>
                    <div id="shop_contacts" class="grid_3">
                        <h2>
                            Contact Us</h2>
                        <table width="100%" cellpadding="0" cellspacing="0" border="0">
                            <tr>
                                <td valign="middle">
                                    <span class="s_icon_32"><span class="s_icon s_phone_32"></span>5355225506
                                        <br />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td valign="middle">
                                    <span class="s_icon_32"><span class="s_icon s_fax_32"></span>5355225506
                                        <br />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td valign="middle">
                                    <span class="s_icon_32"><span class="s_icon s_mail_32"></span><a href="mailto:fahrigoktuna@gmail.com">fahrigoktuna@gmail.com</a>
                                        <br />
                                        <a href="mailto:fahrikaan.goktuna@stu.bahcesehir.edu.tr">fahrikaan.goktuna@stu.bahcesehir.edu.tr</a></span>
                                </td>
                            </tr>
                        </table>
                    </div>
                    
                    <div class="clear">
                    </div>
                </div>
            </div>
        </div>
        <!-- end of shop info -->

        
</asp:Content>
