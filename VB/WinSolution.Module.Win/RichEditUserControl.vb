Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraBars.Ribbon

Public Class RichEditUserControl
    Public ReadOnly Property RichEditControl() As RichEditControl
        Get
            Return Me.RichEditControl1
        End Get
    End Property
    Public ReadOnly Property RibbonControl() As RibbonControl
        Get
            Return Me.RibbonControl1
        End Get
    End Property
    Public Property RtfText() As String
        Get
            If RichEditControl1 IsNot Nothing Then
                Return RichEditControl1.RtfText
            End If
            Return String.Empty
        End Get
        Set(ByVal value As String)
            If RichEditControl1 IsNot Nothing Then
                RichEditControl1.RtfText = value
            End If
        End Set
    End Property

End Class
