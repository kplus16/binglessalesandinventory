Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Public Class UserAccount


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        connect_DB()
        ds = New DataSet
        da = New MySqlDataAdapter("UPDATE login SET fullName=@fullName,username=@userName, password=@password, status=@status, type=@type WHERE IDNo=@IDNo", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@fullName", txtFullName.Text)
        da.SelectCommand.Parameters.AddWithValue("@userName", txtUserName.Text)
        da.SelectCommand.Parameters.AddWithValue("@password", txtPassword.Text)
        da.SelectCommand.Parameters.AddWithValue("@status", txtActive.Text)
        da.SelectCommand.Parameters.AddWithValue("@type", cmbTYPE.Text)
        da.SelectCommand.Parameters.AddWithValue("@IDNo", Label1.Text)
        da.Fill(ds, "login")
        disconnect_DB()
        ViewAllUser()

        MsgBox("User has been updated.")
        txtFullName.Clear()
        txtUserName.Clear()
        txtPassword.Clear()

        txtActive.Enabled = False
        txtFullName.Enabled = False
        txtPassword.Enabled = False
        txtUserName.Enabled = False
        txtActive.Text = "ACTIVE"
       

        btnUpdate.Visible = False
        btnEDIT.Visible = True

    End Sub
    Dim hold As String
    Private Function Encrypt(ByVal clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        connect_DB()
        ds = New DataSet
        da = New MySqlDataAdapter("INSERT INTO login (fullName,username, password, status,type) VALUES (@fullName,@userName,@password, 'ACTIVE',@type)", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@fullName", txtFullName.Text)
        da.SelectCommand.Parameters.AddWithValue("@userName", txtUserName.Text)
        da.SelectCommand.Parameters.AddWithValue("@type", cmbTYPE.Text)
        da.SelectCommand.Parameters.AddWithValue("@password", Encrypt(txtPassword.Text.Trim()))
        da.Fill(ds, "login")
        disconnect_DB()
        ViewAllUser()
        MsgBox("User has been saved.")
        txtFullName.Clear()
        txtUserName.Clear()
        txtPassword.Clear()

        txtActive.Enabled = False
        txtFullName.Enabled = False
        txtPassword.Enabled = False
        txtUserName.Enabled = False

        btnAdd.Visible = False
        btnNew.Visible = True


    End Sub

   

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        connect_DB()
        dt = New DataTable
        da = New MySqlDataAdapter("SELECT * FROM login WHERE fullname LIKE @fullname", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@fullname", "%" & txtSearch.Text & "%")
        da.Fill(dt)
        disconnect_DB()
        DataGridUser.DataSource = dt

    End Sub

    Private Sub DataGridUser_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridUser.KeyUp
        Dim i As Integer
        i = DataGridUser.CurrentRow.Index
        Label1.Text = DataGridUser.Item(0, i).Value
        txtFullName.Text = DataGridUser.Item(1, i).Value
        txtUserName.Text = DataGridUser.Item(2, i).Value
        txtPassword.Text = DataGridUser.Item(3, i).Value
        txtActive.Text = DataGridUser.Item(4, i).Value
        cmbTYPE.Text = DataGridUser.Item(4, i).Value
        txtActive.Enabled = False
        txtFullName.Enabled = False
        txtPassword.Enabled = False
        txtUserName.Enabled = False

       

        btnAdd.Visible = False
        btnUpdate.Visible = False
    End Sub

   
    Private Sub DataGridUser_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridUser.MouseClick
        Dim i As Integer
        i = DataGridUser.CurrentRow.Index
        Label1.Text = DataGridUser.Item(0, i).Value
        txtFullName.Text = DataGridUser.Item(1, i).Value
        txtUserName.Text = DataGridUser.Item(2, i).Value
        txtPassword.Text = DataGridUser.Item(3, i).Value
        txtActive.Text = DataGridUser.Item(4, i).Value
        cmbTYPE.Text = DataGridUser.Item(4, i).Value

        txtActive.Enabled = False
        txtFullName.Enabled = False
        txtPassword.Enabled = False
        txtUserName.Enabled = False

        btnAdd.Visible = False
        btnUpdate.Visible = False

    End Sub

    Public Sub ViewAllUser()
        connect_DB()
        ds = New DataSet
        da = New MySqlDataAdapter("SELECT * FROM login", sqlCon)
        da.Fill(ds, "login")
        disconnect_DB()
        DataGridUser.DataSource = ds.Tables("login")
    End Sub

    Private Sub UserAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewAllUser()

        txtFullName.Clear()
        txtFullName.Clear()
        txtPassword.Clear()
        txtUserName.Clear()

        txtActive.Enabled = False
        txtFullName.Enabled = False
        txtPassword.Enabled = False
        txtUserName.Enabled = False

        btnAdd.Visible = False
        btnUpdate.Visible = False


    End Sub


    

    Sub TestDecoding()
        Dim cipherText As String = My.Computer.FileSystem.ReadAllText(
            My.Computer.FileSystem.SpecialDirectories.MyDocuments &
                "\cipherText.txt")
        Dim password As String = InputBox("Enter the password:")
        Dim wrapper As New Simple3Des(password)

        ' DecryptData throws if the wrong password is used.
        Try
            Dim plainText As String = wrapper.DecryptData(cipherText)
            MsgBox("The plain text is: " & plainText)
        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox("The data could not be decrypted with the password.")
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtFullName.Clear()
        txtFullName.Clear()
        txtPassword.Clear()
        txtUserName.Clear()

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtActive.Enabled = True
        txtFullName.Enabled = True
        txtPassword.Enabled = True
        txtUserName.Enabled = True

        btnAdd.Visible = True
        btnNew.Visible = False

    End Sub

    Private Sub btnEDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEDIT.Click
        txtActive.Enabled = True
        txtFullName.Enabled = True
        txtPassword.Enabled = True
        txtUserName.Enabled = True

        btnEDIT.Visible = False
        btnUpdate.Visible = True

    End Sub

    Private Sub DataGridUser_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridUser.CellContentClick

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
End Class