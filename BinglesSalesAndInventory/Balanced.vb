Imports MySql.Data.MySqlClient

Public Class Balanced

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
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
        Me.Close()

    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged
        Dim sum As Double

        Dim num1 As Double = Double.Parse(POS.txtAmountDue.Text)
        Dim num2 As Double = Double.Parse(txtamount.Text)

        sum = num2 - num1
        txtchange.Text = sum
        
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class