using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Contacts.Reports;

namespace Contacts.Controls
{
    public partial class PreviewControl : XtraUserControl, IControl
    {
        private string _url;
        public PreviewControl(string url = null)
        {
            InitializeComponent();
            _url = url;
        }
        

        public int Id { get; set; }

        public bool IsDirty
        {
            get { return true; }
        }

        public void Save()
        {
            return;
        }

        public void Reload()
        {
            if (_url != null)
            {
                var report = XtraReport.FromFile(_url, true);
                if (report is IReport)
                    (report as IReport).LoadDataSource();
                printControl1.PrintingSystem =
                    report.PrintingSystem;
                report.CreateDocument();
            }
        }

        public int Delete()
        {
            return -1;
        }

        public TabType TabType
        {
            get { return TabType.Preview; }
        }

    }
}
