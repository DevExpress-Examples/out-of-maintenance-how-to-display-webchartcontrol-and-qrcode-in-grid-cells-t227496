<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QRCodeTemplate.aspx.cs" Inherits="QRCodeTemplate" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxGridView ID="ASPxGridView1" runat="server" EnableRowsCache="false" OnDataBinding="ASPxGridView1_DataBinding">
            <Columns>
                <dx:GridViewDataTextColumn FieldName="ID"></dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="ProductName"></dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="QRCodeValue">
                    <DataItemTemplate>
                        <dx:ASPxBinaryImage ID="ASPxBunaryImage1" runat="server" OnInit="ASPxBunaryImage1_Init"></dx:ASPxBinaryImage>
                    </DataItemTemplate>
                </dx:GridViewDataTextColumn>
            </Columns>
        </dx:ASPxGridView>
    </form>
</body>
</html>
