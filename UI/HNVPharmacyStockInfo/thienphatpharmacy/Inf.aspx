<%@ Page Title="HNV" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inf.aspx.cs" Inherits="HNVPharmacyStockInfo._Inf" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <p>Tên thuốc&nbsp;
        <asp:TextBox ID="txtProductName" runat="server" Width="60px" OnTextChanged="txtProductName_TextChanged" AutoPostBack="true" AutoCompleteType="Enabled" Wrap="False"></asp:TextBox>
        <asp:DropDownList ID="cmbProduct" runat="server" DataTextField="ProductName" DataValueField="id" AutoPostBack="True" Width="120px" OnSelectedIndexChanged="cmbProduct_SelectedIndexChanged" >
        </asp:DropDownList>
               
        <asp:Button ID="butSearchByName" runat="server" OnClick="butSearchByName_Click" Text="OK" Width="40px" />
        </p>
    </div>

    <div>
        <p>Nhà phân phối&nbsp;
        <asp:TextBox ID="txtProvider" runat="server" Width="60px" OnTextChanged="txtProvider_TextChanged" AutoPostBack="true" AutoCompleteType="Enabled" Wrap="False"></asp:TextBox>
        <asp:DropDownList ID="cmbProvider" runat="server" DataTextField="Name" DataValueField="id" AutoPostBack="True"  Width="120px" OnSelectedIndexChanged="cmbProvider_SelectedIndexChanged" >
        </asp:DropDownList>
                
        <asp:Button ID="butSearchByProvider" runat="server" Text="OK" Width="40px" OnClick="butSearchByProvider_Click" />
        </p>  
    </div>
    <div>
        <p>Mã vạch&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="txtBarCode" runat="server" Width="100px"></asp:TextBox>
        <asp:Button ID="butSearchByBarCode" runat="server" OnClick="butSearchByBarCode_Click" Text="OK" Width="40px" />
        </p>
    </div>



    <asp:SqlDataSource ID="SqlDataSource10" runat="server" ConnectionString="<%$ ConnectionStrings:pharmacyConnectionString %>" SelectCommand="SELECT id, ProductName FROM ProductName WHERE (ProductName LIKE @name + N'%') ORDER BY ProductName">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtProductName" Name="name" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource11" runat="server" ConnectionString="<%$ ConnectionStrings:pharmacyConnectionString %>" SelectCommand="SELECT id, Name FROM Supplier WHERE (Name LIKE @name + N'%')">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtProvider" Name="name" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>


    <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:pharmacyConnectionString %>" SelectCommand="SELECT SupplierName, SellingRatio, SellingUnit, SellingPrice, SellingStock, SellingQ, UnitPriceComapreToSelling, idInput, idProduct, RQ, DateExpiration, idSupplier, stock, AmountFinal, AmountRefund, idInvoice, AmoutWithVAT, ImpUnit, DateImp, UnitPrice, Q, InvoiceNum, Location, ProductName, BarCode, BarCode_Origin, ContentQuantity, NumReg, idLocation, Comment, SellingRQAll, RQAll, stockLabel FROM AllStocks_AB_OneSellingPrice WHERE (ProductName LIKE @name + N'%') ORDER BY ProductName, DateImp DESC">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtProductName" Name="name" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:pharmacyConnectionString %>" SelectCommand="SELECT * FROM [AllStocks_AB_OneSellingPrice] WHERE (SupplierName LIKE @name + N'%') ORDER BY ProductName, DateImp DESC">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtProvider" Name="name" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>

    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:pharmacyConnectionString %>" SelectCommand="SELECT * FROM [AllStocks_AB_OneSellingPrice] WHERE ([idSupplier] = @idSupplier) ORDER BY ProductName, DateImp DESC">
        <SelectParameters>
            <asp:ControlParameter ControlID="cmbProvider" Name="idSupplier" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:pharmacyConnectionString %>" SelectCommand="SELECT * FROM [AllStocks_AB_OneSellingPrice] WHERE ([idProduct] = @idProduct) ORDER BY ProductName, DateImp DESC">
        <SelectParameters>
            <asp:ControlParameter ControlID="cmbProduct" Name="idProduct" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:pharmacyConnectionString %>" SelectCommand="SELECT SupplierName, SellingRatio, SellingUnit, SellingPrice, SellingStock, SellingQ, UnitPriceComapreToSelling, idInput, idProduct, RQ, DateExpiration, idSupplier, stock, AmountFinal, AmountRefund, idInvoice, AmoutWithVAT, ImpUnit, DateImp, UnitPrice, Q, InvoiceNum, Location, ProductName, BarCode, BarCode_Origin, ContentQuantity, NumReg, idLocation, Comment, SellingRQAll, RQAll, stockLabel FROM AllStocks_AB_OneSellingPrice WHERE (BarCode LIKE @BarCode + '%') or (BarCode_Origin LIKE @BarCode + '%') ORDER BY ProductName, DateImp DESC">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtBarCode" Name="BarCode" PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>

   

    <div class="lead" style='width:100%; overflow:auto;'>
        <asp:GridView ID="view_StockInfo" runat="server" AutoGenerateColumns="False" CellPadding="3" DataKeyNames="idInput" ForeColor="black" GridLines="Vertical" Width="1000px" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
            <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    
                    <asp:BoundField DataField="ProductName" HeaderText="Tên thuốc" SortExpression="ProductName" >
                        <HeaderStyle HorizontalAlign="Left" Width="100px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="ContentQuantity" HeaderText="Hoạt chất" SortExpression="ContentQuantity" >                    
                        <HeaderStyle HorizontalAlign="Left" Width="80px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="ImpUnit" HeaderText="ĐV nhập" SortExpression="ImpUnit" >
                        <HeaderStyle HorizontalAlign="Left" Width="60px" />
                        <ItemStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                   <asp:BoundField DataField="SellingUnit" HeaderText="ĐV bán" SortExpression="SellingUnit" >
                        <HeaderStyle HorizontalAlign="Left" Width="50px" />
                        <ItemStyle HorizontalAlign="Left" />
                    </asp:BoundField>

                    <asp:BoundField DataField="RQ" HeaderText="Tồn theo ĐV nhập" HeaderStyle-CssClass="GridHeader">
                        <HeaderStyle HorizontalAlign="Right" Width="40px" />
                        <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="SellingRQAll" HeaderText="Tồn theo ĐV bán" HeaderStyle-CssClass="GridHeader" >
                        <HeaderStyle HorizontalAlign="Right" Width="40px" />
                        <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="RQAll" HeaderText="Tổng tồn kho" HeaderStyle-CssClass="GridHeader" >
                        <HeaderStyle HorizontalAlign="Right" Width="40px" />
                        <ItemStyle HorizontalAlign="Right"  />
                    </asp:BoundField>
                    
                    
                    <asp:BoundField DataField="Q" HeaderText="SL nhập" HeaderStyle-CssClass="GridHeader" >
                        <HeaderStyle HorizontalAlign="Right" Width="40px" />
                        <ItemStyle HorizontalAlign="Right"/>
                    </asp:BoundField>
                    <asp:BoundField DataField="UnitPrice" HeaderText="ĐG nhập" HeaderStyle-CssClass="GridHeader"  DataFormatString="{0:# ###.0}">
                        <HeaderStyle HorizontalAlign="Right" Width="80px" />
                        <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="AmountRefund" HeaderText="KMãi" HeaderStyle-CssClass="GridHeader" DataFormatString="{0:# ###.0}" >
                        <HeaderStyle HorizontalAlign="Right" Width="70px" />
                        <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    
                    <asp:BoundField DataField="SellingPrice" HeaderText="Giá bán" HeaderStyle-CssClass="GridHeader" DataFormatString="{0:# ###}">                       
                        <HeaderStyle HorizontalAlign="Right" Width="60px" />
                        <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>                   
                   
                    <asp:BoundField DataField="DateImp" HeaderText="Ngày nhập" SortExpression="DateImp" DataFormatString="{0:dd/MM/yyyy}" >
                        <HeaderStyle HorizontalAlign="Left" Width="80px" />
                        <ItemStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="DateExpiration" HeaderText="Ngày hết hạn" SortExpression="DateExpiration" DataFormatString="{0:dd/MM/yyyy}" >
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                                       
                    <asp:BoundField DataField="Location" HeaderText="Nơi SX" SortExpression="Location" />                   
                    <asp:BoundField DataField="stockLabel" HeaderText="Kho" SortExpression="stockLabel" />
                    <asp:BoundField DataField="SupplierName" HeaderText="Nhà cung ứng" SortExpression="SupplierName" />
                    <asp:BoundField DataField="Comment" HeaderText="Ghi chú" SortExpression="Comment" />
                   
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="#105632" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            
        </div>

     <!--
                    <asp:BoundField DataField="SellingQ" HeaderText="SL bán" ReadOnly="True" SortExpression="SellingQ" >
                        <ControlStyle Width="50px" />
                        <HeaderStyle HorizontalAlign="Right" Width="30px" />
                        <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>

                    <asp:BoundField DataField="AmoutWithVAT" HeaderText="Tổng tiền có thuế" SortExpression="AmoutWithVAT" >
                        <HeaderStyle HorizontalAlign="Right" Width="50px" />
                        <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="AmountFinal" HeaderText="Tổng cuối" SortExpression="AmountFinal" >
                        <HeaderStyle HorizontalAlign="Right" Width="50px" />
                        <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>

                    <asp:BoundField DataField="SellingStock" HeaderText="SellingStock" ReadOnly="True" SortExpression="SellingStock" Visible="False" />
                    <asp:BoundField DataField="UnitPriceComapreToSelling" HeaderText="UnitPriceComapreToSelling" ReadOnly="True" SortExpression="UnitPriceComapreToSelling" Visible="False" />
                   
                    <asp:BoundField DataField="idLocation" HeaderText="idLocation" SortExpression="idLocation" Visible="False" />                    
                    <asp:BoundField DataField="BarCode" HeaderText="MV Nhà thuốc" SortExpression="BarCode" Visible="False" />
                    <asp:BoundField DataField="BarCode_Origin" HeaderText="MV SX" SortExpression="BarCode_Origin" Visible="False" />
                    <asp:BoundField DataField="NumReg" HeaderText="Số ĐK" SortExpression="NumReg" Visible="False" >
                        <HeaderStyle HorizontalAlign="Left" Width="100px" />
                        <ItemStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                     <asp:BoundField DataField="idProduct" HeaderText="idProduct" SortExpression="idProduct" Visible="False" />
                    <asp:BoundField DataField="SellingRatio" HeaderText="SellingRatio" SortExpression="SellingRatio" Visible="False" />
                    <asp:BoundField DataField="idInput" HeaderText="idInput" ReadOnly="True" SortExpression="idInput" Visible="False" />
                    <asp:BoundField DataField="idSupplier" HeaderText="idSupplier" SortExpression="idSupplier" Visible="False" />
                    <asp:BoundField DataField="stock" HeaderText="stock" SortExpression="stock" Visible="False" />                   
                    <asp:BoundField DataField="idInvoice" HeaderText="idInvoice" SortExpression="idInvoice" Visible="False" />
                    <asp:BoundField DataField="InvoiceNum" HeaderText="Số HĐơn" SortExpression="InvoiceNum" Visible="False" >
                        <HeaderStyle HorizontalAlign="Left" Width="100px" />
                        <ItemStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    -->
</asp:Content>
