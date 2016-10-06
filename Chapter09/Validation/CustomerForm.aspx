<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CustomerForm.aspx.vb" Inherits="Validation.CustomerForm" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<script language="JavaScript">
<!--
function MyCustomValidation(objSource, objArgs)
{
    // Get value.
    var number = objArgs.Value;//.substr(0, 3);
     objArgs.IsValid = true;

    // Check value and return result.
    number = number.substr(0, 3);
    if (number % 7 == 0)
    {
        objArgs.IsValid = true;
        return;
    }
    else
    {
        objArgs.IsValid = false;
        return;
    }
}
// -->
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<DIV style="BORDER-RIGHT: thin groove; BORDER-TOP: thin groove; FONT-SIZE: x-small; Z-INDEX: 101; LEFT: 16px; BORDER-LEFT: thin groove; WIDTH: 613px; BORDER-BOTTOM: thin groove; FONT-FAMILY: Verdana; POSITION: absolute; TOP: 20px; HEIGHT: 364px; BACKGROUND-COLOR: lightyellow" ms_positioning="GridLayout">
				<asp:TextBox id="txtUserName" style="Z-INDEX: 101; LEFT: 160px; POSITION: absolute; TOP: 16px" runat="server" Width="152px"></asp:TextBox>
				<asp:Label id="Label1" style="Z-INDEX: 102; LEFT: 72px; POSITION: absolute; TOP: 19px" runat="server" Font-Bold="True">User Name:</asp:Label>
				<asp:TextBox id="txtPassword" style="Z-INDEX: 103; LEFT: 160px; POSITION: absolute; TOP: 56px" runat="server" TextMode="Password" Width="152px"></asp:TextBox>
				<asp:Label id="Label2" style="Z-INDEX: 104; LEFT: 80px; POSITION: absolute; TOP: 59px" runat="server" Font-Bold="True">Password:</asp:Label>
				<asp:TextBox id="txtRetype" style="Z-INDEX: 105; LEFT: 160px; POSITION: absolute; TOP: 88px" runat="server" TextMode="Password" Width="152px"></asp:TextBox>
				<asp:Label id="Label3" style="Z-INDEX: 106; LEFT: 13px; POSITION: absolute; TOP: 91px" runat="server" Font-Bold="True">Password (retype):</asp:Label>
				<asp:Label id="Label4" style="Z-INDEX: 107; LEFT: 104px; POSITION: absolute; TOP: 140px" runat="server" Font-Bold="True">E-mail:</asp:Label>
				<asp:TextBox id="txtEmail" style="Z-INDEX: 108; LEFT: 160px; POSITION: absolute; TOP: 136px" runat="server" Width="152px"></asp:TextBox>
				<asp:TextBox id="txtAge" style="Z-INDEX: 109; LEFT: 160px; POSITION: absolute; TOP: 176px" runat="server" Width="152px"></asp:TextBox>
				<asp:Label id="Label5" style="Z-INDEX: 110; LEFT: 117px; POSITION: absolute; TOP: 179px" runat="server" Width="32px" Height="16px" Font-Bold="True">Age:</asp:Label>
				<asp:Label id="Label6" style="Z-INDEX: 111; LEFT: 48px; POSITION: absolute; TOP: 228px" runat="server" Width="106px" Height="24px" Font-Bold="True">Referrer Code:</asp:Label>
				<asp:TextBox id="txtCode" style="Z-INDEX: 112; LEFT: 160px; POSITION: absolute; TOP: 224px" runat="server" Width="152px"></asp:TextBox>
				<asp:RequiredFieldValidator id="vldUserName" style="Z-INDEX: 113; LEFT: 336px; POSITION: absolute; TOP: 18px" runat="server" ErrorMessage="You must enter a user name." ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
				<asp:RequiredFieldValidator id="vldPassword" style="Z-INDEX: 115; LEFT: 336px; POSITION: absolute; TOP: 59px" runat="server" ErrorMessage="You must enter a password." ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
				<asp:CompareValidator id="vldRetype" style="Z-INDEX: 114; LEFT: 336px; POSITION: absolute; TOP: 93px" runat="server" ErrorMessage="Your password does not match." ControlToCompare="txtPassword" ControlToValidate="txtRetype"></asp:CompareValidator>
				<asp:RegularExpressionValidator id="vldEmail" style="Z-INDEX: 117; LEFT: 337px; POSITION: absolute; TOP: 139px" runat="server" ErrorMessage="This email is missing the @ symbol." ValidationExpression=".+@.+" ControlToValidate="txtEmail"></asp:RegularExpressionValidator>
				<asp:RangeValidator id="vldAge" style="Z-INDEX: 116; LEFT: 337px; POSITION: absolute; TOP: 180px" runat="server" ErrorMessage="This age is not between 0 and 120." Type="Integer" MaximumValue="120" MinimumValue="0" ControlToValidate="txtAge"></asp:RangeValidator>
				<asp:CustomValidator id="vldCode" style="Z-INDEX: 118; LEFT: 337px; POSITION: absolute; TOP: 227px" runat="server" ErrorMessage="Try a string that starts with 014." ControlToValidate="txtCode" ClientValidationFunction="MyCustomValidation"></asp:CustomValidator>
				<asp:Button id="cmdSubmit" style="Z-INDEX: 119; LEFT: 160px; POSITION: absolute; TOP: 304px" runat="server" Width="120px" Text="Submit"></asp:Button>
				<asp:Button id="cmdCancel" style="Z-INDEX: 120; LEFT: 304px; POSITION: absolute; TOP: 304px" runat="server" Width="121px" Height="24px" Text="Cancel" CausesValidation="False"></asp:Button></DIV>
			<asp:Label id="lblMessage" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 376px" runat="server" Width="616px" Height="72px"></asp:Label>
		</form>
	</body>
</HTML>
