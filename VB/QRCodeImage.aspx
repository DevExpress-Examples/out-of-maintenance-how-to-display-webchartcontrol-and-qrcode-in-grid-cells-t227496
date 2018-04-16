<%@ Page Language="vb" AutoEventWireup="true" CodeFile="QRCodeImage.aspx.vb" Inherits="QRCodeImage" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Export To PDF" OnClick="ASPxButton1_Click"></dx:ASPxButton>
        <br />
        <br />
        <dx:ASPxGridView ID="ASPxGridView1" runat="server" OnDataBinding="ASPxGridView1_DataBinding" OnCustomUnboundColumnData="ASPxGridView1_CustomUnboundColumnData">
            <Columns>
                <dx:GridViewDataTextColumn FieldName="ID"></dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="ProductName"></dx:GridViewDataTextColumn>
                <dx:GridViewDataBinaryImageColumn FieldName="QRCodeValueUnbound" UnboundType="Object">
                    <PropertiesBinaryImage>
                        <ExportImageSettings Height="200" Width="200" />
                    </PropertiesBinaryImage>
                </dx:GridViewDataBinaryImageColumn>
            </Columns>
        </dx:ASPxGridView>
        <dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server" GridViewID="ASPxGridView1"></dx:ASPxGridViewExporter>
    </form>
</body>
</html>