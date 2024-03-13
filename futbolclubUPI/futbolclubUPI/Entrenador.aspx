<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Entrenador.aspx.cs" Inherits="futbolclubUPI.Entrenador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/estilo.css" rel="stylesheet" />
    <title>Entrenador | UPI</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>

                <li><a href="Principal.aspx">Principal</a></li>
                <li><a href="Jugador.aspx">Jugador</a></li>
                <li><a href="Entrenador.aspx">Entrenador</a></li>

            </ul>
            <div>
            </div><br />
                 <br />

            Codigo:
            <asp:TextBox ID="Tcodigo" runat="server"></asp:TextBox>
            Nombre:
            <asp:TextBox ID="Tnombre" runat="server"></asp:TextBox>
            Titulo:
            <asp:TextBox ID="Ttitulo" runat="server"></asp:TextBox>

        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="conexionequipo" ForeColor="#333333" GridLines="None" Height="137px" Width="196px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="titulos" HeaderText="titulos" SortExpression="titulos" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>

            <asp:SqlDataSource ID="conexionequipo" runat="server" ConnectionString="<%$ ConnectionStrings:UHFCConnectionString %>" SelectCommand="SELECT * FROM [entrenador]"></asp:SqlDataSource>

        </div>
        <div>
            <asp:Button ID="Bagregar" runat="server" Text="Agregar" />
            <asp:Button ID="Bborrar" runat="server" Text="Borrar" />
            <asp:Button ID="Bmodificar" runat="server" Text="Modificar" />
        </div>
    </form>
</body>
</html>
