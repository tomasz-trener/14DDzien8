<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P02AplikacjaZawodnicy.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div style="float:left; margin:10px">
              <asp:Button ID="btnWczytaj" OnClick="btnWczytaj_Click" runat="server" Text="Wczytaj" />
              <asp:TextBox ID="txtFiltr" AutoPostBack="true" OnTextChanged="txtFiltr_TextChanged" runat="server"></asp:TextBox>
            
            <br />
              <asp:ListBox ID="lbDane" AutoPostBack="true" OnSelectedIndexChanged="lbDane_SelectedIndexChanged" runat="server"></asp:ListBox>

            <div style="margin:20px">
                <asp:Button ID="btnLewo" OnClick="btnLewo_Click" runat="server" Text="<--" />
                <asp:TextBox ID="txtStrona" Text="1" Width="20" runat="server"></asp:TextBox>
                z 
                <asp:Label ID="lblLiczbaStron" runat="server"></asp:Label>
                 <asp:Button ID="btnPrawo" OnClick="btnPrawo_Click" Text="-->" runat="server" />
            </div>

        </div>

        <div style="float:left">


            <table>
                <tr>
                    <td>Imie</td>
                    <td><asp:TextBox runat="server" ID="txtImie"></asp:TextBox></td>
                </tr>

                 <tr>
                    <td>Nazwisko</td>
                    <td><asp:TextBox runat="server" ID="txtNazwisko"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>Kraj</td>
                    <td><asp:TextBox runat="server" ID="txtKraj"></asp:TextBox></td>
                </tr>

                  <tr>
                    <td>Data urodzenia </td>
                    <td><asp:TextBox runat="server" ID="txtDataUr"></asp:TextBox></td>
                </tr>

                  <tr>
                    <td>Wzrost</td>
                    <td><asp:TextBox runat="server" ID="txtWzrost"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Waga</td>
                    <td><asp:TextBox runat="server" ID="txtWaga"></asp:TextBox></td>
                </tr>
            </table>

            <div>
                <asp:Button ID="btnEdytuj" Text="Edytuj" OnClick="btnEdytuj_Click" runat="server" />
                <asp:Button ID="btnNowy" Text="Nowy" OnClick="btnNowy_Click" runat="server" />
                <asp:Button ID="btnUsun" Text="Usun" OnClick="btnUsun_Click" runat="server" />
            </div>




        </div>
      



    </form>
</body>
</html>
