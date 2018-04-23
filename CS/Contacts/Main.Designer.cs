namespace Contacts
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SuperToolTip superToolTip8 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem8 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem8 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip9 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem9 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem9 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem7 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem7 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip10 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem10 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem10 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lookMain = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.barMain = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barHome = new DevExpress.XtraBars.BarButtonItem();
            this.barNewPerson = new DevExpress.XtraBars.BarButtonItem();
            this.barRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barSave = new DevExpress.XtraBars.BarButtonItem();
            this.barDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barClose = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.menuFile = new DevExpress.XtraBars.BarSubItem();
            this.menuHome = new DevExpress.XtraBars.BarButtonItem();
            this.menuNew = new DevExpress.XtraBars.BarButtonItem();
            this.menuRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.menuSave = new DevExpress.XtraBars.BarButtonItem();
            this.menuDelete = new DevExpress.XtraBars.BarButtonItem();
            this.menuExit = new DevExpress.XtraBars.BarButtonItem();
            this.menuOptions = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imgIcons = new DevExpress.Utils.ImageCollection();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lookUpPerson = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tabMain = new DevExpress.XtraTab.XtraTabControl();
            this.collectionCategories = new DevExpress.Xpo.XPCollection();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barCreateReport = new DevExpress.XtraBars.BarSubItem();
            this.barByPerson = new DevExpress.XtraBars.BarButtonItem();
            this.barByCategory = new DevExpress.XtraBars.BarButtonItem();
            this.barReportPreview = new DevExpress.XtraBars.BarSubItem();
            ((System.ComponentModel.ISupportInitialize)(this.barMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // lookMain
            // 
            this.lookMain.LookAndFeel.SkinName = "Black";
            // 
            // barMain
            // 
            this.barMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3,
            this.bar4});
            this.barMain.DockControls.Add(this.barDockControlTop);
            this.barMain.DockControls.Add(this.barDockControlBottom);
            this.barMain.DockControls.Add(this.barDockControlLeft);
            this.barMain.DockControls.Add(this.barDockControlRight);
            this.barMain.Form = this;
            this.barMain.Images = this.imgIcons;
            this.barMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barNewPerson,
            this.barSave,
            this.barHome,
            this.barRefresh,
            this.barDelete,
            this.barClose,
            this.menuFile,
            this.menuNew,
            this.menuHome,
            this.menuRefresh,
            this.menuSave,
            this.menuDelete,
            this.menuExit,
            this.barSubItem1,
            this.barButtonItem1,
            this.menuOptions,
            this.barCreateReport,
            this.barByPerson,
            this.barByCategory,
            this.barReportPreview});
            this.barMain.MainMenu = this.bar2;
            this.barMain.MaxItemId = 22;
            this.barMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.lookUpPerson});
            this.barMain.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barHome),
            new DevExpress.XtraBars.LinkPersistInfo(this.barNewPerson),
            new DevExpress.XtraBars.LinkPersistInfo(this.barRefresh, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.barDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barClose, true)});
            this.bar1.Text = "Tools";
            // 
            // barHome
            // 
            this.barHome.Caption = "Home";
            this.barHome.Id = 3;
            this.barHome.ImageIndex = 3;
            this.barHome.Name = "barHome";
            toolTipTitleItem8.Text = "Home";
            toolTipItem8.LeftIndent = 6;
            toolTipItem8.Text = "List all people";
            superToolTip8.Items.Add(toolTipTitleItem8);
            superToolTip8.Items.Add(toolTipItem8);
            this.barHome.SuperTip = superToolTip8;
            this.barHome.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barHome_ItemClick);
            // 
            // barNewPerson
            // 
            this.barNewPerson.Caption = "New";
            this.barNewPerson.Id = 0;
            this.barNewPerson.ImageIndex = 1;
            this.barNewPerson.Name = "barNewPerson";
            toolTipTitleItem6.Text = "Person";
            toolTipItem6.LeftIndent = 6;
            toolTipItem6.Text = "Add new Person";
            superToolTip6.Items.Add(toolTipTitleItem6);
            superToolTip6.Items.Add(toolTipItem6);
            this.barNewPerson.SuperTip = superToolTip6;
            this.barNewPerson.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNewPerson_ItemClick);
            // 
            // barRefresh
            // 
            this.barRefresh.Caption = "Refresh";
            this.barRefresh.Id = 4;
            this.barRefresh.ImageIndex = 13;
            this.barRefresh.Name = "barRefresh";
            toolTipTitleItem9.Text = "Refresh";
            toolTipItem9.LeftIndent = 6;
            toolTipItem9.Text = "Refresh current item";
            superToolTip9.Items.Add(toolTipTitleItem9);
            superToolTip9.Items.Add(toolTipItem9);
            this.barRefresh.SuperTip = superToolTip9;
            this.barRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barRefresh_ItemClick);
            // 
            // barSave
            // 
            this.barSave.Caption = "Save";
            this.barSave.Id = 1;
            this.barSave.ImageIndex = 7;
            this.barSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.barSave.Name = "barSave";
            this.barSave.ShortcutKeyDisplayString = "Ctrl-S";
            toolTipTitleItem7.Text = "Save";
            toolTipItem7.LeftIndent = 6;
            toolTipItem7.Text = "Save Current Item";
            superToolTip7.Items.Add(toolTipTitleItem7);
            superToolTip7.Items.Add(toolTipItem7);
            this.barSave.SuperTip = superToolTip7;
            this.barSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSave_ItemClick);
            // 
            // barDelete
            // 
            this.barDelete.Caption = "Delete";
            this.barDelete.Id = 5;
            this.barDelete.ImageIndex = 14;
            this.barDelete.Name = "barDelete";
            toolTipTitleItem10.Text = "Delete";
            toolTipItem10.LeftIndent = 6;
            toolTipItem10.Text = "Delete Selected Item";
            superToolTip10.Items.Add(toolTipTitleItem10);
            superToolTip10.Items.Add(toolTipItem10);
            this.barDelete.SuperTip = superToolTip10;
            this.barDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDelete_ItemClick);
            // 
            // barClose
            // 
            this.barClose.Caption = "Exit";
            this.barClose.Id = 6;
            this.barClose.ImageIndex = 4;
            this.barClose.Name = "barClose";
            this.barClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barClose_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.menuFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.menuOptions),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // menuFile
            // 
            this.menuFile.Caption = "&File";
            this.menuFile.Id = 7;
            this.menuFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.menuHome),
            new DevExpress.XtraBars.LinkPersistInfo(this.menuNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.menuRefresh, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.menuSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.menuDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.menuExit, true)});
            this.menuFile.Name = "menuFile";
            // 
            // menuHome
            // 
            this.menuHome.Caption = "&Home";
            this.menuHome.Id = 10;
            this.menuHome.Name = "menuHome";
            this.menuHome.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuHome_ItemClick);
            // 
            // menuNew
            // 
            this.menuNew.Caption = "&New";
            this.menuNew.Id = 9;
            this.menuNew.Name = "menuNew";
            this.menuNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuNew_ItemClick);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Caption = "&Refresh";
            this.menuRefresh.Id = 11;
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuRefresh_ItemClick);
            // 
            // menuSave
            // 
            this.menuSave.Caption = "&Save";
            this.menuSave.Id = 12;
            this.menuSave.Name = "menuSave";
            this.menuSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuSave_ItemClick);
            // 
            // menuDelete
            // 
            this.menuDelete.Caption = "&Delete";
            this.menuDelete.Id = 13;
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuDelete_ItemClick);
            // 
            // menuExit
            // 
            this.menuExit.Caption = "E&xit";
            this.menuExit.Id = 14;
            this.menuExit.Name = "menuExit";
            this.menuExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuExit_ItemClick);
            // 
            // menuOptions
            // 
            this.menuOptions.Caption = "&Options";
            this.menuOptions.Id = 17;
            this.menuOptions.Name = "menuOptions";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "&Help";
            this.barSubItem1.Id = 15;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "&About";
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(678, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 622);
            this.barDockControlBottom.Size = new System.Drawing.Size(678, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 571);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(678, 51);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 571);
            // 
            // imgIcons
            // 
            this.imgIcons.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgIcons.ImageStream")));
            this.imgIcons.Images.SetKeyName(0, "Add");
            this.imgIcons.Images.SetKeyName(1, "NewPerson");
            this.imgIcons.Images.SetKeyName(2, "Person");
            this.imgIcons.Images.SetKeyName(3, "Home");
            this.imgIcons.Images.SetKeyName(4, "Close");
            this.imgIcons.Images.SetKeyName(5, "Open");
            this.imgIcons.Images.SetKeyName(6, "Category");
            this.imgIcons.Images.SetKeyName(7, "Save");
            this.imgIcons.Images.SetKeyName(8, "Editor");
            this.imgIcons.Images.SetKeyName(9, "Report");
            this.imgIcons.Images.SetKeyName(10, "NewReport");
            this.imgIcons.Images.SetKeyName(11, "Print");
            this.imgIcons.Images.SetKeyName(12, "Find_16x16.png");
            this.imgIcons.Images.SetKeyName(13, "Refresh_16x16.png");
            this.imgIcons.Images.SetKeyName(14, "Delete_16x16.png");
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // lookUpPerson
            // 
            this.lookUpPerson.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("lookUpPerson.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.lookUpPerson.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Greeting", "Greeting", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpPerson.DisplayMember = "Greeting";
            this.lookUpPerson.EditValueChangedDelay = 3;
            this.lookUpPerson.Name = "lookUpPerson";
            this.lookUpPerson.NullText = "[Find Person]";
            this.lookUpPerson.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // tabMain
            // 
            this.tabMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 51);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(678, 571);
            this.tabMain.TabIndex = 4;
            this.tabMain.CloseButtonClick += new System.EventHandler(this.tabMain_CloseButtonClick);
            // 
            // collectionCategories
            // 
            this.collectionCategories.LoadingEnabled = false;
            this.collectionCategories.ObjectType = typeof(Contacts.Data.Category);
            // 
            // bar4
            // 
            this.bar4.BarName = "Custom 5";
            this.bar4.DockCol = 1;
            this.bar4.DockRow = 1;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCreateReport),
            new DevExpress.XtraBars.LinkPersistInfo(this.barReportPreview)});
            this.bar4.Offset = 207;
            this.bar4.Text = "Custom 5";
            // 
            // barCreateReport
            // 
            this.barCreateReport.Caption = "Create Report";
            this.barCreateReport.Id = 18;
            this.barCreateReport.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barByPerson),
            new DevExpress.XtraBars.LinkPersistInfo(this.barByCategory)});
            this.barCreateReport.Name = "barCreateReport";
            // 
            // barByPerson
            // 
            this.barByPerson.Caption = "By Person";
            this.barByPerson.Id = 19;
            this.barByPerson.Name = "barByPerson";
            this.barByPerson.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barByPerson_ItemClick);
            // 
            // barByCategory
            // 
            this.barByCategory.Caption = "By Category";
            this.barByCategory.Id = 20;
            this.barByCategory.Name = "barByCategory";
            this.barByCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barByCategory_ItemClick);
            // 
            // barReportPreview
            // 
            this.barReportPreview.Caption = "Preview";
            this.barReportPreview.Id = 21;
            this.barReportPreview.Name = "barReportPreview";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 644);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Main";
            this.Text = "Mailings!";
            ((System.ComponentModel.ISupportInitialize)(this.barMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel lookMain;
        private DevExpress.XtraBars.BarManager barMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barNewPerson;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraTab.XtraTabControl tabMain;
        public DevExpress.Utils.ImageCollection imgIcons;
        private DevExpress.XtraBars.BarButtonItem barSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpPerson;
        private DevExpress.XtraBars.BarButtonItem barHome;
        private DevExpress.XtraBars.BarButtonItem barRefresh;
        private DevExpress.XtraBars.BarButtonItem barDelete;
        private DevExpress.XtraBars.BarButtonItem barClose;
        private DevExpress.XtraBars.BarSubItem menuFile;
        private DevExpress.XtraBars.BarButtonItem menuHome;
        private DevExpress.XtraBars.BarButtonItem menuNew;
        private DevExpress.XtraBars.BarButtonItem menuRefresh;
        private DevExpress.XtraBars.BarButtonItem menuSave;
        private DevExpress.XtraBars.BarButtonItem menuDelete;
        private DevExpress.XtraBars.BarButtonItem menuExit;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem menuOptions;
        private DevExpress.Xpo.XPCollection collectionCategories;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarSubItem barCreateReport;
        private DevExpress.XtraBars.BarButtonItem barByPerson;
        private DevExpress.XtraBars.BarButtonItem barByCategory;
        private DevExpress.XtraBars.BarSubItem barReportPreview;
    }
}

