<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Graphs in ASPxGridView Cells</h1>
        <dx:ASPxHyperLink ID="hlLineChartTemplat" runat="server" Text="Line Chart Demo (Template)" NavigateUrl="LineChartTemplate.aspx">
        </dx:ASPxHyperLink>
        <br />
        <dx:ASPxHyperLink ID="hlQRCodeTemplate" runat="server" Text="QRCode Demo (Template)" NavigateUrl="QRCodeTemplate.aspx">
        </dx:ASPxHyperLink>
        <br />
        <br />
        <dx:ASPxHyperLink ID="hlLineChartImage" runat="server" Text="Line Chart Demo (Image Column)" NavigateUrl="LineChartImage.aspx">
        </dx:ASPxHyperLink>
        <br />
        <dx:ASPxHyperLink ID="hlQRCodeImage" runat="server" Text="QRCode demo (Image Column)" NavigateUrl="QRCodeImage.aspx">
        </dx:ASPxHyperLink>

    </form>
</body>
</html>