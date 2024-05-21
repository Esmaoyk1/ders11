<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="detaylar.aspx.cs" Inherits="ders11.detaylar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            

        	<asp:Label ID="lblID" runat="server" Text="ID:"></asp:Label>
            <hr />
        	<asp:Label ID="lblUrunID" runat="server" Text="Ürün ID:"></asp:Label>
            <hr />
        	<asp:Label ID="lblUrunAdet" runat="server" Text="Ürün Adeti:"></asp:Label>
            <hr />
        	<asp:Label ID="lblTarih" runat="server" Text="Sipariş Tarihi:"></asp:Label>
            <hr />
        	<asp:Label ID="lblKargoTarih" runat="server" Text="Kargoya Verilme Tarihi:"></asp:Label>
            <hr />
        	<asp:Label ID="lblAsama" runat="server" Text="Aşama:"></asp:Label>
            <hr />


        </div>
    </form>
</body>
</html>
