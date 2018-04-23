using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraReports.UI;

namespace Contacts.Reports
{
    public class CategoryReportService : ReportTypeService
    {
        private static int _counter = 0;
        public XtraReport GetDefaultReport()
        {
            _counter++;
            CategoryReport r = new CategoryReport();
            r.Name = string.Format("CategoryReport{0}", _counter);
            r.DisplayName = r.Name;
            r.LoadDataSource();
            return r;
        }

        public Type GetType(Type reportType)
        {
            return reportType;
        }
    }
}
