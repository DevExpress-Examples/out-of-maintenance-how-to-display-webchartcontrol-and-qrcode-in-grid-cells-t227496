using System;
using System.Collections.Generic;
using DevExpress.XtraCharts;

public class LineChartData {
    public static List<LineChartExampleDataEntry> GetData() {
        Series series1 = new Series("Series 1", ViewType.Line);
        series1.ShowInLegend = false;
        series1.Points.Add(new SeriesPoint(1, 10));
        series1.Points.Add(new SeriesPoint(2, 5));
        series1.Points.Add(new SeriesPoint(3, 20));
        series1.Points.Add(new SeriesPoint(4, 13));

        Series series2 = new Series("Series 2", ViewType.Line);
        series2.ShowInLegend = false;
        series2.Points.Add(new SeriesPoint(1, 15));
        series2.Points.Add(new SeriesPoint(2, 2));
        series2.Points.Add(new SeriesPoint(3, 45));
        series2.Points.Add(new SeriesPoint(4, 12));

        Series series3 = new Series("Series 3", ViewType.Line);
        series3.ShowInLegend = false;
        series3.Points.Add(new SeriesPoint(1, 20));
        series3.Points.Add(new SeriesPoint(2, 1));
        series3.Points.Add(new SeriesPoint(3, 25));
        series3.Points.Add(new SeriesPoint(4, 10));

        return new List<LineChartExampleDataEntry> {
            new LineChartExampleDataEntry() {
                ID = 1,
                ProductName = "Product 1",
                LineChartValues = series1
            },
            new LineChartExampleDataEntry() {
                ID = 2,
                ProductName = "Product 2",
                LineChartValues = series2
            },
            new LineChartExampleDataEntry() {
                ID = 3,
                ProductName = "Product 3",
                LineChartValues = series3
            }
        };
    }
}

public class LineChartExampleDataEntry : IDisposable {
    public int ID { get; set; }
    public string ProductName { get; set; }
    public Series LineChartValues { get; set; }

    public void Dispose() {
        LineChartValues = null;
        LineChartValues.Dispose();
    }
}