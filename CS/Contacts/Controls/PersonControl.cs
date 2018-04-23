using System;
using System.Linq;
using Contacts.Data;
using DevExpress.Xpo;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Contacts.Controls
{
    public partial class PersonControl : XtraUserControl, IControl
    {
        #region Properties
        public int Id { get; set; }

        public TabType TabType
        {
            get { return TabType.Person; }
        }

        private bool _IsLoaded;
        public bool IsLoaded
        {
            get { return _IsLoaded; }
        }

        public Person Person
        {
            get
            {
                return collectionPerson[0] as Person;
            }
        }

        public XPCollection<Category> Categories { get; set; }

        public bool IsDirty { get; private set; }
        
        public string Title
        {
            get
            {
                if (_IsLoaded)

                    return Person.Greeting;
                else
                    return string.Empty;
            }
        }
        #endregion

        public PersonControl()
        {
            _IsLoaded = false;
            InitializeComponent();
            IsDirty = false;
        }

        #region Person Logic
        /// <summary>
        /// Load a person
        /// </summary>
        /// <param name="p">Person to load</param>
        public void LoadData(Person p, XPCollection categories = null)
        {
            if (categories == null) Categories = new XPCollection<Category>(collectionCategories);
            else Categories = new XPCollection<Category>(categories);

            Categories.LoadingEnabled = true;
            checkedList.DataSource = Categories;


            collectionPerson.Add(p);
            if (p.Oid < 0)
            {
                p.Added = DateTime.Now;
                p.Modified = p.Added;
                layoutImage.Text = "Picture";
            }
            else
            {
                layoutImage.Text = Person.Greeting.Replace("&", "and");
                LoadCategories();
            }

            Id = p.Oid;
            p.Changed += person_Changed;
            IsDirty = false;
            _IsLoaded = true;
        }

        /// <summary>
        /// Saves current person
        /// </summary>
        /// <returns>Oid of Person</returns>
        public void Save()
        {
            layoutPerson.Focus();
            SaveCategories();
            layoutImage.Text = Person.Greeting.Replace("&", "and");
            Person.Modified = DateTime.Now;
            Person.Save();
            Id = Person.Oid;
            IsDirty = false;
        }

        /// <summary>
        /// Reload Current
        /// </summary>
        public void Reload()
        {
            layoutPerson.Focus();
            Person.Reload();
            LoadCategories();
            checkedList.Refresh();
            Refresh();
            IsDirty = false;
        }

        /// <summary>
        /// Load Categories
        /// </summary>
        private void LoadCategories()
        {
            checkedList.UnCheckAll();

            var indices = (from c in Categories
                              .Zip(Enumerable.Range(0, Categories.Count),
                                    (c, i) => new { Category = c, Index = i })
                           where Person.Categories.Contains(c.Category)
                           select c.Index).ToArray();

            foreach (var index in indices)
                checkedList.SetItemChecked(index, true);

        }

        /// <summary>
        /// Save Categories
        /// </summary>
        private void SaveCategories()
        {
            for (int i = 0; i < Categories.Count; i++)
            {
                bool containsItem = Person.Categories.Contains(Categories[i]);
                if (checkedList.GetItemChecked(i) && !containsItem)
                    Person.Categories.Add(Categories[i]);

                if (!checkedList.GetItemChecked(i) && containsItem)
                    Person.Categories.Remove(Categories[i]);
            }
        }

        /// <summary>
        /// Delete current
        /// </summary>
        /// <returns>Oid of deleted ite,</returns>
        public int Delete()
        {
            int id = Person.Oid;
            Person.Delete();
            return id;
        }
        #endregion

        #region Events
        private void person_Changed(object sender, ObjectChangeEventArgs e)
        {
            if(e.PropertyName != null)
                IsDirty = true;
        }

        private void imagePerson_Click(object sender, EventArgs e)
        {
            if (dialogOpen.ShowDialog() == DialogResult.OK)
            {
                var img = Image.FromFile(dialogOpen.FileName);
                imagePerson.EditValue = img;
                imagePerson.Update();
                Refresh();
            }
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            Category cat = new Category
            {
                Name = textCategoryName.Text,
                Description = textCategoryDescription.Text,
                Added = DateTime.Now,
                Modified = DateTime.Now
            };

            cat.Save();
            Categories.Add(cat);

            var index = Categories.BaseIndexOf(cat);
            LoadCategories();
            checkedList.SetItemChecked(index, true);

            textCategoryName.Text = "";
            textCategoryDescription.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (checkedList.SelectedIndex > -1)
            {
                Categories[checkedList.SelectedIndex].Delete();
                LoadCategories();
            }
        }
        #endregion
    }
}
