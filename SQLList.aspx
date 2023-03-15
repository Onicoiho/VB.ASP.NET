<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SQLList.aspx.vb" Inherits="CollectionofCode.SQLList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:ListView ID="ListView1" runat="server">
    <LayoutTemplate>
        <div>
            <table>
                <thead>
                    <tr>
                        <th>Number</th>
                        <th>Name</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                </tbody>
            </table>
        </div>
    </LayoutTemplate>
    <ItemTemplate>
        <tr>
            <td><%# Eval("PNO")%></td>
            <td><%# Eval("PNAME")%></td>
        </tr>
    </ItemTemplate>
</asp:ListView>
    </div>
    </form>
</body>
</html>
