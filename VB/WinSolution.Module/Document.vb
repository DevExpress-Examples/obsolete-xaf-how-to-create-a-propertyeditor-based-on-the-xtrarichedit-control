Imports Microsoft.VisualBasic
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports System.ComponentModel

Namespace WinSolution.Module
	<DefaultClassOptions, DefaultProperty("Subject")> _
	Public Class Document
		Inherits Note
		Friend Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _Subject As String
		Public Property Subject() As String
			Get
				Return _Subject
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Subject", _Subject, value)
			End Set
		End Property
	End Class
End Namespace
