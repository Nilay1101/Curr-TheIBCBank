Imports System.Data.SqlClient

Public Class WebForm3
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox6 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox7 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox8 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox9 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox10 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox11 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox12 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox13 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox14 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox15 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox16 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox17 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox18 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox19 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox20 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox21 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox22 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox23 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox24 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents RequiredFieldValidator2 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator3 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents Label17 As System.Web.UI.WebControls.Label
    Protected WithEvents Label18 As System.Web.UI.WebControls.Label
    Protected WithEvents Label19 As System.Web.UI.WebControls.Label
    Protected WithEvents Label20 As System.Web.UI.WebControls.Label
    Protected WithEvents Label21 As System.Web.UI.WebControls.Label
    Protected WithEvents Label22 As System.Web.UI.WebControls.Label
    Protected WithEvents Label23 As System.Web.UI.WebControls.Label
    Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator4 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator5 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator6 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator7 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator8 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RegularExpressionValidator1 As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents Label24 As System.Web.UI.WebControls.Label
    Protected WithEvents Label25 As System.Web.UI.WebControls.Label
    Protected WithEvents Label26 As System.Web.UI.WebControls.Label
    Protected WithEvents Label27 As System.Web.UI.WebControls.Label
    Protected WithEvents Label28 As System.Web.UI.WebControls.Label
    Protected WithEvents Label29 As System.Web.UI.WebControls.Label
    Protected WithEvents Label30 As System.Web.UI.WebControls.Label
    Protected WithEvents Label31 As System.Web.UI.WebControls.Label
    Protected WithEvents Label32 As System.Web.UI.WebControls.Label
    Protected WithEvents RequiredFieldValidator9 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator10 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator11 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator12 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator13 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator14 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator15 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator16 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Label33 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox25 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox26 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label35 As System.Web.UI.WebControls.Label
    Protected WithEvents Label36 As System.Web.UI.WebControls.Label
    Protected WithEvents RequiredFieldValidator17 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator18 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Button7 As System.Web.UI.WebControls.Button
    Protected WithEvents Textbox27 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label34 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox28 As System.Web.UI.WebControls.TextBox

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim con As SqlConnection
        Dim com As SqlCommand
        Dim a As String
        con = New SqlConnection
        con.ConnectionString() = "server=vb; database=demo; uid=admin; pwd=admin"
        con.Open()
        com = New SqlCommand
        com.Connection() = con
        a = " insert into CQahili values (@A,@B,@C,@D,@E,@F,@G,@H,@I,@J,@K,@L,@M,@N,@O,@P,@Q,@R,@S,@T,@U,@V,@W,@X,@Y,@Z,@A1)"
        com.Parameters.Add("@A", TextBox1.Text)
        com.Parameters.Add("@B", TextBox9.Text)
        com.Parameters.Add("@C", TextBox3.Text)
        com.Parameters.Add("@D", TextBox8.Text)
        com.Parameters.Add("@E", TextBox4.Text)
        com.Parameters.Add("@F", TextBox7.Text)
        com.Parameters.Add("@G", TextBox5.Text)
        com.Parameters.Add("@H", TextBox6.Text)
        com.Parameters.Add("@I", TextBox2.Text)
        com.Parameters.Add("@J", TextBox11.Text)
        com.Parameters.Add("@K", TextBox10.Text)
        com.Parameters.Add("@L", TextBox16.Text)
        com.Parameters.Add("@M", TextBox15.Text)
        com.Parameters.Add("@N", TextBox14.Text)
        com.Parameters.Add("@O", TextBox13.Text)
        com.Parameters.Add("@P", TextBox12.Text)
        com.Parameters.Add("@Q", TextBox19.Text)
        com.Parameters.Add("@R", TextBox18.Text)
        com.Parameters.Add("@S", TextBox17.Text)
        com.Parameters.Add("@T", TextBox23.Text)
        com.Parameters.Add("@U", TextBox20.Text)
        com.Parameters.Add("@V", TextBox22.Text)
        com.Parameters.Add("@W", TextBox26.Text)
        com.Parameters.Add("@X", TextBox25.Text)
        com.Parameters.Add("@Y", TextBox24.Text)
        com.Parameters.Add("@Z", TextBox21.Text)
        com.Parameters.Add("@A1", Textbox27.Text)
        com.CommandText() = a
        If com.ExecuteNonQuery() Then
            Textbox28.Text = " Registration Successful "
        Else
            Textbox28.Text = " Registration Failed "
        End If


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Response.Redirect("WebForm2.aspx", True)
    End Sub
End Class
