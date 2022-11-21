Imports MySql.Data.MySqlClient


Public Class AddCatering

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

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
        da = New MySqlDataAdapter("INSERT INTO tbl_logsactivity (logsID, logsActivity) VALUES (@logsID,'Adds a viand')", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@logsID", Label1.Text)

        da.Fill(dt)
        disconnect_DB()

        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("INSERT INTO tbl_catering (viand, Description, price) VALUES (@viand, @Description, @Price)", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@viand", txtItem.Text)
        da.SelectCommand.Parameters.AddWithValue("@Description", txtDescription.Text)
        da.SelectCommand.Parameters.AddWithValue("@Price", txtPrice.Text)
        da.Fill(dt)
        disconnect_DB()
        MsgBox("Viand has been added")
        Catering.ViewAllCatering()

        txtDescription.Clear()
        txtItem.Clear()
        txtPrice.Clear()

        Me.Close()

    End Sub
End Class