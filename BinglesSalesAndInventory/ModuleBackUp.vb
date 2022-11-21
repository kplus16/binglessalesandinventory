Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.IO

Module ModuleBackUp

    'Public Sub backup3jr()

    '    Dim infoReader As System.IO.FileInfo
    '    infoReader = My.Computer.FileSystem.GetFileInfo("C:\Users\yggleaf\Desktop\3jr")

    '    Dim attributeReader As System.IO.FileAttributes
    '    attributeReader = infoReader.Attributes



    '    If (attributeReader And System.IO.FileAttributes.Hidden) > 0 Then
    '        MsgBox("File is hidden!")
    '    Else
    '        MsgBox("File is not hidden!")

    '        Try

    '            POSmain.ListBox1.Items.Add(Login_3JR.Username_Text.Text & "[" & POSmain.EmployeeID_Text.Text & "] has Successfully Created a Backup for 3JR Database at " & TimeOfDay & " of " & Today.ToString("dd-MM-yyyy") & vbNewLine)
    '            Process.Start("C:\xampp\mysql\bin\MySQLdump.exe", " -u root 3jr -r ""C:\Users\yggleaf\Desktop\3jr\3jr.sql""")
    '            MessageBox.Show("3JR Database Backup was Successfully Created!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)


    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End Try
    '        save_log_message()                'Update Record
    '        populateListboxLoginMessage()


    '    End If







    'End Sub


    Public Sub importBackup()


        Dim myProcess As New Process()

        myProcess.StartInfo.FileName = "cmd.exe"

        myProcess.StartInfo.UseShellExecute = False

        myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin"

        myProcess.StartInfo.RedirectStandardInput = True

        myProcess.StartInfo.RedirectStandardOutput = True

        myProcess.Start()

        Dim myStreamWriter As StreamWriter = myProcess.StandardInput

        Dim mystreamreader As StreamReader = myProcess.StandardOutput

        myStreamWriter.WriteLine("mysql -u root binglessai < C:\Users\Sheila Young\Desktop\Bingles\binglessai.sql")

        myStreamWriter.Close()

        myProcess.WaitForExit()

        myProcess.Close()




    End Sub


End Module
