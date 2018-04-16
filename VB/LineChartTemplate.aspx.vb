Imports System
Imports DevExpress.Web
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class LineChartTemplate
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If (Not IsCallback) AndAlso (Not IsPostBack) Then
            ASPxGridView1.DataBind()
        End If
    End Sub
    Protected Sub ASPxGridView1_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
        ASPxGridView1.DataSource = LineChartData.GetData()
    End Sub
    Protected Sub WebChartControl1_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim chart As WebChartControl = DirectCast(sender, WebChartControl)
        Dim container As GridViewDataItemTemplateContainer = CType(chart.NamingContainer, GridViewDataItemTemplateContainer)
        chart.Series.Add(CType(container.Grid.GetRowValues(container.VisibleIndex, "LineChartValues"), Series))
    End Sub
End Class