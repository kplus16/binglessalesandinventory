Imports MySql.Data.MySqlClient

Public Class EditCatering

    Private Sub EditCatering_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        i = Catering.DataGridCatering.CurrentRow.Index
        txtCode.Text = Catering.DataGridCatering.Item(0, i).Value
        txtItem.Text = Catering.DataGridCatering.Item(1, i).Value
        txtDescription.Text = Catering.DataGridCatering.Item(2, i).Value
        txtPrice.Text = Catering.DataGridCatering.Item(3, i).Value

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click

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
        da = New MySqlDataAdapter("INSERT INTO tbl_logsactivity (logsID, logsActivity) VALUES (@logsID,'Updates a viand')", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@logsID", Label1.Text)

        da.Fill(dt)
        disconnect_DB()

        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("UPDATE tbl_catering SET Viand=@Viand, Description=@Description, Price=@Price WHERE CateringID=@CateringID", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@CateringID", txtCode.Text)
        da.SelectCommand.Parameters.AddWithValue("@Viand", txtItem.Text)
        da.SelectCommand.Parameters.AddWithValue("@Description", txtDescription.Text)
        da.SelectCommand.Parameters.AddWithValue("@Price", txtPrice.Text)
        da.Fill(dt)
        disconnect_DB()
        MsgBox("Viand has been updated")
        Catering.ViewAllCatering()
        Me.Close()

    End Sub
End Class