Imports System.Data.SqlClient
Public Class SQLDataGrid
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then 'populate the gridview only on the first load of the page
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
            Dim sql As String = "SELECT PNAME FROM PERSONAL"
            Dim connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(sql, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            GridView1.DataSource = table
            GridView1.DataBind()
        End If
    End Sub

End Class