Imports Microsoft.VisualBasic
Imports System
Namespace Contacts.Controls
	Partial Public Class PersonControl
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(PersonControl))
			Me.layoutPerson = New DevExpress.XtraDataLayout.DataLayoutControl()
			Me.buttonDelete = New DevExpress.XtraEditors.SimpleButton()
			Me.imgIcons = New DevExpress.Utils.ImageCollection(Me.components)
			Me.textCategoryDescription = New DevExpress.XtraEditors.TextEdit()
			Me.textCategoryName = New DevExpress.XtraEditors.TextEdit()
			Me.checkedList = New DevExpress.XtraEditors.CheckedListBoxControl()
			Me.collectionCategories = New DevExpress.Xpo.XPCollection()
			Me.GreetingTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.collectionPerson = New DevExpress.Xpo.XPCollection()
			Me.FirstNameTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.LastNameTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.CityTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.StateTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.NotesMemoEdit = New DevExpress.XtraEditors.MemoEdit()
			Me.ZipTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.imagePerson = New DevExpress.XtraEditors.PictureEdit()
			Me.AddressMemoEdit = New DevExpress.XtraEditors.MemoEdit()
			Me.ModifiedDateEdit = New DevExpress.XtraEditors.TextEdit()
			Me.AddedDateEdit = New DevExpress.XtraEditors.TextEdit()
			Me.OidSpinEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.buttonAddCategory = New DevExpress.XtraEditors.SimpleButton()
			Me.ItemForOid = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.ItemForGreeting = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ItemForFirstName = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ItemForLastName = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.ItemForAddress = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ItemForZip = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ItemForState = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ItemForCity = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutImage = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.ItemForModified = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ItemForAdded = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.ItemForNotes = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.dialogOpen = New System.Windows.Forms.OpenFileDialog()
			Me.defaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController(Me.components)
			CType(Me.layoutPerson, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutPerson.SuspendLayout()
			CType(Me.imgIcons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textCategoryDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textCategoryName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkedList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.collectionCategories, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.GreetingTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.collectionPerson, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.FirstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.LastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.StateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.NotesMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ZipTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imagePerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.AddressMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ModifiedDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.AddedDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.OidSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForOid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForGreeting, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForLastName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForAddress, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForZip, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForState, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForCity, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutImage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForModified, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForAdded, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForNotes, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutPerson
			' 
			Me.layoutPerson.Controls.Add(Me.buttonDelete)
			Me.layoutPerson.Controls.Add(Me.textCategoryDescription)
			Me.layoutPerson.Controls.Add(Me.textCategoryName)
			Me.layoutPerson.Controls.Add(Me.checkedList)
			Me.layoutPerson.Controls.Add(Me.GreetingTextEdit)
			Me.layoutPerson.Controls.Add(Me.FirstNameTextEdit)
			Me.layoutPerson.Controls.Add(Me.LastNameTextEdit)
			Me.layoutPerson.Controls.Add(Me.CityTextEdit)
			Me.layoutPerson.Controls.Add(Me.StateTextEdit)
			Me.layoutPerson.Controls.Add(Me.NotesMemoEdit)
			Me.layoutPerson.Controls.Add(Me.ZipTextEdit)
			Me.layoutPerson.Controls.Add(Me.imagePerson)
			Me.layoutPerson.Controls.Add(Me.AddressMemoEdit)
			Me.layoutPerson.Controls.Add(Me.ModifiedDateEdit)
			Me.layoutPerson.Controls.Add(Me.AddedDateEdit)
			Me.layoutPerson.Controls.Add(Me.OidSpinEdit)
			Me.layoutPerson.Controls.Add(Me.buttonAddCategory)
			Me.layoutPerson.DataSource = Me.collectionPerson
			Me.layoutPerson.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutPerson.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForOid})
			Me.layoutPerson.Location = New System.Drawing.Point(0, 0)
			Me.layoutPerson.Name = "layoutPerson"
			Me.layoutPerson.Root = Me.layoutControlGroup1
			Me.layoutPerson.Size = New System.Drawing.Size(763, 583)
			Me.layoutPerson.TabIndex = 0
			Me.layoutPerson.Text = "dataLayoutControl1"
			' 
			' buttonDelete
			' 
			Me.buttonDelete.ImageIndex = 1
			Me.buttonDelete.ImageList = Me.imgIcons
			Me.buttonDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
			Me.buttonDelete.Location = New System.Drawing.Point(275, 513)
			Me.buttonDelete.Name = "buttonDelete"
			Me.buttonDelete.Size = New System.Drawing.Size(24, 22)
			Me.buttonDelete.StyleController = Me.layoutPerson
			Me.buttonDelete.TabIndex = 27
'			Me.buttonDelete.Click += New System.EventHandler(Me.buttonDelete_Click);
			' 
			' imgIcons
			' 
			Me.imgIcons.ImageStream = (CType(resources.GetObject("imgIcons.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imgIcons.Images.SetKeyName(0, "Add_16x16.png")
			Me.imgIcons.Images.SetKeyName(1, "Delete_16x16.png")
			' 
			' textCategoryDescription
			' 
			Me.textCategoryDescription.Location = New System.Drawing.Point(79, 539)
			Me.textCategoryDescription.Name = "textCategoryDescription"
			Me.textCategoryDescription.Size = New System.Drawing.Size(220, 20)
			Me.textCategoryDescription.StyleController = Me.layoutPerson
			Me.textCategoryDescription.TabIndex = 26
			' 
			' textCategoryName
			' 
			Me.textCategoryName.Location = New System.Drawing.Point(79, 513)
			Me.textCategoryName.Name = "textCategoryName"
			Me.textCategoryName.Size = New System.Drawing.Size(162, 20)
			Me.textCategoryName.StyleController = Me.layoutPerson
			Me.textCategoryName.TabIndex = 24
			' 
			' checkedList
			' 
			Me.checkedList.DataSource = Me.collectionCategories
			Me.checkedList.DisplayMember = "Name"
			Me.checkedList.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
			Me.checkedList.Location = New System.Drawing.Point(24, 323)
			Me.checkedList.Name = "checkedList"
			Me.checkedList.Size = New System.Drawing.Size(275, 186)
			Me.checkedList.StyleController = Me.layoutPerson
			Me.checkedList.TabIndex = 7
			Me.checkedList.ValueMember = "Oid"
			' 
			' collectionCategories
			' 
			Me.collectionCategories.ObjectType = GetType(Contacts.Data.Category)
			' 
			' GreetingTextEdit
			' 
			Me.GreetingTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.collectionPerson, "Greeting", True))
			Me.GreetingTextEdit.Location = New System.Drawing.Point(79, 44)
			Me.GreetingTextEdit.Name = "GreetingTextEdit"
			Me.GreetingTextEdit.Size = New System.Drawing.Size(220, 20)
			Me.GreetingTextEdit.StyleController = Me.layoutPerson
			Me.GreetingTextEdit.TabIndex = 0
			' 
			' collectionPerson
			' 
			Me.collectionPerson.LoadingEnabled = False
			Me.collectionPerson.ObjectType = GetType(Contacts.Data.Person)
			' 
			' FirstNameTextEdit
			' 
			Me.FirstNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.collectionPerson, "FirstName", True))
			Me.FirstNameTextEdit.Location = New System.Drawing.Point(79, 68)
			Me.FirstNameTextEdit.Name = "FirstNameTextEdit"
			Me.FirstNameTextEdit.Size = New System.Drawing.Size(220, 20)
			Me.FirstNameTextEdit.StyleController = Me.layoutPerson
			Me.FirstNameTextEdit.TabIndex = 1
			' 
			' LastNameTextEdit
			' 
			Me.LastNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.collectionPerson, "LastName", True))
			Me.LastNameTextEdit.Location = New System.Drawing.Point(79, 92)
			Me.LastNameTextEdit.Name = "LastNameTextEdit"
			Me.LastNameTextEdit.Size = New System.Drawing.Size(220, 20)
			Me.LastNameTextEdit.StyleController = Me.layoutPerson
			Me.LastNameTextEdit.TabIndex = 2
			' 
			' CityTextEdit
			' 
			Me.CityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.collectionPerson, "City", True))
			Me.CityTextEdit.Location = New System.Drawing.Point(79, 207)
			Me.CityTextEdit.Name = "CityTextEdit"
			Me.CityTextEdit.Size = New System.Drawing.Size(220, 20)
			Me.CityTextEdit.StyleController = Me.layoutPerson
			Me.CityTextEdit.TabIndex = 4
			' 
			' StateTextEdit
			' 
			Me.StateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.collectionPerson, "State", True))
			Me.StateTextEdit.Location = New System.Drawing.Point(79, 231)
			Me.StateTextEdit.Name = "StateTextEdit"
			Me.StateTextEdit.Size = New System.Drawing.Size(220, 20)
			Me.StateTextEdit.StyleController = Me.layoutPerson
			Me.StateTextEdit.TabIndex = 5
			' 
			' NotesMemoEdit
			' 
			Me.NotesMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.collectionPerson, "Notes", True))
			Me.NotesMemoEdit.Location = New System.Drawing.Point(327, 323)
			Me.NotesMemoEdit.Name = "NotesMemoEdit"
			Me.NotesMemoEdit.Size = New System.Drawing.Size(312, 236)
			Me.NotesMemoEdit.StyleController = Me.layoutPerson
			Me.NotesMemoEdit.TabIndex = 8
			' 
			' ZipTextEdit
			' 
			Me.ZipTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.collectionPerson, "Zip", True))
			Me.ZipTextEdit.Location = New System.Drawing.Point(79, 255)
			Me.ZipTextEdit.Name = "ZipTextEdit"
			Me.ZipTextEdit.Size = New System.Drawing.Size(220, 20)
			Me.ZipTextEdit.StyleController = Me.layoutPerson
			Me.ZipTextEdit.TabIndex = 6
			' 
			' imagePerson
			' 
			Me.imagePerson.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.collectionPerson, "Image", True))
			Me.imagePerson.Location = New System.Drawing.Point(327, 44)
			Me.imagePerson.Name = "imagePerson"
			Me.imagePerson.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			Me.imagePerson.Size = New System.Drawing.Size(96, 122)
			Me.imagePerson.StyleController = Me.layoutPerson
			Me.imagePerson.TabIndex = 9
'			Me.imagePerson.Click += New System.EventHandler(Me.imagePerson_Click);
			' 
			' AddressMemoEdit
			' 
			Me.AddressMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.collectionPerson, "Address", True))
			Me.AddressMemoEdit.Location = New System.Drawing.Point(79, 160)
			Me.AddressMemoEdit.Name = "AddressMemoEdit"
			Me.AddressMemoEdit.Size = New System.Drawing.Size(220, 43)
			Me.AddressMemoEdit.StyleController = Me.layoutPerson
			Me.AddressMemoEdit.TabIndex = 3
			' 
			' ModifiedDateEdit
			' 
			Me.ModifiedDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.collectionPerson, "Modified", True))
			Me.ModifiedDateEdit.Enabled = False
			Me.ModifiedDateEdit.Location = New System.Drawing.Point(427, 99)
			Me.ModifiedDateEdit.Name = "ModifiedDateEdit"
			Me.ModifiedDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.ModifiedDateEdit.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent
			Me.ModifiedDateEdit.Properties.Appearance.Options.UseBackColor = True
			Me.ModifiedDateEdit.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent
			Me.ModifiedDateEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
			Me.ModifiedDateEdit.Properties.AppearanceDisabled.Options.UseBorderColor = True
			Me.ModifiedDateEdit.Properties.AppearanceDisabled.Options.UseForeColor = True
			Me.ModifiedDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.ModifiedDateEdit.Properties.DisplayFormat.FormatString = "f"
			Me.ModifiedDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
			Me.ModifiedDateEdit.Properties.EditFormat.FormatString = "d"
			Me.ModifiedDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
			Me.ModifiedDateEdit.Properties.Mask.EditMask = "d"
			Me.ModifiedDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
			Me.ModifiedDateEdit.Size = New System.Drawing.Size(212, 18)
			Me.ModifiedDateEdit.StyleController = Me.layoutPerson
			Me.ModifiedDateEdit.TabIndex = 14
			Me.ModifiedDateEdit.TabStop = False
			' 
			' AddedDateEdit
			' 
			Me.AddedDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.collectionPerson, "Added", True))
			Me.AddedDateEdit.Enabled = False
			Me.AddedDateEdit.Location = New System.Drawing.Point(427, 60)
			Me.AddedDateEdit.Name = "AddedDateEdit"
			Me.AddedDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.AddedDateEdit.Properties.Appearance.Options.UseBackColor = True
			Me.AddedDateEdit.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent
			Me.AddedDateEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
			Me.AddedDateEdit.Properties.AppearanceDisabled.Options.UseBorderColor = True
			Me.AddedDateEdit.Properties.AppearanceDisabled.Options.UseForeColor = True
			Me.AddedDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.AddedDateEdit.Properties.DisplayFormat.FormatString = "f"
			Me.AddedDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
			Me.AddedDateEdit.Properties.EditFormat.FormatString = "d"
			Me.AddedDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
			Me.AddedDateEdit.Properties.Mask.EditMask = "d"
			Me.AddedDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
			Me.AddedDateEdit.Size = New System.Drawing.Size(212, 18)
			Me.AddedDateEdit.StyleController = Me.layoutPerson
			Me.AddedDateEdit.TabIndex = 13
			Me.AddedDateEdit.TabStop = False
			' 
			' OidSpinEdit
			' 
			Me.OidSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.collectionPerson, "Oid", True))
			Me.OidSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.OidSpinEdit.Location = New System.Drawing.Point(0, 0)
			Me.OidSpinEdit.Name = "OidSpinEdit"
			Me.OidSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.OidSpinEdit.Size = New System.Drawing.Size(0, 20)
			Me.OidSpinEdit.StyleController = Me.layoutPerson
			Me.OidSpinEdit.TabIndex = 23
			' 
			' buttonAddCategory
			' 
			Me.buttonAddCategory.ImageIndex = 0
			Me.buttonAddCategory.ImageList = Me.imgIcons
			Me.buttonAddCategory.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
			Me.buttonAddCategory.Location = New System.Drawing.Point(245, 513)
			Me.buttonAddCategory.Name = "buttonAddCategory"
			Me.buttonAddCategory.Size = New System.Drawing.Size(26, 22)
			Me.buttonAddCategory.StyleController = Me.layoutPerson
			Me.buttonAddCategory.TabIndex = 25
			Me.buttonAddCategory.TabStop = False
'			Me.buttonAddCategory.Click += New System.EventHandler(Me.buttonAddCategory_Click);
			' 
			' ItemForOid
			' 
			Me.ItemForOid.Control = Me.OidSpinEdit
			Me.ItemForOid.CustomizationFormText = "Oid"
			Me.ItemForOid.Location = New System.Drawing.Point(0, 0)
			Me.ItemForOid.Name = "ItemForOid"
			Me.ItemForOid.Size = New System.Drawing.Size(0, 0)
			Me.ItemForOid.Text = "Oid"
			Me.ItemForOid.TextSize = New System.Drawing.Size(50, 20)
			Me.ItemForOid.TextToControlDistance = 5
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "Root"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(763, 583)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "Root"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.AllowDrawBackground = False
			Me.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
			Me.layoutControlGroup2.GroupBordersVisible = False
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup3, Me.layoutControlGroup4, Me.layoutControlGroup7, Me.layoutControlGroup6, Me.layoutControlGroup5, Me.emptySpaceItem1})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup2.Name = "autoGeneratedGroup0"
			Me.layoutControlGroup2.Size = New System.Drawing.Size(743, 563)
			Me.layoutControlGroup2.Text = "autoGeneratedGroup0"
			' 
			' layoutControlGroup3
			' 
			Me.layoutControlGroup3.CustomizationFormText = "Name"
			Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForGreeting, Me.ItemForFirstName, Me.ItemForLastName})
			Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup3.Name = "layoutControlGroup3"
			Me.layoutControlGroup3.Size = New System.Drawing.Size(303, 116)
			Me.layoutControlGroup3.Text = "Name"
			' 
			' ItemForGreeting
			' 
			Me.ItemForGreeting.Control = Me.GreetingTextEdit
			Me.ItemForGreeting.CustomizationFormText = "Greeting"
			Me.ItemForGreeting.Location = New System.Drawing.Point(0, 0)
			Me.ItemForGreeting.MaxSize = New System.Drawing.Size(279, 24)
			Me.ItemForGreeting.MinSize = New System.Drawing.Size(279, 24)
			Me.ItemForGreeting.Name = "ItemForGreeting"
			Me.ItemForGreeting.Size = New System.Drawing.Size(279, 24)
			Me.ItemForGreeting.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.ItemForGreeting.Text = "Greeting"
			Me.ItemForGreeting.TextSize = New System.Drawing.Size(51, 13)
			' 
			' ItemForFirstName
			' 
			Me.ItemForFirstName.Control = Me.FirstNameTextEdit
			Me.ItemForFirstName.CustomizationFormText = "First Name"
			Me.ItemForFirstName.Location = New System.Drawing.Point(0, 24)
			Me.ItemForFirstName.MaxSize = New System.Drawing.Size(279, 24)
			Me.ItemForFirstName.MinSize = New System.Drawing.Size(279, 24)
			Me.ItemForFirstName.Name = "ItemForFirstName"
			Me.ItemForFirstName.Size = New System.Drawing.Size(279, 24)
			Me.ItemForFirstName.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.ItemForFirstName.Text = "First Name"
			Me.ItemForFirstName.TextSize = New System.Drawing.Size(51, 13)
			' 
			' ItemForLastName
			' 
			Me.ItemForLastName.Control = Me.LastNameTextEdit
			Me.ItemForLastName.CustomizationFormText = "Last Name"
			Me.ItemForLastName.Location = New System.Drawing.Point(0, 48)
			Me.ItemForLastName.MaxSize = New System.Drawing.Size(279, 24)
			Me.ItemForLastName.MinSize = New System.Drawing.Size(279, 24)
			Me.ItemForLastName.Name = "ItemForLastName"
			Me.ItemForLastName.Size = New System.Drawing.Size(279, 24)
			Me.ItemForLastName.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.ItemForLastName.Text = "Last Name"
			Me.ItemForLastName.TextSize = New System.Drawing.Size(51, 13)
			' 
			' layoutControlGroup4
			' 
			Me.layoutControlGroup4.CustomizationFormText = "Address"
			Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForAddress, Me.ItemForZip, Me.ItemForState, Me.ItemForCity})
			Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 116)
			Me.layoutControlGroup4.Name = "layoutControlGroup4"
			Me.layoutControlGroup4.Size = New System.Drawing.Size(303, 163)
			Me.layoutControlGroup4.Text = "Address"
			' 
			' ItemForAddress
			' 
			Me.ItemForAddress.Control = Me.AddressMemoEdit
			Me.ItemForAddress.CustomizationFormText = "Address"
			Me.ItemForAddress.Location = New System.Drawing.Point(0, 0)
			Me.ItemForAddress.MaxSize = New System.Drawing.Size(279, 47)
			Me.ItemForAddress.MinSize = New System.Drawing.Size(279, 47)
			Me.ItemForAddress.Name = "ItemForAddress"
			Me.ItemForAddress.Size = New System.Drawing.Size(279, 47)
			Me.ItemForAddress.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.ItemForAddress.Text = "Address"
			Me.ItemForAddress.TextSize = New System.Drawing.Size(51, 13)
			' 
			' ItemForZip
			' 
			Me.ItemForZip.Control = Me.ZipTextEdit
			Me.ItemForZip.CustomizationFormText = "Zip"
			Me.ItemForZip.Location = New System.Drawing.Point(0, 95)
			Me.ItemForZip.MaxSize = New System.Drawing.Size(279, 24)
			Me.ItemForZip.MinSize = New System.Drawing.Size(279, 24)
			Me.ItemForZip.Name = "ItemForZip"
			Me.ItemForZip.Size = New System.Drawing.Size(279, 24)
			Me.ItemForZip.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.ItemForZip.Text = "Zip"
			Me.ItemForZip.TextSize = New System.Drawing.Size(51, 13)
			' 
			' ItemForState
			' 
			Me.ItemForState.Control = Me.StateTextEdit
			Me.ItemForState.CustomizationFormText = "State"
			Me.ItemForState.Location = New System.Drawing.Point(0, 71)
			Me.ItemForState.MaxSize = New System.Drawing.Size(279, 24)
			Me.ItemForState.MinSize = New System.Drawing.Size(279, 24)
			Me.ItemForState.Name = "ItemForState"
			Me.ItemForState.Size = New System.Drawing.Size(279, 24)
			Me.ItemForState.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.ItemForState.Text = "State"
			Me.ItemForState.TextSize = New System.Drawing.Size(51, 13)
			' 
			' ItemForCity
			' 
			Me.ItemForCity.Control = Me.CityTextEdit
			Me.ItemForCity.CustomizationFormText = "City"
			Me.ItemForCity.Location = New System.Drawing.Point(0, 47)
			Me.ItemForCity.MaxSize = New System.Drawing.Size(279, 24)
			Me.ItemForCity.MinSize = New System.Drawing.Size(279, 24)
			Me.ItemForCity.Name = "ItemForCity"
			Me.ItemForCity.Size = New System.Drawing.Size(279, 24)
			Me.ItemForCity.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.ItemForCity.Text = "City"
			Me.ItemForCity.TextSize = New System.Drawing.Size(51, 13)
			' 
			' layoutControlGroup7
			' 
			Me.layoutControlGroup7.CustomizationFormText = "Categories"
			Me.layoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem3, Me.layoutControlItem1, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem2})
			Me.layoutControlGroup7.Location = New System.Drawing.Point(0, 279)
			Me.layoutControlGroup7.Name = "layoutControlGroup7"
			Me.layoutControlGroup7.Size = New System.Drawing.Size(303, 284)
			Me.layoutControlGroup7.Text = "Categories"
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.checkedList
			Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(279, 190)
			Me.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
			Me.layoutControlItem3.Text = "layoutControlItem3"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextToControlDistance = 0
			Me.layoutControlItem3.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.textCategoryName
			Me.layoutControlItem1.CustomizationFormText = "Name"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 190)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(221, 26)
			Me.layoutControlItem1.Text = "Name"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(51, 13)
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.textCategoryDescription
			Me.layoutControlItem4.CustomizationFormText = "Desc"
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 216)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(279, 24)
			Me.layoutControlItem4.Text = "Desc"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(51, 13)
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.buttonDelete
			Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
			Me.layoutControlItem5.Location = New System.Drawing.Point(251, 190)
			Me.layoutControlItem5.MaxSize = New System.Drawing.Size(28, 26)
			Me.layoutControlItem5.MinSize = New System.Drawing.Size(28, 26)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(28, 26)
			Me.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.layoutControlItem5.Text = "layoutControlItem5"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextToControlDistance = 0
			Me.layoutControlItem5.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.buttonAddCategory
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(221, 190)
			Me.layoutControlItem2.MaxSize = New System.Drawing.Size(30, 26)
			Me.layoutControlItem2.MinSize = New System.Drawing.Size(30, 26)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(30, 26)
			Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlGroup6
			' 
			Me.layoutControlGroup6.CustomizationFormText = "Miscellaneous"
			Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutImage, Me.emptySpaceItem2, Me.emptySpaceItem3, Me.ItemForModified, Me.ItemForAdded})
			Me.layoutControlGroup6.Location = New System.Drawing.Point(303, 0)
			Me.layoutControlGroup6.Name = "layoutControlGroup6"
			Me.layoutControlGroup6.Size = New System.Drawing.Size(340, 279)
			Me.layoutControlGroup6.Text = "Miscellaneous"
			' 
			' layoutImage
			' 
			Me.layoutImage.Control = Me.imagePerson
			Me.layoutImage.CustomizationFormText = "Picture"
			Me.layoutImage.Location = New System.Drawing.Point(0, 0)
			Me.layoutImage.MaxSize = New System.Drawing.Size(100, 142)
			Me.layoutImage.MinSize = New System.Drawing.Size(100, 142)
			Me.layoutImage.Name = "layoutImage"
			Me.layoutImage.Size = New System.Drawing.Size(100, 142)
			Me.layoutImage.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.layoutImage.Text = "Picture"
			Me.layoutImage.TextLocation = DevExpress.Utils.Locations.Bottom
			Me.layoutImage.TextSize = New System.Drawing.Size(51, 13)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
			Me.emptySpaceItem2.Location = New System.Drawing.Point(100, 78)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(216, 64)
			Me.emptySpaceItem2.Text = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem3
			' 
			Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
			Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 142)
			Me.emptySpaceItem3.Name = "emptySpaceItem3"
			Me.emptySpaceItem3.Size = New System.Drawing.Size(316, 93)
			Me.emptySpaceItem3.Text = "emptySpaceItem3"
			Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
			' 
			' ItemForModified
			' 
			Me.ItemForModified.Control = Me.ModifiedDateEdit
			Me.ItemForModified.CustomizationFormText = "Modified"
			Me.ItemForModified.Location = New System.Drawing.Point(100, 39)
			Me.ItemForModified.MaxSize = New System.Drawing.Size(216, 39)
			Me.ItemForModified.MinSize = New System.Drawing.Size(216, 39)
			Me.ItemForModified.Name = "ItemForModified"
			Me.ItemForModified.Size = New System.Drawing.Size(216, 39)
			Me.ItemForModified.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.ItemForModified.Text = "Modified"
			Me.ItemForModified.TextLocation = DevExpress.Utils.Locations.Top
			Me.ItemForModified.TextSize = New System.Drawing.Size(51, 13)
			' 
			' ItemForAdded
			' 
			Me.ItemForAdded.Control = Me.AddedDateEdit
			Me.ItemForAdded.CustomizationFormText = "Added"
			Me.ItemForAdded.Location = New System.Drawing.Point(100, 0)
			Me.ItemForAdded.MaxSize = New System.Drawing.Size(216, 39)
			Me.ItemForAdded.MinSize = New System.Drawing.Size(216, 39)
			Me.ItemForAdded.Name = "ItemForAdded"
			Me.ItemForAdded.Size = New System.Drawing.Size(216, 39)
			Me.ItemForAdded.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.ItemForAdded.Text = "Added"
			Me.ItemForAdded.TextLocation = DevExpress.Utils.Locations.Top
			Me.ItemForAdded.TextSize = New System.Drawing.Size(51, 13)
			' 
			' layoutControlGroup5
			' 
			Me.layoutControlGroup5.CustomizationFormText = "Notes"
			Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForNotes})
			Me.layoutControlGroup5.Location = New System.Drawing.Point(303, 279)
			Me.layoutControlGroup5.Name = "layoutControlGroup5"
			Me.layoutControlGroup5.Size = New System.Drawing.Size(340, 284)
			Me.layoutControlGroup5.Text = "Notes"
			' 
			' ItemForNotes
			' 
			Me.ItemForNotes.Control = Me.NotesMemoEdit
			Me.ItemForNotes.CustomizationFormText = "Notes"
			Me.ItemForNotes.Location = New System.Drawing.Point(0, 0)
			Me.ItemForNotes.Name = "ItemForNotes"
			Me.ItemForNotes.Size = New System.Drawing.Size(316, 240)
			Me.ItemForNotes.Text = "Notes"
			Me.ItemForNotes.TextSize = New System.Drawing.Size(0, 0)
			Me.ItemForNotes.TextToControlDistance = 0
			Me.ItemForNotes.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(643, 0)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(100, 563)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' dialogOpen
			' 
			Me.dialogOpen.Filter = "JPEG|*.jpg|PNG|*.png|All Files|*.*"
			' 
			' PersonControl
			' 
			Me.defaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.Default)
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutPerson)
			Me.Name = "PersonControl"
			Me.Size = New System.Drawing.Size(763, 583)
			CType(Me.layoutPerson, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutPerson.ResumeLayout(False)
			CType(Me.imgIcons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textCategoryDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textCategoryName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkedList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.collectionCategories, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.GreetingTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.collectionPerson, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.FirstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.LastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.StateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.NotesMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ZipTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imagePerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.AddressMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ModifiedDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.AddedDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.OidSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForOid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForGreeting, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForFirstName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForLastName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForAddress, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForZip, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForState, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForCity, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutImage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForModified, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForAdded, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForNotes, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private collectionPerson As DevExpress.Xpo.XPCollection
		Private layoutPerson As DevExpress.XtraDataLayout.DataLayoutControl
		Private GreetingTextEdit As DevExpress.XtraEditors.TextEdit
		Private FirstNameTextEdit As DevExpress.XtraEditors.TextEdit
		Private LastNameTextEdit As DevExpress.XtraEditors.TextEdit
		Private CityTextEdit As DevExpress.XtraEditors.TextEdit
		Private StateTextEdit As DevExpress.XtraEditors.TextEdit
		Private ZipTextEdit As DevExpress.XtraEditors.TextEdit
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
		Private ItemForGreeting As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForFirstName As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForLastName As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
		Private ItemForAddress As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForZip As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForState As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForCity As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents imagePerson As DevExpress.XtraEditors.PictureEdit
		Private checkedList As DevExpress.XtraEditors.CheckedListBoxControl
		Private layoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private AddressMemoEdit As DevExpress.XtraEditors.MemoEdit
		Private NotesMemoEdit As DevExpress.XtraEditors.MemoEdit
		Private layoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutImage As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
		Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
		Private ItemForAdded As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForModified As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
		Private ItemForNotes As DevExpress.XtraLayout.LayoutControlItem
		Private dialogOpen As System.Windows.Forms.OpenFileDialog
		Private ModifiedDateEdit As DevExpress.XtraEditors.TextEdit
		Private AddedDateEdit As DevExpress.XtraEditors.TextEdit
		Private OidSpinEdit As DevExpress.XtraEditors.SpinEdit
		Private ItemForOid As DevExpress.XtraLayout.LayoutControlItem
		Private defaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
		Private textCategoryDescription As DevExpress.XtraEditors.TextEdit
		Private textCategoryName As DevExpress.XtraEditors.TextEdit
		Private collectionCategories As DevExpress.Xpo.XPCollection
		Private WithEvents buttonAddCategory As DevExpress.XtraEditors.SimpleButton
		Private imgIcons As DevExpress.Utils.ImageCollection
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents buttonDelete As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace
