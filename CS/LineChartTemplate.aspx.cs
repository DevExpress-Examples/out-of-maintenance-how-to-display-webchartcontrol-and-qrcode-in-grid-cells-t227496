using System;
using DevExpress.Web;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class LineChartTemplate : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsCallback && !IsPostBack)
            ASPxGridView1.DataBind();
    }
    protected void ASPxGridView1_DataBinding(object sender, EventArgs e) {
        ASPxGridView1.DataSource = LineChartData.GetData();
    }
    protected void WebChartControl1_Init(object sender, EventArgs e) {
        WebChartControl chart = (WebChartControl)sender;
        GridViewDataItemTemplateContainer container = (GridViewDataItemTemplateContainer)chart.NamingContainer;
        chart.Series.Add((Series)container.Grid.GetRowValues(container.VisibleIndex, "LineChartValues"));
    }
}