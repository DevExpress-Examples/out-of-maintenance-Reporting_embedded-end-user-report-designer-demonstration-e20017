using System;
using Contacts.Data;

namespace Contacts.Controls
{
    public class PersonEventArgs : EventArgs
    {
        public Person Person { get; set; }
        public PersonEventArgs(Person p)
        {
            Person = p;
        }
    }
}
