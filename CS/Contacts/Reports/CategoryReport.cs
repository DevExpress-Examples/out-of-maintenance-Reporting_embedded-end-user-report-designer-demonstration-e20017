using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using Contacts.Data;

namespace Contacts.Reports
{
    public partial class CategoryReport : XtraReport, IReport
    {
        public CategoryReport()
        {
            InitializeComponent();
        }


        public void LoadDataSource()
        {
            DataSource = new XPCollection<Category>();
        }
    }
}
