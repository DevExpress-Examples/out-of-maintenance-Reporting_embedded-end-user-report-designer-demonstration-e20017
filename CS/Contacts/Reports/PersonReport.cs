using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using Contacts.Data;

namespace Contacts.Reports
{
    public partial class PersonReport : XtraReport, IReport
    {
        public PersonReport()
        {
            InitializeComponent();
        }


        public void LoadDataSource()
        {
            DataSource = new XPCollection<Person>();
        }
    }
}
