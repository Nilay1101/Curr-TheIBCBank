<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm8.aspx.vb" Inherits="Qahili.WebForm8"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm8</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="gainsboro" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label5" style="Z-INDEX: 100; LEFT: 16px; POSITION: absolute; TOP: 40px" runat="server"
				Font-Size="Small" Font-Bold="True" BorderWidth="2px" BorderStyle="Inset" BorderColor="#0000C0"
				BackColor="#8080FF" ForeColor="White" Height="24px" Width="152px">Customer Information</asp:label>
			<asp:button id="Button2" style="Z-INDEX: 132; LEFT: 264px; POSITION: absolute; TOP: 352px" runat="server"
				Font-Bold="True" BorderWidth="2px" BorderStyle="Inset" BorderColor="Green" BackColor="YellowGreen"
				ForeColor="White" Height="24px" Width="112px" Text="Crystal Report"></asp:button>
			<asp:label id="Label16" style="Z-INDEX: 131; LEFT: 8px; POSITION: absolute; TOP: 312px" runat="server"
				Font-Bold="True" Width="64px">Balance</asp:label>
			<asp:textbox id="Textbox12" style="Z-INDEX: 130; LEFT: 72px; POSITION: absolute; TOP: 312px"
				runat="server" Width="136px"></asp:textbox>
			<asp:label id="Label15" style="Z-INDEX: 129; LEFT: 224px; POSITION: absolute; TOP: 280px" runat="server"
				Font-Bold="True" Width="64px">DebitC</asp:label>
			<asp:label id="Label14" style="Z-INDEX: 128; LEFT: 8px; POSITION: absolute; TOP: 280px" runat="server"
				Font-Bold="True" Width="64px">CreditC</asp:label>
			<asp:label id="Label13" style="Z-INDEX: 127; LEFT: 440px; POSITION: absolute; TOP: 280px" runat="server"
				Font-Bold="True" Width="64px">ChequeB</asp:label>
			<asp:textbox id="Textbox11" style="Z-INDEX: 126; LEFT: 72px; POSITION: absolute; TOP: 280px"
				runat="server" Width="136px"></asp:textbox>
			<asp:textbox id="Textbox10" style="Z-INDEX: 125; LEFT: 288px; POSITION: absolute; TOP: 280px"
				runat="server" Width="136px"></asp:textbox>
			<asp:textbox id="Textbox9" style="Z-INDEX: 124; LEFT: 512px; POSITION: absolute; TOP: 280px"
				runat="server" Width="128px"></asp:textbox>
			<asp:label id="Label12" style="Z-INDEX: 123; LEFT: 224px; POSITION: absolute; TOP: 248px" runat="server"
				Font-Bold="True" Width="56px">Phone</asp:label>
			<asp:textbox id="Textbox8" style="Z-INDEX: 122; LEFT: 288px; POSITION: absolute; TOP: 248px"
				runat="server" Width="136px"></asp:textbox>
			<asp:label id="Label11" style="Z-INDEX: 121; LEFT: 8px; POSITION: absolute; TOP: 248px" runat="server"
				Font-Bold="True" Width="56px">Email</asp:label>
			<asp:textbox id="Textbox7" style="Z-INDEX: 120; LEFT: 72px; POSITION: absolute; TOP: 248px" runat="server"
				Width="136px"></asp:textbox><asp:textbox id="Textbox6" style="Z-INDEX: 119; LEFT: 288px; POSITION: absolute; TOP: 216px"
				runat="server" Width="136px"></asp:textbox><asp:label id="Label10" style="Z-INDEX: 118; LEFT: 224px; POSITION: absolute; TOP: 216px" runat="server"
				Font-Bold="True" Width="56px">LName</asp:label><asp:label id="Label9" style="Z-INDEX: 117; LEFT: 8px; POSITION: absolute; TOP: 216px" runat="server"
				Font-Bold="True" Width="56px">FName</asp:label><asp:textbox id="Textbox4" style="Z-INDEX: 116; LEFT: 72px; POSITION: absolute; TOP: 216px" runat="server"
				Width="136px"></asp:textbox><asp:label id="Label2" style="Z-INDEX: 115; LEFT: 440px; POSITION: absolute; TOP: 184px" runat="server"
				Font-Bold="True" Width="64px">Branch</asp:label><asp:textbox id="Textbox3" style="Z-INDEX: 114; LEFT: 504px; POSITION: absolute; TOP: 184px"
				runat="server" Width="136px"></asp:textbox><asp:button id="Button7" style="Z-INDEX: 113; LEFT: 664px; POSITION: absolute; TOP: 88px" runat="server"
				Font-Bold="True" BorderStyle="Inset" BorderColor="Maroon" BackColor="#C00000" ForeColor="White" Width="97px" Text="Dashboard"></asp:button><asp:label id="Label8" style="Z-INDEX: 112; LEFT: 24px; POSITION: absolute; TOP: 184px" runat="server"
				Font-Bold="True">UID</asp:label><asp:label id="Label3" style="Z-INDEX: 111; LEFT: 224px; POSITION: absolute; TOP: 184px" runat="server"
				Font-Bold="True" Width="64px">Acc No.</asp:label><asp:textbox id="TextBox5" style="Z-INDEX: 110; LEFT: 288px; POSITION: absolute; TOP: 184px"
				runat="server" Width="136px"></asp:textbox><asp:textbox id="TextBox2" style="Z-INDEX: 109; LEFT: 72px; POSITION: absolute; TOP: 184px" runat="server"
				Width="136px"></asp:textbox><asp:button id="Button1" style="Z-INDEX: 108; LEFT: 224px; POSITION: absolute; TOP: 96px" runat="server"
				Font-Bold="True" BorderWidth="2px" BorderStyle="Inset" BorderColor="Green" BackColor="YellowGreen" ForeColor="White" Height="24px"
				Width="72px" Text="Get"></asp:button><asp:label id="Label7" style="Z-INDEX: 106; LEFT: 24px; POSITION: absolute; TOP: 104px" runat="server"
				Font-Bold="True">ID</asp:label><asp:textbox id="TextBox1" style="Z-INDEX: 105; LEFT: 72px; POSITION: absolute; TOP: 96px" runat="server"
				Width="136px"></asp:textbox><asp:label id="Label4" style="Z-INDEX: 104; LEFT: 8px; POSITION: absolute; TOP: 384px" runat="server"
				Font-Size="Small" Font-Bold="True" BorderWidth="2px" BorderStyle="Inset" BorderColor="Black" BackColor="#404040" ForeColor="White"
				Height="24px" Width="736px">Terms & Conditions | Disclaimer | Policies</asp:label><asp:label id="Label6" style="Z-INDEX: 103; LEFT: 568px; POSITION: absolute; TOP: 352px" runat="server"
				Font-Size="Small" Font-Bold="True" BorderWidth="2px" BorderStyle="Inset" BorderColor="#0000C0" BackColor="#8080FF" ForeColor="White" Height="24px" Width="176px">Contact : 1800-1800-234</asp:label><asp:label id="Label1" style="Z-INDEX: 102; LEFT: 472px; POSITION: absolute; TOP: 16px" runat="server"
				Font-Size="X-Large" Font-Bold="True" BorderWidth="2px" BorderStyle="Inset" BorderColor="LightGray" BackColor="LightGray" ForeColor="DimGray" Height="48px" Width="240px">The I.B.C Bank</asp:label>
			<HR style="Z-INDEX: 101; LEFT: 16px; WIDTH: 99.53%; POSITION: absolute; TOP: 72px; HEIGHT: 8px"
				width="99.53%" SIZE="8">
		</form>
	</body>
</HTML>
