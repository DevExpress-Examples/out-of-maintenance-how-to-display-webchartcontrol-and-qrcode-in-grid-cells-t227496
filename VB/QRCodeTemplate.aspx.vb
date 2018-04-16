Imports System
Imports System.Drawing
Imports System.Text
Imports System.Web.UI
Imports DevExpress.BarCodes
Imports DevExpress.Web

Partial Public Class QRCodeTemplate
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If (Not IsCallback) AndAlso (Not IsPostBack) Then
            ASPxGridView1.DataBind()
        End If
    End Sub
    Protected Sub ASPxGridView1_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
        ASPxGridView1.DataSource = QRCodeData.GetData()
    End Sub
    Protected Sub ASPxBunaryImage1_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim biControl As ASPxBinaryImage = DirectCast(sender, ASPxBinaryImage)
        Dim container As GridViewDataItemTemplateContainer = CType(biControl.NamingContainer, GridViewDataItemTemplateContainer)
        Dim barCodeText As String = CStr(container.Grid.GetRowValues(container.VisibleIndex, "QRCodeValue"))
        Dim barCode As New BarCode() With {.Symbology = Symbology.QRCode, .CodeBinaryData = Encoding.Default.GetBytes(barCodeText)}
        Dim converter As New ImageConverter()
        biControl.ContentBytes = DirectCast(converter.ConvertTo(barCode.BarCodeImage, GetType(Byte())), Byte())
    End Sub
End Class