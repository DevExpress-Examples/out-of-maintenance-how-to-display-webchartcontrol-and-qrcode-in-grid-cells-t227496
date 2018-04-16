using System;
using System.Drawing;
using System.Text;
using System.Web.UI;
using DevExpress.BarCodes;
using DevExpress.Web;

public partial class QRCodeTemplate : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsCallback && !IsPostBack)
            ASPxGridView1.DataBind();
    }
    protected void ASPxGridView1_DataBinding(object sender, EventArgs e) {
        ASPxGridView1.DataSource = QRCodeData.GetData();
    }
    protected void ASPxBunaryImage1_Init(object sender, EventArgs e) {
        ASPxBinaryImage biControl = (ASPxBinaryImage)sender;
        GridViewDataItemTemplateContainer container = (GridViewDataItemTemplateContainer)biControl.NamingContainer;
        string barCodeText = (string)container.Grid.GetRowValues(container.VisibleIndex, "QRCodeValue");
        BarCode barCode = new BarCode() { Symbology = Symbology.QRCode, CodeBinaryData = Encoding.Default.GetBytes(barCodeText) };
        ImageConverter converter = new ImageConverter();
        biControl.ContentBytes = (byte[])converter.ConvertTo(barCode.BarCodeImage, typeof(byte[]));
    }
}