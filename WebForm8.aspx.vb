Imports System.Data.SqlClient
Imports System.Int32


Public Class WebForm8
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Button7 As System.Web.UI.WebControls.Button
    Protected WithEvents Textbox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox6 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Textbox7 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox8 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox9 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Textbox10 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Textbox11 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox12 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button

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
        Dim bal As Int32



        con = New SqlConnection
        con.ConnectionString() = "server=vb; database=demo; uid=admin; pwd=admin"
        con.Open()
        com = New SqlCommand
        com.Connection() = con
        a = " select UID, Acc, Branch, FName, LName, Email, Phone,CCard, DCard,CBook,Balance from CQahili where ID = @id "
        com.Parameters.Add("@id", TextBox1.Text)
        com.CommandText() = a
        dr = com.ExecuteReader()

        If dr.Read Then
            TextBox2.Text = dr.GetString(0)
            TextBox5.Text = dr.GetString(1)
            Textbox3.Text = dr.GetString(2)
            Textbox4.Text = dr.GetString(3)
            Textbox6.Text = dr.GetString(4)
            Textbox7.Text = dr.GetString(5)
            Textbox8.Text = dr.GetString(6)
            Textbox11.Text = dr.GetString(7)
            Textbox10.Text = dr.GetString(8)
            Textbox9.Text = dr.GetString(9)
            bal = dr.GetInt32(10)
            Textbox12.Text = bal.ToString


        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Response.Redirect("CrystalReport1.rpt", True)
    End Sub
End Class
