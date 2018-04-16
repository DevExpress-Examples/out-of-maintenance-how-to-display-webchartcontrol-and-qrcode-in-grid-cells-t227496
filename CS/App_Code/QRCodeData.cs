using System;
using System.Collections.Generic;

public class QRCodeData {
    public static List<QRCodeExampleDataEntry> GetData() {
        return new List<QRCodeExampleDataEntry> {
            new QRCodeExampleDataEntry() {
                ID = 1,
                ProductName = "DevExpress Home",
                QRCodeValue = "http://www.devexpress.com/"
            },
            new QRCodeExampleDataEntry() {
                ID = 2,
                ProductName = "DevExpress Support Center",
                QRCodeValue = "http://www.devexpress.com/sc"
            },
            new QRCodeExampleDataEntry() {
                ID = 3,
                ProductName = "DevExpress Help",
                QRCodeValue = "http://help.devexpress.com"
            }
        };
    }
}

public class QRCodeExampleDataEntry {
    public int ID { get; set; }
    public string ProductName { get; set; }
    public string QRCodeValue { get; set; }
}