Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.Win.Editors
Imports DevExpress.ExpressApp.Model

Namespace WinSolution.Module.Win
    Public Class RichEditPropertyEditor
        Inherits WinPropertyEditor
        Public Sub New(ByVal objectType As Type, ByVal info As IModelMemberViewItem)
            MyBase.New(objectType, info)
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
    End Class
End Namespace
