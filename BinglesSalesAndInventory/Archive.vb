Imports MySql.Data.MySqlClient

Public Class Archive

    Private Sub Archive_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ViewHistory()
    End Sub

    Public Sub ViewHistory()
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT customer_name as Customer, COUNT(*) AS OrderCount FROM tbl_reservation GROUP BY customer_name HAVING OrderCount > 0 ORDER BY OrderCount DESC ", sqlCon)
        da.Fill(dt)
        disconnect_DB()
        grid_orders.DataSource = dt
    End Sub

    Private Sub grid_orders_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_orders.CellContentDoubleClick
        
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub grid_orders_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_orders.CellContentClick

    End Sub

    Private Sub grid_orders_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid_orders.MouseClick
        Dim i As Integer
        Dim custname As Object
        i = grid_orders.CurrentRow.Index
        custname = grid_orders.Item(0, i).Value
        OrderHistory.customer_name = custname
        OrderHistory.ShowDialog()
    End Sub
End Class