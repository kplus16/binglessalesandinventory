Imports MySql.Data.MySqlClient

Public Class ReportsForm

    Private Sub ReportsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewAllItem()
        'ViewAllsales()

    End Sub

    Private Sub btn_SalesGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SalesGenerate.Click
        Dim a = New SalesReport(txtDateFrom.Value.ToString("yyyy-MM-dd"), txtDateTo.Value.ToString("yyyy-MM-dd"))
        a.ShowDialog()


        'If txtDateTo.Value < txtDateFrom.Value Then
        '    MsgBox("Invalid Date To.", MsgBoxStyle.Critical)

        'Else



        '    connect_DB()



        '    ds = New DataSet
        '    da = New MySqlDataAdapter("SELECT * FROM tbl_totalsales WHERE transactiondate BETWEEN @from AND @to ", sqlCon)
        '    da.SelectCommand.Parameters.AddWithValue("@from", txtDateFrom.Text)
        '    da.SelectCommand.Parameters.AddWithValue("@to", txtDateTo.Text)
        '    da.Fill(ds, "tbl_totalsales")



        '    Dim salesreports As New CrystalReport1
        '    salesreports.SetParameterValue("StartDaate", txtDateFrom.Text)
        '    salesreports.SetParameterValue("EndDaate", txtDateTo.Text)
        '    SReport.CrystalReportViewer1.ReportSource = salesreports
        '    SReport.Show()

        'End If

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        InventoryReport.Show()
    End Sub
    Public Sub ViewAllItem()
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT ItemCode as Code, ItemName as Name, ItemDescription as Description, ItemPrice as Price, ItemStock as Stock FROM tbl_InventoryItem", sqlCon)
        da.Fill(dt)
        disconnect_DB()

        DataGridViewInventory.DataSource = dt

    End Sub
    'Public Sub ViewAllsales()
    '    connect_DB()
    '    dt = New DataTable
    '    da = New MySqlDataAdapter("SELECT * FROM tbl_totalsales", sqlCon)
    '    da.Fill(dt)
    '    disconnect_DB()

    '    DataGridViewsales.DataSource = dt


    'End Sub

   
End Class