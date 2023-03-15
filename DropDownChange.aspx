<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DropDownChange.aspx.vb" Inherits="CollectionofCode.DropDownChange" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
 <br />
        
        <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
    </div>
    </form>
</body>
</html>
