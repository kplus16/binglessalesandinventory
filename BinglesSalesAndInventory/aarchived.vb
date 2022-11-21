Imports MySql.Data.MySqlClient

Public Class aarchived

    Private Sub schedule_data_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles schedule_data.CellContentClick

    End Sub

    Public Sub ViewAllReservation()

        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT customer_name as 'Customer', event_name as 'Event', date_needed as 'Date', time_needed as 'Time' FROM tbl_archive WHERE date_needed>=@nooow ORDER BY customer_name ASC ", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@nooow", Date.Now.ToString("yyyy/MM/dd"))
        da.Fill(dt)
        disconnect_DB()
        schedule_data.DataSource = dt

    End Sub

    Private Sub aarchived_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewAllReservation()

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT customer_name as 'Customer', event_name as 'Event', date_needed as 'Date', time_needed as 'Time' FROM tbl_archive WHERE customer_name LIKE @customer_name", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@customer_name", "%" & txtSearch.Text & "%")
        da.Fill(dt)
        disconnect_DB()

        schedule_data.DataSource = dt
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class