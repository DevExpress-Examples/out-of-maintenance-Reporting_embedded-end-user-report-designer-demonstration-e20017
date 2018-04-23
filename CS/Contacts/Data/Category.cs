using System;
using DevExpress.Xpo;

namespace Contacts.Data
{

    public class Category : XPObject
    {
        public Category()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Category(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                SetPropertyValue("Name", ref _Name, value);
            }
        }

        private string _Description;
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                SetPropertyValue("Description", ref _Description, value);
            }
        }

        private DateTime _Added;
        public DateTime Added
        {
            get
            {
                return _Added;
            }
            set
            {
                SetPropertyValue("Added", ref _Added, value);
            }
        }

        private DateTime _Modified;
        public DateTime Modified
        {
            get
            {
                return _Modified;
            }
            set
            {
                SetPropertyValue("Modified", ref _Modified, value);
            }
        }

        [Association("PersonCategory")]
        public XPCollection<Person> Persons
        {
            get
            {
                return GetCollection<Person>("Persons");
            }
        } 

    }

}