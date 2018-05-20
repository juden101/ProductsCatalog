<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CustomerHome.aspx.cs" Inherits="CustomerArea_CustomerHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h2>Customer Home Page</h2>

    <asp:LinkButton ID="lnkProducts" runat="server" OnClick="lnkProducts_Click">View products</asp:LinkButton>
    <asp:LinkButton ID="lnkOrders" runat="server" OnClick="lnkOrders_Click">View Orders</asp:LinkButton>
    <br />
      <asp:Label ID="lblWelcome" runat="server" Text=""></asp:Label>
       <asp:Panel ID="pnlUserDetails" runat="server"></asp:Panel>
   
     <asp:LinkButton ID="lnkLogout" runat="server">Logout</asp:LinkButton>
</asp:Content>

