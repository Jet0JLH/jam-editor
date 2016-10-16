Module KontextHilfe
    Public Sub main(ByVal sender As Object)
        Select Case sender.name.ToString
            Case "kMessage"
                Dim temp As String = InputBox("Was für eine Nachricht soll ausgegeben werden?", "Message")
                If temp <> "" Then
                    insert("message " & temp)
                End If
            Case "kSleep"
                Dim temp As String = InputBox("Wie viele Sekunden soll gewartet werden", "Sleep")
                If temp <> "" Then
                    insert("sleep " & temp)
                End If
            Case "kShell"
                Dim temp As String = InputBox("Welcher Shellbefehl soll aufgerufen werden?", "Shell")
                If temp <> "" Then
                    insert("shell " & temp)
                End If
            Case "kStart", "kStartWait"
                Dim temp As String = InputBox("Welches Programm soll aufgerufen werden?", "Start")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Werden Parameter benötigt? Wenn nein dann nichts eingeben oder abbrechen", "Start")
                    Dim tempString As String = ""
                    If temp2 = "" Then
                        tempString = temp
                    Else
                        tempString = temp & "|" & temp2
                    End If
                    If sender.name.ToString = "kStart" Then
                        insert("start " & tempString)
                    Else
                        insert("startWait " & tempString)
                    End If
                End If
            Case "kTitle"
                Dim temp As String = InputBox("Welcher Titel soll im Programm angezeigt werden?", "Title")
                If temp <> "" Then
                    insert("title " & temp)
                End If
            Case "kVisible"
                Dim temp As String = InputBox("Soll die Anwendung sichtbar sein?" & vbCrLf & "Bitte nur true oder false eingeben!", "Visible")
                If temp <> "" Then
                    insert("visible " & temp)
                End If
            Case "kLable"
                Dim temp As String = InputBox("Wie soll die Sprungmarke heißen?", "Sprungmarke")
                If temp <> "" Then
                    insert(":" & temp)
                End If
            Case "kGoto"
                Dim temp As String = InputBox("Zur welcher Sprungmarke soll gesprungen werden?", "Goto")
                If temp <> "" Then
                    insert("goto " & temp)
                End If
            Case "kExit"
                insert("exit")
            Case "kIfDirExist"
                Dim temp As String = InputBox("Welches Verzeichnis soll geprüft werden?", "IfDirExist")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Zur welcher Sprungmarke soll gesprungen werden wenn das Verzeichnis existiert?", "IfDirExist")
                    If temp2 <> "" Then
                        Dim temp3 As String = InputBox("Zur welcher Sprungmarke soll gesprungen werden wenn das Verzeichnis nicht existiert?" & vbCrLf & "Wenn dies nicht benötigt wird, bitte das Feld leer lassen oder abbrechen!", "IfDirExist")
                        If temp3 = "" Then
                            insert("ifDirExist " & temp & "|" & temp2)
                        Else
                            insert("ifDirExist " & temp & "|" & temp2 & "|" & temp3)
                        End If
                    End If
                End If
            Case "kIfFileExist"
                Dim temp As String = InputBox("Welche Datei soll geprüft werden?", "IfFileExist")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Zur welcher Sprungmarke soll gesprungen werden wenn die Datei existiert?", "IfFileExist")
                    If temp2 <> "" Then
                        Dim temp3 As String = InputBox("Zur welcher Sprungmarke soll gesprungen werden wenn die Datei nicht existiert?" & vbCrLf & "Wenn dies nicht benötigt wird, bitte das Feld leer lassen oder abbrechen!", "IfFileExist")
                        If temp3 = "" Then
                            insert("ifFileExist " & temp & "|" & temp2)
                        Else
                            insert("ifFileExist " & temp & "|" & temp2 & "|" & temp3)
                        End If
                    End If
                End If
            Case "kDelDir"
                Dim temp As String = InputBox("Welches Verzeichnis soll gelöscht werden?", "DelDir")
                If temp <> "" Then
                    insert("delDir " & temp)
                End If
            Case "kDelFile"
                Dim temp As String = InputBox("Welche Datei soll gelöscht werden?", "DelFile")
                If temp <> "" Then
                    insert("delFile " & temp)
                End If
            Case "kCopyDir"
                Dim temp As String = InputBox("Welches Verzeichnis soll kopiert werden?", "CopyDir")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Wohin soll das Verzeichnis kopiert werden?", "CopyDir")
                    If temp2 <> "" Then
                        insert("copyDir " & temp & " > " & temp2)
                    End If
                End If
            Case "kCopyFile"
                Dim temp As String = InputBox("Welche Datei soll kopiert werden?", "CopyFile")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Wohin soll die Datei kopiert werden?", "CopyFile")
                    If temp2 <> "" Then
                        insert("copyFile " & temp & " > " & temp2)
                    End If
                End If
            Case "kMoveDir"
                Dim temp As String = InputBox("Welches Verzeichnis soll verschoben werden?", "MoveDir")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Wohin soll das Verzeichnis verschoben werden?", "MoveDir")
                    If temp2 <> "" Then
                        insert("moveDir " & temp & " > " & temp2)
                    End If
                End If
            Case "kMoveFile"
                Dim temp As String = InputBox("Welche Datei soll verschoben werden?", "MoveFile")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Wohin soll die Datei verschoben werden?", "MoveFile")
                    If temp2 <> "" Then
                        insert("moveFile " & temp & " > " & temp2)
                    End If
                End If
            Case "kWriteFile", "kWriteFileAppend"
                Dim temp As String = InputBox("In welche Datei soll geschrieben werden?", "WriteFile")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Was soll in die Datei geschrieben werden?", "WriteFile")
                    If temp2 <> "" Then
                        If sender.name.ToString = "kWriteFile" Then
                            insert("writeFile " & temp2 & " > " & temp)
                        Else
                            insert("writeFileAppend " & temp2 & " > " & temp)
                        End If
                    End If
                End If
            Case "kMkDir"
                Dim temp As String = InputBox("Welches Verzeichnis soll angelegt werden?", "MkDir")
                If temp <> "" Then
                    insert("mkDir " & temp)
                End If
            Case "kTaskKill"
                Dim temp As String = InputBox("Welcher Task soll gekillt werden?" & vbCrLf & "Tasknamen ohne .exe angeben!", "TaskKill")
                If temp <> "" Then
                    insert("taskKill " & temp)
                End If
            Case "kTaskClose"
                Dim temp As String = InputBox("Welcher Task soll versucht werden beendet zu werden?" & vbCrLf & "Tasknamen ohne .exe angeben!", "TaskClose")
                If temp <> "" Then
                    insert("taskClose " & temp)
                End If
            Case "kIfTaskExist"
                Dim temp As String = InputBox("Welcher Task soll geprüft werden?", "IfTaskExist")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Zur welcher Sprungmarke soll gesprungen werden wenn der Task aktiv ist?", "IfTaskExist")
                    If temp2 <> "" Then
                        Dim temp3 As String = InputBox("Zur welcher Sprungmarke soll gesprungen werden wenn der Task nicht aktiv ist?" & vbCrLf & "Wenn dies nicht benötigt wird, bitte das Feld leer lassen oder abbrechen!", "IfTaskExist")
                        If temp3 = "" Then
                            insert("ifFileExist " & temp & "|" & temp2)
                        Else
                            insert("ifFileExist " & temp & "|" & temp2 & "|" & temp3)
                        End If
                    End If
                End If
            Case "kKommentar"
                Dim temp As String = InputBox("Bitte Kommentar eingeben", "Kommentar")
                If temp <> "" Then
                    insert("# " & temp)
                End If
            Case "kGoSub"
                Dim temp As String = InputBox("In welche Sub soll gesprungen werden?", "GoSub")
                If temp <> "" Then
                    insert("goSub " & temp)
                End If
            Case "kWget"
                Dim temp As String = InputBox("Welche Datei soll herrunter geladen werden?", "Wget")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Wo soll die Datei gespeichert werden? (Mit Dateinamen angeben!)", "Wget")
                    If temp2 <> "" Then
                        Dim temp3 As String = InputBox("Mit welchem Benutzer soll sich am Server authentifiziert werden? (Nur bei Bedarf angeben, ansonsten abbrechen)", "Wget")
                        If temp3 <> "" Then
                            Dim temp4 As String = InputBox("Mit welchem Passwort soll sich authentifiziert werden?", "Wget")
                            If temp4 <> "" Then
                                insert("wget " & temp & "|" & temp2 & "|" & temp3 & "|" & temp4)
                            End If
                        Else
                            insert("wget " & temp & "|" & temp2)
                        End If
                    End If
                End If
        End Select
    End Sub
    Public Sub insert(ByVal word As String, Optional ByVal ending As Boolean = True)
        If ending = True Then
            Form1.RichTextBox1.SelectedText = word & ";" & vbCrLf
        Else
            Form1.RichTextBox1.SelectedText = word
        End If
    End Sub
    Public Sub variablen(ByVal sender As Object)
        Select Case sender.name.ToString
            Case "vZeilenumbruch"
                insert("%_br%", False)
            Case "v1"
                insert("%_pipe%", False)
            Case "v2"
                insert("%_gd%", False)
            Case "v3"
                insert("%_prozent%", False)
        End Select
    End Sub
End Module
