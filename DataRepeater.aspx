<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DataRepeater.aspx.vb" Inherits="CollectionofCode.DataRepeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
        <div>
            <h3><%# Eval("PNO")%></h3>
            <p><%# Eval("PNAME")%></p>
        </div>
    </ItemTemplate>
</asp:Repeater>
    </div>
    </form>
</body>
</html>
