Imports MySql.Data.MySqlClient


Public Class Catering

    Public Sub ViewAllCatering()
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT * FROM tbl_catering", sqlCon)
        da.Fill(dt)
        disconnect_DB()

        DataGridCatering.DataSource = dt

    End Sub
    Private Sub Catering_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewAllCatering()
        Dim tooltip1 As New ToolTip()
        tooltip1.AutoPopDelay = 1000
        tooltip1.InitialDelay = 500
        tooltip1.ReshowDelay = 100
        tooltip1.ShowAlways = True

        tooltip1.SetToolTip(Me.pcbxNew, "Add new viand.")
    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT * FROM tbl_catering WHERE Viand LIKE @Viand", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@Viand", "%" & txtSearch.Text & "%")
        da.Fill(dt)
        disconnect_DB()
        DataGridCatering.DataSource = dt
    End Sub

    Private Sub pcbxNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxNew.Click
        AddCatering.ShowDialog()

    End Sub

    Private Sub pcbxNew_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxNew.MouseHover
        pcbxNew.Image = My.Resources.itemNewicon2
    End Sub

    Private Sub pcbxNew_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxNew.MouseLeave
        pcbxNew.Image = My.Resources.itemNewicon
    End Sub


    Private Sub DataGridCatering_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridCatering.KeyUp
        Dim i As Integer
        i = DataGridCatering.CurrentRow.Index
        Label1.Text = DataGridCatering.Item(0, i).Value

        If e.KeyCode = Keys.Right Then
            ContextMenuStrip1.Show()

        End If
    End Sub

    Private Sub UpdateViandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateViandToolStripMenuItem.Click
        EditCatering.ShowDialog()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class