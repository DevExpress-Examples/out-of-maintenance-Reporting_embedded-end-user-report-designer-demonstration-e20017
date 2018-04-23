Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Imaging

Namespace Contacts.Data

	Public Class Person
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

		Private _Greeting As String
		Public Property Greeting() As String
			Get
				Return _Greeting
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Greeting", _Greeting, value)
			End Set
		End Property

		<DisplayName("First Name")> _
		Private _FirstName As String
		Public Property FirstName() As String
			Get
				Return _FirstName
			End Get
			Set(ByVal value As String)
				SetPropertyValue("FirstName", _FirstName, value)
			End Set
		End Property

		<DisplayName("Last Name")> _
		Private _LastName As String
		Public Property LastName() As String
			Get
				Return _LastName
			End Get
			Set(ByVal value As String)
				SetPropertyValue("LastName", _LastName, value)
			End Set
		End Property

		Private _Address As String
		Public Property Address() As String
			Get
				Return _Address
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Address", _Address, value)
			End Set
		End Property

		Private _City As String
		Public Property City() As String
			Get
				Return _City
			End Get
			Set(ByVal value As String)
				SetPropertyValue("City", _City, value)
			End Set
		End Property

		Private _State As String
		Public Property State() As String
			Get
				Return _State
			End Get
			Set(ByVal value As String)
				SetPropertyValue("State", _State, value)
			End Set
		End Property

		Private _Zip As Integer
		Public Property Zip() As Integer
			Get
				Return _Zip
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue("Zip", _Zip, value)
			End Set
		End Property

		Private _Picture() As Byte
		Public Property Picture() As Byte()
			Get
				Return _Picture
			End Get
			Set(ByVal value As Byte())
				SetPropertyValue("Picture", _Picture, value)
			End Set
		End Property

		<NonPersistent> _
		Public Property Image() As Image
			Get
				If Picture Is Nothing OrElse Picture.Length = 0 Then
					Return Nothing
				Else
					Return Image.FromStream(New MemoryStream(Picture))
				End If
			End Get
			Set(ByVal value As Image)
				Using m As New MemoryStream()
					value.Save(m, ImageFormat.Png)
					_Picture = m.ToArray()
				End Using
			End Set
		End Property

		Private _Notes As String
		Public Property Notes() As String
			Get
				Return _Notes
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Notes", _Notes, value)
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
		Public ReadOnly Property Categories() As XPCollection(Of Category)
			Get
				Return GetCollection(Of Category)("Categories")
			End Get
		End Property

	End Class
End Namespace