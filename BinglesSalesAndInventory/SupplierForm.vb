Imports MySql.Data.MySqlClient

Public Class SupplierForm

    Public Sub ViewAllSuppiers()
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT supplierid as 'ID', suppliername as 'Name', supplieraddress as 'Address', suppliercontact as 'Contact #', supplierstatus as 'Status' FROM tbl_supplier", sqlCon)
        da.Fill(dt)
        disconnect_DB()
        DataGridSupplier.DataSource = dt


    End Sub
    

    Private Sub SupplierForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewAllSuppiers()

    End Sub

    Private Sub DataGridSupplier_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridSupplier.KeyUp
        Dim i As Integer
        i = DataGridSupplier.CurrentRow.Index
        Label1.Text = DataGridSupplier.Item(0, i).Value


        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT itemname as 'Name', itemdescription as 'Description', itemstock as 'Stocks' FROM tbl_inventoryitem WHERE SupplierID=@id", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@id", Label1.Text)
        da.Fill(dt)
        disconnect_DB()
        DataGridSupplier2.DataSource = dt
      

        If e.KeyCode = Keys.Right Then
            ContextMenuStrip1.Show()

        End If

    End Sub

    Private Sub DataGridSupplier_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridSupplier.MouseClick
        Dim i As Integer
        i = DataGridSupplier.CurrentRow.Index
        Label1.Text = DataGridSupplier.Item(0, i).Value
        EditSupplier.txtName.Text = DataGridSupplier.Item(1, i).Value
        EditSupplier.txtAddress.Text = DataGridSupplier.Item(2, i).Value
        EditSupplier.txtContact.Text = DataGridSupplier.Item(3, i).Value
        EditSupplier.cmbStatus.Text = DataGridSupplier.Item(4, i).Value

        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT * FROM tbl_inventoryitem WHERE SupplierID=@id", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@id", Label1.Text)
        da.Fill(dt)
        disconnect_DB()
        DataGridSupplier2.DataSource = dt


    End Sub

    Private Sub EditSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSupplierToolStripMenuItem.Click
        EditSupplier.ShowDialog()

    End Sub

    Private Sub DataGridSupplier_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridSupplier.CellContentClick

    End Sub

    Private Sub DataGridSupplier2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridSupplier2.CellContentClick

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Supplier.ShowDialog()

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT supplierid as 'ID', suppliername as 'Name', supplieraddress as 'Address', suppliercontact as 'Contact #', supplierstatus as 'Status' FROM tbl_supplier WHERE suppliername LIKE @suppliername", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@suppliername", "%" & txtSearch.Text & "%")
        da.Fill(dt)
        disconnect_DB()
        DataGridSupplier.DataSource = dt
    End Sub
End Class