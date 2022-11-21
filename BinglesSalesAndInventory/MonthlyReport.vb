Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports MySql.Data.MySqlClient

Public Class MonthlyReport

  
    Private Sub MonthlyReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rptdoc = New ReportDocument()
        Dim dsw As New DataSetMONTHLY() ' .xsd file name
        Dim dt As New DataTable()

        ' set the name of data table
        dt.TableName = "tbl_totalsalesMonthly"
        dt = getAllProducts() ' this function is located below
        dsw.Tables(0).Merge(dt)
        ' your .rpt file path below
        rptdoc.Load("C:\Users\Sheila Young\Documents\Visual Studio 2010\Projects\BinglesSalesAndInventory\BinglesSalesAndInventory\Monthly.rpt")

        ' set dataset to the report viewer.
        rptdoc.SetDataSource(dsw)
        CrystalReportViewer1.ReportSource = rptdoc

    End Sub

    Private Function getAllProducts() As DataTable
        connect_DB()
        Dim query As String = "SELECT * FROM tbl_totalsalesMonthly"
        Dim da As New MySqlDataAdapter(query, sqlCon)
        Dim ds As New DataSet()
        da.Fill(ds)
        disconnect_DB()
        Return ds.Tables(0)
    End Function
End Class