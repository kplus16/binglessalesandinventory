Imports MySql.Data.MySqlClient
Public Class OrderHistory
    Public customer_name As Object

    Private Sub OrderHistory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ViewHistory()
    End Sub

    Public Sub ViewHistory()
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT reservation_id as Code, customer_name as Customer , event_name as Event, event_address as Address, date_needed as Date, time_needed as Time FROM tbl_reservation WHERE customer_name = @custname", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@custname", customer_name)
        da.Fill(dt)
        disconnect_DB()
        grid_history.DataSource = dt
    End Sub

    Private Sub grid_history_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_history.CellContentClick
        
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub grid_history_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid_history.MouseClick
        Dim i, reservation_id As Integer
        i = grid_history.CurrentRow.Index
        reservation_id = grid_history.Item(0, i).Value
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT item_name as Item, order_quantity as Quantity, total as Total FROM tbl_purchaseorder WHERE reservation_id = @id", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@id", reservation_id)
        da.Fill(dt)
        disconnect_DB()
        grid_orderlist.DataSource = dt
    End Sub
End Class