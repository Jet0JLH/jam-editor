<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LadenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernUnterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SchließenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BefehleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardBefehleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kMessage = New System.Windows.Forms.ToolStripMenuItem()
        Me.kSleep = New System.Windows.Forms.ToolStripMenuItem()
        Me.kShell = New System.Windows.Forms.ToolStripMenuItem()
        Me.kStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.kStartWait = New System.Windows.Forms.ToolStripMenuItem()
        Me.kKommentar = New System.Windows.Forms.ToolStripMenuItem()
        Me.kCalculate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErscheinungsbildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kTitle = New System.Windows.Forms.ToolStripMenuItem()
        Me.kVisible = New System.Windows.Forms.ToolStripMenuItem()
        Me.kLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntscheidungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kLable = New System.Windows.Forms.ToolStripMenuItem()
        Me.kGoto = New System.Windows.Forms.ToolStripMenuItem()
        Me.kGoSub = New System.Windows.Forms.ToolStripMenuItem()
        Me.kIfDirExist = New System.Windows.Forms.ToolStripMenuItem()
        Me.kIfFileExist = New System.Windows.Forms.ToolStripMenuItem()
        Me.kIfTaskExist = New System.Windows.Forms.ToolStripMenuItem()
        Me.kIfStringEqual = New System.Windows.Forms.ToolStripMenuItem()
        Me.kIfStringContain = New System.Windows.Forms.ToolStripMenuItem()
        Me.kExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateiUndOrdnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kDelDir = New System.Windows.Forms.ToolStripMenuItem()
        Me.kCopyDir = New System.Windows.Forms.ToolStripMenuItem()
        Me.kMoveDir = New System.Windows.Forms.ToolStripMenuItem()
        Me.kDelFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.kCopyFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.kMoveFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.kWriteFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.kWriteFileAppend = New System.Windows.Forms.ToolStripMenuItem()
        Me.kReadFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.kMkDir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.kWget = New System.Windows.Forms.ToolStripMenuItem()
        Me.TasksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kTaskKill = New System.Windows.Forms.ToolStripMenuItem()
        Me.kTaskClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.StringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kSubstring = New System.Windows.Forms.ToolStripMenuItem()
        Me.kReplaceString = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kSetRegValue = New System.Windows.Forms.ToolStripMenuItem()
        Me.kGetRegValue = New System.Windows.Forms.ToolStripMenuItem()
        Me.kCreateRegKey = New System.Windows.Forms.ToolStripMenuItem()
        Me.kDelRegKey = New System.Windows.Forms.ToolStripMenuItem()
        Me.kDelRegValue = New System.Windows.Forms.ToolStripMenuItem()
        Me.VariablenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZeichenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.vZeilenumbruch = New System.Windows.Forms.ToolStripMenuItem()
        Me.v1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.v2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.v3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.kSet = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(852, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.LadenToolStripMenuItem, Me.SpeichernToolStripMenuItem, Me.SpeichernUnterToolStripMenuItem, Me.ToolStripSeparator1, Me.SchließenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.NeuToolStripMenuItem.Text = "Neu"
        '
        'LadenToolStripMenuItem
        '
        Me.LadenToolStripMenuItem.Name = "LadenToolStripMenuItem"
        Me.LadenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.LadenToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.LadenToolStripMenuItem.Text = "Laden"
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.SpeichernToolStripMenuItem.Text = "Speichern"
        '
        'SpeichernUnterToolStripMenuItem
        '
        Me.SpeichernUnterToolStripMenuItem.Name = "SpeichernUnterToolStripMenuItem"
        Me.SpeichernUnterToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SpeichernUnterToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.SpeichernUnterToolStripMenuItem.Text = "Speichern unter"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(279, 6)
        '
        'SchließenToolStripMenuItem
        '
        Me.SchließenToolStripMenuItem.Name = "SchließenToolStripMenuItem"
        Me.SchließenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SchließenToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.SchließenToolStripMenuItem.Text = "Schließen"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 497)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(852, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.RichTextBox1.DetectUrls = False
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(852, 473)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BefehleToolStripMenuItem, Me.VariablenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 70)
        '
        'BefehleToolStripMenuItem
        '
        Me.BefehleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StandardBefehleToolStripMenuItem, Me.ErscheinungsbildToolStripMenuItem, Me.EntscheidungenToolStripMenuItem, Me.DateiUndOrdnerToolStripMenuItem, Me.TasksToolStripMenuItem, Me.StringToolStripMenuItem, Me.RegistryToolStripMenuItem})
        Me.BefehleToolStripMenuItem.Name = "BefehleToolStripMenuItem"
        Me.BefehleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BefehleToolStripMenuItem.Text = "Befehle"
        '
        'StandardBefehleToolStripMenuItem
        '
        Me.StandardBefehleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.kMessage, Me.kSleep, Me.kShell, Me.kStart, Me.kStartWait, Me.kKommentar, Me.kCalculate})
        Me.StandardBefehleToolStripMenuItem.Name = "StandardBefehleToolStripMenuItem"
        Me.StandardBefehleToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.StandardBefehleToolStripMenuItem.Text = "Standard Befehle"
        '
        'kMessage
        '
        Me.kMessage.Name = "kMessage"
        Me.kMessage.Size = New System.Drawing.Size(136, 22)
        Me.kMessage.Text = "message"
        '
        'kSleep
        '
        Me.kSleep.Name = "kSleep"
        Me.kSleep.Size = New System.Drawing.Size(136, 22)
        Me.kSleep.Text = "sleep"
        '
        'kShell
        '
        Me.kShell.Name = "kShell"
        Me.kShell.Size = New System.Drawing.Size(136, 22)
        Me.kShell.Text = "shell"
        '
        'kStart
        '
        Me.kStart.Name = "kStart"
        Me.kStart.Size = New System.Drawing.Size(136, 22)
        Me.kStart.Text = "start"
        '
        'kStartWait
        '
        Me.kStartWait.Name = "kStartWait"
        Me.kStartWait.Size = New System.Drawing.Size(136, 22)
        Me.kStartWait.Text = "startwait"
        '
        'kKommentar
        '
        Me.kKommentar.Name = "kKommentar"
        Me.kKommentar.Size = New System.Drawing.Size(136, 22)
        Me.kKommentar.Text = "kommentar"
        '
        'kCalculate
        '
        Me.kCalculate.Name = "kCalculate"
        Me.kCalculate.Size = New System.Drawing.Size(136, 22)
        Me.kCalculate.Text = "calculate"
        '
        'ErscheinungsbildToolStripMenuItem
        '
        Me.ErscheinungsbildToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.kTitle, Me.kVisible, Me.kLog})
        Me.ErscheinungsbildToolStripMenuItem.Name = "ErscheinungsbildToolStripMenuItem"
        Me.ErscheinungsbildToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ErscheinungsbildToolStripMenuItem.Text = "Sonderfunktionen"
        '
        'kTitle
        '
        Me.kTitle.Name = "kTitle"
        Me.kTitle.Size = New System.Drawing.Size(107, 22)
        Me.kTitle.Text = "title"
        '
        'kVisible
        '
        Me.kVisible.Name = "kVisible"
        Me.kVisible.Size = New System.Drawing.Size(107, 22)
        Me.kVisible.Text = "visible"
        '
        'kLog
        '
        Me.kLog.Name = "kLog"
        Me.kLog.Size = New System.Drawing.Size(107, 22)
        Me.kLog.Text = "log"
        '
        'EntscheidungenToolStripMenuItem
        '
        Me.EntscheidungenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.kLable, Me.kGoto, Me.kGoSub, Me.kIfDirExist, Me.kIfFileExist, Me.kIfTaskExist, Me.kIfStringEqual, Me.kIfStringContain, Me.kExit})
        Me.EntscheidungenToolStripMenuItem.Name = "EntscheidungenToolStripMenuItem"
        Me.EntscheidungenToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EntscheidungenToolStripMenuItem.Text = "Entscheidungen"
        '
        'kLable
        '
        Me.kLable.Name = "kLable"
        Me.kLable.Size = New System.Drawing.Size(154, 22)
        Me.kLable.Text = "Sprungmarke"
        '
        'kGoto
        '
        Me.kGoto.Name = "kGoto"
        Me.kGoto.Size = New System.Drawing.Size(154, 22)
        Me.kGoto.Text = "Goto"
        '
        'kGoSub
        '
        Me.kGoSub.Name = "kGoSub"
        Me.kGoSub.Size = New System.Drawing.Size(154, 22)
        Me.kGoSub.Text = "GoSub"
        '
        'kIfDirExist
        '
        Me.kIfDirExist.Name = "kIfDirExist"
        Me.kIfDirExist.Size = New System.Drawing.Size(154, 22)
        Me.kIfDirExist.Text = "ifDirExist"
        '
        'kIfFileExist
        '
        Me.kIfFileExist.Name = "kIfFileExist"
        Me.kIfFileExist.Size = New System.Drawing.Size(154, 22)
        Me.kIfFileExist.Text = "ifFileExist"
        '
        'kIfTaskExist
        '
        Me.kIfTaskExist.Name = "kIfTaskExist"
        Me.kIfTaskExist.Size = New System.Drawing.Size(154, 22)
        Me.kIfTaskExist.Text = "ifTaskExist"
        '
        'kIfStringEqual
        '
        Me.kIfStringEqual.Name = "kIfStringEqual"
        Me.kIfStringEqual.Size = New System.Drawing.Size(154, 22)
        Me.kIfStringEqual.Text = "ifStringEqual"
        '
        'kIfStringContain
        '
        Me.kIfStringContain.Name = "kIfStringContain"
        Me.kIfStringContain.Size = New System.Drawing.Size(154, 22)
        Me.kIfStringContain.Text = "ifStringContain"
        '
        'kExit
        '
        Me.kExit.Name = "kExit"
        Me.kExit.Size = New System.Drawing.Size(154, 22)
        Me.kExit.Text = "exit"
        '
        'DateiUndOrdnerToolStripMenuItem
        '
        Me.DateiUndOrdnerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.kDelDir, Me.kCopyDir, Me.kMoveDir, Me.kDelFile, Me.kCopyFile, Me.kMoveFile, Me.ToolStripSeparator2, Me.kWriteFile, Me.kWriteFileAppend, Me.kReadFile, Me.kMkDir, Me.ToolStripSeparator3, Me.kWget})
        Me.DateiUndOrdnerToolStripMenuItem.Name = "DateiUndOrdnerToolStripMenuItem"
        Me.DateiUndOrdnerToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DateiUndOrdnerToolStripMenuItem.Text = "Datei und Ordner"
        '
        'kDelDir
        '
        Me.kDelDir.Name = "kDelDir"
        Me.kDelDir.Size = New System.Drawing.Size(160, 22)
        Me.kDelDir.Text = "delDir"
        '
        'kCopyDir
        '
        Me.kCopyDir.Name = "kCopyDir"
        Me.kCopyDir.Size = New System.Drawing.Size(160, 22)
        Me.kCopyDir.Text = "copyDir"
        '
        'kMoveDir
        '
        Me.kMoveDir.Name = "kMoveDir"
        Me.kMoveDir.Size = New System.Drawing.Size(160, 22)
        Me.kMoveDir.Text = "moveDir"
        '
        'kDelFile
        '
        Me.kDelFile.Name = "kDelFile"
        Me.kDelFile.Size = New System.Drawing.Size(160, 22)
        Me.kDelFile.Text = "delFile"
        '
        'kCopyFile
        '
        Me.kCopyFile.Name = "kCopyFile"
        Me.kCopyFile.Size = New System.Drawing.Size(160, 22)
        Me.kCopyFile.Text = "copyFile"
        '
        'kMoveFile
        '
        Me.kMoveFile.Name = "kMoveFile"
        Me.kMoveFile.Size = New System.Drawing.Size(160, 22)
        Me.kMoveFile.Text = "moveFile"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(157, 6)
        '
        'kWriteFile
        '
        Me.kWriteFile.Name = "kWriteFile"
        Me.kWriteFile.Size = New System.Drawing.Size(160, 22)
        Me.kWriteFile.Text = "writeFile"
        '
        'kWriteFileAppend
        '
        Me.kWriteFileAppend.Name = "kWriteFileAppend"
        Me.kWriteFileAppend.Size = New System.Drawing.Size(160, 22)
        Me.kWriteFileAppend.Text = "writeFileAppend"
        '
        'kReadFile
        '
        Me.kReadFile.Name = "kReadFile"
        Me.kReadFile.Size = New System.Drawing.Size(160, 22)
        Me.kReadFile.Text = "readFile"
        '
        'kMkDir
        '
        Me.kMkDir.Name = "kMkDir"
        Me.kMkDir.Size = New System.Drawing.Size(160, 22)
        Me.kMkDir.Text = "mkDir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(157, 6)
        '
        'kWget
        '
        Me.kWget.Name = "kWget"
        Me.kWget.Size = New System.Drawing.Size(160, 22)
        Me.kWget.Text = "wget"
        '
        'TasksToolStripMenuItem
        '
        Me.TasksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.kTaskKill, Me.kTaskClose})
        Me.TasksToolStripMenuItem.Name = "TasksToolStripMenuItem"
        Me.TasksToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.TasksToolStripMenuItem.Text = "Tasks"
        '
        'kTaskKill
        '
        Me.kTaskKill.Name = "kTaskKill"
        Me.kTaskKill.Size = New System.Drawing.Size(124, 22)
        Me.kTaskKill.Text = "taskKill"
        '
        'kTaskClose
        '
        Me.kTaskClose.Name = "kTaskClose"
        Me.kTaskClose.Size = New System.Drawing.Size(124, 22)
        Me.kTaskClose.Text = "taskClose"
        '
        'StringToolStripMenuItem
        '
        Me.StringToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.kSubstring, Me.kReplaceString})
        Me.StringToolStripMenuItem.Name = "StringToolStripMenuItem"
        Me.StringToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.StringToolStripMenuItem.Text = "String"
        '
        'kSubstring
        '
        Me.kSubstring.Name = "kSubstring"
        Me.kSubstring.Size = New System.Drawing.Size(146, 22)
        Me.kSubstring.Text = "Substring"
        '
        'kReplaceString
        '
        Me.kReplaceString.Name = "kReplaceString"
        Me.kReplaceString.Size = New System.Drawing.Size(146, 22)
        Me.kReplaceString.Text = "ReplaceString"
        '
        'RegistryToolStripMenuItem
        '
        Me.RegistryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.kSetRegValue, Me.kGetRegValue, Me.kCreateRegKey, Me.kDelRegKey, Me.kDelRegValue})
        Me.RegistryToolStripMenuItem.Name = "RegistryToolStripMenuItem"
        Me.RegistryToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.RegistryToolStripMenuItem.Text = "Registry"
        '
        'kSetRegValue
        '
        Me.kSetRegValue.Name = "kSetRegValue"
        Me.kSetRegValue.Size = New System.Drawing.Size(152, 22)
        Me.kSetRegValue.Text = "setRegValue"
        '
        'kGetRegValue
        '
        Me.kGetRegValue.Name = "kGetRegValue"
        Me.kGetRegValue.Size = New System.Drawing.Size(152, 22)
        Me.kGetRegValue.Text = "getRegValue"
        '
        'kCreateRegKey
        '
        Me.kCreateRegKey.Name = "kCreateRegKey"
        Me.kCreateRegKey.Size = New System.Drawing.Size(152, 22)
        Me.kCreateRegKey.Text = "createRegKey"
        '
        'kDelRegKey
        '
        Me.kDelRegKey.Name = "kDelRegKey"
        Me.kDelRegKey.Size = New System.Drawing.Size(152, 22)
        Me.kDelRegKey.Text = "delRegKey"
        '
        'kDelRegValue
        '
        Me.kDelRegValue.Name = "kDelRegValue"
        Me.kDelRegValue.Size = New System.Drawing.Size(152, 22)
        Me.kDelRegValue.Text = "delRegValue"
        '
        'VariablenToolStripMenuItem
        '
        Me.VariablenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZeichenToolStripMenuItem, Me.kSet})
        Me.VariablenToolStripMenuItem.Name = "VariablenToolStripMenuItem"
        Me.VariablenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VariablenToolStripMenuItem.Text = "Variablen"
        '
        'ZeichenToolStripMenuItem
        '
        Me.ZeichenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.vZeilenumbruch, Me.v1, Me.v2, Me.v3})
        Me.ZeichenToolStripMenuItem.Name = "ZeichenToolStripMenuItem"
        Me.ZeichenToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ZeichenToolStripMenuItem.Text = "Sonderzeichen"
        '
        'vZeilenumbruch
        '
        Me.vZeilenumbruch.Name = "vZeilenumbruch"
        Me.vZeilenumbruch.Size = New System.Drawing.Size(155, 22)
        Me.vZeilenumbruch.Text = "Zeilenumbruch"
        '
        'v1
        '
        Me.v1.Enabled = False
        Me.v1.Name = "v1"
        Me.v1.Size = New System.Drawing.Size(155, 22)
        Me.v1.Text = "|"
        Me.v1.Visible = False
        '
        'v2
        '
        Me.v2.Enabled = False
        Me.v2.Name = "v2"
        Me.v2.Size = New System.Drawing.Size(155, 22)
        Me.v2.Text = ">"
        Me.v2.Visible = False
        '
        'v3
        '
        Me.v3.Enabled = False
        Me.v3.Name = "v3"
        Me.v3.Size = New System.Drawing.Size(155, 22)
        Me.v3.Text = "%"
        Me.v3.Visible = False
        '
        'kSet
        '
        Me.kSet.Name = "kSet"
        Me.kSet.Size = New System.Drawing.Size(151, 22)
        Me.kSet.Text = "set"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Jam Skript|*.jam"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Jam Skript|*.jam"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 519)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Jam Skripteditor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SchließenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents NeuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LadenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpeichernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpeichernUnterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BefehleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandardBefehleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kMessage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kSleep As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kShell As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kStart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kStartWait As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErscheinungsbildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kTitle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kVisible As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntscheidungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kLable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kGoto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kIfDirExist As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kIfFileExist As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateiUndOrdnerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kDelDir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kCopyDir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kMoveDir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kDelFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kCopyFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kMoveFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents kWriteFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kWriteFileAppend As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VariablenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZeichenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vZeilenumbruch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents v1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents v2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents v3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kMkDir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TasksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kTaskKill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kTaskClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kIfTaskExist As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kKommentar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kGoSub As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents kWget As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kCalculate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kLog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kIfStringEqual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kIfStringContain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kReadFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kSet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kSubstring As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kReplaceString As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kSetRegValue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kGetRegValue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kCreateRegKey As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kDelRegKey As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kDelRegValue As System.Windows.Forms.ToolStripMenuItem

End Class
