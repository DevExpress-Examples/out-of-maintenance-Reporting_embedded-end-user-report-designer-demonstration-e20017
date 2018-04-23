using System;

namespace Contacts.Controls
{
    public enum TabType
    {
        PersonList,
        Person,
        Preview,
        Editor
    }

    public interface IControl
    {
        int Id { get; set; }
        bool IsDirty { get; }
        void Save();
        void Reload();
        int Delete();
        TabType TabType { get; }
    }
}
