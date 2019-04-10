<%@ Page Title="" Language="C#" MasterPageFile="~/PCmist.master" AutoEventWireup="true" CodeFile="Game.aspx.cs" Inherits="Game" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentstart" Runat="Server">
<div id="DetailView">
    <asp:DetailsView ID="DetailsView1" runat="server" Height="220px" Width="595px"
        AllowPaging="True" AutoGenerateRows="False" DataKeyNames="GameID" 
        DataSourceID="SqlDataSource1">
        <Fields>
            <asp:BoundField DataField="GameID" HeaderText="GameID" InsertVisible="False" 
                ReadOnly="True" SortExpression="GameID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Company" HeaderText="Company" 
                SortExpression="Company" />
            <asp:BoundField DataField="Year Release" HeaderText="Year Release" 
                SortExpression="Year Relese" />
        </Fields>
</asp:DetailsView></div>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
    SelectCommand="SELECT * FROM [Games] ORDER BY [GameID], [Name], [Company]">
</asp:SqlDataSource>
    <div id="footer"><center><h6>&copy; Gabriel González, Fangkai Li, Bing Dai & Marcus Gustafsson</center></h6></div>

</asp:Content>

