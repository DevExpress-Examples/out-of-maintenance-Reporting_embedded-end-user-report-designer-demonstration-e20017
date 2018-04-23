Imports Microsoft.VisualBasic
Imports System
Imports Contacts.Data
Imports DevExpress.XtraEditors

Namespace Contacts.Controls
	Partial Public Class PersonListControl
		Inherits XtraUserControl
		Implements IControl
		#Region "Properties/Events"
		Private privateId As Integer
		Public Property Id() As Integer Implements IControl.Id
			Get
				Return privateId
			End Get
			Set(ByVal value As Integer)
				privateId = value
			End Set
		End Property
		Public ReadOnly Property TabType() As TabType Implements IControl.TabType
			Get
				Return TabType.PersonList
			End Get
		End Property
		' Never dirty!
		Public ReadOnly Property IsDirty() As Boolean Implements IControl.IsDirty
			Get
				Return False
			End Get
		End Property

		Public Delegate Sub PersonClickEventHandler(ByVal sender As Object, ByVal e As PersonEventArgs)
		Public Event PersonClicked As PersonClickEventHandler
		Protected Overridable Sub OnPersonClick(ByVal e As PersonEventArgs)
			RaiseEvent PersonClicked(Me, e)
		End Sub
		#End Region

		Public Sub New()
			InitializeComponent()
			Id = -1
		End Sub

		#Region "Person List Logic"
		''' <summary>
		''' Save grid, nothing to do here...
		''' </summary>
		Public Sub Save() Implements IControl.Save

		End Sub

		''' <summary>
		''' Reload Grid
		''' </summary>
		Public Sub Reload() Implements IControl.Reload
			collectionPersons.Reload()
		End Sub

		''' <summary>
		''' Removed focused person
		''' </summary>
		''' <returns>Oid of deleted person</returns>
		Public Function Delete() As Integer Implements IControl.Delete
			If gridViewPerson.SelectedRowsCount = 1 Then
				Dim handle As Integer = gridViewPerson.GetDataSourceRowIndex(gridViewPerson.GetSelectedRows()(0))
				Dim oid As Integer = (TryCast(collectionPersons(handle), Person)).Oid
				gridViewPerson.DeleteRow(handle)
				Return oid
			Else
				Return -1
			End If
		End Function
		#End Region

		#Region "Events"
		Private Sub gridViewPerson_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles gridViewPerson.DoubleClick
			If gridViewPerson.SelectedRowsCount = 1 Then
				Dim p = TryCast(collectionPersons(gridViewPerson.GetDataSourceRowIndex(gridViewPerson.GetSelectedRows()(0))), Person)
				OnPersonClick(New PersonEventArgs(p))
			End If
		End Sub
		#End Region
	End Class
End Namespace