Imports MySql.Data.MySqlClient

Public Class AdminPass
    Dim password As String

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        connect_DB()
        ds = New DataSet
        da = New MySqlDataAdapter("SELECT *FROM login WHERE password=@password AND TYPE =@type", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@type", "Admin")
        da.SelectCommand.Parameters.AddWithValue("@password", MainMenu.Encrypt(txtPassWord.Text.Trim()))
        da.Fill(ds, "login")

        Dim tbl As New DataTable
        da.Fill(tbl)

        If tbl.Rows.Count > 0 Then
            password = tbl.Rows(0).Item("password").ToString
        End If
        disconnect_DB()
        If MainMenu.Encrypt(txtPassWord.Text.Trim()) = password Then
            txtPassWord.Clear()
            Dim poss As Integer

            Dim i As Integer
            i = POS.DataGridOrder.CurrentRow.Index
            Try
                connect_DB()
                dt = New DataTable
                da = New MySqlDataAdapter("UPDATE  tbl_inventoryitem SET ItemStock = ItemStock + @orderquantity WHERE ItemName = @itemname", sqlCon)
                da.SelectCommand.Parameters.AddWithValue("@itemname", POS.DataGridOrder.Item(1, i).Value)
                da.SelectCommand.Parameters.AddWithValue("@orderquantity", POS.DataGridOrder.Item(3, i).Value)
                da.Fill(dt)
                disconnect_DB()

                If POS.rbRENTAL.Checked Then
                    POS.ViewAlLRentalItems()
                Else
                    POS.ViewAllSellingItems()
                End If
            Catch ex As Exception
                MsgBox(ErrorToString)
            End Try



            i = POS.DataGridOrder.CurrentRow.Index
            poss = POS.DataGridOrder.Item(0, i).Value
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("DELETE FROM tbl_purchaseorder WHERE purchase_id = " & poss, sqlCon)
            da.Fill(dt)
            disconnect_DB()
            Try
                connect_DB()
                dt = New DataTable
                da = New MySqlDataAdapter("SELECT  purchase_id as Code, item_name as Item, item_price as Price, order_quantity as Quantity, total as Total from tbl_purchaseorder WHERE purchase_status = 1 AND reservation_id = " & POS.res_id.Text, sqlCon)
                da.Fill(dt)
                disconnect_DB()
                POS.DataGridOrder.DataSource = dt
            Catch ex As Exception
                MsgBox("Error")
            End Try

            Try
                Dim total As Object
                connect_DB()
                ds = New DataSet
                dt = New DataTable
                da = New MySqlDataAdapter("SELECT total FROM tbl_purchaseorder WHERE purchase_status = 1 AND reservation_id = " & POS.res_id.Text, sqlCon)
                da.Fill(dt)
                For Each Row As DataRow In dt.Rows
                    total = total + Row(0) 'row is the current row selected and 0 is the column number
                Next
                POS.txtAmountDue.Text = total


            Catch ex As Exception
                MsgBox(ErrorToString)
            End Try
            Me.Close()

        End If


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class