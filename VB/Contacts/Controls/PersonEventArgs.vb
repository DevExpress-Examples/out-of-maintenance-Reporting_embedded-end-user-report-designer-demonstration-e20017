Imports Microsoft.VisualBasic
Imports System
Imports Contacts.Data

Namespace Contacts.Controls
	Public Class PersonEventArgs
		Inherits EventArgs
		Private privatePerson As Person
		Public Property Person() As Person
			Get
				Return privatePerson
			End Get
			Set(ByVal value As Person)
				privatePerson = value
			End Set
		End Property
		Public Sub New(ByVal p As Person)
			Person = p
		End Sub
	End Class
End Namespace
