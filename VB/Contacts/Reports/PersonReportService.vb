Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.XtraReports.UI

Namespace Contacts.Reports
	Public Class PersonReportService
        Implements ReportTypeService
		Private Shared _counter As Integer = 0
        Public Function GetDefaultReport() As XtraReport Implements ReportTypeService.GetDefaultReport
            _counter += 1
            Dim r As New PersonReport()
            r.Name = String.Format("PersonReport{0}", _counter)
            r.DisplayName = r.Name
            r.LoadDataSource()
            Return r
        End Function

        Public Function [GetType](ByVal reportType As Type) As Type Implements ReportTypeService.GetType
            Return reportType
        End Function
	End Class
End Namespace
