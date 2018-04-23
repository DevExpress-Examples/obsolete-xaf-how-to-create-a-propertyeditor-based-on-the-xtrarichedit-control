Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.Win.Editors
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.XtraEditors.Repository

Namespace WinSolution.Module.Win
	<PropertyEditor(GetType(String), "RTF", False)> _
	Public Class RichEditPropertyEditor
		Inherits WinPropertyEditor
		Implements IInplaceEditSupport
		Public Sub New(ByVal objectType As Type, ByVal model As IModelMemberViewItem)
			MyBase.New(objectType, model)
			ControlBindingProperty = "RtfText"
		End Sub
		Private richEditUserControlCore As RichEditUserControl = Nothing
		Public ReadOnly Property RichEditUserControl() As RichEditUserControl
			Get
				Return richEditUserControlCore
			End Get
		End Property
		Protected Overrides Function CreateControlCore() As Object
			richEditUserControlCore = New RichEditUserControl()
			UpdateReadOnly()
			Return richEditUserControlCore
		End Function
		Protected Overrides Sub OnAllowEditChanged()
			MyBase.OnAllowEditChanged()
			UpdateReadOnly()
		End Sub
		Private Sub UpdateReadOnly()
			If RichEditUserControl IsNot Nothing AndAlso RichEditUserControl.RichEditControl IsNot Nothing Then
				RichEditUserControl.RichEditControl.ReadOnly = Not AllowEdit
			End If
		End Sub

		#Region "IInplaceEditSupport Members"

		Public Function CreateRepositoryItem() As DevExpress.XtraEditors.Repository.RepositoryItem Implements IInplaceEditSupport.CreateRepositoryItem
			Return New RepositoryItemRtfEditEx()
		End Function

		#End Region
	End Class
End Namespace