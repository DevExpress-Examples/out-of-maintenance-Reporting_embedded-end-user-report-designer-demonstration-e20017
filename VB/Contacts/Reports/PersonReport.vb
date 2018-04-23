Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.Xpo
Imports Contacts.Data

Namespace Contacts.Reports
	Partial Public Class PersonReport
		Inherits XtraReport
		Implements IReport
		Public Sub New()
			InitializeComponent()
		End Sub


		Public Sub LoadDataSource() Implements IReport.LoadDataSource
			DataSource = New XPCollection(Of Person)()
		End Sub
	End Class
End Namespace
