<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ders11.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Label ID="Label1" runat="server" Text="Ürün:"></asp:Label>

        	<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>

        	<asp:Label ID="Label2" runat="server" Text="Adet:"></asp:Label>
        	<asp:TextBox ID="TextBox1" runat="server" Width="37px"></asp:TextBox>
        	<asp:Button ID="Button1" runat="server" Text="Satın al" OnClick="Button1_Click" />
        	<asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
