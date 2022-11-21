Imports MySql.Data.MySqlClient


Public Class Items

    Public Sub ViewAllRentalItem()
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT i.ItemCode as Code, i.ItemName as Name, i.ItemDescription as Description, i.ItemPrice as Price, i.ItemStock as Stock FROM tbl_InventoryItem i WHERE ItemCategory='RENTAL'", sqlCon)
        da.Fill(dt)
        disconnect_DB()

        DataGridRENTALItems.DataSource = dt

    End Sub
    Public Sub ViewAllSellingItem()
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT i.ItemCode as Code, i.ItemName as Name, i.ItemDescription as Description, i.ItemPrice as Price, i.ItemStock as Stock,  s.SupplierName as Supplier FROM tbl_InventoryItem i JOIN tbl_Supplier s on i.SupplierID=s.SupplierID WHERE ItemCategory='SELLING'", sqlCon)
        da.Fill(dt)
        disconnect_DB()

        DataGridViewSELLING.DataSource = dt

    End Sub

    Private Sub Items_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tooltip1 As New ToolTip()
        tooltip1.AutoPopDelay = 1000
        tooltip1.InitialDelay = 500
        tooltip1.ReshowDelay = 100
        tooltip1.ShowAlways = True

        tooltip1.SetToolTip(Me.pcbxNew, "Add new item.")

        rbRENTAL.Checked = True
        Label3.Visible = False
        DataGridViewSELLING.Visible = False
        ViewAllRentalItem()


    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If rbRENTAL.Checked Then
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("SELECT i.ItemCode as Code, i.ItemName as Name, i.ItemDescription as Description, i.ItemPrice as Price, i.ItemStock as Stock,  s.SupplierName as Supplier FROM tbl_InventoryItem i JOIN tbl_Supplier s on i.SupplierID=s.SupplierID WHERE ItemCategory='RENTAL' AND ItemName LIKE @ItemName", sqlCon)
            da.SelectCommand.Parameters.AddWithValue("@ItemName", "%" & txtSearch.Text & "%")
            da.Fill(dt)
            disconnect_DB()

            DataGridRENTALItems.DataSource = dt
        Else
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("SELECT i.ItemCode as Code, i.ItemName as Name, i.ItemDescription as Description, i.ItemPrice as Price, i.ItemStock as Stock,  s.SupplierName as Supplier FROM tbl_InventoryItem i JOIN tbl_Supplier s on i.SupplierID=s.SupplierID WHERE ItemCategory='SELLING' AND ItemName LIKE @ItemName", sqlCon)
            da.SelectCommand.Parameters.AddWithValue("@ItemName", "%" & txtSearch.Text & "%")
            da.Fill(dt)
            disconnect_DB()

            DataGridViewSELLING.DataSource = dt
        End If
       
    End Sub

    Private Sub pcbxNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxNew.Click
        AddItem.ShowDialog()

    End Sub

    Private Sub pcbxNew_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxNew.MouseHover
        pcbxNew.Image = My.Resources.itemNewicon2
    End Sub

    Private Sub pcbxNew_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxNew.MouseLeave
        pcbxNew.Image = My.Resources.itemNewicon
    End Sub

    Private Sub DataGridItems_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridRENTALItems.KeyUp
        Dim i As Integer
        i = DataGridRENTALItems.CurrentRow.Index
        Label1.Text = DataGridRENTALItems.Item(0, i).Value

        If e.KeyCode = Keys.Right Then
            ContextMenuStrip1.Show()

        End If

    End Sub

    Private Sub EditSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditItemToolStripMenuItem.Click
        EditItem.ShowDialog()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub rbITEMS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRENTAL.CheckedChanged
        If rbRENTAL.Checked Then
            Label2.Visible = True
            DataGridRENTALItems.Visible = True
            Label3.Visible = False
            DataGridViewSELLING.Visible = False
            ViewAllRentalItem()

        End If
    End Sub

    Private Sub rbSELLING_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSELLING.CheckedChanged
        If rbSELLING.Checked Then
            Label3.Visible = True
            DataGridViewSELLING.Visible = True
            Label2.Visible = False
            DataGridRENTALItems.Visible = False
            ViewAllSellingItem()

        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub DataGridRENTALItems_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridRENTALItems.CellContentClick

    End Sub

    Private Sub DataGridViewSELLING_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewSELLING.CellContentClick

    End Sub
End Class