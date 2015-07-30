<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ProyectoArquitecturaWeb.Presentacion.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="../style.css" />
    <title>Ingreso</title>
</head>
<body>
    <div class="center content">
        <form id="form1" runat="server">
            <div>
                
                <table style="width:100%;">
                    <tr>
                        <td class="cuadro_login">Usuario:</td>
                        <td>
                            <asp:TextBox ID="TxtUsuario" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="cuadro_login">Contraseña:</td>
                        <td>
                            <asp:TextBox ID="TxtContrasena" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="cuadro_login_boton">
                            <asp:Button ID="BtnIngresar" runat="server" Text="Ingresar" OnClick="BtnIngresar_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblErrorLogin" runat="server" Font-Size="11px" ForeColor="#990000"></asp:Label>
                        </td>
                    </tr>
                </table>
                
            </div>
        </form>
    </div>
    <div class="pie_login center">
        <p>&copy 2015 Todos los Derechos Reservados<br />
            Desarrollo: Jorge Tapia & Diego Paredes<br />
            Escuela Politécnica Nacional
        </p>

    </div>
</body>
</html>
