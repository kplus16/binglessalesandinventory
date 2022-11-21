Imports MySql.Data.MySqlClient
Public Class amountPaid

    Private Sub txtamount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamount.KeyPress
     
      


    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("INSERT INTO tbl_totalsales (reservation_id, totalsales,customer_name,event,transactiondate) VALUES (@reservationid, @totalsales,@customer_name,@event,@transac)", sqlCon)
            da.SelectCommand.Parameters.AddWithValue("@reservationid", POS.res_id.Text)
            da.SelectCommand.Parameters.AddWithValue("@totalsales", POS.txtAmountDue.Text)
            da.SelectCommand.Parameters.AddWithValue("@customer_name", POS.lblName.Text)
            da.SelectCommand.Parameters.AddWithValue("@event", POS.lblEvent.Text)
            da.SelectCommand.Parameters.AddWithValue("@transac", Date.Now.ToString("MM/dd/yyyy"))
            da.Fill(dt)
            disconnect_DB()

        Catch ex As Exception

        End Try


        Try
            Dim balance As Double
            balance = CDbl(POS.txtAmountDue.Text) - CDbl(POS.txtPayment.Text)


            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("INSERT INTO tbl_payment (reservation_id,customer_name,amountdue, payment, balance) VALUES (@reservationid, @customer_name, @amountdue ,@payment,@balance)", sqlCon)
            da.SelectCommand.Parameters.AddWithValue("@reservationid", POS.res_id.Text)
            da.SelectCommand.Parameters.AddWithValue("@amountdue", POS.txtAmountDue.Text)
            da.SelectCommand.Parameters.AddWithValue("@customer_name", POS.lblName.Text)
            da.SelectCommand.Parameters.AddWithValue("@payment", POS.txtPayment.Text)
            da.SelectCommand.Parameters.AddWithValue("@balance", balance)
            da.Fill(dt)
            disconnect_DB()

        Catch ex As Exception


        End Try
        Try
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("UPDATE tbl_purchaseorder SET purchase_status = 0 WHERE reservation_id = " & POS.res_id.Text, sqlCon)
            da.Fill(dt)
            disconnect_DB()
            POS.DataGridRENTAL.DataSource = dt
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
        MsgBox("Order Processed.")
        txtamount.Clear()
        txtchange.Clear()



        Reservation.Show()
        Reservation.MdiParent = MainMenu
        Reservation.ViewAllReservation()
        Reservation.Location = New Point(0, 247)
        Me.Close()
        SupplierForm.Close()
        Catering.Close()
        Services.Close()
        POS.Close()
        Items.Close()
        AddItem.Close()
        MainMenu.Panel4.SendToBack()
        Receipt.ShowDialog()

    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged
        Try
            Dim sum As Double

            Dim num1 As Double = Double.Parse(POS.txtAmountDue.Text)
            Dim num2 As Double = Double.Parse(txtamount.Text)

            sum = num2 - num1
            txtchange.Text = sum
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub amountPaid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class