Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class MainMenu

    Dim mytime As String
  Dim password As String
    Private Function Decrypt(ByVal cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function

    Public Function Encrypt(ByVal clearText As String) As String
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

    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim tooltip1 As New ToolTip()
        tooltip1.AutoPopDelay = 1000
        tooltip1.InitialDelay = 500
        tooltip1.ReshowDelay = 100
        tooltip1.ShowAlways = True

        tooltip1.SetToolTip(Me.pcbxRESERVATION, "Reservation")
        tooltip1.SetToolTip(Me.pcbxITEMS, "Items")
        tooltip1.SetToolTip(Me.pcbxSERVICES, "Services")
        tooltip1.SetToolTip(Me.pcbxSupplier, "Suppliers")
        tooltip1.SetToolTip(Me.pcbxREPORTS, "Reports")
        tooltip1.SetToolTip(Me.pcbxCATERING, "Catering")
        tooltip1.SetToolTip(Me.pcbxACCOUNTS, "Accounts")


        Reservation.Show()
        Reservation.MdiParent = Me
        Reservation.Location = New Point(0, 247)
        Panel4.SendToBack()
    End Sub

    Private Sub pcbxPOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        POS.Show()
        POS.MdiParent = Me
        POS.Location = New Point(0, 247)

        ReportsForm.Close()
        SupplierForm.Close()
        Reservation.Close()
        Catering.Close()
        Services.Close()
        Items.Close()
        AddItem.Close()
        Panel4.SendToBack()
    End Sub



    Private Sub pcbxITEMS_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxITEMS.MouseHover
        pcbxITEMS.Image = My.Resources.items2

    End Sub

    Private Sub pcbxITEMS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxITEMS.MouseLeave
        pcbxITEMS.Image = My.Resources.items

    End Sub

    Private Sub pcbxSTOCKS_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxSERVICES.MouseHover
        pcbxSERVICES.Image = My.Resources.ballon2

    End Sub

    Private Sub pcbxSTOCKS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxSERVICES.MouseLeave
        pcbxSERVICES.Image = My.Resources.ballon

    End Sub

    Private Sub pcbxREPORTS_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxREPORTS.MouseHover
        pcbxREPORTS.Image = My.Resources.reports2

    End Sub

    Private Sub pcbxREPORTS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxREPORTS.MouseLeave
        pcbxREPORTS.Image = My.Resources.reports

    End Sub

    Private Sub pcbxACCOUNTS_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxACCOUNTS.MouseHover
        pcbxACCOUNTS.Image = My.Resources.accounts2

    End Sub

    Private Sub pcbxACCOUNTS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxACCOUNTS.MouseLeave
        pcbxACCOUNTS.Image = My.Resources.accounts

    End Sub



    Private Sub pcbxACCOUNTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub pcbxITEMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbxITEMS.Click
        Items.Show()
        Items.MdiParent = Me
        Items.Location = New Point(0, 247)

        ReportsForm.Close()
        SupplierForm.Close()
        Reservation.Close()
        Catering.Close()
        Services.Close()
        POS.Close()
        AddItem.Close()
        Panel4.SendToBack()

    End Sub

    Private Sub pcbxSTOCKS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbxSERVICES.Click
        Services.Show()
        Services.MdiParent = Me
        Services.Location = New Point(0, 247)

        ReportsForm.Close()
        SupplierForm.Close()
        Reservation.Close()
        Catering.Close()
        POS.Close()
        Items.Close()
        AddItem.Close()
        Panel4.SendToBack()

    End Sub

    Private Sub pcbxSupplier_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxSupplier.Click
        SupplierForm.Show()
        SupplierForm.MdiParent = Me
        SupplierForm.Location = New Point(0, 247)

        ReportsForm.Close()
        Reservation.Close()
        Catering.Close()
        Services.Close()
        POS.Close()
        Items.Close()
        AddItem.Close()
        Panel4.SendToBack()
    End Sub


    Private Sub pcbxSupplier_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxSupplier.MouseHover
        pcbxSupplier.Image = My.Resources.suppliers2

    End Sub

    Private Sub pcbxSupplier_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxSupplier.MouseLeave
        pcbxSupplier.Image = My.Resources.suppliers

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub pcbxRESERVATION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbxRESERVATION.Click
        Reservation.Show()
        Reservation.MdiParent = Me
        Reservation.Location = New Point(0, 247)
        Reservation.ViewAllReservation()


        ReportsForm.Close()
        SupplierForm.Close()
        Catering.Close()
        Services.Close()
        POS.Close()
        Items.Close()
        AddItem.Close()
        Panel4.SendToBack()
    End Sub

    Private Sub pcbxRESERVATION_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxRESERVATION.MouseHover
        pcbxRESERVATION.Image = My.Resources.resevation2

    End Sub

    Private Sub pcbxRESERVATION_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxRESERVATION.MouseLeave
        pcbxRESERVATION.Image = My.Resources.resevation
    End Sub


    Private Sub pcbxCATERING_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbxCATERING.Click
        Catering.Show()
        Catering.MdiParent = Me
        Catering.Location = New Point(0, 247)

        ReportsForm.Close()
        SupplierForm.Close()
        Reservation.Close()
        Services.Close()
        POS.Close()
        Items.Close()
        AddItem.Close()
        Panel4.SendToBack()
    End Sub

    Private Sub pcbxCATERING_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxCATERING.MouseHover
        pcbxCATERING.Image = My.Resources.catering2
    End Sub

    Private Sub pcbxCATERING_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbxCATERING.MouseLeave
        pcbxCATERING.Image = My.Resources.catering
    End Sub

    Private Sub pcbxREPORTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbxREPORTS.Click
        ReportsForm.Show()
        ReportsForm.MdiParent = Me
        ReportsForm.Location = New Point(0, 247)
        ReportsForm.ViewAllItem()
        'ReportsForm.ViewAllsales()

        SupplierForm.Close()
        Reservation.Close()
        Catering.Close()
        Services.Close()
        POS.Close()
        Items.Close()
        AddItem.Close()
        Panel4.SendToBack()
    End Sub

    Private Sub pcbxACCOUNTS_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbxACCOUNTS.Click
        UserAccount.Show()
        UserAccount.MdiParent = Me
        UserAccount.Location = New Point(0, 247)

        ReportsForm.Close()
        SupplierForm.Close()
        Reservation.Close()
        Catering.Close()
        Services.Close()
        POS.Close()
        Items.Close()
        AddItem.Close()
        Panel4.SendToBack()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LOGSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LOGSToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Logs.Show()
        Logs.MdiParent = Me
        Logs.Location = New Point(0, 247)

        UserAccount.Close()
        ReportsForm.Close()
        SupplierForm.Close()
        Reservation.Close()
        Catering.Close()
        Services.Close()
        POS.Close()
        Items.Close()
        AddItem.Close()
        Panel4.SendToBack()
    End Sub

    Private Sub Header_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Header.Paint

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ContextMenuStrip1.Show(PictureBox1, 0, PictureBox1.Height)


    End Sub

    Private Sub LOGSToolStripMenuItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGSToolStripMenuItem.Click
        Logs.Show()
        Logs.MdiParent = Me
        Logs.Location = New Point(0, 247)

        UserAccount.Close()
        ReportsForm.Close()
        SupplierForm.Close()
        Reservation.Close()
        Catering.Close()
        Services.Close()
        POS.Close()
        Items.Close()
        AddItem.Close()
        Panel4.SendToBack()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Close()

    End Sub


    Private Sub BACKUPDATABSEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACKUPDATABSEToolStripMenuItem.Click
        Label1.Text = System.DateTime.Now.ToString("MMMM dd,yyyy")
        Process.Start("C:\xampp\mysql\bin\mysqldump.exe", "-u root -p binglessai -r ""C:\Users\Sheila Young\Desktop\Bingles\Backup " + Label1.Text + ".sql")
        MsgBox("Database Successfully Back Up")

    End Sub
End Class
