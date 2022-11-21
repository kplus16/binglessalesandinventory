Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports MySql.Data.MySqlClient


Public Class InventoryReport

    Private Sub InventoryReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rptdoc = New ReportDocument()
        Dim dsw As New DataSetReport() ' .xsd file name
        Dim dt As New DataTable()

        ' set the name of data table
        dt.TableName = "tbl_inventoryitem"
        dt = getAllProducts() ' this function is located below
        dsw.Tables(0).Merge(dt)
        ' your .rpt file path below
        rptdoc.Load("C:\Users\Sheila Young\Documents\Visual Studio 2010\Projects\BinglesSalesAndInventory\BinglesSalesAndInventory\CrystalReport2.rpt")

        ' set dataset to the report viewer.
        rptdoc.SetDataSource(dsw)
        CrystalReportViewer1.ReportSource = rptdoc
    End Sub
    Private Function getAllProducts() As DataTable
        connect_DB()
        Dim query As String = "SELECT * FROM tbl_inventoryitem"
        Dim da As New MySqlDataAdapter(query, sqlCon)
        Dim ds As New DataSet()
        da.Fill(ds)
        disconnect_DB()
        Return ds.Tables(0)
    End Function

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class

  