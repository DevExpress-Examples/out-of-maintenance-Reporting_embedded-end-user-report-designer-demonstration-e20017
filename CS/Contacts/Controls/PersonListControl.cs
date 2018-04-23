using System;
using Contacts.Data;
using DevExpress.XtraEditors;

namespace Contacts.Controls
{
    public partial class PersonListControl : XtraUserControl, IControl
    {
        #region Properties/Events
        public int Id { get; set; }
        public TabType TabType
        {
            get { return TabType.PersonList; }
        }
        // Never dirty!
        public bool IsDirty { get { return false; } }

        public delegate void PersonClickEventHandler(object sender, PersonEventArgs e);
        public event PersonClickEventHandler PersonClicked;
        protected virtual void OnPersonClick(PersonEventArgs e)
        {
            if (PersonClicked != null)
                PersonClicked(this, e);
        }
        #endregion

        public PersonListControl()
        {
            InitializeComponent();
            Id = -1;
        }

        #region Person List Logic
        /// <summary>
        /// Save grid, nothing to do here...
        /// </summary>
        public void Save()
        {

        }

        /// <summary>
        /// Reload Grid
        /// </summary>
        public void Reload()
        {
            collectionPersons.Reload();
        }

        /// <summary>
        /// Removed focused person
        /// </summary>
        /// <returns>Oid of deleted person</returns>
        public int Delete()
        {
            if (gridViewPerson.SelectedRowsCount == 1)
            {
                int handle = gridViewPerson.GetDataSourceRowIndex(gridViewPerson.GetSelectedRows()[0]);
                int oid = (collectionPersons[handle] as Person).Oid;
                gridViewPerson.DeleteRow(handle);
                return oid;
            }
            else
                return -1;
        }
        #endregion

        #region Events
        private void gridViewPerson_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewPerson.SelectedRowsCount == 1)
            {
                var p =
                    collectionPersons[gridViewPerson.GetDataSourceRowIndex(gridViewPerson.GetSelectedRows()[0])] as Person;
                OnPersonClick(new PersonEventArgs(p));
            }
        }
        #endregion
    }
}