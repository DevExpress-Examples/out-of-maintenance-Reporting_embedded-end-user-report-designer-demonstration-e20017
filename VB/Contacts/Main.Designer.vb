Imports Microsoft.VisualBasic
Imports System
Namespace Contacts
	Partial Public Class Main
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim superToolTip8 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem8 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem8 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip6 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem6 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem6 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip9 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem9 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem9 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip7 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem7 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem7 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip10 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem10 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem10 As New DevExpress.Utils.ToolTipItem()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Main))
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.lookMain = New DevExpress.LookAndFeel.DefaultLookAndFeel()
			Me.barMain = New DevExpress.XtraBars.BarManager()
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.barHome = New DevExpress.XtraBars.BarButtonItem()
			Me.barNewPerson = New DevExpress.XtraBars.BarButtonItem()
			Me.barRefresh = New DevExpress.XtraBars.BarButtonItem()
			Me.barSave = New DevExpress.XtraBars.BarButtonItem()
			Me.barDelete = New DevExpress.XtraBars.BarButtonItem()
			Me.barClose = New DevExpress.XtraBars.BarButtonItem()
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.menuFile = New DevExpress.XtraBars.BarSubItem()
			Me.menuHome = New DevExpress.XtraBars.BarButtonItem()
			Me.menuNew = New DevExpress.XtraBars.BarButtonItem()
			Me.menuRefresh = New DevExpress.XtraBars.BarButtonItem()
			Me.menuSave = New DevExpress.XtraBars.BarButtonItem()
			Me.menuDelete = New DevExpress.XtraBars.BarButtonItem()
			Me.menuExit = New DevExpress.XtraBars.BarButtonItem()
			Me.menuOptions = New DevExpress.XtraBars.BarSubItem()
			Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.imgIcons = New DevExpress.Utils.ImageCollection()
			Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.lookUpPerson = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.tabMain = New DevExpress.XtraTab.XtraTabControl()
			Me.collectionCategories = New DevExpress.Xpo.XPCollection()
			Me.bar4 = New DevExpress.XtraBars.Bar()
			Me.barCreateReport = New DevExpress.XtraBars.BarSubItem()
			Me.barByPerson = New DevExpress.XtraBars.BarButtonItem()
			Me.barByCategory = New DevExpress.XtraBars.BarButtonItem()
			Me.barReportPreview = New DevExpress.XtraBars.BarSubItem()
			CType(Me.barMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgIcons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lookUpPerson, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.collectionCategories, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lookMain
			' 
			Me.lookMain.LookAndFeel.SkinName = "Black"
			' 
			' barMain
			' 
			Me.barMain.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2, Me.bar3, Me.bar4})
			Me.barMain.DockControls.Add(Me.barDockControlTop)
			Me.barMain.DockControls.Add(Me.barDockControlBottom)
			Me.barMain.DockControls.Add(Me.barDockControlLeft)
			Me.barMain.DockControls.Add(Me.barDockControlRight)
			Me.barMain.Form = Me
			Me.barMain.Images = Me.imgIcons
			Me.barMain.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barNewPerson, Me.barSave, Me.barHome, Me.barRefresh, Me.barDelete, Me.barClose, Me.menuFile, Me.menuNew, Me.menuHome, Me.menuRefresh, Me.menuSave, Me.menuDelete, Me.menuExit, Me.barSubItem1, Me.barButtonItem1, Me.menuOptions, Me.barCreateReport, Me.barByPerson, Me.barByCategory, Me.barReportPreview})
			Me.barMain.MainMenu = Me.bar2
			Me.barMain.MaxItemId = 22
			Me.barMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemLookUpEdit1, Me.lookUpPerson})
			Me.barMain.StatusBar = Me.bar3
			' 
			' bar1
			' 
			Me.bar1.BarName = "Tools"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 1
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barHome), New DevExpress.XtraBars.LinkPersistInfo(Me.barNewPerson), New DevExpress.XtraBars.LinkPersistInfo(Me.barRefresh, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barSave), New DevExpress.XtraBars.LinkPersistInfo(Me.barDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.barClose, True)})
			Me.bar1.Text = "Tools"
			' 
			' barHome
			' 
			Me.barHome.Caption = "Home"
			Me.barHome.Id = 3
			Me.barHome.ImageIndex = 3
			Me.barHome.Name = "barHome"
			toolTipTitleItem8.Text = "Home"
			toolTipItem8.LeftIndent = 6
			toolTipItem8.Text = "List all people"
			superToolTip8.Items.Add(toolTipTitleItem8)
			superToolTip8.Items.Add(toolTipItem8)
			Me.barHome.SuperTip = superToolTip8
'			Me.barHome.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barHome_ItemClick);
			' 
			' barNewPerson
			' 
			Me.barNewPerson.Caption = "New"
			Me.barNewPerson.Id = 0
			Me.barNewPerson.ImageIndex = 1
			Me.barNewPerson.Name = "barNewPerson"
			toolTipTitleItem6.Text = "Person"
			toolTipItem6.LeftIndent = 6
			toolTipItem6.Text = "Add new Person"
			superToolTip6.Items.Add(toolTipTitleItem6)
			superToolTip6.Items.Add(toolTipItem6)
			Me.barNewPerson.SuperTip = superToolTip6
'			Me.barNewPerson.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barNewPerson_ItemClick);
			' 
			' barRefresh
			' 
			Me.barRefresh.Caption = "Refresh"
			Me.barRefresh.Id = 4
			Me.barRefresh.ImageIndex = 13
			Me.barRefresh.Name = "barRefresh"
			toolTipTitleItem9.Text = "Refresh"
			toolTipItem9.LeftIndent = 6
			toolTipItem9.Text = "Refresh current item"
			superToolTip9.Items.Add(toolTipTitleItem9)
			superToolTip9.Items.Add(toolTipItem9)
			Me.barRefresh.SuperTip = superToolTip9
'			Me.barRefresh.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barRefresh_ItemClick);
			' 
			' barSave
			' 
			Me.barSave.Caption = "Save"
			Me.barSave.Id = 1
			Me.barSave.ImageIndex = 7
			Me.barSave.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
			Me.barSave.Name = "barSave"
			Me.barSave.ShortcutKeyDisplayString = "Ctrl-S"
			toolTipTitleItem7.Text = "Save"
			toolTipItem7.LeftIndent = 6
			toolTipItem7.Text = "Save Current Item"
			superToolTip7.Items.Add(toolTipTitleItem7)
			superToolTip7.Items.Add(toolTipItem7)
			Me.barSave.SuperTip = superToolTip7
'			Me.barSave.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barSave_ItemClick);
			' 
			' barDelete
			' 
			Me.barDelete.Caption = "Delete"
			Me.barDelete.Id = 5
			Me.barDelete.ImageIndex = 14
			Me.barDelete.Name = "barDelete"
			toolTipTitleItem10.Text = "Delete"
			toolTipItem10.LeftIndent = 6
			toolTipItem10.Text = "Delete Selected Item"
			superToolTip10.Items.Add(toolTipTitleItem10)
			superToolTip10.Items.Add(toolTipItem10)
			Me.barDelete.SuperTip = superToolTip10
'			Me.barDelete.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barDelete_ItemClick);
			' 
			' barClose
			' 
			Me.barClose.Caption = "Exit"
			Me.barClose.Id = 6
			Me.barClose.ImageIndex = 4
			Me.barClose.Name = "barClose"
'			Me.barClose.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barClose_ItemClick);
			' 
			' bar2
			' 
			Me.bar2.BarName = "Main menu"
			Me.bar2.DockCol = 0
			Me.bar2.DockRow = 0
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.menuFile), New DevExpress.XtraBars.LinkPersistInfo(Me.menuOptions), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1)})
			Me.bar2.OptionsBar.MultiLine = True
			Me.bar2.OptionsBar.UseWholeRow = True
			Me.bar2.Text = "Main menu"
			' 
			' menuFile
			' 
			Me.menuFile.Caption = "&File"
			Me.menuFile.Id = 7
			Me.menuFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.menuHome), New DevExpress.XtraBars.LinkPersistInfo(Me.menuNew), New DevExpress.XtraBars.LinkPersistInfo(Me.menuRefresh, True), New DevExpress.XtraBars.LinkPersistInfo(Me.menuSave), New DevExpress.XtraBars.LinkPersistInfo(Me.menuDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.menuExit, True)})
			Me.menuFile.Name = "menuFile"
			' 
			' menuHome
			' 
			Me.menuHome.Caption = "&Home"
			Me.menuHome.Id = 10
			Me.menuHome.Name = "menuHome"
'			Me.menuHome.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.menuHome_ItemClick);
			' 
			' menuNew
			' 
			Me.menuNew.Caption = "&New"
			Me.menuNew.Id = 9
			Me.menuNew.Name = "menuNew"
'			Me.menuNew.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.menuNew_ItemClick);
			' 
			' menuRefresh
			' 
			Me.menuRefresh.Caption = "&Refresh"
			Me.menuRefresh.Id = 11
			Me.menuRefresh.Name = "menuRefresh"
'			Me.menuRefresh.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.menuRefresh_ItemClick);
			' 
			' menuSave
			' 
			Me.menuSave.Caption = "&Save"
			Me.menuSave.Id = 12
			Me.menuSave.Name = "menuSave"
'			Me.menuSave.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.menuSave_ItemClick);
			' 
			' menuDelete
			' 
			Me.menuDelete.Caption = "&Delete"
			Me.menuDelete.Id = 13
			Me.menuDelete.Name = "menuDelete"
'			Me.menuDelete.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.menuDelete_ItemClick);
			' 
			' menuExit
			' 
			Me.menuExit.Caption = "E&xit"
			Me.menuExit.Id = 14
			Me.menuExit.Name = "menuExit"
'			Me.menuExit.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.menuExit_ItemClick);
			' 
			' menuOptions
			' 
			Me.menuOptions.Caption = "&Options"
			Me.menuOptions.Id = 17
			Me.menuOptions.Name = "menuOptions"
			' 
			' barSubItem1
			' 
			Me.barSubItem1.Caption = "&Help"
			Me.barSubItem1.Id = 15
			Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1)})
			Me.barSubItem1.Name = "barSubItem1"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "&About"
			Me.barButtonItem1.Id = 16
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' bar3
			' 
			Me.bar3.BarName = "Status bar"
			Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.bar3.DockCol = 0
			Me.bar3.DockRow = 0
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.bar3.OptionsBar.AllowQuickCustomization = False
			Me.bar3.OptionsBar.DrawDragBorder = False
			Me.bar3.OptionsBar.UseWholeRow = True
			Me.bar3.Text = "Status bar"
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(678, 51)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 622)
			Me.barDockControlBottom.Size = New System.Drawing.Size(678, 22)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 51)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 571)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(678, 51)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 571)
			' 
			' imgIcons
			' 
			Me.imgIcons.ImageStream = (CType(resources.GetObject("imgIcons.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imgIcons.Images.SetKeyName(0, "Add")
			Me.imgIcons.Images.SetKeyName(1, "NewPerson")
			Me.imgIcons.Images.SetKeyName(2, "Person")
			Me.imgIcons.Images.SetKeyName(3, "Home")
			Me.imgIcons.Images.SetKeyName(4, "Close")
			Me.imgIcons.Images.SetKeyName(5, "Open")
			Me.imgIcons.Images.SetKeyName(6, "Category")
			Me.imgIcons.Images.SetKeyName(7, "Save")
			Me.imgIcons.Images.SetKeyName(8, "Editor")
			Me.imgIcons.Images.SetKeyName(9, "Report")
			Me.imgIcons.Images.SetKeyName(10, "NewReport")
			Me.imgIcons.Images.SetKeyName(11, "Print")
			Me.imgIcons.Images.SetKeyName(12, "Find_16x16.png")
			Me.imgIcons.Images.SetKeyName(13, "Refresh_16x16.png")
			Me.imgIcons.Images.SetKeyName(14, "Delete_16x16.png")
			' 
			' repositoryItemLookUpEdit1
			' 
			Me.repositoryItemLookUpEdit1.AutoHeight = False
			Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
			' 
			' lookUpPerson
			' 
			Me.lookUpPerson.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("lookUpPerson.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, True)})
			Me.lookUpPerson.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Greeting", "Greeting", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
			Me.lookUpPerson.DisplayMember = "Greeting"
			Me.lookUpPerson.EditValueChangedDelay = 3
			Me.lookUpPerson.Name = "lookUpPerson"
			Me.lookUpPerson.NullText = "[Find Person]"
			Me.lookUpPerson.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			' 
			' tabMain
			' 
			Me.tabMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
			Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tabMain.Location = New System.Drawing.Point(0, 51)
			Me.tabMain.Name = "tabMain"
			Me.tabMain.Size = New System.Drawing.Size(678, 571)
			Me.tabMain.TabIndex = 4
'			Me.tabMain.CloseButtonClick += New System.EventHandler(Me.tabMain_CloseButtonClick);
			' 
			' collectionCategories
			' 
			Me.collectionCategories.LoadingEnabled = False
			Me.collectionCategories.ObjectType = GetType(Contacts.Data.Category)
			' 
			' bar4
			' 
			Me.bar4.BarName = "Custom 5"
			Me.bar4.DockCol = 1
			Me.bar4.DockRow = 1
			Me.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barCreateReport), New DevExpress.XtraBars.LinkPersistInfo(Me.barReportPreview)})
			Me.bar4.Offset = 207
			Me.bar4.Text = "Custom 5"
			' 
			' barCreateReport
			' 
			Me.barCreateReport.Caption = "Create Report"
			Me.barCreateReport.Id = 18
			Me.barCreateReport.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barByPerson), New DevExpress.XtraBars.LinkPersistInfo(Me.barByCategory)})
			Me.barCreateReport.Name = "barCreateReport"
			' 
			' barByPerson
			' 
			Me.barByPerson.Caption = "By Person"
			Me.barByPerson.Id = 19
			Me.barByPerson.Name = "barByPerson"
'			Me.barByPerson.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barByPerson_ItemClick);
			' 
			' barByCategory
			' 
			Me.barByCategory.Caption = "By Category"
			Me.barByCategory.Id = 20
			Me.barByCategory.Name = "barByCategory"
'			Me.barByCategory.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barByCategory_ItemClick);
			' 
			' barReportPreview
			' 
			Me.barReportPreview.Caption = "Preview"
			Me.barReportPreview.Id = 21
			Me.barReportPreview.Name = "barReportPreview"
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(678, 644)
			Me.Controls.Add(Me.tabMain)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Main"
			Me.Text = "Mailings!"
			CType(Me.barMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgIcons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lookUpPerson, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.collectionCategories, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lookMain As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private barMain As DevExpress.XtraBars.BarManager
		Private bar1 As DevExpress.XtraBars.Bar
		Private WithEvents barNewPerson As DevExpress.XtraBars.BarButtonItem
		Private bar2 As DevExpress.XtraBars.Bar
		Private bar3 As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents tabMain As DevExpress.XtraTab.XtraTabControl
		Public imgIcons As DevExpress.Utils.ImageCollection
		Private WithEvents barSave As DevExpress.XtraBars.BarButtonItem
		Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private lookUpPerson As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private WithEvents barHome As DevExpress.XtraBars.BarButtonItem
		Private WithEvents barRefresh As DevExpress.XtraBars.BarButtonItem
		Private WithEvents barDelete As DevExpress.XtraBars.BarButtonItem
		Private WithEvents barClose As DevExpress.XtraBars.BarButtonItem
		Private menuFile As DevExpress.XtraBars.BarSubItem
		Private WithEvents menuHome As DevExpress.XtraBars.BarButtonItem
		Private WithEvents menuNew As DevExpress.XtraBars.BarButtonItem
		Private WithEvents menuRefresh As DevExpress.XtraBars.BarButtonItem
		Private WithEvents menuSave As DevExpress.XtraBars.BarButtonItem
		Private WithEvents menuDelete As DevExpress.XtraBars.BarButtonItem
		Private WithEvents menuExit As DevExpress.XtraBars.BarButtonItem
		Private barSubItem1 As DevExpress.XtraBars.BarSubItem
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private menuOptions As DevExpress.XtraBars.BarSubItem
		Private collectionCategories As DevExpress.Xpo.XPCollection
		Private bar4 As DevExpress.XtraBars.Bar
		Private barCreateReport As DevExpress.XtraBars.BarSubItem
		Private WithEvents barByPerson As DevExpress.XtraBars.BarButtonItem
		Private WithEvents barByCategory As DevExpress.XtraBars.BarButtonItem
		Private barReportPreview As DevExpress.XtraBars.BarSubItem
	End Class
End Namespace

