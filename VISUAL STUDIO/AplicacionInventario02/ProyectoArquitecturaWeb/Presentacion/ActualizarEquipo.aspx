<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/master.Master" AutoEventWireup="true" CodeBehind="ActualizarEquipo.aspx.cs" Inherits="ProyectoArquitecturaWeb.Presentacion.ActualizarEquipo" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width:520px; margin:0 auto;">
        <tr>
            <td>ID Equipo:</td>
            <td>
                <asp:TextBox ID="TxtIDEquipo" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td rowspan="8" valign="middle">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Presentacion/imagenes/botones/actualizar.jpg" OnClick="ImgBtnRegistro_Click" />
            </td>
        </tr>
        <tr>
            <td>Codigo:</td>
            <td>
                <asp:TextBox ID="TxtCodigo" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Tipo:</td>
            <td>
                <asp:TextBox ID="TxtTipo" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Marca:</td>
            <td>
                <asp:TextBox ID="TxtMarca" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Modelo:</td>
            <td>
                <asp:TextBox ID="TxtModelo" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Serial:</td>
            <td>
                <asp:TextBox ID="TxtSerial" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Disponible:</td>
            <td>
                <asp:TextBox ID="TxtDisponible" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Fecha Registro:</td>
            <td>
                <asp:TextBox ID="TxtFechaRegistro" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Fecha Actualizacion:</td>
            <td>
                <asp:TextBox ID="TxtFechaActual" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
