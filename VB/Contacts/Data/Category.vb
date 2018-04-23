Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace Contacts.Data

	Public Class Category
		Inherits XPObject
		Public Sub New()
			MyBase.New()
			' This constructor is used when an object is loaded from a persistent storage.
			' Do not place any code here.
		End Sub

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
			' This constructor is used when an object is loaded from a persistent storage.
			' Do not place any code here.
		End Sub

		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
			' Place here your initialization code.
		End Sub

		Private _Name As String
		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Name", _Name, value)
			End Set
		End Property

		Private _Description As String
		Public Property Description() As String
			Get
				Return _Description
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Description", _Description, value)
			End Set
		End Property

		Private _Added As DateTime
		Public Property Added() As DateTime
			Get
				Return _Added
			End Get
			Set(ByVal value As DateTime)
				SetPropertyValue("Added", _Added, value)
			End Set
		End Property

		Private _Modified As DateTime
		Public Property Modified() As DateTime
			Get
				Return _Modified
			End Get
			Set(ByVal value As DateTime)
				SetPropertyValue("Modified", _Modified, value)
			End Set
		End Property

		<Association("PersonCategory")> _
		Public ReadOnly Property Persons() As XPCollection(Of Person)
			Get
				Return GetCollection(Of Person)("Persons")
			End Get
		End Property

	End Class

End Namespace