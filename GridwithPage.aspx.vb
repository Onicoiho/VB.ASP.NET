Imports System.Data.SqlClient
Public Class GridwithPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindData()
        End If
    End Sub

    Private Sub BindData()
        Dim connString As String = ConfigurationManager.ConnectionStrings("myConnectionString").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand("SELECT PNAME FROM PERSONAL order by pname", conn)
            conn.Open()
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            GridView1.DataSource = table
            GridView1.DataBind()
        End Using
    End Sub

    Protected Sub GridView1_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        GridView1.PageIndex = e.NewPageIndex
        BindData()
    End Sub


End Class