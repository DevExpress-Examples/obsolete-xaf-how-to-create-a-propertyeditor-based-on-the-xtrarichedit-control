Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraBars.Ribbon

Namespace WinSolution.Module.Win
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
				If richEditControl_Renamed IsNot Nothing Then
					Return richEditControl_Renamed.RtfText
				End If
				Return String.Empty
			End Get
			Set(ByVal value As String)
				If richEditControl_Renamed IsNot Nothing Then
					richEditControl_Renamed.RtfText = value
				End If
			End Set
		End Property
	End Class
End Namespace