<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="shop.aspx.cs" Inherits="shop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div id="wrapper0">
    <div id="page_content0">
        <div class="right_section">
            <div class="common_content">
                <asp:SqlDataSource ID="dataProductsByCategory" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [Products] WHERE ([Category] = @Category) ORDER BY [Product]">
                    <SelectParameters>
                        <asp:QueryStringParameter DefaultValue="Stuff" Name="Category" QueryStringField="Category" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:GridView ID="gvProductsByCategory" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="dataProductsByCategory" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" PageSize="8">
                    <Columns>
                        <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
                        <asp:BoundField DataField="Product" HeaderText="Product" SortExpression="Product" />
                        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                        <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                        <asp:ImageField DataImageUrlField="Image">
                            <ControlStyle Height="50px" Width="50px" />
                        </asp:ImageField>
                        <asp:HyperLinkField DataNavigateUrlFields="Id" Text="View" DataNavigateUrlFormatString="ShowDetails.aspx?ID={0}" AccessibleHeaderText="Image" />
                    </Columns>
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </div>
        </div>
    </div>
        
    </form>
</body>
</html>
    </div>
</asp:Content>

