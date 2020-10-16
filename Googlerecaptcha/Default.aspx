<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Googlerecaptcha.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

     <script src="https://www.google.com/recaptcha/api.js" async defer></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TXTKULLANICI" runat="server" placeholder="KULLANICI ADI" > </asp:TextBox>
        <br />
              <asp:TextBox ID="TXTSIFRE" runat="server" placeholder="KULLANICI ADI" > </asp:TextBox>
            <br />
            <asp:Button ID="BTN" runat="server" OnClick="BTN_Click"/>
                   <br />
            <div class="g-recaptcha" data-sitekey="6Lfx6qgZAAAAAKw3WBO0v_Hz-DdAdkqVPHs-ZN-e"></div>
        </div>
    </form>
</body>
</html>
