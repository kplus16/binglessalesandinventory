Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports MySql.Data.MySqlClient

Public Class SalesReport

    'Private Sub SalesReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Dim rptdoc = New ReportDocument()
    '    Dim dsw As New DataSet1() ' .xsd file name
    '    Dim dt As New DataTable()

    '    ' set the name of data table
    '    dt.TableName = "tbl_totalsales"
    '    dt = getAllProducts() ' this function is located below
    '    dsw.Tables(0).Merge(dt)
    '    ' your .rpt file path below
    '    rptdoc.Load("C:\Users\Sheila Young\Documents\Visual Studio 2010\Projects\BinglesSalesAndInventory\BinglesSalesAndInventory\Sales.rpt")

    '    ' set dataset to the report viewer.
    '    rptdoc.SetDataSource(dsw)
    '    CrystalReportViewer1.ReportSource = rptdoc
    'End Sub
    'Private Function getAllProducts() As DataTable
    '    connect_DB()
    '    Dim query As String = "SELECT * FROM tbl_totalsales"
    '    Dim da As New MySqlDataAdapter(query, sqlCon)
    '    Dim ds As New DataSet()
    '    da.Fill(ds)
    '    disconnect_DB()
    '    Return ds.Tables(0)
    'End Function


    Public Sub New(ByVal set_date_from As Date, ByVal set_date_to As Date)

        ' This call is required by the designer.

        InitializeComponent()
        Dim rptdoc = New ReportDocument()
        rptdoc.Load(System.IO.Path.GetFullPath("..\..\CrystalReport3.rpt"))
        rptdoc.SetParameterValue(1, set_date_from)
        rptdoc.SetParameterValue(0, set_date_to)
        CrystalReportViewer1.ReportSource = rptdoc
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub SalesReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class