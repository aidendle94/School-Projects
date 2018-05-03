<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ShowDetails.aspx.cs" Inherits="ShowDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:SqlDataSource ID="dataProduct" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [Products] WHERE ([Id] = @Id)">
        <SelectParameters>
            <asp:QueryStringParameter Name="Id" QueryStringField="Id" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
<asp:DetailsView ID="dvProduct" runat="server" AutoGenerateRows="False" DataKeyNames="Id,Category,Product,Price" DataSourceID="dataProduct" Height="50px" Width="125px">
    <Fields>
        <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
        <asp:BoundField DataField="Product" HeaderText="Product" SortExpression="Product" />
        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" DataFormatString="{0:c}" />
        <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
        <asp:ImageField DataImageUrlField="Image">
            <ControlStyle Height="250px" Width="250px" />
        </asp:ImageField>
    </Fields>

</asp:DetailsView>
    <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
    <asp:TextBox ID="txtQuantity" runat="server">0</asp:TextBox>

<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"   ControlToValidate="txtQuantity" ErrorMessage="Enter only Numbers" 
ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>

    <asp:Button ID="btnAddToCart" runat="server" Text="add" OnClick="btnAddToCart_Click" />
    </asp:Content>

