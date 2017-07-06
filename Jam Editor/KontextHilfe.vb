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
                KshellForm.ShowDialog()
                If KshellForm.abgebrochen = False And KshellForm.TextBox1.Text <> "" Then
                    Select Case KshellForm.ComboBox1.SelectedIndex
                        Case 0
                            Select Case KshellForm.ComboBox3.SelectedIndex
                                Case 0
                                    Select Case KshellForm.ComboBox2.SelectedIndex
                                        Case 0
                                            insert("shell wait:true|" & KshellForm.TextBox1.Text)
                                        Case 1
                                            insert("shell wait:true|focus:false|" & KshellForm.TextBox1.Text)
                                    End Select
                                Case 1
                                    Select Case KshellForm.ComboBox2.SelectedIndex
                                        Case 0
                                            insert("shell " & KshellForm.TextBox1.Text)
                                        Case 1
                                            insert("shell focus:false|" & KshellForm.TextBox1.Text)
                                    End Select
                            End Select
                        Case 1
                            Select Case KshellForm.ComboBox3.SelectedIndex
                                Case 0
                                    insert("shell winstyle:hidden|wait:true|" & KshellForm.TextBox1.Text)
                                Case 1
                                    insert("shell winstyle:hidden|" & KshellForm.TextBox1.Text)
                            End Select
                        Case 2
                            Select Case KshellForm.ComboBox3.SelectedIndex
                                Case 0
                                    Select Case KshellForm.ComboBox2.SelectedIndex
                                        Case 0
                                            insert("shell winstyle:minimized|wait:true|" & KshellForm.TextBox1.Text)
                                        Case 1
                                            insert("shell winstyle:minimized|focus:false" & KshellForm.TextBox1.Text)
                                    End Select
                                Case 1
                                    Select Case KshellForm.ComboBox2.SelectedIndex
                                        Case 0
                                            insert("shell winstyle:minimized|wait:true|" & KshellForm.TextBox1.Text)
                                        Case 1
                                            insert("shell winstyle:minimized|focus:false" & KshellForm.TextBox1.Text)
                                    End Select
                            End Select
                        Case 3
                            Select Case KshellForm.ComboBox3.SelectedIndex
                                Case 0
                                    insert("shell winstyle:maximized|wait:true|" & KshellForm.TextBox1.Text)
                                Case 1
                                    insert("shell winstyle:maximized|" & KshellForm.TextBox1.Text)
                            End Select
                    End Select
                End If
                'Dim temp As String = InputBox("Welcher Shellbefehl soll aufgerufen werden?", "Shell")
                'If temp <> "" Then
                '    insert("shell " & temp)
                'End If
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
                            insert("ifTaskExist " & temp & "|" & temp2)
                        Else
                            insert("ifTaskExist " & temp & "|" & temp2 & "|" & temp3)
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
            Case "kLog"
                Dim temp As String = InputBox("Sollen die weitere Ausführung des Skripts in einem Log mitgeschrieben werden?" & vbCrLf & "Bitte nur true oder false eingeben!", "Log")
                If temp <> "" Then
                    If temp.ToLower = "false" Then
                        insert("log false")
                    Else
                        Dim temp2 As String = InputBox("Pfad und Name der Log Datei angeben.", "Log")
                        If temp2 <> "" Then
                            insert("log " & temp & "|" & temp2)
                        End If
                    End If
                End If
            Case "kSet"
                Dim temp As String = InputBox("Wie ist der Name der Variable die gesetzt werden soll?", "Set")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Wie soll der Wert der Variable sein?", "Set")
                    If temp2 <> "" Then
                        insert("set " & temp & "|" & temp2)
                    End If
                End If
            Case "kReadFile"
                Dim temp As String = InputBox("Welche Datei soll eingelesen werden?", "ReadFile")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("In welche Variable soll der Inhalt der Textdatei geladen werden?" & vbCrLf & "Variable ohne $ Zeichen angeben!", "ReadFile")
                    If temp2 <> "" Then
                        insert("readFile " & temp & ">" & temp2)
                    End If
                End If
            Case "kIfStringEqual"
                Dim temp As String = InputBox("String 1 oder Variable eingeben?", "IfStringEqual")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("String 2 oder Variable eingeben?", "IfStringEqual")
                    If temp2 <> "" Then
                        Dim temp3 As String = InputBox("Zu welcher Sprungmarke soll gesprungen werden wenn die Strings übereinstimmen?", "IfStringEqual")
                        If temp3 <> "" Then
                            Dim temp4 As String = InputBox("Zu welcher Sprungmarke soll gesprungen werden wenn die Strings nicht übereinstimmen?", "IfStringEqual")
                            If temp4 <> "" Then
                                insert("ifStringEqual " & temp & "|" & temp2 & "|" & temp3 & "|" & temp4)
                            Else
                                insert("ifStringEqual " & temp & "|" & temp2 & "|" & temp3)
                            End If
                        End If
                    End If
                End If
            Case "kIfStringContain"
                Dim temp As String = InputBox("Welcher String oder Variable soll überprüft werden?", "IfStringContain")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Auf welchen String oder Variable soll geprüft werden ob dieser enthalten ist?", "IfStringContain")
                    If temp2 <> "" Then
                        Dim temp3 As String = InputBox("Zu welcher Sprungmarke soll gesprungen werden wenn der Strings enthalten ist?", "IfStringContain")
                        If temp3 <> "" Then
                            Dim temp4 As String = InputBox("Zu welcher Sprungmarke soll gesprungen werden wenn der Strings nicht enthalten ist?", "IfStringContain")
                            If temp4 <> "" Then
                                insert("ifStringContain " & temp & "|" & temp2 & "|" & temp3 & "|" & temp4)
                            Else
                                insert("ifStringContain " & temp & "|" & temp2 & "|" & temp3)
                            End If
                        End If
                    End If
                End If
            Case "kCalculate"
                Dim temp As String = InputBox("In welche Variable soll gespeichert werden?" & vbCrLf & "Variable ohne $ Zeichen angeben!", "Calculate")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Was soll gerechnet werden?", "Calculate")
                    If temp2 <> "" Then
                        insert("calculate " & temp & "|" & temp2)
                    End If
                End If
            Case "kSubstring"
                Dim temp As String = InputBox("In welche Variable soll gespeichert werden?", "Substring")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Welcher String oder Variable soll überarbeitet werden?", "Substring")
                    If temp2 <> "" Then
                        Dim temp3 As String = InputBox("Bei welchem Index (Null basiert) soll der neue String anfangen?", "Substring")
                        If temp3 <> "" Then
                            Dim temp4 As String = InputBox("Wie lang soll der neue String sein? Bei keiner Angabe wird der String am Ende nicht geschnitten.", "Substring")
                            If temp4 <> "" Then
                                insert("substring " & temp & "|" & temp2 & "|" & temp3 & "|" & temp4)
                            Else
                                insert("substring " & temp & "|" & temp2 & "|" & temp3)
                            End If
                        End If
                    End If
                End If
            Case "kReplaceString"
                Dim temp As String = InputBox("In welche Variable soll gespeichert werden?", "ReplaceString")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Welcher String oder Variable soll überarbeitet werden?", "ReplaceString")
                    If temp2 <> "" Then
                        Dim temp3 As String = InputBox("Welches Zeichen soll ersetzt werden?", "ReplaceString")
                        If temp3 <> "" Then
                            Dim temp4 As String = InputBox("Durch welches Zeichen soll ersetzt werden?", "ReplaceString")
                            If temp4 <> "" Then
                                insert("replaceString " & temp & "|" & temp2 & "|" & temp3 & "|" & temp4)
                            Else
                                insert("replaceString " & temp & "|" & temp2 & "|" & temp3)
                            End If
                        End If
                    End If
                End If
            Case "kSetRegValue"
                Dim temp As String = InputBox("Wie lautet der Pfad des Registrykey in dem sich der zu ändernde Eintrag befindet oder erstellt werden soll?", "SetRegValue")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Wie lautet der Name des Eintrags der geändert oder erstellt werden soll?", "SetRegValue")
                    If temp2 <> "" Then
                        Dim temp3 As String = InputBox("Welchen Wert soll in den Eintrag geschrieben werden?", "SetRegValue")
                        If temp3 <> "" Then
                            Dim temp4 As String = InputBox("Welchen Registry Typ soll der Eintrag besitzen? (Optional)" & vbCrLf & "Mögliche Eingaben sind: binary, string, dword, qword, expandstring, multistring", "SetRegValue")
                            If temp4 <> "" Then
                                insert("setRegValue " & temp & "|" & temp2 & "|" & temp3 & "|" & temp4)
                            Else
                                insert("setRegValue " & temp & "|" & temp2 & "|" & temp3)
                            End If
                        End If
                    End If
                End If
            Case "kGetRegValue"
                Dim temp As String = InputBox("Wie lautet der Pfad des Registrykey in dem sich der zu lesende Eintrag befindet?", "GetRegValue")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Wie lautet der Name des Eintrags der gelesen werden soll?", "GetRegValue")
                    If temp2 <> "" Then
                        Dim temp3 As String = InputBox("In welche Variable soll der Wert gespeichert werden?" & vbCrLf & " (Ohne Angabe vom Zeichen $)", "GetRegValue")
                        If temp3 <> "" Then
                            insert("getRegValue " & temp & "|" & temp2 & "|" & temp3)
                        End If
                    End If
                End If
            Case "kCreateRegKey"
                Dim temp As String = InputBox("Wie lautet der Pfad des Registrykey der erstellt werden soll?", "CreateRegKey")
                If temp <> "" Then
                    insert("createRegKey " & temp)
                End If
            Case "kDelRegKey"
                Dim temp As String = InputBox("Wie lautet der Pfad des Registrykey?", "DelRegKey")
                If temp <> "" Then
                    insert("delRegKey " & temp)
                End If
            Case "kDelRegValue"
                Dim temp As String = InputBox("Wie lautet der Pfad des Registrykey in dem sich der zu löschende Eintrag befindet?", "DelRegValue")
                If temp <> "" Then
                    Dim temp2 As String = InputBox("Wie lautet der Name des Eintrags der gelöscht werden soll?", "DelRegValue")
                    If temp2 <> "" Then
                        insert("delRegValue " & temp & "|" & temp2)
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
