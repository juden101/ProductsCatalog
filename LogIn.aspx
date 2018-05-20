<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="login">
        <asp:RadioButtonList ID="rdoUser" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem>Customer</asp:ListItem>
            <asp:ListItem>Staff</asp:ListItem>
        </asp:RadioButtonList>
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate"></asp:Login>
</div>
    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
</asp:Content>

