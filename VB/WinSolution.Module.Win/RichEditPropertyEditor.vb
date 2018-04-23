Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.Win.Editors

Public Class RichEditPropertyEditor
    Inherits WinPropertyEditor
    Public Sub New(ByVal objectType As Type, ByVal info As DevExpress.ExpressApp.DictionaryNode)
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
        richEditUserControlCore.RichEditControl.ReadOnly = [ReadOnly]
        Return richEditUserControlCore
    End Function
    Protected Overrides Sub OnReadOnlyChanged()
        MyBase.OnReadOnlyChanged()
        If RichEditUserControl IsNot Nothing Then
            RichEditUserControl.RichEditControl.ReadOnly = [ReadOnly]
        End If
    End Sub
End Class