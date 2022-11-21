Imports MySql.Data.MySqlClient

Public Class Notification


    Public Sub ViewAllReservation()
       

        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT reservation_id as 'Code', customer_name as 'Customer', event_name as 'Event', event_address as 'Address', date_needed as 'Date', time_needed as 'Time' FROM tbl_reservation WHERE date_needed BETWEEN @startdate AND @enddate ", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@enddate", Date.Now.AddDays(4))
        da.SelectCommand.Parameters.AddWithValue("@startdate", Date.Now)
        da.Fill(dt)
        disconnect_DB()
        DataGridUPEVENTS.DataSource = dt

    End Sub

    Public Sub ViewAllSellingItem()
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT i.ItemName as Name, i.ItemDescription as Description, i.ItemPrice as Price, i.ItemStock as Stock,  s.SupplierName as Supplier FROM tbl_InventoryItem i JOIN tbl_Supplier s on i.SupplierID=s.SupplierID WHERE i.ItemStock<10", sqlCon)
        da.Fill(dt)
        disconnect_DB()

        DataGridINSTOCKS.DataSource = dt

    End Sub
    Private Sub TabStocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStocks.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Notification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewAllReservation()
        ViewAllSellingItem()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class