<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ViewCart.aspx.cs" Inherits="ViewCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    &nbsp;<asp:Table ID="tblCart" runat="server">
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">Category</asp:TableCell>
        <asp:TableCell runat="server">Product</asp:TableCell>
        <asp:TableCell runat="server">Price</asp:TableCell>
        <asp:TableCell runat="server">Quantity</asp:TableCell>
        <asp:TableCell runat="server">Total</asp:TableCell>
    </asp:TableRow>
</asp:Table>
Order Total:<asp:Label ID="lblOrderTotal" runat="server" Text="Label"></asp:Label>
<asp:Button ID="btnClearCart" runat="server" OnClick="btnClearCart_Click" Text="Clear Cart" />
</asp:Content>

