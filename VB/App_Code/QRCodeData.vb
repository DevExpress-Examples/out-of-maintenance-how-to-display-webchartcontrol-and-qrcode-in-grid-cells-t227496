Imports System
Imports System.Collections.Generic

Public Class QRCodeData
    Public Shared Function GetData() As List(Of QRCodeExampleDataEntry)
        Return New List(Of QRCodeExampleDataEntry) From { _
            New QRCodeExampleDataEntry() With {.ID = 1, .ProductName = "DevExpress Home", .QRCodeValue = "http://www.devexpress.com/"}, _
            New QRCodeExampleDataEntry() With {.ID = 2, .ProductName = "DevExpress Support Center", .QRCodeValue = "http://www.devexpress.com/sc"}, _
            New QRCodeExampleDataEntry() With {.ID = 3, .ProductName = "DevExpress Help", .QRCodeValue = "http://help.devexpress.com"} _
        }
    End Function
End Class

Public Class QRCodeExampleDataEntry
    Public Property ID() As Integer
    Public Property ProductName() As String
    Public Property QRCodeValue() As String
End Class