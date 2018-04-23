Imports Microsoft.VisualBasic
Imports System
Namespace Contacts.Controls
	Partial Public Class PersonListControl
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridPerson = New DevExpress.XtraGrid.GridControl()
			Me.collectionPersons = New DevExpress.Xpo.XPCollection()
			Me.gridViewPerson = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colGreeting = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryImage = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.colModified = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.gridPerson, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.collectionPersons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridViewPerson, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryImage, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridPerson
			' 
			Me.gridPerson.DataSource = Me.collectionPersons
			Me.gridPerson.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridPerson.Location = New System.Drawing.Point(0, 0)
			Me.gridPerson.MainView = Me.gridViewPerson
			Me.gridPerson.Name = "gridPerson"
			Me.gridPerson.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryImage})
			Me.gridPerson.ShowOnlyPredefinedDetails = True
			Me.gridPerson.Size = New System.Drawing.Size(650, 433)
			Me.gridPerson.TabIndex = 0
			Me.gridPerson.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridViewPerson})
			' 
			' collectionPersons
			' 
			Me.collectionPersons.DeleteObjectOnRemove = True
			Me.collectionPersons.ObjectType = GetType(Contacts.Data.Person)
			' 
			' gridViewPerson
			' 
			Me.gridViewPerson.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colGreeting, Me.colCity, Me.colState, Me.colImage, Me.colModified})
			Me.gridViewPerson.GridControl = Me.gridPerson
			Me.gridViewPerson.Name = "gridViewPerson"
			Me.gridViewPerson.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
			Me.gridViewPerson.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True
			Me.gridViewPerson.OptionsBehavior.Editable = False
			Me.gridViewPerson.OptionsBehavior.ReadOnly = True
			Me.gridViewPerson.RowHeight = 50
'			Me.gridViewPerson.DoubleClick += New System.EventHandler(Me.gridViewPerson_DoubleClick);
			' 
			' colGreeting
			' 
			Me.colGreeting.FieldName = "Greeting"
			Me.colGreeting.Name = "colGreeting"
			Me.colGreeting.Visible = True
			Me.colGreeting.VisibleIndex = 0
			' 
			' colCity
			' 
			Me.colCity.FieldName = "City"
			Me.colCity.Name = "colCity"
			Me.colCity.Visible = True
			Me.colCity.VisibleIndex = 1
			' 
			' colState
			' 
			Me.colState.FieldName = "State"
			Me.colState.Name = "colState"
			Me.colState.Visible = True
			Me.colState.VisibleIndex = 2
			' 
			' colImage
			' 
			Me.colImage.ColumnEdit = Me.repositoryImage
			Me.colImage.FieldName = "Image"
			Me.colImage.Name = "colImage"
			Me.colImage.OptionsColumn.ReadOnly = True
			Me.colImage.Visible = True
			Me.colImage.VisibleIndex = 3
			' 
			' repositoryImage
			' 
			Me.repositoryImage.CustomHeight = 50
			Me.repositoryImage.Name = "repositoryImage"
			Me.repositoryImage.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			' 
			' colModified
			' 
			Me.colModified.DisplayFormat.FormatString = "g"
			Me.colModified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
			Me.colModified.FieldName = "Modified"
			Me.colModified.Name = "colModified"
			Me.colModified.Visible = True
			Me.colModified.VisibleIndex = 4
			' 
			' PersonListControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridPerson)
			Me.Name = "PersonListControl"
			Me.Size = New System.Drawing.Size(650, 433)
			CType(Me.gridPerson, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.collectionPersons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridViewPerson, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryImage, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridPerson As DevExpress.XtraGrid.GridControl
		Private WithEvents gridViewPerson As DevExpress.XtraGrid.Views.Grid.GridView
		Private colGreeting As DevExpress.XtraGrid.Columns.GridColumn
		Private colCity As DevExpress.XtraGrid.Columns.GridColumn
		Private colState As DevExpress.XtraGrid.Columns.GridColumn
		Private colImage As DevExpress.XtraGrid.Columns.GridColumn
		Private colModified As DevExpress.XtraGrid.Columns.GridColumn
		Private collectionPersons As DevExpress.Xpo.XPCollection
		Private repositoryImage As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

	End Class
End Namespace
