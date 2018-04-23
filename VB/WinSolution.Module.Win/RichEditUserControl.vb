Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit


	Partial Public Class RichEditUserControl
		Inherits XtraUserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Public ReadOnly Property RichEditControl() As RichEditControl
			Get
				Return Me.richEditControl_Renamed
			End Get
		End Property
		Public ReadOnly Property RibbonControl() As RibbonControl
			Get
				Return Me.ribbonControl1
			End Get
		End Property
		Public Property RtfText() As String
			Get
				Return richEditControl_Renamed.RtfText
			End Get

			Set(ByVal value As String)
				richEditControl_Renamed.RtfText = value
			End Set
		End Property
	End Class
