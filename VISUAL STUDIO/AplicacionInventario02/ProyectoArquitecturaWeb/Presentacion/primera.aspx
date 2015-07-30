<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/master.Master" AutoEventWireup="true" CodeBehind="primera.aspx.cs" Inherits="ProyectoArquitecturaWeb.Presentacion.primera" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div>

        <table style="width:100%;">
            <tr>
                <td align="center">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageAlign="Middle" ImageUrl="~/Presentacion/imagenes/computadoras.jpg" OnClick="ImageButton1_Click" />
                </td>
                <td align="center">
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Presentacion/imagenes/impresoras.jpg" />
                </td>
                <td align="center">
                    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Presentacion/imagenes/accesorios.jpg" />
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
