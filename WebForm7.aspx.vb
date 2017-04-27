Imports System.Data.SqlClient
Imports System.Threading
Imports System.Int32




Public Class WebForm7
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Button7 As System.Web.UI.WebControls.Button
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Textbox5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox7 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox6 As System.Web.UI.WebControls.TextBox

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


        Dim con As SqlConnection
        Dim com As SqlCommand
        Dim com2 As SqlCommand
        Dim com3 As SqlCommand
        Dim a As String
        Dim b As String
        Dim c As String
        Dim dr As SqlDataReader
        Dim dr2 As SqlDataReader
        Dim dr3 As SqlDataReader
        Dim bal As Int32

        con = New SqlConnection
        con.ConnectionString() = "server=vb; database=demo; uid=admin; pwd=admin"
        con.Open()
        com = New SqlCommand
        com2 = New SqlCommand
        com3 = New SqlCommand
        com.Connection() = con
        com2.Connection() = con
        com3.Connection() = con
        a = " select FName from CQahili where UID = @id "
        com.Parameters.Add("@id", Request.QueryString("User"))
        com.CommandText() = a
        dr = com.ExecuteReader()

        If dr.Read Then
            TextBox1.Text() = dr.GetString(0)
        End If
        dr.Close()


        b = " select Acc from CQahili where UID = @id "
        com2.Parameters.Add("@id", Request.QueryString("User"))
        com2.CommandText() = b
        dr2 = com2.ExecuteReader()

        If dr2.Read Then
            Textbox3.Text() = dr2.GetString(0)
        End If
        dr2.Close()


        c = " select Balance from CQahili where UID = @id "
        com3.Parameters.Add("@id", Request.QueryString("User"))
        com3.CommandText() = c
        dr3 = com3.ExecuteReader()

        If dr3.Read Then
            bal = dr3.GetInt32(0)
            TextBox2.Text() = bal.ToString
        End If
        dr3.Close()




    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Response.Redirect("WebForm1.aspx", True)
    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim con As SqlConnection
        Dim com As SqlCommand
        Dim com2 As SqlCommand
        Dim a As String
        Dim b As String
        Dim dr As SqlDataReader
        Dim dr2 As SqlDataReader


        con = New SqlConnection
        con.ConnectionString() = "server=vb; database=demo; uid=admin; pwd=admin"
        con.Open()
        com = New SqlCommand
        com2 = New SqlCommand

        com.Connection() = con
        com2.Connection() = con

        a = " update CQahili set Balance = Balance + @amt where Acc = @acc and ID = @id and Branch = @br"
        com.Parameters.Add("@amt", Textbox7.Text)
        com.Parameters.Add("@id", Textbox4.Text)
        com.Parameters.Add("@acc", Textbox5.Text)
        com.Parameters.Add("@br", Textbox6.Text)
        com.CommandText() = a
        dr = com.ExecuteReader()
        dr.Close()


        b = " update CQahili set Balance = Balance - @amt where UID = @uid"
        com2.Parameters.Add("@amt", Textbox7.Text)
        com2.Parameters.Add("@uid", Request.QueryString("User"))
        com2.CommandText = b
        dr2 = com2.ExecuteReader()
        dr2.Close()


    End Sub
End Class
