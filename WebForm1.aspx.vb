Imports System.Data.SqlClient
Imports System.Threading


Public Class WebForm1
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator2 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox3 As System.Web.UI.WebControls.TextBox

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
            a = " select PWD from AdminLogin where UID = @uid "
            com.Parameters.Add("@uid", TextBox1.Text)
            com.CommandText() = a
            dr = com.ExecuteReader()

            If dr.Read And dr.GetString(0) = TextBox2.Text Then
            Response.Redirect("WebForm2.aspx", True)
        Else
            Textbox3.Text = " Invalid Credentials "
        End If
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
        a = " select PWD from CQahili where UID = @uid "
        com.Parameters.Add("@uid", TextBox1.Text)
        com.CommandText() = a
        dr = com.ExecuteReader()

        If dr.Read And dr.GetString(0) = TextBox2.Text Then
            Response.Redirect("WebForm7.aspx?User=" + TextBox1.Text, False)
        Else
            Textbox3.Text = " Invalid Credentials "
        End If
    End Sub
End Class
