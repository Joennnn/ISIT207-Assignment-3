<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Task4._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeaderContent">
    <link href="~/css/task4.css" rel="stylesheet" type="text/css" media="screen" runat="server" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://code.jquery.com/ui/1.13.0/jquery-ui.js"></script>
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="welcomebanner">
        <div>
            <img src="images/banner.jpg" alt="Welcome" />
        </div>
    </div>
    <h3>We offer a variety of food for you to choose from!</h3>
    <div id="foodmenu">
        <ul>
            <li><a href="#local">Local</a></li>
            <li><a href="#dessert">Dessert</a></li>
            <li><a href="#snacks">Snacks</a></li>
            <li><a href="#comfort">Comfort Food</a></li>
        </ul>
      <h3>Local</h3>
      <div id="local">
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="FoodList.aspx">
            <img style="width: 100%;" src="images/5.jpg" alt="local delights">
        </asp:HyperLink>
        <p>Take a look at our local delights!</p>
    </div>
      <h3>Dessert</h3>
      <div id="dessert">
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="FoodList.aspx">
            <img style="width: 100%;" src="images/3.jpg" alt="dessert">
        </asp:HyperLink>
        <p>Take a look at our dessert section!</p>
        </div>
      <h3>Snacks</h3>
      <div id="snacks">
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="FoodList.aspx">
            <img style="width: 100%;" src="images/4.jpg" alt="snacks">
        </asp:HyperLink>
        <p>Take a look at our snacks section!</p>
        </div>
      <h3>Comfort Food</h3>
      <div id="comfort">
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="FoodList.aspx">
            <img style="width: 100%;" src="images/2.jpg" alt="comfort food">
        </asp:HyperLink>
        <p>Take a look at the amount of comfort food we offer!</p>
    </div>
    </div>
    <div class="progressbar"></div>
    <script type="text/javascript">
      $(function() {
          $("#foodmenu").tabs();
        });
        $(document).on("scroll", function () {
            var pixels = $(document).scrollTop();
            var pageHeight = $(document).height() - $(window).height();
            var progress = 100 * pixels / pageHeight;
            $("div.progressbar").css("width", progress + "%");
        });
    </script>
</asp:Content>
