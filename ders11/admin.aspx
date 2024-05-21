<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="ders11.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView runat="server" ID="grdSiparisler" EnableSortingAndPagingCallbacks="false" OnRowDataBound="grdSiparisler_RowDataBound" AutoGenerateColumns="False"  EnableTheming="True" Width="50%" >
                
                <Columns>
                    <asp:BoundField HeaderText="Sipariş ID" DataField="id" />
                    <asp:BoundField HeaderText="Ürün ID" DataField="urun_id" />
                    <asp:BoundField HeaderText="Ürün Adeti" DataField="adet" />

                    <asp:BoundField HeaderText="Sipariş Aşaması" DataField="asama" />
                    
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button runat="server" ID="btnDetay" OnClick="btnDetay_Click" Text="Detaylar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button runat="server" ID="btnIptal" OnClick="btnIptal_Click" Text="İptal Et" BackColor="#ff6600" BorderColor="#ff9933"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
               
            </asp:GridView>
        </div>
    </form>
</body>
</html>
