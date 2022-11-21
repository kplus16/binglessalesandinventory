Imports MySql.Data.MySqlClient

Public Class Services

    Public Sub ViewAllServices()
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT i.ServiceID as Code, i.ServiceName as Name, i.ServiceDescription as Description, i.ServiceFee as Fee,  s.SupplierName as Supplier FROM tbl_Services i JOIN tbl_Supplier s on i.SupplierID=s.SupplierID", sqlCon)
        da.Fill(dt)
        disconnect_DB()

        DataGridServices.DataSource = dt

    End Sub

    Private Sub Stocks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tooltip1 As New ToolTip()
        tooltip1.AutoPopDelay = 1000
        tooltip1.InitialDelay = 500
        tooltip1.ReshowDelay = 100
        tooltip1.ShowAlways = True

        tooltip1.SetToolTip(Me.pcbxNew, "Add new service.")
        connect_DB()
        ViewAllServices()
        disconnect_DB()
    End Sub
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT i.ServiceID as Code, i.ServiceName as Name, i.ServiceDescription as Description, i.ServiceFee as Fee,  s.SupplierName as Supplier FROM tbl_Services i JOIN tbl_Supplier s on i.SupplierID=s.SupplierID WHERE ServiceName LIKE @ServiceName", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@ServiceName", "%" & txtSearch.Text & "%")
        da.Fill(dt)
        disconnect_DB()
        DataGridServices.DataSource = dt
    End Sub

    Private Sub pcbxNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxNew.Click
        AddServices.ShowDialog()

    End Sub

    Private Sub pcbxNew_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxNew.MouseHover
        pcbxNew.Image = My.Resources.itemNewicon2
    End Sub

    Private Sub pcbxNew_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxNew.MouseLeave
        pcbxNew.Image = My.Resources.itemNewicon
    End Sub

    Private Sub DataGridServices_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridServices.KeyUp
        Dim i As Integer
        i = DataGridServices.CurrentRow.Index
        Label1.Text = DataGridServices.Item(0, i).Value

        If e.KeyCode = Keys.Right Then
            ContextMenuStrip1.Show()

        End If

    End Sub

    Private Sub EditItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditItemToolStripMenuItem.Click
        EditService.ShowDialog()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class