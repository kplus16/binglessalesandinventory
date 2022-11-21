Imports MySql.Data.MySqlClient

Public Class reservationdetails
    Public id As Integer
    Dim itemcode As Integer
   

    Public Sub ViewDetails()

        Try
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("SELECT purchase_id as Code, item_name as Item, item_price as Price, order_quantity as Quantity FROM tbl_purchaseorder WHERE reservation_id = " & id, sqlCon)
            da.Fill(dt)
            disconnect_DB()
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox("error")
        End Try

        Try
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("SELECT  customer_name, event_name, date_needed, time_needed FROM tbl_reservation WHERE reservation_id = " & id, sqlCon)
            da.Fill(dt)
            disconnect_DB()
            dummy.DataSource = dt


            txt_customer.Text = dummy.Item(0, 0).Value
            txt_event.Text = dummy.Item(1, 0).Value
            txt_date.Text = dummy.Item(2, 0).Value
            txt_time.Text = dummy.Item(3, 0).Value

        Catch ex As Exception

        End Try
    End Sub

    Public Sub ViewRent()

        Try
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("SELECT purchase_id as Code, item_name as Item, item_price as Price, order_quantity as Quantity FROM tbl_purchaseorder WHERE rental=1 AND order_quantity>0 AND reservation_id = " & id, sqlCon)
            da.Fill(dt)
            disconnect_DB()
            DataGridRENT.DataSource = dt

        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try

        Try
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("SELECT  customer_name, event_name, date_needed, time_needed FROM tbl_reservation WHERE reservation_id = " & id, sqlCon)
            da.Fill(dt)
            disconnect_DB()
            dummy1.DataSource = dt

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If DataGridRENT.Rows.Count = 0 Then
            Button1.Enabled = True


        Else
            Button1.Enabled = False

        End If
        ViewDetails()
        ViewRent()

        Dim total As String
        connect_DB()
        ds = New DataSet
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT  amountdue FROM tbl_payment WHERE reservation_id = " & id, sqlCon)
        da.Fill(dt)
        For Each Row As DataRow In dt.Rows
            total = Row(0)
        Next
        lblTOTAL.Text = total

        Dim bal As String
        connect_DB()
        ds = New DataSet
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT  balance FROM tbl_payment WHERE reservation_id = " & id, sqlCon)
        da.Fill(dt)
        For Each Row As DataRow In dt.Rows
            bal = Row(0)
        Next
        lblBalanced.Text = bal

        Dim par As String
        connect_DB()
        ds = New DataSet
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT payment FROM tbl_payment WHERE reservation_id = " & id, sqlCon)
        da.Fill(dt)
        For Each Row As DataRow In dt.Rows
            par = Row(0)
        Next
        lblPartial.Text = par


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("UPDATE tbl_reservation SET reservation_status = 0 WHERE reservation_id = @resid", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@resid", id)
       
        da.Fill(dt)
        disconnect_DB()

        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("DELETE FROM tbl_reservation WHERE customer_name=@customername AND  event_name=@eventname AND date_needed=@dateneeded AND time_needed=@timeneeded", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@customername", txt_customer.Text)
        da.SelectCommand.Parameters.AddWithValue("@eventname", txt_event.Text)
        da.SelectCommand.Parameters.AddWithValue("@dateneeded", Reservation.dateneeded.Value.Date)
        da.SelectCommand.Parameters.AddWithValue("@timeneeded", Reservation.timeneeded.Text)

        da.Fill(dt)
        disconnect_DB()

        MsgBox("Reservation Archived")
        Reservation.ViewAllReservation()

        Me.Close()
    End Sub

    Private Sub DataGridRENT_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridRENT.MouseClick
        Dim i As Integer
        i = DataGridRENT.CurrentRow.Index
        itemcode = DataGridRENT.Item(0, i).Value
        txtITEM.Text = DataGridRENT.Item(1, i).Value
        txtQUANTITY.Text = DataGridRENT.Item(3, i).Value


    End Sub


    Private Sub DataGridRENT_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridRENT.CellContentClick

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Dim i As Integer
        i = DataGridRENT.CurrentRow.Index

        Dim myValue As String
        myValue = InputBox("Enter the value of returned stocks", "Quantity", "Please Enter Value")
        If IsNumeric(myValue) Then
            Try
                connect_DB()
                dt = New DataTable
                da = New MySqlDataAdapter("UPDATE  tbl_inventoryitem SET ItemStock = ItemStock + @orderquantity WHERE ItemName = @itemname", sqlCon)
                da.SelectCommand.Parameters.AddWithValue("@itemname", txtITEM.Text)
                da.SelectCommand.Parameters.AddWithValue("@orderquantity", myValue)
                da.Fill(dt)
                disconnect_DB()

                connect_DB()
                dt = New DataTable
                da = New MySqlDataAdapter("UPDATE  tbl_purchaseorder SET order_quantity = order_quantity - @orderquantity WHERE item_name = @itemname", sqlCon)
                da.SelectCommand.Parameters.AddWithValue("@itemname", txtITEM.Text)
                da.SelectCommand.Parameters.AddWithValue("@orderquantity", myValue)
                da.Fill(dt)
                disconnect_DB()

               


                txtITEM.Text = ""
                txtQUANTITY.Text = ""
                ViewRent()
                connect_DB()
                ds = New DataSet
                da = New MySqlDataAdapter("SELECT *FROM tbl_purchaseorder WHERE purchase_id=@id ", sqlCon)
                da.SelectCommand.Parameters.AddWithValue("@id", itemcode)
                da.Fill(ds, "tbl_inventoryitem")
                Dim dtb As New DataTable
                Dim qty As New Integer
                Dim count As Integer = 0
                da.Fill(dtb)
                While dtb.Rows.Count > count
                    If dtb.Rows.Count > 0 Then
                        qty = dtb.Rows(count).Item("order_quantity").ToString
                        count = count + 1
                    End If
                End While

                If qty > 0 Then
                    Dim ins As Integer
                    Dim add As Integer
                    ins = InputBox("Insert forfeit.")
                    add = qty * ins
                    MsgBox(add) ' Value 
                    lblBalanced.Text = CInt(lblBalanced.Text) + add + ".00"


                Else
                    MsgBox("Done.")
                End If
                disconnect_DB()
            Catch
                MsgBox(ErrorToString)
            End Try
        Else
            MsgBox("Numbers only, Please try again!")
        End If
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT * FROM tbl_inventoryitem WHERE ItemStock<0", sqlCon)
        da.Fill(dt)
        disconnect_DB()
        DataGridRENT.DataSource = dt
        If DataGridRENT.Rows.Count = 0 Then
            Button1.Enabled = True


        Else
            Button1.Enabled = False

        End If
    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
            btnPay.Enabled = True
            amountPaid.ShowDialog()

    End Sub
End Class