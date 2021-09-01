<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Wba.Querystrings.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>QueryString : startpagina</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 100px;">
            <table>
                <tr>
                    <td>Uw naam : </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtNaam"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Uw geslacht : </td>
                    <td>
                        <asp:DropDownList runat="server" ID="cmbGeslacht">
                            <asp:ListItem Text="Man" Value="Man"></asp:ListItem>
                            <asp:ListItem Text="Vrouw" Value="Vrouw"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Taal : </td>
                    <td>
                        <asp:DropDownList runat="server" ID="cmbTaal">
                            <asp:ListItem Text="Nederlands" Value="NL"></asp:ListItem>
                            <asp:ListItem Text="Frans" Value="FR"></asp:ListItem>
                            <asp:ListItem Text="Engels" Value="EN"></asp:ListItem>
                            <asp:ListItem Text="Duits" Value="DU"></asp:ListItem>
                            <asp:ListItem Text="Italiaans" Value="IT"></asp:ListItem>
                            <asp:ListItem Text="Spaans" Value="SP"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnVerder" runat="server" Text="Naar volgende pagina" OnClick="btnVerder_Click" />
                    </td>

                </tr>
            </table>

        </div>
    </form>
</body>
</html>
