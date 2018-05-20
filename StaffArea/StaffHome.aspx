<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="StaffHome.aspx.cs" Inherits="StaffArea_StaffHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h2> Staff Home Page</h2>
    <p> 
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"> Products</asp:LinkButton>
        <asp:LinkButton ID="LinkButton2" runat="server">Customers</asp:LinkButton>
        <asp:LinkButton ID="LinkButton3" runat="server">Orders</asp:LinkButton>
    </p>
    <p> &nbsp;</p>

</asp:Content>

