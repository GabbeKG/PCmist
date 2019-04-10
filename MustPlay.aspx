<%@ Page Title="" Language="C#" MasterPageFile="~/PCmist.master" AutoEventWireup="true" CodeFile="MustPlay.aspx.cs" Inherits="MustPlay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentStart" Runat="Server">

<div id="middle">
<br />
    <asp:DropDownList ID="ddlLanguage" runat="server" 
        onselectedindexchanged="ddlLanguage_SelectedIndexChanged" AutoPostBack="true"> 
                <asp:ListItem Value="Choose">Choose Language...</asp:ListItem>
        <asp:ListItem Value="English">English</asp:ListItem>
        <asp:ListItem Value="Chinese">汉语 Chinese</asp:ListItem>
    </asp:DropDownList>Choose your prefered Language

    <br />
    
    
    <asp:Label ID="lContent" runat="server" Text="lContent"></asp:Label>
    </div>
        <div id="footer"><center><h6>&copy; Gabriel González, Fangkai Li, Bing Dai & Marcus Gustafsson</center></h6></div>
 

</asp:Content>

