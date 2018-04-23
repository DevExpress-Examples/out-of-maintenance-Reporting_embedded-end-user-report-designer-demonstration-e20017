using System;
using Contacts.Data;
using DevExpress.Utils;
using Contacts.Controls;
using DevExpress.XtraTab;
using DevExpress.XtraBars;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraReports.UserDesigner;
using Contacts.Reports;
using DevExpress.XtraReports.UI;
using System.IO;

namespace Contacts
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            HomeTab();
            LoadReportMenu();
        }

        /// <summary>
        /// Current Focused Person
        /// </summary>
        private PersonControl CurrentPerson
        {
            get
            {
                if (tabMain.SelectedTabPage != null &&
                    tabMain.SelectedTabPage.Controls.Count > 0 &&
                    tabMain.SelectedTabPage.Controls[0] is PersonControl)
                    return (PersonControl)tabMain.SelectedTabPage.Controls[0];
                else
                    return null;
            }
        }

        private IControl GetControl(XtraTabPage page)
        {
            if (page != null &&
                    page.Controls.Count > 0 &&
                    page.Controls[0] is IControl)
                return (IControl)page.Controls[0];
            else
                return null;
        }

        /// <summary>
        /// Home Tab Page
        /// </summary>
        private XtraTabPage Home { get; set; }

        #region Logic
        private void LoadPerson(Person person = null)
        {
            // check if tab already loaded
            if (person != null)
            {
                foreach (XtraTabPage t in tabMain.TabPages)
                {
                    IControl control = GetControl(t);
                    if (control.TabType == TabType.Person
                        && control.Id == person.Oid)
                    {
                        tabMain.SelectedTabPage = t;
                        return;
                    }
                }
            }


            PersonControl p = new PersonControl();
            if (person == null)
                p.LoadData(new Person(), collectionCategories);
            else
                p.LoadData(person, collectionCategories);

            var tab = tabMain.TabPages.Add(person == null ? "[New Person]" : p.Title.Replace("&", "and"));
            p.Dock = DockStyle.Fill;
            tab.Controls.Add(p);
            tab.Image = imgIcons.Images[2];
            tabMain.SelectedTabPage = tab;
        }

        private void Save()
        {
            IControl control = GetControl(tabMain.SelectedTabPage);
            tabMain.SelectedTabPage.Focus();
            if (control != null)
            {
                control.Save();
                if (control is PersonControl)
                {
                    tabMain.SelectedTabPage.Text =
                        ((PersonControl)control)
                            .Title.Replace("&", "and");

                    GetControl(Home).Reload();
                }
            }
        }

        private void Delete()
        {
            IControl control = GetControl(tabMain.SelectedTabPage);
            if (control != null)
            {
                if (XtraMessageBox.Show("Are you sure you wish to remove the selected item?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    int oid = control.Delete();
                    if(control.TabType != TabType.PersonList)
                        CloseTab(control.TabType, control.Id);

                    if (Home != null &&
                        control is PersonControl &&
                        Home.Controls.Count > 0 && Home.Controls[0] is IControl)
                        ((IControl)Home.Controls[0]).Reload();
                }
            }
        }

        private void HomeTab()
        {
            if (Home != null)
                tabMain.SelectedTabPage = Home;
            else
            {
                PersonListControl p = new PersonListControl();
                p.PersonClicked += new PersonListControl.PersonClickEventHandler(p_PersonClicked);
                var tab = tabMain.TabPages.Add("Home");
                p.Dock = DockStyle.Fill;
                tab.Controls.Add(p);
                tab.Image = imgIcons.Images[3];
                tabMain.SelectedTabPage = tab;
                tab.ShowCloseButton = DefaultBoolean.False;
                Home = tab;
            }
        }

        private void RefreshCurrent()
        {
            IControl control = GetControl(tabMain.SelectedTabPage);
            if (control != null)
            {
                control.Reload();
            }
        }

        private void CloseTab(TabType type, int id = -1)
        {
            foreach (XtraTabPage t in tabMain.TabPages)
            {
                IControl control = GetControl(t);
                if (control != null 
                    && control.TabType == type
                    && control.Id == id)
                {

                    if (control.IsDirty &&
                        XtraMessageBox.Show("The current item has been changed. Save Changes?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        control.Save();

                    t.PageVisible = false;
                    t.Dispose();
                    break;

                }
            }
        }
        #endregion

        #region Events

        public void p_PersonClicked(object sender, PersonEventArgs e)
        {
            LoadPerson(e.Person);
        }

        private void barNewPerson_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadPerson();
        }

        private void barSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            Save();
        }

        private void barHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            HomeTab();
        }

        private void tabMain_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs args = (ClosePageButtonEventArgs)e;
            tabMain.SelectedTabPage = (XtraTabPage)args.Page;
            IControl control = GetControl(tabMain.SelectedTabPage);
            CloseTab(control.TabType, control.Id);
        }

        private void barRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshCurrent();
        }

        private void barClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void menuHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            HomeTab();
        }

        private void menuNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadPerson();
        }

        private void menuRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshCurrent();
        }

        private void menuSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            Save();
        }

        private void menuDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            Delete();
        }

        private void menuExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            Delete();
        }
        #endregion

        private void LoadDesigner(ReportType type)
        {
            XRDesignForm form = new XRDesignForm();
            var controller = form.DesignMdiController;
            if (type == ReportType.Category)
                controller.AddService(typeof(ReportTypeService),
                    new CategoryReportService());
            else
                controller.AddService(typeof(ReportTypeService),
                    new PersonReportService());

            controller.CreateNewReport();
            form.DesignDockManager[DesignDockPanelType.FieldList].Show();
            form.ShowDialog();
            LoadReportMenu();
        }

        private void LoadDesigner(string url)
        {
            //var report = XtraReport.FromFile(url, true);
            //if (report is IReport)
            //    (report as IReport).LoadDataSource();
            //report.ShowDesignerDialog();

            EditorControl preview = new EditorControl(url);
            preview.Reload();
            preview.Dock = DockStyle.Fill;
            var tab = tabMain.TabPages.Add();
            tab.Text = "Edit";
            tab.Controls.Add(preview);

            tabMain.SelectedTabPage = tab;
        }

        private void LoadPreview(string url)
        {
            //var report = XtraReport.FromFile(url, true);
            //if (report is IReport)
            //    (report as IReport).LoadDataSource();
            //report.ShowPreview();

            PreviewControl preview = new PreviewControl(url);
            preview.Reload();
            preview.Dock = DockStyle.Fill;
            var tab = tabMain.TabPages.Add();
            tab.Text = "Preview";
            tab.Controls.Add(preview);

            tabMain.SelectedTabPage = tab;

            
        }

        private void LoadReportMenu()
        {
            barReportPreview.ClearLinks();
            var path = Application
                .ExecutablePath
                .Substring(0, Application.ExecutablePath.LastIndexOf('\\'));
            foreach (var f in Directory.EnumerateFiles(path, "*.repx"))
            {
                BarSubItem b = new BarSubItem(barMain, f);
                BarButtonItem edit = new BarButtonItem(barMain, "Edit");
                edit.ItemClick += new ItemClickEventHandler(edit_ItemClick);
                edit.Tag = f;
                b.AddItem(edit);
                b.Tag = f;
                b.Caption = f.Substring(f.LastIndexOf('\\') + 1, f.Length - f.LastIndexOf('\\') - 1);
                b.ItemClick += new ItemClickEventHandler(preview_ItemClick);
                barReportPreview.ItemLinks.Add(b);
            }
        }

        void preview_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadPreview(e.Item.Tag.ToString());
        }

        void edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadDesigner(e.Item.Tag.ToString());
        }

        private void barByPerson_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadDesigner(ReportType.Person);
        }

        private void barByCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadDesigner(ReportType.Category);
        }
    }
}
