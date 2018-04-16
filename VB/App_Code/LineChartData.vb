Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraCharts

Public Class LineChartData
    Public Shared Function GetData() As List(Of LineChartExampleDataEntry)
        Dim series1 As New Series("Series 1", ViewType.Line)
        series1.ShowInLegend = False
        series1.Points.Add(New SeriesPoint(1, 10))
        series1.Points.Add(New SeriesPoint(2, 5))
        series1.Points.Add(New SeriesPoint(3, 20))
        series1.Points.Add(New SeriesPoint(4, 13))

        Dim series2 As New Series("Series 2", ViewType.Line)
        series2.ShowInLegend = False
        series2.Points.Add(New SeriesPoint(1, 15))
        series2.Points.Add(New SeriesPoint(2, 2))
        series2.Points.Add(New SeriesPoint(3, 45))
        series2.Points.Add(New SeriesPoint(4, 12))

        Dim series3 As New Series("Series 3", ViewType.Line)
        series3.ShowInLegend = False
        series3.Points.Add(New SeriesPoint(1, 20))
        series3.Points.Add(New SeriesPoint(2, 1))
        series3.Points.Add(New SeriesPoint(3, 25))
        series3.Points.Add(New SeriesPoint(4, 10))

        Return New List(Of LineChartExampleDataEntry) From { _
            New LineChartExampleDataEntry() With {.ID = 1, .ProductName = "Product 1", .LineChartValues = series1}, _
            New LineChartExampleDataEntry() With {.ID = 2, .ProductName = "Product 2", .LineChartValues = series2}, _
            New LineChartExampleDataEntry() With {.ID = 3, .ProductName = "Product 3", .LineChartValues = series3} _
        }
    End Function
End Class

Public Class LineChartExampleDataEntry
    Implements IDisposable

    Public Property ID() As Integer
    Public Property ProductName() As String
    Public Property LineChartValues() As Series

    Public Sub Dispose() Implements IDisposable.Dispose
        LineChartValues = Nothing
        LineChartValues.Dispose()
    End Sub
End Class