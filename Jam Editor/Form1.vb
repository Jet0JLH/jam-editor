Public Class Form1
    Dim saveFile As String = ""
    Private Sub SchließenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchließenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NeuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeuToolStripMenuItem.Click
        If RichTextBox1.CanUndo = True Then
            If MsgBox("Alle nicht gespeicherten Änderungen werden verworfen. Soll wirklich ein neues Skript erstellt werden?", MsgBoxStyle.YesNo, "Neues Skript?") = MsgBoxResult.Yes Then
                clearBox()
                saveFile = ""
            End If
        End If
    End Sub

    Private Sub LadenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LadenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                If RichTextBox1.CanUndo = True Then
                    If MsgBox("Alle nicht gespeicherten Änderungen werden verworfen. Soll wirklich ein anderes Skript geladen werden?", MsgBoxStyle.YesNo, "Skript laden?") = MsgBoxResult.Yes Then
                        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName, System.Text.Encoding.Default)
                    End If
                End If
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
                saveFile = OpenFileDialog1.FileName
            Catch ex As Exception
                MsgBox("Ein Fehler beim Laden des Skripts ist aufgetreten!" & vbCrLf & vbCrLf & ex.ToString)
            End Try
        End If
    End Sub

    Sub clearBox()
        RichTextBox1.Clear()
        While RichTextBox1.CanUndo = True
            RichTextBox1.ClearUndo()
        End While
    End Sub

    'Syntax Highlightning
    Private Sub RichTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        Dim tempSelection As Integer = RichTextBox1.SelectionStart
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionColor = Color.Black
        'RichTextBox1.SelectionFont = New Font(DefaultFont.FontFamily, 12, FontStyle.Regular)

        Dim tempWord As String = ""
        Dim startIndex As Integer = 0
        Dim semicolon As Boolean = True
        For i As Integer = 0 To RichTextBox1.Text.Length - 1
            Select Case RichTextBox1.Text(i)
                Case ";"
                    Dim tempEditWord As String = tempWord.ToLower.Replace(Chr(13), "").Replace(Chr(10), "").ToLower
                    If tempEditWord = "exit" And semicolon = True Then
                        RichTextBox1.Select(startIndex, tempWord.Length)
                        RichTextBox1.SelectionColor = Color.Red
                    ElseIf tempEditWord.StartsWith(":") And semicolon = True Then
                        RichTextBox1.Select(startIndex, tempWord.Length)
                        RichTextBox1.SelectionColor = Color.Red
                    End If
                    startIndex = i + 1
                    semicolon = True
                    tempWord = ""
                Case " "
                    If semicolon = True Then
                        Select Case tempWord.Replace(Chr(13), "").Replace(Chr(10), "").ToLower
                            Case "message", "sleep", "wait", "deldir", "copydir", "delfile", "copyfile", "movedir", "movefile", "start", "startwait", "goto", "ifdirexist", "iffileexist", "shell", "writefile", "writefileappend", "mkdir", "taskkill", "taskclose", "iftaskexist", "gosub", "wget"
                                RichTextBox1.Select(startIndex, tempWord.Length)
                                RichTextBox1.SelectionColor = Color.DarkGreen
                                'RichTextBox1.SelectionFont = New Font(DefaultFont.FontFamily, 12, FontStyle.Bold)
                            Case "title", "visible"
                                RichTextBox1.Select(startIndex, tempWord.Length)
                                RichTextBox1.SelectionColor = Color.CornflowerBlue
                        End Select
                    End If
                    semicolon = False
                    tempWord = ""
                Case "|", ">"
                    RichTextBox1.Select(i, 1)
                    RichTextBox1.SelectionColor = Color.DarkRed
                Case Else
                    tempWord &= RichTextBox1.Text(i)
            End Select
        Next

        RichTextBox1.Select(tempSelection, 0)
    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Environment.GetCommandLineArgs.Count >= 2 Then
            Try
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(Environment.GetCommandLineArgs(1), System.Text.Encoding.Default)
                saveFile = Environment.GetCommandLineArgs(1)
            Catch ex As Exception
                MsgBox("Datei konnte nicht geladen werden!" & vbCrLf & vbCrLf & ex.ToString)
            End Try
        End If
    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernToolStripMenuItem.Click
        If saveFile = "" Then
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                saveFile = SaveFileDialog1.FileName
                speichern(saveFile)
            End If
        Else
            speichern(saveFile)
        End If
    End Sub

    Private Sub SpeichernUnterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernUnterToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            saveFile = SaveFileDialog1.FileName
            speichern(saveFile)
        End If
    End Sub

    Sub speichern(ByVal pfad As String)
        Try
            My.Computer.FileSystem.WriteAllText(pfad, RichTextBox1.Text.Replace(Chr(10), Chr(13) & Chr(10)), False)
            MsgBox("Erfolgreich gespeichert")
        Catch ex As Exception
            MsgBox("Es ist ein Fehler beim Speichern aufgetreten!" & vbCrLf & vbCrLf & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub HelpMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kMessage.Click, kSleep.Click, kShell.Click, kStart.Click, kStartWait.Click, kTitle.Click, kVisible.Click, kLable.Click, kGoto.Click, kExit.Click, kIfDirExist.Click, kIfFileExist.Click, kDelDir.Click, kDelFile.Click, kCopyDir.Click, kCopyFile.Click, kMoveDir.Click, kMoveFile.Click, kWriteFile.Click, kWriteFileAppend.Click, kMkDir.Click, kTaskKill.Click, kTaskClose.Click, kIfTaskExist.Click, kKommentar.Click, kGoSub.Click, kWget.Click
        KontextHilfe.main(sender)
    End Sub

    Private Sub HelpMenuVariablen(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vZeilenumbruch.Click, v1.Click, v2.Click, v3.Click
        KontextHilfe.variablen(sender)
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        MsgBox("Jam Editor Version: " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor, MsgBoxStyle.Information)
    End Sub
End Class
