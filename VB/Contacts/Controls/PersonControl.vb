Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports Contacts.Data
Imports DevExpress.Xpo
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace Contacts.Controls
	Partial Public Class PersonControl
		Inherits XtraUserControl
		Implements IControl
		#Region "Properties"
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
				Return TabType.Person
			End Get
		End Property

		Private _IsLoaded As Boolean
		Public ReadOnly Property IsLoaded() As Boolean
			Get
				Return _IsLoaded
			End Get
		End Property

		Public ReadOnly Property Person() As Person
			Get
				Return TryCast(collectionPerson(0), Person)
			End Get
		End Property

		Private privateCategories As XPCollection(Of Category)
		Public Property Categories() As XPCollection(Of Category)
			Get
				Return privateCategories
			End Get
			Set(ByVal value As XPCollection(Of Category))
				privateCategories = value
			End Set
		End Property

		Private privateIsDirty As Boolean
        Public ReadOnly Property IsDirty() As Boolean Implements IControl.IsDirty
            Get
                Return privateIsDirty
            End Get
        End Property

		Public ReadOnly Property Title() As String
			Get
				If _IsLoaded Then

					Return Person.Greeting
				Else
					Return String.Empty
				End If
			End Get
		End Property
		#End Region

		Public Sub New()
			_IsLoaded = False
			InitializeComponent()
            privateIsDirty = False
		End Sub

		#Region "Person Logic"
		''' <summary>
		''' Load a person
		''' </summary>
		''' <param name="p">Person to load</param>
		Public Sub LoadData(ByVal p As Person, Optional ByVal categories As XPCollection = Nothing)
			If categories Is Nothing Then
                categories = New XPCollection(collectionCategories)
			Else
                categories = New XPCollection(categories)
			End If

			Categories.LoadingEnabled = True
			checkedList.DataSource = Categories


			collectionPerson.Add(p)
			If p.Oid < 0 Then
				p.Added = DateTime.Now
				p.Modified = p.Added
				layoutImage.Text = "Picture"
			Else
				layoutImage.Text = Person.Greeting.Replace("&", "and")
				LoadCategories()
			End If

			Id = p.Oid
			AddHandler p.Changed, AddressOf person_Changed
            privateIsDirty = False
			_IsLoaded = True
		End Sub

		''' <summary>
		''' Saves current person
		''' </summary>
		''' <returns>Oid of Person</returns>
		Public Sub Save() Implements IControl.Save
			layoutPerson.Focus()
			SaveCategories()
			layoutImage.Text = Person.Greeting.Replace("&", "and")
			Person.Modified = DateTime.Now
			Person.Save()
			Id = Person.Oid
            privateIsDirty = False
		End Sub

		''' <summary>
		''' Reload Current
		''' </summary>
		Public Sub Reload() Implements IControl.Reload
			layoutPerson.Focus()
			Person.Reload()
			LoadCategories()
			checkedList.Refresh()
			Refresh()
            privateIsDirty = False
		End Sub

		''' <summary>
		''' Load Categories
		''' </summary>
		Private Sub LoadCategories()
			checkedList.UnCheckAll()

			Dim indices = ( _
					From c In Categories.Zip(Enumerable.Range(0, Categories.Count), Function(c, i) New With {Key .Category = c, Key .Index = i}) _
					Where Person.Categories.Contains(c.Category) _
					Select c.Index).ToArray()

			For Each index In indices
				checkedList.SetItemChecked(index, True)
			Next index

		End Sub

		''' <summary>
		''' Save Categories
		''' </summary>
		Private Sub SaveCategories()
			For i As Integer = 0 To Categories.Count - 1
				Dim containsItem As Boolean = Person.Categories.Contains(Categories(i))
				If checkedList.GetItemChecked(i) AndAlso (Not containsItem) Then
					Person.Categories.Add(Categories(i))
				End If

				If (Not checkedList.GetItemChecked(i)) AndAlso containsItem Then
					Person.Categories.Remove(Categories(i))
				End If
			Next i
		End Sub

		''' <summary>
		''' Delete current
		''' </summary>
		''' <returns>Oid of deleted ite,</returns>
		Public Function Delete() As Integer Implements IControl.Delete
			Dim id As Integer = Person.Oid
			Person.Delete()
			Return id
		End Function
		#End Region

		#Region "Events"
		Private Sub person_Changed(ByVal sender As Object, ByVal e As ObjectChangeEventArgs)
			If e.PropertyName IsNot Nothing Then
                privateIsDirty = True
			End If
		End Sub

		Private Sub imagePerson_Click(ByVal sender As Object, ByVal e As EventArgs) Handles imagePerson.Click
			If dialogOpen.ShowDialog() = DialogResult.OK Then
				Dim img = Image.FromFile(dialogOpen.FileName)
				imagePerson.EditValue = img
				imagePerson.Update()
				Refresh()
			End If
		End Sub

		Private Sub buttonAddCategory_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAddCategory.Click
			Dim cat As Category = New Category With {.Name = textCategoryName.Text, .Description = textCategoryDescription.Text, .Added = DateTime.Now, .Modified = DateTime.Now}

			cat.Save()
			Categories.Add(cat)

			Dim index = Categories.BaseIndexOf(cat)
			LoadCategories()
			checkedList.SetItemChecked(index, True)

			textCategoryName.Text = ""
			textCategoryDescription.Text = ""
		End Sub

		Private Sub buttonDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonDelete.Click
			If checkedList.SelectedIndex > -1 Then
				Categories(checkedList.SelectedIndex).Delete()
				LoadCategories()
			End If
		End Sub
		#End Region
	End Class
End Namespace
