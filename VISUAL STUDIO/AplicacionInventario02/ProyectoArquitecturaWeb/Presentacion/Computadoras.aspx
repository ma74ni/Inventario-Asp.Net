<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/master.Master" AutoEventWireup="true" CodeBehind="Computadoras.aspx.cs" Inherits="ProyectoArquitecturaWeb.Presentacion.Computadoras" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:520px; margin:0 auto;">
        <tr>
            <td>Codigo:</td>
            <td>
                <asp:TextBox ID="TxtCodigo" runat="server"></asp:TextBox>
            </td>
            <td rowspan="7" valign="middle">
                <asp:ImageButton ID="ImgBtnRegistro" runat="server" ImageUrl="~/Presentacion/imagenes/botones/registrar.jpg" OnClick="ImgBtnRegistro_Click" />
            </td>
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
                <asp:DropDownList ID="drlDisponible" runat="server">
                    <asp:ListItem Selected="True" Value="s">SI</asp:ListItem>
                    <asp:ListItem Value="n">NO</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Fecha:</td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="grvequipos" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="grvequipos_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="IDEquipo1" HeaderText="ID" />
                        <asp:BoundField DataField="Tipo1" HeaderText="TIPO" />
                        <asp:BoundField DataField="Marca1" HeaderText="MARCA" />
                        <asp:BoundField DataField="Modelo1" HeaderText="MODELO" />
                        <asp:BoundField DataField="Activo1" HeaderText="CODIGO" />
                        <asp:BoundField DataField="Serial1" HeaderText="SERIAL" />
                        <asp:BoundField DataField="Prestar1" HeaderText="DISPONIBLE" />
                        <asp:BoundField DataField="Fecha_registro" HeaderText="FECHA REGISTRO" />
                        <asp:BoundField DataField="Fecha_actualizacion" HeaderText="ULTIMA ACTUALIZACION" />
                        <asp:CommandField SelectText="Editar" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    </asp:Content>

