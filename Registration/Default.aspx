﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            text-align: center;
            font-size: xx-large;
        }
        .auto-style6 {
            text-align: center;
        }
        .auto-style7 {
            width: 847px;
            text-align: center;
        }
        .auto-style8 {
            width: 847px;
            text-align: right;
        }
        .auto-style9 {
            text-align: left;
        }
        .auto-style10 {
            font-size: large;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style5" colspan="2">
                    <strong>REGISTRATION FORM</strong></td>
            </tr>
            <tr>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="Fname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Last Name</td>
                <td class="auto-style9">
                    <asp:TextBox ID="Lname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Register" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10" colspan="2"><strong>List of Registered Students</strong></td>
            </tr>
            <tr>
                <td></td>
                <td class="auto-style6">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                        <Columns>
                            <asp:BoundField DataField="FName" HeaderText="FName" SortExpression="FName"></asp:BoundField>
                            <asp:BoundField DataField="LName" HeaderText="LName" SortExpression="LName"></asp:BoundField>
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=&quot;C:\Users\Arun\Documents\Visual Studio 2015\WebSites\Registration\Database\Student.accdb&quot;" ProviderName="<%$ ConnectionStrings:StudentDBCon.ProviderName %>" SelectCommand="SELECT * FROM [Registration]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="2">&nbsp;</td>
            </tr>
            </table>
    <div>
    
    </div>
    </form>
</body>
</html>
