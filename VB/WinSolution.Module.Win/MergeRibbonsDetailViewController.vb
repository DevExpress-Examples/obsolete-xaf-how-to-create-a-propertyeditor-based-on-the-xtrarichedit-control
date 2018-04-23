Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.RibbonUI.Win.Templates

Public Class MergeRibbonsDetailViewController
    Inherits ViewController
    Public Sub New()
        TargetViewType = ViewType.DetailView
    End Sub
    Protected Overrides Sub OnViewControlsCreated()
        MyBase.OnViewControlsCreated()
        Dim editors As IList(Of RichEditPropertyEditor) = (CType(View, DetailView)).GetItems(Of RichEditPropertyEditor)()
        If editors.Count > 0 Then
            Dim richeditControl As RichEditUserControl = CType(editors(0).Control, RichEditUserControl)
            Dim ribbonForm As RibbonDetailViewForm = CType(Me.Frame.Template, RibbonDetailViewForm)
            ribbonForm.RibbonControl.MergeRibbon(richeditControl.RibbonControl)
            ribbonForm.RibbonControl.ForceInitialize()
        End If
    End Sub
End Class