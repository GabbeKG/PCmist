<%@ Page Language="C#" MasterPageFile="~/PCmist.master" AutoEventWireup="true" CodeFile="AboutUs.aspx.cs" Inherits="AboutUs" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentstart" runat="Server">
    <div id="middle">
<br />
    <asp:DropDownList ID="ddlLanguage" runat="server" 
        onselectedindexchanged="ddlLanguage_SelectedIndexChanged" AutoPostBack="true"> 
                <asp:ListItem Value="Choose">Choose Language...</asp:ListItem>
        <asp:ListItem Value="English">English</asp:ListItem>
        <asp:ListItem Value="Chinese">汉语 Chinese</asp:ListItem>
    </asp:DropDownList>Choose your prefered Language

    <br />
    
    
    <asp:Label ID="lAboutUs" runat="server" Text="lAboutUs"></asp:Label>
    </div>
        <div id="footer"><center><h6>&copy; Gabriel González, Fangkai Li, Bing Dai & Marcus Gustafsson</center></h6></div>


</asp:Content>

