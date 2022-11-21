Imports MySql.Data.MySqlClient

Public Class AddServices

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
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
        da = New MySqlDataAdapter("INSERT INTO tbl_logs (logsID, logsActivity) VALUES (@logsID,'Adds a service')", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@logsID", Label1.Text)

        da.Fill(dt)
        disconnect_DB()


        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("INSERT INTO tbl_logsactivity (ServiceName, ServiceDescription, SupplierID, ServiceFee) VALUES (@ServiceName, @ServiceDescription, @SupplierID, @ServiceFee)", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@ServiceName", txtName.Text)
        da.SelectCommand.Parameters.AddWithValue("@ServiceDescription", txtDescription.Text)
        da.SelectCommand.Parameters.AddWithValue("@SupplierID", cmbSupplier.SelectedValue)
        da.SelectCommand.Parameters.AddWithValue("@ServiceFee", txtPrice.Text)
        da.Fill(dt)
        disconnect_DB()
        MsgBox("Service has been added")
        txtName.Clear()
        txtDescription.Clear()
        txtPrice.Clear()

        Services.ViewAllServices()
        Me.Close()
    End Sub

    Private Sub AddServices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect_DB()

        dt = New DataTable
        da = New MySqlDataAdapter("SELECT * FROM tbl_Supplier", sqlCon)
        da.Fill(dt)
        cmbSupplier.DataSource = dt
        cmbSupplier.ValueMember = dt.Columns(0).ToString
        cmbSupplier.DisplayMember = dt.Columns(1).ToString

        disconnect_DB()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class