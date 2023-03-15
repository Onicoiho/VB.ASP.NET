Public Class DropDownChange
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then 'populate the dropdown only on the first load of the page
            DropDownList1.Items.Add(New ListItem("", ""))
            DropDownList1.Items.Add(New ListItem("Option 1", "Option 1"))
            DropDownList1.Items.Add(New ListItem("Option 2", "Option 2"))
            DropDownList1.AppendDataBoundItems = True
        End If
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)

        DropDownList2.Items.Clear() 'Clear items in DropDownList2
        If DropDownList1.SelectedValue = "Option 1" Then
            'Set the value of the second dropdown based on Option 1 selection
            DropDownList2.Items.Add(New ListItem("Option A", "Option A"))
            DropDownList2.SelectedValue = "Option A"
        ElseIf DropDownList1.SelectedValue = "Option 2" Then
            'Set the value of the second dropdown based on Option 2 selection
            DropDownList2.Items.Add(New ListItem("Option B", "Option B"))
            DropDownList2.SelectedValue = "Option B"
        End If
    End Sub

End Class