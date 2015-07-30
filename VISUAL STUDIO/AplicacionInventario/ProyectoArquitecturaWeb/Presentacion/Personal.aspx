<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/master.Master" AutoEventWireup="true" CodeBehind="Personal.aspx.cs" Inherits="ProyectoArquitecturaWeb.Presentacion.Personal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            background-color: #FF6600;
        }
        .auto-style3 {
            height: 69px;
            width: 233px;
        }
        .auto-style4 {
            height: 69px;
            background-color: #FF6600;
        }
        .auto-style5 {
            height: 227px;
            background-color: #FF6600;
        }
        .auto-style6 {
            width: 233px;
            background-color: #FF6600;
        }
        .auto-style7 {
            height: 227px;
            width: 233px;
            background-color: #FF6600;
        }
        .auto-style8 {
            height: 69px;
            width: 134px;
            background-color: #FF6600;
        }
        .auto-style9 {
            width: 134px;
            background-color: #FF6600;
        }
        .auto-style10 {
            height: 227px;
            width: 134px;
            background-color: #FF6600;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3" style="background-color: #FF6600"></td>
            <td class="auto-style8"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label1" runat="server" Text="Cédula de Identidad"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtcedula" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2">
                <asp:DropDownList ID="drlpersonal" runat="server" DataSourceID="ObjectDataSource1" DataTextField="IDPersonal" DataValueField="IDPersonal">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ObtenerPersonalById" TypeName="ProyectoArquitecturaWeb.Negocio.NegocioPersonal">
                    <SelectParameters>
                        <asp:Parameter Name="IDPersonal" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label4" runat="server" Text="Teléfono"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label5" runat="server" Text="E-mail"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label6" runat="server" Text="Área de Trabajo"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtarea" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style9">
                <asp:Button ID="btnalmacenar" runat="server" Height="34px" Text="Almacenar" Width="101px" OnClick="btnalmacenar_Click" />
                <br />
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style9">
                <asp:Button ID="btneliminar" runat="server" Text="Eliminar" Height="34px" Width="101px" OnClick="btneliminar_Click"/>
                <br />
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style9">
                <asp:Button ID="btnmodificar" runat="server" Text="Modificar" Height="34px" Width="101px" OnClick="btnmodificar_Click"/>
                <br />
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style10"></td>
            <td class="auto-style5">
                <asp:GridView ID="grvpersonal" runat="server" Height="220px" Width="312px">
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
