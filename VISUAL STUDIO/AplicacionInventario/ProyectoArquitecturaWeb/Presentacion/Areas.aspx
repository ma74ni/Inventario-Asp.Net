<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/master.Master" AutoEventWireup="true" CodeBehind="Areas.aspx.cs" Inherits="ProyectoArquitecturaWeb.Presentacion.Areas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #00CC00;
        }
        .auto-style8 {
            width: 130px;
            text-align: center;
            color: #000000;
            font-size: medium;
        }
        .auto-style6 {
            width: 72px;
        }
        .auto-style5 {
            width: 327px;
        }
        .auto-style7 {
            width: 130px;
        }
        .auto-style9 {
            width: 130px;
            text-align: center;
            color: #000000;
            font-size: medium;
            height: 53px;
        }
        .auto-style10 {
            width: 72px;
            height: 53px;
        }
        .auto-style11 {
            width: 327px;
            height: 53px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style10"></td>
            <td class="auto-style11"></td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">Nombre del Area:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtarea" runat="server"  style="margin-left: 33px" Height="36px" Width="173px"></asp:TextBox>
                <br />
                <br />
            </td>
            <td class="auto-style5">
                <asp:DropDownList ID="drlarea" runat="server" OnTextChanged="drlarea_TextChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style6">
                <asp:Button ID="btnalmacenar" runat="server" Text="Almacenar" Height="37px" style="text-align: center" Width="109px" OnClick="btnalmacenar_Click" />
                <br />
                <br />
                <br />
            </td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style6">
                <asp:Button ID="btneliminar" runat="server" Text="Eliminar" Height="37px" style="text-align: center" Width="109px" OnClick="btneliminar_Click" />
                <br />
                <br />
                <br />
            </td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style6">
                <asp:Button ID="btnmodificar" runat="server" Text="Modificar" Height="37px" style="text-align: center" Width="109px" OnClick="btnmodificar_Click" />
                <br />
                <br />
                <br />
            </td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style6">
                <asp:GridView ID="grvarea" runat="server" Height="207px" Width="344px">
                </asp:GridView>
                <br />
                <br />
            </td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <br />
</asp:Content>
