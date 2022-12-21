<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FoodDetails.aspx.cs" Inherits="Task4.FoodDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <asp:FormView ID="foodDetail" runat="server" ItemType="Task4.Models.food" SelectMethod="GetFoods" RenderOuterTable="False" OnPageIndexChanging="foodDetail_PageIndexChanging">
        <ItemTemplate>
            <div>
                <h1><%#:Item.FoodName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="<%#:Item.ImagePath %>" runat="server" style="border:solid; height:300px" alt="<%#:Item.FoodName%>"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Description:</b><br /><%#:Item.Description %><br /><span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span><br /><span><b>Food ID:</b>&nbsp;<%#:Item.FoodID %></span><br /><a href="/AddToCart.aspx?FoodID=<%#:Item.FoodID %>" runat="server"></a></td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" Text="Add to cart" href="/AddToCart.aspx?FoodID=<%#:Item.FoodID %>" />
</asp:Content>
