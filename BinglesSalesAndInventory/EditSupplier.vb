Imports MySql.Data.MySqlClient

Public Class EditSupplier

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        Dim i As Integer
        i = SupplierForm.DataGridSupplier.CurrentRow.Index
        Label1.Text = SupplierForm.DataGridSupplier.Item(0, i).Value
        txtName.Text = SupplierForm.DataGridSupplier.Item(1, i).Value
        txtAddress.Text = SupplierForm.DataGridSupplier.Item(2, i).Value
        txtContact.Text = SupplierForm.DataGridSupplier.Item(3, i).Value
        cmbStatus.Text = SupplierForm.DataGridSupplier.Item(4, i).Value
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim LogsID As String
        connect_DB()
        ds = New DataSet
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT LogsID FROM tbl_logs", sqlCon)
        da.Fill(dt)
        For Each Row As DataRow In dt.Rows
            LogsID = Row(0) 'row is the current row selected and 0 is the column number
        Next
        Label1.Text = LogsID

        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("INSERT INTO tbl_logsactivity (logsID, logsActivity) VALUES (@logsID,'Updates a supplier')", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@logsID", Label1.Text)

        da.Fill(dt)
        disconnect_DB()

        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("UPDATE tbl_supplier SET SupplierName=@SupplierName, SupplierAddress=@SupplierAddress, SupplierContact=@SupplierContact, SupplierStatus=@SupplierStatus WHERE SupplierID=@SupplierID", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@SupplierID", Label1.Text)
        da.SelectCommand.Parameters.AddWithValue("@SupplierName", txtName.Text)
        da.SelectCommand.Parameters.AddWithValue("@SupplierAddress", txtAddress.Text)
        da.SelectCommand.Parameters.AddWithValue("@SupplierContact", txtContact.Text)
        da.SelectCommand.Parameters.AddWithValue("@SupplierStatus", cmbStatus.Text)
        da.Fill(dt)
        disconnect_DB()
        MsgBox("Supplier has been updated")
        SupplierForm.ViewAllSuppiers()
        Me.Close()


    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

   
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class