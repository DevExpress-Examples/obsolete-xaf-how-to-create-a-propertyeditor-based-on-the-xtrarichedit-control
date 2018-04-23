Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering

Namespace WinSolution.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			If ObjectSpace.FindObject(Of Document)(New BinaryOperator("Subject", "RichEditAbout.rtf")) Is Nothing Then
				Dim doc As Document = ObjectSpace.CreateObject(Of Document)()
				doc.Subject = "RichEditAbout.rtf"
				Dim rtfStreamReader As New StreamReader(Me.GetType().Assembly.GetManifestResourceStream("" & doc.Subject))
				doc.Text = rtfStreamReader.ReadToEnd()
				doc.Save()
			End If
		End Sub
	End Class
End Namespace
