Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.ExpressApp
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.RibbonUI.Win.Templates

Namespace WinSolution.Module.Win
    Public Class MergeRibbonsDetailViewController
        Inherits ViewController
        Public Sub New()
            TargetViewType = ViewType.DetailView
        End Sub
        Protected Overloads Overrides Sub OnViewControlsCreated()
            MyBase.OnViewControlsCreated()
            AddHandler (CType(View.Control, Control)).HandleCreated, AddressOf Control_HandleCreated
        End Sub
        Private Sub Control_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim control As Control = CType(sender, Control)
            RemoveHandler control.HandleCreated, AddressOf Control_HandleCreated
            Dim editors As IList(Of RichEditPropertyEditor) = (CType(View, DetailView)).GetItems(Of RichEditPropertyEditor)()
            If editors.Count > 0 Then
                Dim richEditUserControl As RichEditUserControl = CType(editors(0).Control, RichEditUserControl)
                Dim ribbonForm As RibbonDetailViewForm = CType(control.FindForm(), RibbonDetailViewForm)
                ribbonForm.RibbonControl.MergeRibbon(richEditUserControl.RibbonControl)
                ribbonForm.RibbonControl.ForceInitialize()
            End If
        End Sub
    End Class
End Namespace