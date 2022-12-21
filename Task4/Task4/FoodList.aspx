<%@ Page Title="FoodList" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FoodList.aspx.cs" Inherits="Task4.FoodList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://code.jquery.com/ui/1.13.0/jquery-ui.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>
            <div>
                <p>
                   <label for="amount">Price range:</label>
                   <input type="text" id="amount" readonly style="border:0; font-weight:bold;">
                </p>
                <div class="slider-range"></div>
            </div>
            <asp:ListView ID="foodList" runat="server" 
                DataKeyNames="FoodID" GroupItemCount="4"
                ItemType="Task4.Models.food" SelectMethod="GetFoods">
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td/>
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="FoodDetails.aspx?FoodID=<%#:Item.FoodID%>">
                                        <img src="<%#:Item.ImagePath%>" runat="server"
                                            width="100" height="75" style="border: solid" /></a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="FoodDetails.aspx?FoodID=<%#:Item.FoodID%>">
                                        <span>
                                            <%#:Item.FoodName%>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Price: </b><%#:String.Format("{0:c}", Item.UnitPrice)%>
                                    </span>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
    <script type="text/javascript">
        $(function () {
            $(".slider-range").slider({
                range: true,
                min: 0,
                max: 50,
                values: [0, 10],
                slide: function (event, ui) {
                    $("#amount").val("$" + ui.values[0] + " - $" + ui.values[1]);
                }
            });
            $("#amount").val("$" + $(".slider-range").slider("values", 0) + " - $" + $(".slider-range").slider("values", 1));
        });
    </script>
</asp:Content>
    