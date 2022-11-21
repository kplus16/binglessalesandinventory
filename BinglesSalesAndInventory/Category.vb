Imports MySql.Data.MySqlClient

Public Class Category

    Private Sub Category_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("INSERT INTO tbl_Category (CategoryName) VALUES (@CategoryName)", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@CategoryName", txtICategory.Text)
        da.Fill(dt)

        dt = New DataTable
        da = New MySqlDataAdapter("SELECT * FROM tbl_Category", sqlCon)
        da.Fill(dt)
        disconnect_DB()
        MsgBox("Category successfully added.")
        Me.Close()

        

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class