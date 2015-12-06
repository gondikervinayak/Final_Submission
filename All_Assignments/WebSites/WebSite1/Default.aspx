<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>Enter First Number</td>
                <td>
                    <asp:TextBox ID="number1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Enter Second Number</td>
                <td>
                    <asp:TextBox ID="number2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Add" Width="128px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Sum</td>
                <td>
                    <asp:TextBox ID="sum" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
