Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports DevExpress.ExpressApp
Imports System.Reflection


Namespace WinSolution.Module
	Public NotInheritable Partial Class WinSolutionModule
		Inherits ModuleBase
		Public Sub New()
			DevExpress.ExpressApp.Demos.InMemoryDataStoreProvider.Register()
			InitializeComponent()
		End Sub
	End Class
End Namespace
