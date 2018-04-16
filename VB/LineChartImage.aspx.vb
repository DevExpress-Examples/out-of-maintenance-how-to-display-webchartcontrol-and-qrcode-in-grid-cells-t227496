Imports DevExpress.XtraCharts
Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Partial Public Class LineChartImage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If (Not IsCallback) AndAlso (Not IsPostBack) Then
            ASPxGridView1.DataBind()
        End If
    End Sub
    Protected Sub ASPxGridView1_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
        ASPxGridView1.DataSource = LineChartData.GetData()
    End Sub
    Protected Sub ASPxGridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDataEventArgs)
        If e.Column.FieldName = "LineChartValueUnbound" Then
            Dim seriesValue As Series = CType(e.GetListSourceFieldValue("LineChartValues"), Series)
            WebChartControl1.Series.Clear()
            WebChartControl1.Series.Add(seriesValue)
            Using s As New MemoryStream()
                WebChartControl1.ExportToImage(s, ImageFormat.Jpeg)
                Dim bitmap As Bitmap = CType(Image.FromStream(s), Bitmap)
                Dim converter As New ImageConverter()
                e.Value = DirectCast(converter.ConvertTo(bitmap, GetType(Byte())), Byte())
            End Using
        End If
    End Sub
    Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
        ASPxGridViewExporter1.WritePdfToResponse()
    End Sub
End Class