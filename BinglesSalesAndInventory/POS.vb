Imports MySql.Data.MySqlClient

Public Class POS
    Dim pos As Integer
    Dim total As Object

    Public Sub ViewAllServices()
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT i.ServiceID as Code, i.ServiceName as Name, i.ServiceDescription as Description, i.ServiceFee as Fee,  s.SupplierName as Supplier FROM tbl_Services i JOIN tbl_Supplier s on i.SupplierID=s.SupplierID", sqlCon)
        da.Fill(dt)
        disconnect_DB()

        DataGridViewServices.DataSource = dt

    End Sub


    Public Sub ViewAllCatering()
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT * FROM tbl_catering", sqlCon)
        da.Fill(dt)
        disconnect_DB()

        DataGridViewViand.DataSource = dt

    End Sub


    Public Sub ViewAlLRentalItems()
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT ItemCode as Code, ItemName as Item, ItemPrice as Price, ItemStock as Stock FROM tbl_InventoryItem WHERE itemcategory='RENTAL'", sqlCon)
        da.Fill(dt)
        disconnect_DB()
        DataGridRENTAL.DataSource = dt

    End Sub

    Public Sub ViewAllSellingItems()
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT ItemCode as Code, ItemName as Item, ItemPrice as Price, ItemStock as Stock FROM tbl_InventoryItem WHERE itemcategory='SELLING'", sqlCon)
        da.Fill(dt)
        disconnect_DB()
        DataGridSELLING.DataSource = dt


        Try
            Dim total As Object
            connect_DB()
            ds = New DataSet
            dt = New DataTable
            da = New MySqlDataAdapter("SELECT reservation_id FROM tbl_reservation", sqlCon)
            da.Fill(dt)
            For Each Row As DataRow In dt.Rows
                total = Row(0) 'row is the current row selected and 0 is the column number
            Next
            res_id.Text = total


        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try

    End Sub

    Private Sub POS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ViewAllCatering()
        ViewAllServices()
        ViewAlLRentalItems()
        ViewAllSellingItems()

        rbITEMS.Checked = True
        rbPartial.Checked = True
        rbRENTAL.Checked = True


        Dim name As String
        connect_DB()
        ds = New DataSet
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT customer_name FROM tbl_reservation", sqlCon)
        da.Fill(dt)
        For Each Row As DataRow In dt.Rows
            name = Row(0) 'row is the current row selected and 0 is the column number
        Next
        lblName.Text = name

        Dim eventname As String
        connect_DB()
        ds = New DataSet
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT event_name FROM tbl_reservation", sqlCon)
        da.Fill(dt)
        For Each Row As DataRow In dt.Rows
            eventname = Row(0) 'row is the current row selected and 0 is the column number
        Next
        lblEvent.Text = eventname

        Dim address As String
        connect_DB()
        ds = New DataSet
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT event_address FROM tbl_reservation", sqlCon)
        da.Fill(dt)
        For Each Row As DataRow In dt.Rows
            address = Row(0) 'row is the current row selected and 0 is the column number
        Next
        Label13.Text = address

        Dim toolTip1 As New ToolTip()
        toolTip1.AutoPopDelay = 1000
        toolTip1.InitialDelay = 500
        toolTip1.ReshowDelay = 500
        toolTip1.ShowAlways = True

        toolTip1.SetToolTip(Me.pcbxAddToCart, "Add to Cart")
        toolTip1.SetToolTip(Me.pcbxRemoveToCart, "Remove from Cart")
    End Sub



    Private Sub pcbxAddToCart_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        pcbxAddToCart.Image = My.Resources.add21

    End Sub

    Private Sub pcbxAddToCart_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        pcbxAddToCart.Image = My.Resources.add1

    End Sub

    Private Sub pcbxRemoveToCart_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        pcbxRemoveToCart.Image = My.Resources.remove2

    End Sub

    Private Sub pcbxRemoveToCart_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        pcbxRemoveToCart.Image = My.Resources.remove

    End Sub


    Private Sub DataGridViewViand_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridViewViand.KeyUp
        txtQuantity.Text = "1"
        Dim i As Integer
        i = DataGridViewViand.CurrentRow.Index
        txtItemCode.Text = DataGridViewViand.Item(0, i).Value
        txtItem.Text = DataGridViewViand.Item(1, i).Value
        txtPrice.Text = DataGridViewViand.Item(3, i).Value
    End Sub

    Private Sub DataGridViewViand_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridViewViand.MouseClick
        txtQuantity.Text = "1"
        Dim i As Integer
        i = DataGridViewViand.CurrentRow.Index
        txtItemCode.Text = DataGridViewViand.Item(0, i).Value
        txtItem.Text = DataGridViewViand.Item(1, i).Value
        txtPrice.Text = DataGridViewViand.Item(3, i).Value

    End Sub

    Private Sub DataGridViewServices_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridViewServices.MouseClick
        txtQuantity.Text = "1"
        Dim i As Integer
        i = DataGridViewServices.CurrentRow.Index
        txtItemCode.Text = DataGridViewServices.Item(0, i).Value
        txtItem.Text = DataGridViewServices.Item(1, i).Value
        txtPrice.Text = DataGridViewServices.Item(3, i).Value
    End Sub

    Private Sub DataGridViewServices_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridViewServices.KeyUp
        txtQuantity.Text = "1"
        Dim i As Integer
        i = DataGridViewServices.CurrentRow.Index
        txtItemCode.Text = DataGridViewServices.Item(0, i).Value
        txtItem.Text = DataGridViewServices.Item(1, i).Value
        txtPrice.Text = DataGridViewServices.Item(3, i).Value
    End Sub

    Private Sub btnProcess_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
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
        da = New MySqlDataAdapter("INSERT INTO tbl_logsactivity (logsID, logsActivity) VALUES (@logsID,'Process an order')", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@logsID", lblLogs.Text)

        da.Fill(dt)
        disconnect_DB()
        Try
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("INSERT INTO tbl_totalsales (reservation_id, totalsales,customer_name,event,transactiondate) VALUES (@reservationid, @totalsales,@customer_name,@event,@transac)", sqlCon)
            da.SelectCommand.Parameters.AddWithValue("@reservationid", res_id.Text)
            da.SelectCommand.Parameters.AddWithValue("@totalsales", txtAmountDue.Text)
            da.SelectCommand.Parameters.AddWithValue("@customer_name", lblName.Text)
            da.SelectCommand.Parameters.AddWithValue("@event", lblEvent.Text)
            da.SelectCommand.Parameters.AddWithValue("@transac", Date.Now.ToString("yyyy-MM-dd"))
            da.Fill(dt)
            disconnect_DB()

        Catch ex As Exception

        End Try

        Try
            Dim formattedDate As String
          
            formattedDate = Format$(Date.Now, "MM/yyyy")
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("INSERT INTO tbl_totalsalesMonthly (reservation_id, totalsales,customer_name,event,transactiondate, transactionMonth) VALUES (@reservationid, @totalsales,@customer_name,@event,@transac, @transactionMonth)", sqlCon)
            da.SelectCommand.Parameters.AddWithValue("@reservationid", res_id.Text)
            da.SelectCommand.Parameters.AddWithValue("@totalsales", txtAmountDue.Text)
            da.SelectCommand.Parameters.AddWithValue("@customer_name", lblName.Text)
            da.SelectCommand.Parameters.AddWithValue("@event", lblEvent.Text)
            da.SelectCommand.Parameters.AddWithValue("@transac", Date.Now.ToString("MM-dd-yyyy"))
            da.SelectCommand.Parameters.AddWithValue("@transactionMonth", formattedDate)
            da.Fill(dt)
            disconnect_DB()

        Catch ex As Exception

        End Try

        Try
            Dim formatDate As String

            formatDate = Format$(Date.Now, "yyyy")
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("INSERT INTO tbl_totalsalesYearly (reservation_id, totalsales,customer_name,event,transactiondate, transactionyear) VALUES (@reservationid, @totalsales,@customer_name,@event,@transac, @transactionyear)", sqlCon)
            da.SelectCommand.Parameters.AddWithValue("@reservationid", res_id.Text)
            da.SelectCommand.Parameters.AddWithValue("@totalsales", txtAmountDue.Text)
            da.SelectCommand.Parameters.AddWithValue("@customer_name", lblName.Text)
            da.SelectCommand.Parameters.AddWithValue("@event", lblEvent.Text)
            da.SelectCommand.Parameters.AddWithValue("@transac", Date.Now.ToString("MM-dd-yyyy"))
            da.SelectCommand.Parameters.AddWithValue("@transactionyear", formatDate)
            da.Fill(dt)
            disconnect_DB()

        Catch ex As Exception

        End Try

        If rbFull.Checked Then
            amountPaid.ShowDialog()

        Else

            Try
                Dim balance As Double
                balance = CDbl(txtAmountDue.Text) - CDbl(txtPayment.Text)


                connect_DB()
                dt = New DataTable
                da = New MySqlDataAdapter("INSERT INTO tbl_payment (reservation_id,customer_name,amountdue, payment, balance) VALUES (@reservationid, @customer_name, @amountdue ,@payment,@balance)", sqlCon)
                da.SelectCommand.Parameters.AddWithValue("@reservationid", res_id.Text)
                da.SelectCommand.Parameters.AddWithValue("@amountdue", txtAmountDue.Text)
                da.SelectCommand.Parameters.AddWithValue("@customer_name", lblName.Text)
                da.SelectCommand.Parameters.AddWithValue("@payment", txtPayment.Text)
                da.SelectCommand.Parameters.AddWithValue("@balance", balance)
                da.Fill(dt)
                disconnect_DB()

            Catch ex As Exception


            End Try
            Try
                connect_DB()
                dt = New DataTable
                da = New MySqlDataAdapter("UPDATE tbl_purchaseorder SET purchase_status = 0 WHERE reservation_id = " & res_id.Text, sqlCon)
                da.Fill(dt)
                disconnect_DB()
                DataGridRENTAL.DataSource = dt
            Catch ex As Exception
                MsgBox(ErrorToString)
            End Try
            Me.Close()
            MsgBox("Order Processed.")

            Receipt.ShowDialog()


            Reservation.Show()
            Reservation.MdiParent = MainMenu
            Reservation.ViewAllReservation()
            Reservation.Location = New Point(0, 247)
        End If

    End Sub


    Private Sub panelCatering_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panelCatering.Paint
        ViewAllCatering()

    End Sub


    Private Sub pcbxAddToCart_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbxAddToCart.Click
        If rbITEMS.Checked Then
            If txtQuantity.Text = "" Then
                MessageBox.Show("Please enter item's quantity", "No entry",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

        Dim x, y, product As Integer
        x = CInt(txtPrice.Text)
        y = Val(txtQuantity.Text)

        


        product = x * y
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("INSERT INTO tbl_purchaseorder (item_name, item_price, order_quantity, total, purchase_status, reservation_id, rental) VALUES (@itemname, @itemprice, @orderquantity, @totalprice, 1, @reservationid, @rental)", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@itemname", txtItem.Text)
        da.SelectCommand.Parameters.AddWithValue("@itemprice", txtPrice.Text)
        da.SelectCommand.Parameters.AddWithValue("@orderquantity", txtQuantity.Text)
        da.SelectCommand.Parameters.AddWithValue("@totalprice", product)
        da.SelectCommand.Parameters.AddWithValue("@reservationid", res_id.Text)
        da.SelectCommand.Parameters.AddWithValue("@rental", txtrental.Text)
        da.Fill(dt)
        disconnect_DB()

        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("INSERT INTO tbl_dummy (customer_name, event_address, datenow, order_quantity, item_name, item_price, total) VALUES (@customer_name, @event_address, @datenow, @order_quantity, @item_name, @item_price, @total)", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@customer_name", lblName.Text)
        da.SelectCommand.Parameters.AddWithValue("@event_address", Label13.Text)
        da.SelectCommand.Parameters.AddWithValue("@datenow", Date.Now.ToString("MM-dd-yyyy"))
        da.SelectCommand.Parameters.AddWithValue("@item_name", txtItem.Text)
        da.SelectCommand.Parameters.AddWithValue("@item_price", txtPrice.Text)
        da.SelectCommand.Parameters.AddWithValue("@order_quantity", txtQuantity.Text)
        da.SelectCommand.Parameters.AddWithValue("@total", product)

        da.Fill(dt)
        disconnect_DB()

        Try
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("SELECT  purchase_id as Code, item_name as Item, item_price as Price, order_quantity as Quantity, total as Total from tbl_purchaseorder WHERE purchase_status = 1 AND reservation_id = " & res_id.Text, sqlCon)
            da.Fill(dt)
            disconnect_DB()
            DataGridOrder.DataSource = dt
        Catch ex As Exception
            MsgBox("error")
        End Try

        Try
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("UPDATE  tbl_inventoryitem SET ItemStock = ItemStock - @orderquantity WHERE ItemName = @itemname", sqlCon)
            da.SelectCommand.Parameters.AddWithValue("@itemname", txtItem.Text)
            da.SelectCommand.Parameters.AddWithValue("@orderquantity", txtQuantity.Text)
            da.Fill(dt)
            disconnect_DB()
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try

        If rbRENTAL.Checked Then
            ViewAlLRentalItems()
        Else
            ViewAllSellingItems()
        End If


        Try

            connect_DB()
            ds = New DataSet
            dt = New DataTable
            da = New MySqlDataAdapter("SELECT total FROM tbl_purchaseorder WHERE purchase_status = 1 AND reservation_id = " & res_id.Text, sqlCon)
            da.Fill(dt)
            For Each Row As DataRow In dt.Rows
                total = total + Row(0) 'row is the current row selected and 0 is the column number
            Next
            txtAmountDue.Text = total


        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try

        txtQuantity.Clear()



    End Sub

    Private Sub pcbxRemoveToCart_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbxRemoveToCart.Click
        If Label12.Text = "USER" Then
            AdminPass.ShowDialog()

        Else
            Dim i As Integer
            i = DataGridOrder.CurrentRow.Index
            Try
                connect_DB()
                dt = New DataTable
                da = New MySqlDataAdapter("UPDATE  tbl_inventoryitem SET ItemStock = ItemStock + @orderquantity WHERE ItemName = @itemname", sqlCon)
                da.SelectCommand.Parameters.AddWithValue("@itemname", DataGridOrder.Item(1, i).Value)
                da.SelectCommand.Parameters.AddWithValue("@orderquantity", DataGridOrder.Item(3, i).Value)
                da.Fill(dt)
                disconnect_DB()

                If rbRENTAL.Checked Then
                    ViewAlLRentalItems()
                Else
                    ViewAllSellingItems()
                End If
            Catch ex As Exception
                MsgBox(ErrorToString)
            End Try

            pos = DataGridOrder.Item(0, i).Value
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("DELETE FROM tbl_purchaseorder WHERE purchase_id = " & pos, sqlCon)
            da.Fill(dt)
            disconnect_DB()
            Try
                connect_DB()
                dt = New DataTable
                da = New MySqlDataAdapter("SELECT  purchase_id as Code, item_name as Item, item_price as Price, order_quantity as Quantity, total as Total from tbl_purchaseorder WHERE purchase_status = 1 AND reservation_id = " & res_id.Text, sqlCon)
                da.Fill(dt)
                disconnect_DB()
                DataGridOrder.DataSource = dt
            Catch ex As Exception
                MsgBox("Error")
            End Try

            Try
                Dim total As Object
                connect_DB()
                ds = New DataSet
                dt = New DataTable
                da = New MySqlDataAdapter("SELECT total FROM tbl_purchaseorder WHERE purchase_status = 1 AND reservation_id = " & res_id.Text, sqlCon)
                da.Fill(dt)
                For Each Row As DataRow In dt.Rows
                    total = total + Row(0) 'row is the current row selected and 0 is the column number
                Next
                txtAmountDue.Text = total


            Catch ex As Exception
                MsgBox(ErrorToString)
            End Try

        End If

       
    End Sub




    Private Sub rbServices_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbServices.CheckedChanged

        panelCatering.SendToBack()
        panelItems.SendToBack()


        txtQuantity.Enabled = False
        txtQuantity.Location = New Point(580, 27)
        txtQuantity.SendToBack()
        Label2.Location = New Point(580, 27)
        Label2.SendToBack()

        txtQuantity.Text = "1"
        txtrental.Text = "0"

      

    End Sub
    Private Sub rbITEMS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbITEMS.CheckedChanged
        panelCatering.SendToBack()
        panelService.SendToBack()

        txtQuantity.Enabled = True
        txtQuantity.Text = ""
        Label2.Location = New Point(316, 273)
        txtQuantity.Location = New Point(404, 270)
        txtrental.Text = "1"
    


    End Sub

    Private Sub rbCatering_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCatering.CheckedChanged
        panelItems.SendToBack()
        panelService.SendToBack()

        txtQuantity.Enabled = False
        txtQuantity.Location = New Point(580, 27)
        txtQuantity.SendToBack()
        Label2.Location = New Point(580, 27)
        Label2.SendToBack()

        txtQuantity.Text = "1"
        txtrental.Text = "0"


    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Down Then
            e.SuppressKeyPress = True

            If rbCatering.Checked Then
                Dim i As Integer
                i = DataGridViewViand.CurrentRow.Index
                txtItemCode.Text = DataGridViewViand.Item(0, i).Value
                txtItem.Text = DataGridViewViand.Item(1, i).Value
                txtPrice.Text = DataGridViewViand.Item(3, i).Value
            End If
            If rbITEMS.Checked Then
                Dim i As Integer
                i = DataGridRENTAL.CurrentRow.Index
                txtItemCode.Text = DataGridRENTAL.Item(0, i).Value
                txtItem.Text = DataGridRENTAL.Item(1, i).Value
                txtPrice.Text = DataGridRENTAL.Item(2, i).Value
            End If
            If rbServices.Checked Then
                Dim i As Integer
                i = DataGridViewServices.CurrentRow.Index
                txtItemCode.Text = DataGridViewServices.Item(0, i).Value
                txtItem.Text = DataGridViewServices.Item(1, i).Value
                txtPrice.Text = DataGridViewServices.Item(3, i).Value
            End If
        End If
    End Sub

    Private Sub txtSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If rbCatering.Checked Then
                Dim i As Integer
                i = DataGridViewViand.CurrentRow.Index
                txtItemCode.Text = DataGridViewViand.Item(0, i).Value
                txtItem.Text = DataGridViewViand.Item(1, i).Value
                txtPrice.Text = DataGridViewViand.Item(3, i).Value
            End If
            If rbITEMS.Checked Then
                Dim i As Integer
                i = DataGridRENTAL.CurrentRow.Index
                txtItemCode.Text = DataGridRENTAL.Item(0, i).Value
                txtItem.Text = DataGridRENTAL.Item(1, i).Value
                txtPrice.Text = DataGridRENTAL.Item(2, i).Value
            End If
            If rbServices.Checked Then
                Dim i As Integer
                i = DataGridViewServices.CurrentRow.Index
                txtItemCode.Text = DataGridViewServices.Item(0, i).Value
                txtItem.Text = DataGridViewServices.Item(1, i).Value
                txtPrice.Text = DataGridViewServices.Item(3, i).Value
            End If
        End If



    End Sub





    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If rbCatering.Checked Then
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("SELECT * FROM tbl_catering WHERE Viand LIKE @Viand", sqlCon)
            da.SelectCommand.Parameters.AddWithValue("@Viand", "%" & txtSearch.Text & "%")
            da.Fill(dt)
            disconnect_DB()
            DataGridViewViand.DataSource = dt

        End If
        If rbServices.Checked Then
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("SELECT i.ServiceID as Code, i.ServiceName as Name, i.ServiceDescription as Description, i.ServiceFee as Fee,  s.SupplierName as Supplier FROM tbl_Services i JOIN tbl_Supplier s on i.SupplierID=s.SupplierID WHERE ServiceName LIKE @ServiceName", sqlCon)
            da.SelectCommand.Parameters.AddWithValue("@ServiceName", "%" & txtSearch.Text & "%")
            da.Fill(dt)
            disconnect_DB()
            DataGridViewServices.DataSource = dt

        End If
        If rbITEMS.Checked Then

            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("SELECT ItemCode as Code, ItemName as Item, ItemPrice as Price, ItemStock as Stock FROM tbl_InventoryItem WHERE ItemName LIKE @ItemName", sqlCon)
            da.SelectCommand.Parameters.AddWithValue("@ItemName", "%" & txtSearch.Text & "%")
            da.Fill(dt)
            disconnect_DB()
            DataGridRENTAL.DataSource = dt

        End If

    End Sub

 
    Private Sub rbFull_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFull.CheckedChanged
        If rbFull.Checked Then
            txtPayment.Text = total
            txtPayment.Enabled = False
            Label11.Visible = False



        End If
    End Sub

    Private Sub rbPartial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPartial.CheckedChanged
        If rbPartial.Checked Then
            txtPayment.Text = ""
            txtPayment.Enabled = True
            Label11.Visible = True



        End If
    End Sub

    Private Sub txtPayment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayment.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

   

    Private Sub DataGridSELLING_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridSELLING.KeyUp
        Dim i As Integer
        i = DataGridSELLING.CurrentRow.Index
        txtItemCode.Text = DataGridSELLING.Item(0, i).Value
        txtItem.Text = DataGridSELLING.Item(1, i).Value
        txtPrice.Text = DataGridSELLING.Item(2, i).Value
    End Sub


    Private Sub DataGridSELLING_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridSELLING.MouseClick
        Dim i As Integer
        i = DataGridSELLING.CurrentRow.Index
        txtItemCode.Text = DataGridSELLING.Item(0, i).Value
        txtItem.Text = DataGridSELLING.Item(1, i).Value
        txtPrice.Text = DataGridSELLING.Item(2, i).Value
    End Sub

    Private Sub DataGridRENTAL_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridRENTAL.KeyUp
        Dim i As Integer
        i = DataGridRENTAL.CurrentRow.Index
        txtItemCode.Text = DataGridRENTAL.Item(0, i).Value
        txtItem.Text = DataGridRENTAL.Item(1, i).Value
        txtPrice.Text = DataGridRENTAL.Item(2, i).Value
    End Sub

    Private Sub DataGridRENTAL_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridRENTAL.MouseClick
        Dim i As Integer
        i = DataGridRENTAL.CurrentRow.Index
        txtItemCode.Text = DataGridRENTAL.Item(0, i).Value
        txtItem.Text = DataGridRENTAL.Item(1, i).Value
        txtPrice.Text = DataGridRENTAL.Item(2, i).Value
    End Sub

    Private Sub rbRENTAL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRENTAL.CheckedChanged
        ViewAlLRentalItems()
        DataGridRENTAL.Visible = True
        DataGridSELLING.Visible = False
        txtrental.Text = "1"



    End Sub

    Private Sub rbSELLING_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSELLING.CheckedChanged
        ViewAllSellingItems()
        DataGridRENTAL.Visible = False
        DataGridSELLING.Visible = True
        txtrental.Text = "0"

    End Sub

  
End Class