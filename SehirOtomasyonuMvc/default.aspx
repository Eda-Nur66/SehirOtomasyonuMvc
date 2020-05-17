<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="_default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Ana Sayfa</title>

    <link href="/style.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">

        <section class="wrapper box-shadow">

            <asp:Label ID="lblKullaniciAdi" Text="durum" runat="server" />

            <asp:Button ID="btnOturumAc" Text="Oturum Aç" runat="server" OnClick="btnOturumAc_Click" Style="position: absolute; left: 20px; bottom: 24px;" />

            <asp:Button ID="btnCikis" Text="Çıkış" runat="server" OnClick="btnCikis_Click" Style="position: absolute; right: 20px; bottom: 24px;" />

        </section>

    </form>
</body>
</html>
