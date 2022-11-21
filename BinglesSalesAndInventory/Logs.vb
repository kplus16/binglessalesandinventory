Imports MySql.Data.MySqlClient


Public Class Logs

    Public Sub ViewAllLogs()
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT logsid as 'ID', fullname as 'Name', username as 'Username', date as 'Date', time as 'Time' FROM tbl_logs", sqlCon)
        da.Fill(dt)
        disconnect_DB()

        DataGridLogs.DataSource = dt

    End Sub

    Private Sub DataGridLogs_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim i As Integer
        i = DataGridLogs.CurrentRow.Index
        Label1.Text = DataGridLogs.Item(0, i).Value

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ViewAllLogs()

    End Sub


    Private Sub GroupBox1_Enter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnClearLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearLogs.Click
        Dim result As DialogResult


        result = MessageBox.Show("You are about to TRUNCATE a complete table! Do you really want to execute TRUNCATE logs?", "Confrimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            MsgBox("Cancelled")
        Else
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("TRUNCATE tbl_logs", sqlCon)
            da.Fill(dt)
            disconnect_DB()

            DataGridLogs.DataSource = dt
            ViewAllLogs()

        End If
    End Sub

    Private Sub DataGridLogs_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridLogs.CellContentClick

    End Sub

    Private Sub DataGridLogs_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridLogs.KeyUp
        Dim i As Integer
        i = DataGridLogs.CurrentRow.Index
        Label2.Text = DataGridLogs.Item(0, i).Value


        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT logsActivity as 'Activities' FROM tbl_logsActivity WHERE logsID=@id", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@id", Label2.Text)
        da.Fill(dt)
        disconnect_DB()
        DataGridActivities.DataSource = dt
    End Sub

    Private Sub Logs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewAllLogs()

    End Sub
End Class