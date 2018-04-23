Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.XtraReports.UI

Namespace Contacts.Reports
	Public Class CategoryReportService
        Implements ReportTypeService

        Private Shared _counter As Integer = 0
        Public Function GetDefaultReport() As XtraReport Implements DevExpress.XtraReports.UserDesigner.ReportTypeService.GetDefaultReport
            _counter += 1
            Dim r As New CategoryReport()
            r.Name = String.Format("CategoryReport{0}", _counter)
            r.DisplayName = r.Name
            r.LoadDataSource()
            Return r
        End Function

        Public Function [GetType](ByVal reportType As Type) As Type Implements ReportTypeService.GetType
            Return reportType
        End Function
    End Class
End Namespace
