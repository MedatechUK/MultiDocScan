Public Class iDocument : Inherits List(Of System.Drawing.Image)

    Private _barcode As String

    Public ReadOnly Property scan_type_code() As String
        Get
            Return _barcode.Substring(0, 5).Replace(" ", "")
        End Get
    End Property

    Public ReadOnly Property scan_doc_code() As String
        Get
            Return _barcode.Substring(6).Replace(" ", "")
        End Get
    End Property

    Public Sub New(ByVal Barcode As String)
        _barcode = Barcode
    End Sub

End Class
