using System;
using System.Drawing;
using System.Text;
using DevExpress.BarCodes;
using DevExpress.Web;

public partial class QRCodeImage : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsCallback && !IsPostBack)
            ASPxGridView1.DataBind();
    }
    protected void ASPxGridView1_DataBinding(object sender, EventArgs e) {
        ASPxGridView1.DataSource = QRCodeData.GetData();
    }
    protected void ASPxGridView1_CustomUnboundColumnData(object sender, ASPxGridViewColumnDataEventArgs e) {
        if(e.Column.FieldName == "QRCodeValueUnbound") {
            string barCodeText = e.GetListSourceFieldValue("QRCodeValue").ToString();
            BarCode barCode = new BarCode() { Symbology = Symbology.QRCode, CodeBinaryData = Encoding.Default.GetBytes(barCodeText) };
            ImageConverter converter = new ImageConverter();
            e.Value = (byte[])converter.ConvertTo(barCode.BarCodeImage, typeof(byte[]));
        }
    }
    protected void ASPxButton1_Click(object sender, EventArgs e) {
        ASPxGridViewExporter1.WritePdfToResponse();
    }
}