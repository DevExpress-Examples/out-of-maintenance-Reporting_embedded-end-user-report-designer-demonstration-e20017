namespace Contacts.Controls
{
    partial class PersonListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridPerson = new DevExpress.XtraGrid.GridControl();
            this.collectionPersons = new DevExpress.Xpo.XPCollection();
            this.gridViewPerson = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGreeting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryImage = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colModified = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPerson
            // 
            this.gridPerson.DataSource = this.collectionPersons;
            this.gridPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPerson.Location = new System.Drawing.Point(0, 0);
            this.gridPerson.MainView = this.gridViewPerson;
            this.gridPerson.Name = "gridPerson";
            this.gridPerson.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryImage});
            this.gridPerson.ShowOnlyPredefinedDetails = true;
            this.gridPerson.Size = new System.Drawing.Size(650, 433);
            this.gridPerson.TabIndex = 0;
            this.gridPerson.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPerson});
            // 
            // collectionPersons
            // 
            this.collectionPersons.DeleteObjectOnRemove = true;
            this.collectionPersons.ObjectType = typeof(Contacts.Data.Person);
            // 
            // gridViewPerson
            // 
            this.gridViewPerson.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGreeting,
            this.colCity,
            this.colState,
            this.colImage,
            this.colModified});
            this.gridViewPerson.GridControl = this.gridPerson;
            this.gridViewPerson.Name = "gridViewPerson";
            this.gridViewPerson.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewPerson.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewPerson.OptionsBehavior.Editable = false;
            this.gridViewPerson.OptionsBehavior.ReadOnly = true;
            this.gridViewPerson.RowHeight = 50;
            this.gridViewPerson.DoubleClick += new System.EventHandler(this.gridViewPerson_DoubleClick);
            // 
            // colGreeting
            // 
            this.colGreeting.FieldName = "Greeting";
            this.colGreeting.Name = "colGreeting";
            this.colGreeting.Visible = true;
            this.colGreeting.VisibleIndex = 0;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 1;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 2;
            // 
            // colImage
            // 
            this.colImage.ColumnEdit = this.repositoryImage;
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.OptionsColumn.ReadOnly = true;
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 3;
            // 
            // repositoryImage
            // 
            this.repositoryImage.CustomHeight = 50;
            this.repositoryImage.Name = "repositoryImage";
            this.repositoryImage.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // colModified
            // 
            this.colModified.DisplayFormat.FormatString = "g";
            this.colModified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colModified.FieldName = "Modified";
            this.colModified.Name = "colModified";
            this.colModified.Visible = true;
            this.colModified.VisibleIndex = 4;
            // 
            // PersonListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPerson);
            this.Name = "PersonListControl";
            this.Size = new System.Drawing.Size(650, 433);
            ((System.ComponentModel.ISupportInitialize)(this.gridPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridPerson;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colGreeting;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colModified;
        private DevExpress.Xpo.XPCollection collectionPersons;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryImage;

    }
}
