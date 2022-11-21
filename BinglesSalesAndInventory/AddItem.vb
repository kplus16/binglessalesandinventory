Imports MySql.Data.MySqlClient

Public Class AddItem

    Private Sub AddItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect_DB()
 
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT * FROM tbl_Supplier", sqlCon)
        da.Fill(dt)
        cmbSupplier.DataSource = dt
        cmbSupplier.ValueMember = dt.Columns(0).ToString
        cmbSupplier.DisplayMember = dt.Columns(1).ToString

        disconnect_DB()

    End Sub

    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
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
        da = New MySqlDataAdapter("INSERT INTO tbl_logsactivity (logsID, logsActivity) VALUES (@logsID,'Adds an item')", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@logsID", Label1.Text)

        da.Fill(dt)
        disconnect_DB()


        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("INSERT INTO tbl_inventoryitem (ItemName, ItemDescription, ItemStock, SupplierID, ItemPrice, ItemCategory) VALUES (@ItemName, @ItemDescription, @ItemStock, @SupplierID, @ItemPrice, @ItemCategory)", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@ItemName", txtItem.Text)
        da.SelectCommand.Parameters.AddWithValue("@ItemDescription", txtDescription.Text)
        da.SelectCommand.Parameters.AddWithValue("@ItemStock", txtStock.Text)
        da.SelectCommand.Parameters.AddWithValue("@SupplierID", cmbSupplier.SelectedValue)
        da.SelectCommand.Parameters.AddWithValue("@ItemCategory", cmbCategory.Text)
        da.SelectCommand.Parameters.AddWithValue("@ItemPrice", txtPrice.Text)
        da.Fill(dt)
        disconnect_DB()
        MsgBox("Item has been added")
        Items.ViewAllRentalItem()
        Items.ViewAllSellingItem()

        txtDescription.Clear()
        txtItem.Clear()
        txtPrice.Clear()
        txtStock.Clear()

        Me.Close()


    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class