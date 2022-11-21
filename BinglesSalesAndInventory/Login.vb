Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO


Public Class Login
    Dim attempt As Integer = 1
    Dim usertxt As String

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

    Dim mytime As String
    Dim startTime As Date
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        
        connect_DB()
        lbltime.Text = Format(Now, "hh:mm:ss")
        startTime = lbltime.Text
        lbluname.Text = txtUserName.Text

        ds = New DataSet
        da = New MySqlDataAdapter("SELECT * FROM login WHERE username=@username AND password=@password  ", sqlCon)
        da.SelectCommand.Parameters.AddWithValue("@username", txtUserName.Text)
        da.SelectCommand.Parameters.AddWithValue("@password", Encrypt(txtPassword.Text.Trim()))
        da.Fill(ds, "login")
        If ds.Tables("login").Rows.Count > 0 Then

            Dim idNum As String = ds.Tables("login").Rows(0).Item("IDNo").ToString
            Dim fullname As String = ds.Tables("login").Rows(0).Item("fullname").ToString
            Dim userName As String = ds.Tables("login").Rows(0).Item("username").ToString
            Dim password As String = ds.Tables("login").Rows(0).Item("password").ToString
            Dim status As String = ds.Tables("login").Rows(0).Item("status").ToString
            Dim type As String = ds.Tables("login").Rows(0).Item("TYPE").ToString
            MainMenu.lblTitle.Text = userName
            connect_DB()
            dt = New DataTable
            da = New MySqlDataAdapter("INSERT INTO tbl_logs(fullname, username, date, time) VALUES (@fullname,@username, @date, @time)", sqlCon)
            da.SelectCommand.Parameters.AddWithValue("@fullname", fullname)
            da.SelectCommand.Parameters.AddWithValue("@username", userName)
            da.SelectCommand.Parameters.AddWithValue("@date", Date.Now.ToString("MM-dd-yyyy"))
            da.SelectCommand.Parameters.AddWithValue("@time", lbltime.Text)
            da.Fill(dt)

            disconnect_DB()

            If type = "ADMIN" Then

                MainMenu.Show()
                Notification.ShowDialog()
               



                Me.Close()
            ElseIf type = "USER" Then
                POS.Label12.Text = "USER"

                MainMenu.Show()
                Notification.ShowDialog()

                MainMenu.pcbxREPORTS.Visible = False
                MainMenu.pcbxSupplier.Visible = False
                MainMenu.pcbxACCOUNTS.Visible = False
                MainMenu.LOGSToolStripMenuItem.Visible = False
                MainMenu.pcbxSERVICES.Location = New Point(889, 2)
                MainMenu.pcbxITEMS.Location = New Point(594, 2)
                MainMenu.pcbxCATERING.Location = New Point(306, 2)


                Me.Close()

            Else
                MsgBox("Invalid Username Or Password")
                txtUserName.Clear()
                txtPassword.Clear()
            End If

        ElseIf attempt = 3 Then
            MsgBox("Maximum number of attempt(3). Progress will now close.")
            Close()


        Else

            'Invalid 
            MsgBox("Username Or Password incorrect, please re-enter, you currently have reached attempt " & attempt & " of 3.")
            attempt = attempt + 1

            txtUserName.Clear()
            txtPassword.Clear()
            txtUserName.Focus()

        End If

        disconnect_DB()

        Reservation.ViewAllReservation()


    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        mytime = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUserName.Focus()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class