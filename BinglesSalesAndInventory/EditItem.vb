Imports MySql.Data.MySqlClient

Public Class EditItem

    Private Sub EditItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        If Items.rbRENTAL.Checked Then
            i = Items.DataGridRENTALItems.CurrentRow.Index
            txtItemCode.Text = Items.DataGridRENTALItems.Item(0, i).Value
            txtItem.Text = Items.DataGridRENTALItems.Item(1, i).Value
            txtDescription.Text = Items.DataGridRENTALItems.Item(2, i).Value
            txtPrice.Text = Items.DataGridRENTALItems.Item(3, i).Value
            txtStock.Text = Items.DataGridRENTALItems.Item(4, i).Value
            cmbSupplier.Text = Items.DataGridRENTALItems.Item(5, i).Value
            cmbCategory.Text = "RENTAL"
        Else
            i = Items.DataGridRENTALItems.CurrentRow.Index
            txtItemCode.Text = Items.DataGridRENTALItems.Item(0, i).Value
            txtItem.Text = Items.DataGridRENTALItems.Item(1, i).Value
            txtDescription.Text = Items.DataGridRENTALItems.Item(2, i).Value
            txtPrice.Text = Items.DataGridRENTALItems.Item(3, i).Value
            txtStock.Text = Items.DataGridRENTALItems.Item(4, i).Value
            cmbSupplier.Text = Items.DataGridRENTALItems.Item(5, i).Value
            cmbCategory.Text = "SELLING"

        End If

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
        da = New MySqlDataAdapter("INSERT INTO tbl_logsactivity (logsID, logsActivity) VALUES (@logsID,'Updates an item')", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@logsID", Label1.Text)

        da.Fill(dt)
        disconnect_DB()

        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("UPDATE tbl_InventoryItem SET ItemName=@ItemName, ItemDescription=@ItemDescription, ItemStock=@ItemStock, SupplierID=@SupplierID,ItemCategory=@ItemCategory, ItemPrice=@ItemPrice WHERE ItemCode=@ItemCode ", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@ItemCode", txtItemCode.Text)
        da.SelectCommand.Parameters.AddWithValue("@ItemName", txtItem.Text)
        da.SelectCommand.Parameters.AddWithValue("@ItemDescription", txtDescription.Text)
        da.SelectCommand.Parameters.AddWithValue("@ItemStock", txtStock.Text)
        da.SelectCommand.Parameters.AddWithValue("@SupplierID", cmbSupplier.SelectedValue)
        da.SelectCommand.Parameters.AddWithValue("@ItemCategory", cmbCategory.Text)
        da.SelectCommand.Parameters.AddWithValue("@ItemPrice", txtPrice.Text)
        da.Fill(dt)
        disconnect_DB()
        MsgBox("Item has been updated")
        Items.ViewAllRentalItem()
        Items.ViewAllSellingItem()

        Me.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

End Class