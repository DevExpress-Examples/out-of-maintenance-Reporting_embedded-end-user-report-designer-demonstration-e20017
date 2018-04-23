Imports Microsoft.VisualBasic
Imports System

Namespace Contacts.Controls
	Public Enum TabType
		PersonList
		Person
		Preview
		Editor
	End Enum

	Public Interface IControl
		Property Id() As Integer
		ReadOnly Property IsDirty() As Boolean
        Sub Save()
		Sub Reload()
		Function Delete() As Integer
		ReadOnly Property TabType() As TabType
	End Interface
End Namespace
