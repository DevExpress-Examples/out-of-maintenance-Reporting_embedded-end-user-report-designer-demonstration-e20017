Imports Microsoft.VisualBasic
Imports System
Imports Contacts.Data
Imports DevExpress.Utils
Imports Contacts.Controls
Imports DevExpress.XtraTab
Imports DevExpress.XtraBars
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.XtraReports.UserDesigner
Imports Contacts.Reports
Imports DevExpress.XtraReports.UI
Imports System.IO

Namespace Contacts
	Partial Public Class Main
		Inherits Form
		Public Sub New()
			InitializeComponent()
			HomeTab()
			LoadReportMenu()
		End Sub

		''' <summary>
		''' Current Focused Person
		''' </summary>
		Private ReadOnly Property CurrentPerson() As PersonControl
			Get
				If tabMain.SelectedTabPage IsNot Nothing AndAlso tabMain.SelectedTabPage.Controls.Count > 0 AndAlso TypeOf tabMain.SelectedTabPage.Controls(0) Is PersonControl Then
					Return CType(tabMain.SelectedTabPage.Controls(0), PersonControl)
				Else
					Return Nothing
				End If
			End Get
		End Property

		Private Function GetControl(ByVal page As XtraTabPage) As IControl
			If page IsNot Nothing AndAlso page.Controls.Count > 0 AndAlso TypeOf page.Controls(0) Is IControl Then
				Return CType(page.Controls(0), IControl)
			Else
				Return Nothing
			End If
		End Function

		''' <summary>
		''' Home Tab Page
		''' </summary>
		Private privateHome As XtraTabPage
		Private Property Home() As XtraTabPage
			Get
				Return privateHome
			End Get
			Set(ByVal value As XtraTabPage)
				privateHome = value
			End Set
		End Property

		#Region "Logic"
		Private Sub LoadPerson(Optional ByVal person As Person = Nothing)
			' check if tab already loaded
			If person IsNot Nothing Then
				For Each t As XtraTabPage In tabMain.TabPages
					Dim control As IControl = GetControl(t)
					If control.TabType = TabType.Person AndAlso control.Id = person.Oid Then
						tabMain.SelectedTabPage = t
						Return
					End If
				Next t
			End If


			Dim p As New PersonControl()
			If person Is Nothing Then
				p.LoadData(New Person(), collectionCategories)
			Else
				p.LoadData(person, collectionCategories)
			End If

			Dim tab = tabMain.TabPages.Add(If(person Is Nothing, "[New Person]", p.Title.Replace("&", "and")))
			p.Dock = DockStyle.Fill
			tab.Controls.Add(p)
			tab.Image = imgIcons.Images(2)
			tabMain.SelectedTabPage = tab
		End Sub

		Private Sub Save()
			Dim control As IControl = GetControl(tabMain.SelectedTabPage)
			tabMain.SelectedTabPage.Focus()
			If control IsNot Nothing Then
				control.Save()
				If TypeOf control Is PersonControl Then
					tabMain.SelectedTabPage.Text = (CType(control, PersonControl)).Title.Replace("&", "and")

					GetControl(Home).Reload()
				End If
			End If
		End Sub

		Private Sub Delete()
			Dim control As IControl = GetControl(tabMain.SelectedTabPage)
			If control IsNot Nothing Then
				If XtraMessageBox.Show("Are you sure you wish to remove the selected item?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
					Dim oid As Integer = control.Delete()
					If control.TabType <> TabType.PersonList Then
						CloseTab(control.TabType, control.Id)
					End If

					If Home IsNot Nothing AndAlso TypeOf control Is PersonControl AndAlso Home.Controls.Count > 0 AndAlso TypeOf Home.Controls(0) Is IControl Then
						CType(Home.Controls(0), IControl).Reload()
					End If
				End If
			End If
		End Sub

		Private Sub HomeTab()
			If Home IsNot Nothing Then
				tabMain.SelectedTabPage = Home
			Else
				Dim p As New PersonListControl()
				AddHandler p.PersonClicked, AddressOf p_PersonClicked
				Dim tab = tabMain.TabPages.Add("Home")
				p.Dock = DockStyle.Fill
				tab.Controls.Add(p)
				tab.Image = imgIcons.Images(3)
				tabMain.SelectedTabPage = tab
				tab.ShowCloseButton = DefaultBoolean.False
				Home = tab
			End If
		End Sub

		Private Sub RefreshCurrent()
			Dim control As IControl = GetControl(tabMain.SelectedTabPage)
			If control IsNot Nothing Then
				control.Reload()
			End If
		End Sub

		Private Sub CloseTab(ByVal type As TabType, Optional ByVal id As Integer = -1)
			For Each t As XtraTabPage In tabMain.TabPages
				Dim control As IControl = GetControl(t)
				If control IsNot Nothing AndAlso control.TabType = type AndAlso control.Id = id Then

					If control.IsDirty AndAlso XtraMessageBox.Show("The current item has been changed. Save Changes?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
						control.Save()
					End If

					t.PageVisible = False
					t.Dispose()
					Exit For

				End If
			Next t
		End Sub
		#End Region

		#Region "Events"

		Public Sub p_PersonClicked(ByVal sender As Object, ByVal e As PersonEventArgs)
			LoadPerson(e.Person)
		End Sub

		Private Sub barNewPerson_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barNewPerson.ItemClick
			LoadPerson()
		End Sub

		Private Sub barSave_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barSave.ItemClick
			Save()
		End Sub

		Private Sub barHome_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barHome.ItemClick
			HomeTab()
		End Sub

		Private Sub tabMain_CloseButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles tabMain.CloseButtonClick
			Dim args As ClosePageButtonEventArgs = CType(e, ClosePageButtonEventArgs)
			tabMain.SelectedTabPage = CType(args.Page, XtraTabPage)
			Dim control As IControl = GetControl(tabMain.SelectedTabPage)
			CloseTab(control.TabType, control.Id)
		End Sub

		Private Sub barRefresh_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barRefresh.ItemClick
			RefreshCurrent()
		End Sub

		Private Sub barClose_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barClose.ItemClick
			Application.Exit()
		End Sub

		Private Sub menuHome_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles menuHome.ItemClick
			HomeTab()
		End Sub

		Private Sub menuNew_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles menuNew.ItemClick
			LoadPerson()
		End Sub

		Private Sub menuRefresh_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles menuRefresh.ItemClick
			RefreshCurrent()
		End Sub

		Private Sub menuSave_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles menuSave.ItemClick
			Save()
		End Sub

		Private Sub menuDelete_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles menuDelete.ItemClick
			Delete()
		End Sub

		Private Sub menuExit_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles menuExit.ItemClick
			Application.Exit()
		End Sub

		Private Sub barDelete_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barDelete.ItemClick
			Delete()
		End Sub
		#End Region

		Private Sub LoadDesigner(ByVal type As ReportType)
			Dim form As New XRDesignForm()
			Dim controller = form.DesignMdiController
			If type = ReportType.Category Then
				controller.AddService(GetType(ReportTypeService), New CategoryReportService())
			Else
				controller.AddService(GetType(ReportTypeService), New PersonReportService())
			End If

			controller.CreateNewReport()
			form.DesignDockManager(DesignDockPanelType.FieldList).Show()
			form.ShowDialog()
			LoadReportMenu()
		End Sub

		Private Sub LoadDesigner(ByVal url As String)
			'var report = XtraReport.FromFile(url, true);
			'if (report is IReport)
			'    (report as IReport).LoadDataSource();
			'report.ShowDesignerDialog();

			Dim preview As New EditorControl(url)
			preview.Reload()
			preview.Dock = DockStyle.Fill
			Dim tab = tabMain.TabPages.Add()
			tab.Text = "Edit"
			tab.Controls.Add(preview)

			tabMain.SelectedTabPage = tab
		End Sub

		Private Sub LoadPreview(ByVal url As String)
			'var report = XtraReport.FromFile(url, true);
			'if (report is IReport)
			'    (report as IReport).LoadDataSource();
			'report.ShowPreview();

			Dim preview As New PreviewControl(url)
			preview.Reload()
			preview.Dock = DockStyle.Fill
			Dim tab = tabMain.TabPages.Add()
			tab.Text = "Preview"
			tab.Controls.Add(preview)

			tabMain.SelectedTabPage = tab


		End Sub

		Private Sub LoadReportMenu()
			barReportPreview.ClearLinks()
			Dim path = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\"c))
			For Each f In Directory.EnumerateFiles(path, "*.repx")
				Dim b As New BarSubItem(barMain, f)
				Dim edit As New BarButtonItem(barMain, "Edit")
				AddHandler edit.ItemClick, AddressOf edit_ItemClick
				edit.Tag = f
				b.AddItem(edit)
				b.Tag = f
				b.Caption = f.Substring(f.LastIndexOf("\"c) + 1, f.Length - f.LastIndexOf("\"c) - 1)
				AddHandler b.ItemClick, AddressOf preview_ItemClick
				barReportPreview.ItemLinks.Add(b)
			Next f
		End Sub

		Private Sub preview_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			LoadPreview(e.Item.Tag.ToString())
		End Sub

		Private Sub edit_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			LoadDesigner(e.Item.Tag.ToString())
		End Sub

		Private Sub barByPerson_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barByPerson.ItemClick
			LoadDesigner(ReportType.Person)
		End Sub

		Private Sub barByCategory_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barByCategory.ItemClick
			LoadDesigner(ReportType.Category)
		End Sub
	End Class
End Namespace
