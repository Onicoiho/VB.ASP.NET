Imports System.Data.SqlClient
Public Class SQLList
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then 'populate the listview only on the first load of the page
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
            Dim sql As String = "SELECT PNO,PNAME FROM PERSONAL ORDER BY PNAME"
            Dim connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(sql, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataSet As New DataSet()
            adapter.Fill(dataSet, "MyTable")
            ListView1.DataSource = dataSet.Tables("MyTable")
            ListView1.DataBind()
        End If
    End Sub

End Class