Imports MySql.Data.MySqlClient

Public Class Reservation


    Public reservation_id As Integer = 0
   

    Private Sub Reservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ViewAllReservation()

    End Sub

    Private Sub date_check_ValueChanged(sender As System.Object, e As System.EventArgs) Handles date_check.ValueChanged
        POS.rbITEMS.Checked = True

        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT reservation_id as Code, customer_name as Customer , event_name as Event, event_address as Address, date_needed as Date, time_needed as Time FROM tbl_reservation WHERE date_needed = @dateneeded", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@dateneeded", date_check.Value.Date)
        da.Fill(dt)
        disconnect_DB()
        schedule_data.DataSource = dt
    End Sub

    Private Sub btn_reserve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reserve.Click
       
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("TRUNCATE tbl_dummy", sqlCon)
        da.Fill(dt)
        disconnect_DB()

        Dim LogsID As String
        connect_DB()
        ds = New DataSet
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT LogsID FROM tbl_logs", sqlCon)
        da.Fill(dt)
        For Each Row As DataRow In dt.Rows
            LogsID = Row(0) 'row is the current row selected and 0 is the column number
        Next
        lblLogs.Text = LogsID

        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("INSERT INTO tbl_logsactivity (logsID, logsActivity) VALUES (@logsID,'Adds a reservation')", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@logsID", lblLogs.Text)

        da.Fill(dt)
        disconnect_DB()

        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("INSERT INTO tbl_reservation (customer_name, event_name, event_address, date_needed, time_needed,reservation_status) VALUES (@customername, @eventname, @eventaddress, @dateneeded, @timeneeded,1)", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@customername", txt_custname.Text)
        da.SelectCommand.Parameters.AddWithValue("@eventname", txt_eventname.Text)
        da.SelectCommand.Parameters.AddWithValue("@eventaddress", txt_address.Text)
        da.SelectCommand.Parameters.AddWithValue("@dateneeded", dateneeded.Value.Date)
        da.SelectCommand.Parameters.AddWithValue("@timeneeded", timeneeded.Text)

        da.Fill(dt)
        disconnect_DB()
        MsgBox("Reservation Added")

        POS.Show()
        POS.MdiParent = MainMenu
        POS.Location = New Point(0, 247)

        txt_address.Text = ""
        txt_custname.Text = ""
        txt_eventname.Text = ""

    End Sub



    Private Sub schedule_data_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles schedule_data.MouseDoubleClick
        Try
            Dim i As Integer
            i = schedule_data.CurrentRow.Index
            reservation_id = schedule_data.Item(0, i).Value
            reservationdetails.id = reservation_id
            reservationdetails.ShowDialog()
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try

    End Sub

  
    Public Sub ViewAllReservation()
       
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT reservation_id as 'Code', customer_name as 'Customer', event_name as 'Event', event_address as 'Address', date_needed as 'Date', time_needed as 'Time' FROM tbl_reservation WHERE reservation_status = 1 AND date_needed>=@nooow ORDER BY date_needed ASC ", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@nooow", Date.Now.ToString("yyyy/MM/dd"))
        da.Fill(dt)
        disconnect_DB()
        schedule_data.DataSource = dt

    End Sub
  
    Private Sub pnl_sched_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnl_sched.Paint

    End Sub

    Private Sub btnArchived_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArchived.Click
        Archive.ShowDialog()

    End Sub

End Class