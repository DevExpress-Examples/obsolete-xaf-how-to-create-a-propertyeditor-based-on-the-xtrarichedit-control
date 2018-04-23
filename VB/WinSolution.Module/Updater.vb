Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp.Updating

Namespace WinSolution.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal session As Session, ByVal currentDBVersion As Version)
			MyBase.New(session, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			Dim doc As New Document(Session)
			doc.Subject = "RichEditAbout.rtf"
			Dim rtfStreamReader As New StreamReader(Me.GetType().Assembly.GetManifestResourceStream("" & doc.Subject))
			doc.Text = rtfStreamReader.ReadToEnd()
			doc.Save()
		End Sub
	End Class
End Namespace
