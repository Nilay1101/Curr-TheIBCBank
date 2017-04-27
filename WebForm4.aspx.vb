Imports System.Data.SqlClient

Public Class WebForm4
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Button7 As System.Web.UI.WebControls.Button
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Response.Redirect("WebForm2.aspx", True)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As SqlConnection
        Dim com As SqlCommand
        Dim a As String
        Dim dr As SqlDataReader


        con = New SqlConnection
        con.ConnectionString() = "server=vb; database=demo; uid=admin; pwd=admin"
        con.Open()
        com = New SqlCommand
        com.Connection() = con
        a = " update CQahili set Balance = Balance + @amt where ID = @id "
        com.Parameters.Add("@id", TextBox1.Text)
        com.Parameters.Add("@amt", TextBox2.Text)
        com.CommandText() = a
        dr = com.ExecuteReader()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim con As SqlConnection
        Dim com As SqlCommand
        Dim a As String
        Dim dr As SqlDataReader


        con = New SqlConnection
        con.ConnectionString() = "server=vb; database=demo; uid=admin; pwd=admin"
        con.Open()
        com = New SqlCommand
        com.Connection() = con
        a = " update CQahili set Balance = Balance - @amt where ID = @id "
        com.Parameters.Add("@id", TextBox3.Text)
        com.Parameters.Add("@amt", TextBox4.Text)
        com.CommandText() = a
        dr = com.ExecuteReader()
    End Sub
End Class
