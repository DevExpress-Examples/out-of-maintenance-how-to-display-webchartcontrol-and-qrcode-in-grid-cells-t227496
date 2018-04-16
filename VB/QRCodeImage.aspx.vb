Imports System
Imports System.Drawing
Imports System.Text
Imports DevExpress.BarCodes
Imports DevExpress.Web

Partial Public Class QRCodeImage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If (Not IsCallback) AndAlso (Not IsPostBack) Then
            ASPxGridView1.DataBind()
        End If
    End Sub
    Protected Sub ASPxGridView1_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
        ASPxGridView1.DataSource = QRCodeData.GetData()
    End Sub
    Protected Sub ASPxGridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As ASPxGridViewColumnDataEventArgs)
        If e.Column.FieldName = "QRCodeValueUnbound" Then
            Dim barCodeText As String = e.GetListSourceFieldValue("QRCodeValue").ToString()
            Dim barCode As New BarCode() With {.Symbology = Symbology.QRCode, .CodeBinaryData = Encoding.Default.GetBytes(barCodeText)}
            Dim converter As New ImageConverter()
            e.Value = DirectCast(converter.ConvertTo(barCode.BarCodeImage, GetType(Byte())), Byte())
        End If
    End Sub
    Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
        ASPxGridViewExporter1.WritePdfToResponse()
    End Sub
End Class