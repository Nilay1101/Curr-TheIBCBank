<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="Qahili.WebForm1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="gainsboro" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 100; LEFT: 496px; POSITION: absolute; TOP: 16px" runat="server"
				Font-Size="X-Large" Font-Bold="True" BorderWidth="2px" BorderStyle="Inset" BorderColor="LightGray"
				BackColor="LightGray" ForeColor="DimGray" Height="48px" Width="240px">The I.B.C Bank</asp:label>
			<asp:textbox id="Textbox3" style="Z-INDEX: 114; LEFT: 8px; POSITION: absolute; TOP: 360px" runat="server"
				Width="184px"></asp:textbox><asp:label id="Label6" style="Z-INDEX: 113; LEFT: 568px; POSITION: absolute; TOP: 360px" runat="server"
				Font-Size="Small" Font-Bold="True" BorderWidth="2px" BorderStyle="Inset" BorderColor="#0000C0" BackColor="#8080FF" ForeColor="White"
				Height="24px" Width="176px">Contact : 1800-1800-234</asp:label><asp:label id="Label5" style="Z-INDEX: 112; LEFT: 8px; POSITION: absolute; TOP: 32px" runat="server"
				Font-Size="Small" Font-Bold="True" BorderWidth="2px" BorderStyle="Inset" BorderColor="#0000C0" BackColor="#8080FF" ForeColor="White" Height="24px" Width="208px">Welcome to I.B.C EBanking</asp:label>
			<HR style="Z-INDEX: 111; LEFT: 8px; WIDTH: 99.53%; POSITION: absolute; TOP: 72px; HEIGHT: 8px"
				width="99.53%" SIZE="8">
			<asp:label id="Label4" style="Z-INDEX: 110; LEFT: 8px; POSITION: absolute; TOP: 392px" runat="server"
				Font-Size="Small" Font-Bold="True" BorderWidth="2px" BorderStyle="Inset" BorderColor="Black"
				BackColor="#404040" ForeColor="White" Height="24px" Width="736px">Terms & Conditions | Disclaimer | Policies</asp:label><asp:requiredfieldvalidator id="RequiredFieldValidator2" style="Z-INDEX: 109; LEFT: 408px; POSITION: absolute; TOP: 168px"
				runat="server" ControlToValidate="TextBox2" ErrorMessage="Required"></asp:requiredfieldvalidator><asp:label id="Label3" style="Z-INDEX: 107; LEFT: 56px; POSITION: absolute; TOP: 168px" runat="server"
				Font-Bold="True" Height="24px" Width="88px">Password</asp:label><asp:textbox id="TextBox2" style="Z-INDEX: 105; LEFT: 176px; POSITION: absolute; TOP: 160px"
				runat="server" Width="184px" TextMode="Password"></asp:textbox><asp:button id="Button1" style="Z-INDEX: 101; LEFT: 224px; POSITION: absolute; TOP: 256px" runat="server"
				Font-Bold="True" BorderWidth="2px" BorderStyle="Inset" BorderColor="#C04000" BackColor="#C00000" ForeColor="White" Height="40px" Width="144px" Text="Admin Login"></asp:button><asp:button id="Button2" style="Z-INDEX: 102; LEFT: 392px; POSITION: absolute; TOP: 256px" runat="server"
				Font-Bold="True" BorderWidth="2px" BorderStyle="Inset" BorderColor="Green" BackColor="YellowGreen" ForeColor="White" Height="40px" Width="144px" Text="Customer Login"></asp:button><asp:textbox id="TextBox1" style="Z-INDEX: 103; LEFT: 176px; POSITION: absolute; TOP: 112px"
				runat="server" Width="184px"></asp:textbox><asp:label id="Label2" style="Z-INDEX: 106; LEFT: 56px; POSITION: absolute; TOP: 112px" runat="server"
				Font-Bold="True" Height="24px" Width="88px">Username</asp:label><asp:requiredfieldvalidator id="RequiredFieldValidator1" style="Z-INDEX: 108; LEFT: 408px; POSITION: absolute; TOP: 120px"
				runat="server" ControlToValidate="TextBox1" ErrorMessage="Required"></asp:requiredfieldvalidator></form>
	</body>
</HTML>
