Imports MySql.Data.MySqlClient

Public Class EditService

    Private Sub EditService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        i = Services.DataGridServices.CurrentRow.Index
        txtCode.Text = Services.DataGridServices.Item(0, i).Value
        txtName.Text = Services.DataGridServices.Item(1, i).Value
        txtDescription.Text = Services.DataGridServices.Item(2, i).Value
        txtPrice.Text = Services.DataGridServices.Item(3, i).Value
        cmbSupplier.Text = Services.DataGridServices.Item(4, i).Value
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
        da = New MySqlDataAdapter("INSERT INTO tbl_logsactivity (logsID, logsActivity) VALUES (@logsID,'Updates a service')", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@logsID", Label1.Text)

        da.Fill(dt)
        disconnect_DB()

        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("UPDATE tbl_services SET ServiceName=@ServiceName, ServiceDescription=@ServiceDescription, SupplierID=@SupplierID, ServiceFee=@ServicePrice WHERE ServiceID=@ServiceID", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@ServiceID", txtCode.Text)
        da.SelectCommand.Parameters.AddWithValue("@ServiceName", txtName.Text)
        da.SelectCommand.Parameters.AddWithValue("@ServiceDescription", txtDescription.Text)
        da.SelectCommand.Parameters.AddWithValue("@SupplierID", cmbSupplier.SelectedValue)
        da.SelectCommand.Parameters.AddWithValue("@ServicePrice", txtPrice.Text)
        da.Fill(dt)
        disconnect_DB()
        MsgBox("Service has been updated")
        Services.ViewAllServices()
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub
End Class