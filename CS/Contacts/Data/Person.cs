using System;
using DevExpress.Xpo;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace Contacts.Data
{

    public class Person : XPObject
    {
        public Person()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Person(Session session)
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

        private string _Greeting;
        public string Greeting
        {
            get
            {
                return _Greeting;
            }
            set
            {
                SetPropertyValue("Greeting", ref _Greeting, value);
            }
        }

        [DisplayName("First Name")]
        private string _FirstName;
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                SetPropertyValue("FirstName", ref _FirstName, value);
            }
        }

        [DisplayName("Last Name")]
        private string _LastName;
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                SetPropertyValue("LastName", ref _LastName, value);
            }
        }

        private string _Address;
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                SetPropertyValue("Address", ref _Address, value);
            }
        }

        private string _City;
        public string City
        {
            get
            {
                return _City;
            }
            set
            {
                SetPropertyValue("City", ref _City, value);
            }
        }

        private string _State;
        public string State
        {
            get
            {
                return _State;
            }
            set
            {
                SetPropertyValue("State", ref _State, value);
            }
        }

        private int _Zip;
        public int Zip
        {
            get
            {
                return _Zip;
            }
            set
            {
                SetPropertyValue("Zip", ref _Zip, value);
            }
        }

        private byte[] _Picture;
        public byte[] Picture
        {
            get
            {
                return _Picture;
            }
            set
            {
                SetPropertyValue("Picture", ref _Picture, value);
            }
        }

        [NonPersistent]
        public Image Image
        {
            get
            {
                if (Picture == null || Picture.Length == 0)
                    return null;
                else
                    return Image.FromStream(new MemoryStream(Picture));
            }
            set
            {
                using (MemoryStream m = new MemoryStream())
                {
                    value.Save(m, ImageFormat.Png);
                    _Picture = m.ToArray();
                }
            }
        }

        private string _Notes;
        public string Notes
        {
            get
            {
                return _Notes;
            }
            set
            {
                SetPropertyValue("Notes", ref _Notes, value);
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
        public XPCollection<Category> Categories
        {
            get
            {
                return GetCollection<Category>("Categories");
            }
        }

    }
}