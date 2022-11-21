Imports MySql.Data.MySqlClient

Public Class Supplier

    Private Sub brnAddd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnAddd.Click
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
        da = New MySqlDataAdapter("INSERT INTO tbl_logsactivity (logsID, logsActivity) VALUES (@logsID,'Adds a supplier')", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@logsID", Label1.Text)

        da.Fill(dt)
        disconnect_DB()

        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("INSERT INTO tbl_Supplier (SupplierName, SupplierAddress, SupplierContact, SupplierStatus) VALUES (@SupplierName, @SupplierAddress, @SupplierContact, 'ACTIVE')", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@SupplierName", txtName.Text)
        da.SelectCommand.Parameters.AddWithValue("@SupplierAddress", txtAddress.Text)
        da.SelectCommand.Parameters.AddWithValue("@SupplierContact", txtContact.Text)
        da.Fill(dt)

        dt = New DataTable
        da = New MySqlDataAdapter("SELECT * FROM tbl_Supplier", sqlCon)
        da.Fill(dt)
        disconnect_DB()
        MsgBox("Supplier successfully added")
        SupplierForm.ViewAllSuppiers()
        txtAddress.Clear()
        txtContact.Clear()
        txtName.Clear()

        Me.Close()
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class