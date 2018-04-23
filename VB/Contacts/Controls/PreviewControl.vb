Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports Contacts.Reports

Namespace Contacts.Controls
	Partial Public Class PreviewControl
		Inherits XtraUserControl
		Implements IControl
		Private _url As String
		Public Sub New(Optional ByVal url As String = Nothing)
			InitializeComponent()
			_url = url
		End Sub


		Private privateId As Integer
		Public Property Id() As Integer Implements IControl.Id
			Get
				Return privateId
			End Get
			Set(ByVal value As Integer)
				privateId = value
			End Set
		End Property

		Public ReadOnly Property IsDirty() As Boolean Implements IControl.IsDirty
			Get
				Return True
			End Get
		End Property

		Public Sub Save() Implements IControl.Save
			Return
		End Sub

		Public Sub Reload() Implements IControl.Reload
			If _url IsNot Nothing Then
				Dim report = XtraReport.FromFile(_url, True)
				If TypeOf report Is IReport Then
					TryCast(report, IReport).LoadDataSource()
				End If
				printControl1.PrintingSystem = report.PrintingSystem
				report.CreateDocument()
			End If
		End Sub

		Public Function Delete() As Integer Implements IControl.Delete
			Return -1
		End Function

		Public ReadOnly Property TabType() As TabType Implements IControl.TabType
			Get
				Return TabType.Preview
			End Get
		End Property

	End Class
End Namespace
