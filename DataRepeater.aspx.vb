Imports System.Data.SqlClient
Public Class DataRepeater
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then 'populate the repeater only on the first load of the page
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
            Dim sql As String = "SELECT PNO, PNAME FROM PERSONAL"
            Dim connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(sql, connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            Repeater1.DataSource = reader
            Repeater1.DataBind()
            reader.Close()
            connection.Close()
        End If
    End Sub

End Class