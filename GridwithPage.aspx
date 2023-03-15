<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="GridwithPage.aspx.vb" Inherits="CollectionofCode.GridwithPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        /* Style the table header */

        .gridview{
            width: 100%;
        }
.gridview-header {
    background-color: #ccc;
    font-weight: bold;
}

/* Style the table rows */
.gridview-row {
    background-color: #fff;
}

/* Style the alternating table rows */
.gridview-alternating-row {
    background-color: #eee;
}

/* Style the selected table row */
.gridview-selected-row {
    background-color: #ff0;
}

/* Style the table cell padding and border */
.gridview-cell {
    padding: 5px;
    border: 1px solid #ccc;
}


/* Style the pager container */
.gridview-pager {
    text-align: center;
}

/* Style the pager links */
.gridview-pager a {
    display: inline-block;
    padding: 5px;
    margin: 0 2px;
    background-color: #fff;
    border: 1px solid #ccc;
    color: #333;
    text-decoration: none;
}

/* Style the active pager link */
.gridview-pager .active {
    background-color: #ccc;
}

/* Style the disabled pager link */
.gridview-pager .disabled {
    color: #999;
    cursor: default;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="gridview" AllowPaging="True" PageSize="50">
    <Columns>
        <asp:BoundField DataField="PNAME" HeaderText="Name" ItemStyle-CssClass="gridview-cell" />
    </Columns>
    <HeaderStyle CssClass="gridview-header" />
    <RowStyle CssClass="gridview-row" />
    <AlternatingRowStyle CssClass="gridview-alternating-row" />
    <SelectedRowStyle CssClass="gridview-selected-row" />
    <PagerStyle CssClass="gridview-pager" />
</asp:GridView>
    </div>
    </form>
</body>
</html>
