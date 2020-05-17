<%@ Page Language="C#" AutoEventWireup="true" CodeFile="giris.aspx.cs" Inherits="giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Kullanıcı Girişi</title>

    <link href="/style.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">

        <section class="wrapper box-shadow">

            <table class="tblKullaniciGirisi">
                <tr>
                    <td>
                        <asp:Label CssClass="itext" Text="Kullanıcı Girişi" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Kullanıcı Adı
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtKullaniciAdi" placeholder="Kullanıcı adınız" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Şifre
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtSifre" placeholder="Parolanız" runat="server" TextMode="Password" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-top: 15px;"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnGiris" Text="Giriş" OnClick="btnGiris_Click" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblGirisDurum" Text="" runat="server" />
                    </td>
                </tr>
            </table>

        </section>

    </form>
</body>
</html>
