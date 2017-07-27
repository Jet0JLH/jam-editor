Imports System.Text
Public Class Form1
    Dim saveFile As String = ""
    Dim getFileSizeThread As Threading.Thread
    Dim formIsClosing As Boolean = False
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

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.formClosing
        formIsClosing = True
    End Sub

    Private Sub RichTextBox1_KeyUp() Handles RichTextBox1.KeyUp, Me.Shown, RichTextBox1.MouseUp, OpenFileDialog1.FileOk
        'Statusbar
        ToolStripStatusLabel1.Text = "Zeile: " & RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart) + 1 & " von "
        If RichTextBox1.Lines.Count() = 0 Then
            ToolStripStatusLabel1.Text &= 1
        Else
            ToolStripStatusLabel1.Text &= RichTextBox1.Lines.Count()
        End If
        ToolStripStatusLabel2.Text = "Zeichen: " & RichTextBox1.SelectionStart & " von " & RichTextBox1.Text.Count
    End Sub

    'Syntax Highlightning
    Private Sub RichTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox2.Rtf = RichTextBox1.Rtf
        Dim tempSelection As Integer = RichTextBox1.SelectionStart
        RichTextBox2.SelectAll()
        RichTextBox2.SelectionColor = Color.Black
        'RichTextBox1.SelectionFont = New Font(DefaultFont.FontFamily, 12, FontStyle.Regular)

        Dim tempWord As String = ""
        Dim startIndex As Integer = 0
        Dim semicolon As Boolean = True
        For i As Integer = 0 To RichTextBox2.Text.Length - 1
            Select Case RichTextBox2.Text(i)
                Case ";"
                    Dim tempEditWord As String = tempWord.ToLower.Replace(Chr(13), "").Replace(Chr(10), "").ToLower
                    If tempEditWord = "exit" And semicolon = True Then
                        RichTextBox2.Select(startIndex, tempWord.Length)
                        RichTextBox2.SelectionColor = Color.Red
                    ElseIf tempEditWord.StartsWith(":") And semicolon = True Then
                        RichTextBox2.Select(startIndex, tempWord.Length)
                        RichTextBox2.SelectionColor = Color.Red
                    End If
                    startIndex = i + 1
                    semicolon = True
                    tempWord = ""
                Case " "
                    If semicolon = True Then
                        Select Case tempWord.Replace(Chr(13), "").Replace(Chr(10), "").ToLower
                            Case "message", "sleep", "wait", "deldir", "copydir", "delfile", "copyfile", "movedir", "movefile", "start", "startwait", "goto", "ifdirexist", "iffileexist", "shell", "writefile", "writefileappend", "mkdir", "taskkill", "taskclose", "iftaskexist", "gosub", "wget", "readfile", "ifstringequal", "ifstringcontain", "calculate", "set", "substring", "replacestring", "setregvalue", "getregvalue", "createregkey", "delregkey", "delregvalue"
                                RichTextBox2.Select(startIndex, tempWord.Length)
                                RichTextBox2.SelectionColor = Color.DarkGreen
                                'RichTextBox1.SelectionFont = New Font(DefaultFont.FontFamily, 12, FontStyle.Bold)
                            Case "title", "visible", "log", "include"
                                RichTextBox2.Select(startIndex, tempWord.Length)
                                RichTextBox2.SelectionColor = Color.CornflowerBlue
                        End Select
                    End If
                    semicolon = False
                    tempWord = ""
                Case "|", ">"
                    RichTextBox2.Select(i, 1)
                    RichTextBox2.SelectionColor = Color.DarkRed
                Case Else
                    tempWord &= RichTextBox2.Text(i)
            End Select
        Next

        RichTextBox2.Select(tempSelection, 0)
        RichTextBox1.Rtf = RichTextBox2.Rtf
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

    Private Sub HelpMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kMessage.Click, kSleep.Click, kShell.Click, kStart.Click, kStartWait.Click, kTitle.Click, kVisible.Click, kLable.Click, kGoto.Click, kExit.Click, kIfDirExist.Click, kIfFileExist.Click, kDelDir.Click, kDelFile.Click, kCopyDir.Click, kCopyFile.Click, kMoveDir.Click, kMoveFile.Click, kWriteFile.Click, kWriteFileAppend.Click, kMkDir.Click, kTaskKill.Click, kTaskClose.Click, kIfTaskExist.Click, kKommentar.Click, kGoSub.Click, kWget.Click, kLog.Click, kSet.Click, kReadFile.Click, kIfStringEqual.Click, kIfStringContain.Click, kCalculate.Click, kSubstring.Click, kReplaceString.Click, kSetRegValue.Click, kGetRegValue.Click, kCreateRegKey.Click, kDelRegKey.Click, kDelRegValue.Click, kInclude.Click
        KontextHilfe.main(sender)
    End Sub

    Private Sub HelpMenuVariablen(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vZeilenumbruch.Click, v1.Click, v2.Click, v3.Click
        KontextHilfe.variablen(sender)
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        MsgBox("Jam Editor Version: " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build, MsgBoxStyle.Information)
    End Sub
    Function humanReadable(value As Double) As String
        Dim count As Byte = 0
        While value > 1024
            count += 1
            value = value / 1024
        End While
        Select count
            Case 0
                Return Math.Round(value, 2) & " Byte"
            Case 1
                Return Math.Round(value, 2) & " KB"
            Case 2
                Return Math.Round(value, 2) & " MB"
            Case 3
                Return Math.Round(value, 2) & " GB"
            Case 4
                Return Math.Round(value, 2) & " TB"
            Case Else
                Return Math.Round(value, 2) & " PB"
        End Select
    End Function
    Sub getFileSize()
        While True
            If RichTextBox1.Lines.Count = 0 Then
                ToolStripStatusLabel3.Text = "Größe: " & humanReadable(Encoding.UTF8.GetBytes(RichTextBox1.Text).Count + RichTextBox1.Lines.Count + 3)
            Else
                ToolStripStatusLabel3.Text = "Größe: " & humanReadable(Encoding.UTF8.GetBytes(RichTextBox1.Text).Count + RichTextBox1.Lines.Count + 2)
            End If
            If formIsClosing = True Then Exit While
            Threading.Thread.Sleep(2000)
        End While
    End Sub
    Private Sub Form1_Shown() Handles MyBase.Shown
        CheckForIllegalCrossThreadCalls = False
        getFileSizeThread = New Threading.Thread(AddressOf getFileSize)
        getFileSizeThread.Start()
    End Sub
End Class
