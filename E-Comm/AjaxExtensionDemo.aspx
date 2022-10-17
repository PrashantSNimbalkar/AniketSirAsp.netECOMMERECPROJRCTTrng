<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxExtensionDemo.aspx.cs" Inherits="E_Comm.AjaxExtensionDemo" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
            </asp:ToolkitScriptManager>
            <br />
            <br />
            Enter Passoword :<asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
            <asp:PasswordStrength ID="TextBox1_PasswordStrength" runat="server" Enabled="True" TargetControlID="TextBox1">
            </asp:PasswordStrength>
            <br />
            <br />
            Select Date :&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" Enabled="True" TargetControlID="TextBox2">
            </asp:CalendarExtender>

        </div>
    </form>
</body>
</html>
