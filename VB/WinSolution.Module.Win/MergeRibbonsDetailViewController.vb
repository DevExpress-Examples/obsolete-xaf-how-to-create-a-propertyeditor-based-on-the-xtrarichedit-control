Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports System.Collections.Generic
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.ExpressApp.Win.Templates.ActionContainers

Namespace WinSolution.Module.Win
	Public Class MergeRibbonsViewController
		Inherits ViewController(Of DetailView)
		Private editor As RichEditPropertyEditor
		Private mainRibbonControl As RibbonControl
		Protected Overrides Overloads Sub OnFrameAssigned()
			MyBase.OnFrameAssigned()
			AddHandler Frame.TemplateChanged, AddressOf Frame_TemplateChanged
		End Sub
		Private Sub UnMergeRibbon()
			If mainRibbonControl IsNot Nothing Then
				mainRibbonControl.UnMergeRibbon()
			End If
		End Sub
		Private Sub Frame_TemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnMergeRibbon()
			mainRibbonControl = Nothing
			Dim form As IClassicToRibbonTransformerHolder = TryCast(Frame.Template, IClassicToRibbonTransformerHolder)
			If form IsNot Nothing Then
				AddHandler form.RibbonTransformer.Transformed, AddressOf RibbonTransformer_Transformed
			End If
		End Sub
		Private Sub RibbonTransformer_Transformed(ByVal sender As Object, ByVal e As EventArgs)
			Dim transformer As ClassicToRibbonTransformer = CType(sender, ClassicToRibbonTransformer)
			RemoveHandler transformer.Transformed, AddressOf RibbonTransformer_Transformed
			mainRibbonControl = transformer.Ribbon
			CheckForMerge()
		End Sub
		Private Sub CheckForMerge()
			If editor IsNot Nothing AndAlso mainRibbonControl IsNot Nothing Then
				mainRibbonControl.MergeRibbon(editor.RichEditUserControl.RibbonControl)
			End If
		End Sub
		Protected Overrides Overloads Sub OnViewControlsCreated()
			MyBase.OnViewControlsCreated()
			Dim editors As IList(Of RichEditPropertyEditor) = View.GetItems(Of RichEditPropertyEditor)()
			If editors.Count > 0 Then
				editor = editors(0)
				CheckForMerge()
			End If
		End Sub
		Protected Overrides Overloads Sub OnDeactivated()
			MyBase.OnDeactivated()
			UnMergeRibbon()
			editor = Nothing
		End Sub
	End Class
End Namespace