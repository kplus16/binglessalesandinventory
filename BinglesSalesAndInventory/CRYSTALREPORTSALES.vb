Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class CRYSTALREPORTSALES
    Public fullname As String
    Public Sub New(ByVal set_date_from As Date, ByVal set_date_to As Date)

        ' This call is required by the designer.

        InitializeComponent()
        Dim rptdoc = New ReportDocument()
        rptdoc.Load(System.IO.Path.GetFullPath("C:\Users\Sheila Young\Documents\Visual Studio 2010\Projects\BinglesSalesAndInventory\BinglesSalesAndInventory\SALESREPORTCRYS.rpt"))
        rptdoc.SetParameterValue(0, set_date_from)
        rptdoc.SetParameterValue(1, set_date_to)
        CrystalReportViewer1.ReportSource = rptdoc
        ' Add any initialization after the InitializeComponent() call.

    End Sub

End Class