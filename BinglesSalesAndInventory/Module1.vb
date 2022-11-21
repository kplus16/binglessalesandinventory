Imports MySql.Data.MySqlClient

Module Module1

    Public sqlCon As New MySqlConnection
    Public dt As New DataTable
    Public da As New MySqlDataAdapter
    Public sqlCommand As New MySqlCommand
    Public ds As New DataSet



    Public Sub connect_DB()
        If sqlCon.State = ConnectionState.Closed Then
            sqlCon = New MySqlConnection("server=localhost; user id=root;password= ;database=binglessai;")
            sqlCon.Open()

        End If

    End Sub

    Public Sub disconnect_DB()

        If sqlCon.State = ConnectionState.Open Then
            sqlCon.Close()
        End If

    End Sub
End Module
