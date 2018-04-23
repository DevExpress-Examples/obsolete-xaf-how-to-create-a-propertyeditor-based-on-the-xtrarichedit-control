Imports System
Imports DevExpress.ExpressApp
Imports System.Collections.Generic
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.ExpressApp.Win.Templates.ActionContainers
Imports DevExpress.ExpressApp.Win.Templates

Namespace WinSolution.Module.Win
	Public Class MergeRibbonsViewController
		Inherits ViewController(Of DetailView)

		Private editorWithRibbon As RichEditPropertyEditor
		Protected Overrides Sub OnFrameAssigned()
			MyBase.OnFrameAssigned()
			AddHandler Frame.TemplateChanged, AddressOf Frame_TemplateChanged
		End Sub
		Protected Overrides Sub OnDeactivated()
			AddHandler Frame.TemplateChanged, AddressOf Frame_TemplateChanged
			UnMergeRibbon()
			editorWithRibbon = Nothing
			MyBase.OnDeactivated()
		End Sub
		Protected Overrides Sub OnViewControlsCreated()
			MyBase.OnViewControlsCreated()
			Dim editors As IList(Of RichEditPropertyEditor) = View.GetItems(Of RichEditPropertyEditor)()
			If editors.Count > 0 Then
				editorWithRibbon = editors(0)
				MergeRibbons()
			End If
		End Sub
		Protected ReadOnly Property MainWindowRibbon() As RibbonControl
			Get
				If Application.MainWindow IsNot Nothing AndAlso Application.MainWindow.Template IsNot Nothing Then
					Return DirectCast(Application.MainWindow.Template, XtraFormTemplateBase).Ribbon
				End If
				Return Nothing
			End Get
		End Property
		Private Sub UnMergeRibbon()
			If MainWindowRibbon IsNot Nothing Then
				MainWindowRibbon.UnMergeRibbon()
			End If
		End Sub
		Private Sub Frame_TemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnMergeRibbon()
			Dim form As IClassicToRibbonTransformerHolder = TryCast(Frame.Template, IClassicToRibbonTransformerHolder)
			If form IsNot Nothing Then
				AddHandler form.RibbonTransformer.Transformed, AddressOf RibbonTransformer_Transformed
			End If
		End Sub
		Private Sub RibbonTransformer_Transformed(ByVal sender As Object, ByVal e As EventArgs)
			Dim transformer As ClassicToRibbonTransformer = DirectCast(sender, ClassicToRibbonTransformer)
			RemoveHandler transformer.Transformed, AddressOf RibbonTransformer_Transformed
			MergeRibbons()
		End Sub
		Private Sub MergeRibbons()
			If editorWithRibbon IsNot Nothing AndAlso (MainWindowRibbon IsNot Nothing) AndAlso (editorWithRibbon.RichEditUserControl IsNot Nothing) Then
				MainWindowRibbon.MergeRibbon(editorWithRibbon.RichEditUserControl.RibbonControl)
			End If
		End Sub
	End Class
End Namespace