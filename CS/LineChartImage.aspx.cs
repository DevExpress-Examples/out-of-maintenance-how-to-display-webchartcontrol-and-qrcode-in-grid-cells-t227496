using DevExpress.XtraCharts;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

public partial class LineChartImage : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsCallback && !IsPostBack)
            ASPxGridView1.DataBind();
    }
    protected void ASPxGridView1_DataBinding(object sender, EventArgs e) {
        ASPxGridView1.DataSource = LineChartData.GetData();
    }
    protected void ASPxGridView1_CustomUnboundColumnData(object sender, DevExpress.Web.ASPxGridViewColumnDataEventArgs e) {
        if(e.Column.FieldName == "LineChartValueUnbound") {
            Series seriesValue = (Series)e.GetListSourceFieldValue("LineChartValues");
            WebChartControl1.Series.Clear();
            WebChartControl1.Series.Add(seriesValue);
            using(MemoryStream s = new MemoryStream()) {
                WebChartControl1.ExportToImage(s, ImageFormat.Jpeg);
                Bitmap bitmap = (Bitmap)Image.FromStream(s);
                ImageConverter converter = new ImageConverter();
                e.Value = (byte[])converter.ConvertTo(bitmap, typeof(byte[]));
            }
        }
    }
    protected void ASPxButton1_Click(object sender, EventArgs e) {
        ASPxGridViewExporter1.WritePdfToResponse();
    }
}