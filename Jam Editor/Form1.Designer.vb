﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AufUpdatesPrüfenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SchließenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
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
        Me.kCls = New System.Windows.Forms.ToolStripMenuItem()
        Me.kClearLine = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErscheinungsbildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kTitle = New System.Windows.Forms.ToolStripMenuItem()
        Me.kVisible = New System.Windows.Forms.ToolStripMenuItem()
        Me.kLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.kInclude = New System.Windows.Forms.ToolStripMenuItem()
        Me.kSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.kOpacity = New System.Windows.Forms.ToolStripMenuItem()
        Me.kTopMost = New System.Windows.Forms.ToolStripMenuItem()
        Me.kFontSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntscheidungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kLable = New System.Windows.Forms.ToolStripMenuItem()
        Me.kGoto = New System.Windows.Forms.ToolStripMenuItem()
        Me.kGoSub = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.kIf = New System.Windows.Forms.ToolStripMenuItem()
        Me.kIfDirExist = New System.Windows.Forms.ToolStripMenuItem()
        Me.kIfFileExist = New System.Windows.Forms.ToolStripMenuItem()
        Me.kIfTaskExist = New System.Windows.Forms.ToolStripMenuItem()
        Me.kIfStringEqual = New System.Windows.Forms.ToolStripMenuItem()
        Me.kIfStringContain = New System.Windows.Forms.ToolStripMenuItem()
        Me.kIfPingSuccessfull = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.kChangeDir = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ZeitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.vJahr = New System.Windows.Forms.ToolStripMenuItem()
        Me.vMonat = New System.Windows.Forms.ToolStripMenuItem()
        Me.vTag = New System.Windows.Forms.ToolStripMenuItem()
        Me.vStunde = New System.Windows.Forms.ToolStripMenuItem()
        Me.vMinute = New System.Windows.Forms.ToolStripMenuItem()
        Me.vSekunde = New System.Windows.Forms.ToolStripMenuItem()
        Me.vMonat0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.vTag0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.vStunde0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.vMinute0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.vSekunde0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.kSet = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.vDesktop = New System.Windows.Forms.ToolStripMenuItem()
        Me.vDokumente = New System.Windows.Forms.ToolStripMenuItem()
        Me.vBilder = New System.Windows.Forms.ToolStripMenuItem()
        Me.vMusik = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.vFavoriten = New System.Windows.Forms.ToolStripMenuItem()
        Me.vZuletztVerwendet = New System.Windows.Forms.ToolStripMenuItem()
        Me.vSendenAn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.vStartmenue = New System.Windows.Forms.ToolStripMenuItem()
        Me.vStartmenueProgramme = New System.Windows.Forms.ToolStripMenuItem()
        Me.vAutostart = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.vCookies = New System.Windows.Forms.ToolStripMenuItem()
        Me.vVerlauf = New System.Windows.Forms.ToolStripMenuItem()
        Me.vCache = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.vBetriebssystemPlatform = New System.Windows.Forms.ToolStripMenuItem()
        Me.vBetriebssystemVersion = New System.Windows.Forms.ToolStripMenuItem()
        Me.vProzessorAnzahl = New System.Windows.Forms.ToolStripMenuItem()
        Me.vUptime = New System.Windows.Forms.ToolStripMenuItem()
        Me.JamreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.vAktuellesVerzeichnis = New System.Windows.Forms.ToolStripMenuItem()
        Me.vApplicationPath = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LadenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernUnterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkriptSpeichernUndAusfuehrenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusführenMitParameternToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
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
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.LadenToolStripMenuItem, Me.SpeichernToolStripMenuItem, Me.SpeichernUnterToolStripMenuItem, Me.SkriptSpeichernUndAusfuehrenToolStripMenuItem, Me.AusführenMitParameternToolStripMenuItem, Me.ToolStripSeparator4, Me.AufUpdatesPrüfenToolStripMenuItem, Me.ToolStripSeparator1, Me.SchließenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(313, 6)
        '
        'AufUpdatesPrüfenToolStripMenuItem
        '
        Me.AufUpdatesPrüfenToolStripMenuItem.Name = "AufUpdatesPrüfenToolStripMenuItem"
        Me.AufUpdatesPrüfenToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.AufUpdatesPrüfenToolStripMenuItem.Text = "Auf Updates prüfen"
        Me.AufUpdatesPrüfenToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(313, 6)
        Me.ToolStripSeparator1.Visible = False
        '
        'SchließenToolStripMenuItem
        '
        Me.SchließenToolStripMenuItem.Name = "SchließenToolStripMenuItem"
        Me.SchließenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SchließenToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 497)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(852, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel1.Text = "Zeilen:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(55, 17)
        Me.ToolStripStatusLabel2.Text = "Zeichen: "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel3.Text = "Größe ca."
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
        Me.RichTextBox1.WordWrap = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BefehleToolStripMenuItem, Me.VariablenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(123, 48)
        '
        'BefehleToolStripMenuItem
        '
        Me.BefehleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StandardBefehleToolStripMenuItem, Me.ErscheinungsbildToolStripMenuItem, Me.EntscheidungenToolStripMenuItem, Me.DateiUndOrdnerToolStripMenuItem, Me.TasksToolStripMenuItem, Me.StringToolStripMenuItem, Me.RegistryToolStripMenuItem})
        Me.BefehleToolStripMenuItem.Name = "BefehleToolStripMenuItem"
        Me.BefehleToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.BefehleToolStripMenuItem.Text = "Befehle"
        '
        'StandardBefehleToolStripMenuItem
        '
        Me.StandardBefehleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.kMessage, Me.kSleep, Me.kShell, Me.kStart, Me.kStartWait, Me.kKommentar, Me.kCalculate, Me.kCls, Me.kClearLine})
        Me.StandardBefehleToolStripMenuItem.Name = "StandardBefehleToolStripMenuItem"
        Me.StandardBefehleToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.StandardBefehleToolStripMenuItem.Text = "Standard Befehle"
        '
        'kMessage
        '
        Me.kMessage.Name = "kMessage"
        Me.kMessage.Size = New System.Drawing.Size(161, 22)
        Me.kMessage.Text = "message"
        '
        'kSleep
        '
        Me.kSleep.Name = "kSleep"
        Me.kSleep.Size = New System.Drawing.Size(161, 22)
        Me.kSleep.Text = "sleep"
        '
        'kShell
        '
        Me.kShell.Name = "kShell"
        Me.kShell.Size = New System.Drawing.Size(161, 22)
        Me.kShell.Text = "shell"
        '
        'kStart
        '
        Me.kStart.Name = "kStart"
        Me.kStart.Size = New System.Drawing.Size(161, 22)
        Me.kStart.Text = "start"
        '
        'kStartWait
        '
        Me.kStartWait.Name = "kStartWait"
        Me.kStartWait.Size = New System.Drawing.Size(161, 22)
        Me.kStartWait.Text = "startwait"
        '
        'kKommentar
        '
        Me.kKommentar.Name = "kKommentar"
        Me.kKommentar.Size = New System.Drawing.Size(161, 22)
        Me.kKommentar.Text = "kommentar"
        '
        'kCalculate
        '
        Me.kCalculate.Name = "kCalculate"
        Me.kCalculate.Size = New System.Drawing.Size(161, 22)
        Me.kCalculate.Text = "calculate"
        '
        'kCls
        '
        Me.kCls.Name = "kCls"
        Me.kCls.Size = New System.Drawing.Size(161, 22)
        Me.kCls.Text = "cls (clear screen)"
        '
        'kClearLine
        '
        Me.kClearLine.Name = "kClearLine"
        Me.kClearLine.Size = New System.Drawing.Size(161, 22)
        Me.kClearLine.Text = "clearLine"
        '
        'ErscheinungsbildToolStripMenuItem
        '
        Me.ErscheinungsbildToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.kTitle, Me.kVisible, Me.kLog, Me.kInclude, Me.kSize, Me.kOpacity, Me.kTopMost, Me.kFontSize})
        Me.ErscheinungsbildToolStripMenuItem.Name = "ErscheinungsbildToolStripMenuItem"
        Me.ErscheinungsbildToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ErscheinungsbildToolStripMenuItem.Text = "Sonderfunktionen"
        '
        'kTitle
        '
        Me.kTitle.Name = "kTitle"
        Me.kTitle.Size = New System.Drawing.Size(119, 22)
        Me.kTitle.Text = "title"
        '
        'kVisible
        '
        Me.kVisible.Name = "kVisible"
        Me.kVisible.Size = New System.Drawing.Size(119, 22)
        Me.kVisible.Text = "visible"
        '
        'kLog
        '
        Me.kLog.Name = "kLog"
        Me.kLog.Size = New System.Drawing.Size(119, 22)
        Me.kLog.Text = "log"
        '
        'kInclude
        '
        Me.kInclude.Name = "kInclude"
        Me.kInclude.Size = New System.Drawing.Size(119, 22)
        Me.kInclude.Text = "include"
        '
        'kSize
        '
        Me.kSize.Name = "kSize"
        Me.kSize.Size = New System.Drawing.Size(119, 22)
        Me.kSize.Text = "size"
        '
        'kOpacity
        '
        Me.kOpacity.Name = "kOpacity"
        Me.kOpacity.Size = New System.Drawing.Size(119, 22)
        Me.kOpacity.Text = "opacity"
        '
        'kTopMost
        '
        Me.kTopMost.Name = "kTopMost"
        Me.kTopMost.Size = New System.Drawing.Size(119, 22)
        Me.kTopMost.Text = "topMost"
        '
        'kFontSize
        '
        Me.kFontSize.Name = "kFontSize"
        Me.kFontSize.Size = New System.Drawing.Size(119, 22)
        Me.kFontSize.Text = "fontSize"
        '
        'EntscheidungenToolStripMenuItem
        '
        Me.EntscheidungenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.kLable, Me.kGoto, Me.kGoSub, Me.ToolStripSeparator5, Me.kIf, Me.kIfDirExist, Me.kIfFileExist, Me.kIfTaskExist, Me.kIfStringEqual, Me.kIfStringContain, Me.kIfPingSuccessfull, Me.ToolStripSeparator6, Me.kExit})
        Me.EntscheidungenToolStripMenuItem.Name = "EntscheidungenToolStripMenuItem"
        Me.EntscheidungenToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EntscheidungenToolStripMenuItem.Text = "Entscheidungen"
        '
        'kLable
        '
        Me.kLable.Name = "kLable"
        Me.kLable.Size = New System.Drawing.Size(163, 22)
        Me.kLable.Text = "Sprungmarke"
        '
        'kGoto
        '
        Me.kGoto.Name = "kGoto"
        Me.kGoto.Size = New System.Drawing.Size(163, 22)
        Me.kGoto.Text = "Goto"
        '
        'kGoSub
        '
        Me.kGoSub.Name = "kGoSub"
        Me.kGoSub.Size = New System.Drawing.Size(163, 22)
        Me.kGoSub.Text = "GoSub"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(160, 6)
        '
        'kIf
        '
        Me.kIf.Name = "kIf"
        Me.kIf.Size = New System.Drawing.Size(163, 22)
        Me.kIf.Text = "If"
        '
        'kIfDirExist
        '
        Me.kIfDirExist.Name = "kIfDirExist"
        Me.kIfDirExist.Size = New System.Drawing.Size(163, 22)
        Me.kIfDirExist.Text = "ifDirExist"
        '
        'kIfFileExist
        '
        Me.kIfFileExist.Name = "kIfFileExist"
        Me.kIfFileExist.Size = New System.Drawing.Size(163, 22)
        Me.kIfFileExist.Text = "ifFileExist"
        '
        'kIfTaskExist
        '
        Me.kIfTaskExist.Name = "kIfTaskExist"
        Me.kIfTaskExist.Size = New System.Drawing.Size(163, 22)
        Me.kIfTaskExist.Text = "ifTaskExist"
        '
        'kIfStringEqual
        '
        Me.kIfStringEqual.Name = "kIfStringEqual"
        Me.kIfStringEqual.Size = New System.Drawing.Size(163, 22)
        Me.kIfStringEqual.Text = "ifStringEqual"
        Me.kIfStringEqual.Visible = False
        '
        'kIfStringContain
        '
        Me.kIfStringContain.Name = "kIfStringContain"
        Me.kIfStringContain.Size = New System.Drawing.Size(163, 22)
        Me.kIfStringContain.Text = "ifStringContain"
        Me.kIfStringContain.Visible = False
        '
        'kIfPingSuccessfull
        '
        Me.kIfPingSuccessfull.Name = "kIfPingSuccessfull"
        Me.kIfPingSuccessfull.Size = New System.Drawing.Size(163, 22)
        Me.kIfPingSuccessfull.Text = "ifPingSuccessfull"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(160, 6)
        '
        'kExit
        '
        Me.kExit.Name = "kExit"
        Me.kExit.Size = New System.Drawing.Size(163, 22)
        Me.kExit.Text = "exit"
        '
        'DateiUndOrdnerToolStripMenuItem
        '
        Me.DateiUndOrdnerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.kDelDir, Me.kCopyDir, Me.kMoveDir, Me.kDelFile, Me.kCopyFile, Me.kMoveFile, Me.ToolStripSeparator2, Me.kWriteFile, Me.kWriteFileAppend, Me.kReadFile, Me.kMkDir, Me.kChangeDir, Me.ToolStripSeparator3, Me.kWget})
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
        'kChangeDir
        '
        Me.kChangeDir.Name = "kChangeDir"
        Me.kChangeDir.Size = New System.Drawing.Size(160, 22)
        Me.kChangeDir.Text = "changeDir"
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
        Me.kWget.Text = "Download"
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
        Me.kSetRegValue.Size = New System.Drawing.Size(145, 22)
        Me.kSetRegValue.Text = "setRegValue"
        '
        'kGetRegValue
        '
        Me.kGetRegValue.Name = "kGetRegValue"
        Me.kGetRegValue.Size = New System.Drawing.Size(145, 22)
        Me.kGetRegValue.Text = "getRegValue"
        '
        'kCreateRegKey
        '
        Me.kCreateRegKey.Name = "kCreateRegKey"
        Me.kCreateRegKey.Size = New System.Drawing.Size(145, 22)
        Me.kCreateRegKey.Text = "createRegKey"
        '
        'kDelRegKey
        '
        Me.kDelRegKey.Name = "kDelRegKey"
        Me.kDelRegKey.Size = New System.Drawing.Size(145, 22)
        Me.kDelRegKey.Text = "delRegKey"
        '
        'kDelRegValue
        '
        Me.kDelRegValue.Name = "kDelRegValue"
        Me.kDelRegValue.Size = New System.Drawing.Size(145, 22)
        Me.kDelRegValue.Text = "delRegValue"
        '
        'VariablenToolStripMenuItem
        '
        Me.VariablenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZeichenToolStripMenuItem, Me.ZeitToolStripMenuItem, Me.kSet, Me.UserToolStripMenuItem, Me.SystemToolStripMenuItem, Me.JamreToolStripMenuItem})
        Me.VariablenToolStripMenuItem.Name = "VariablenToolStripMenuItem"
        Me.VariablenToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
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
        'ZeitToolStripMenuItem
        '
        Me.ZeitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.vJahr, Me.vMonat, Me.vTag, Me.vStunde, Me.vMinute, Me.vSekunde, Me.vMonat0, Me.vTag0, Me.vStunde0, Me.vMinute0, Me.vSekunde0})
        Me.ZeitToolStripMenuItem.Name = "ZeitToolStripMenuItem"
        Me.ZeitToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ZeitToolStripMenuItem.Text = "Zeit"
        '
        'vJahr
        '
        Me.vJahr.Name = "vJahr"
        Me.vJahr.Size = New System.Drawing.Size(220, 22)
        Me.vJahr.Text = "Jahr"
        '
        'vMonat
        '
        Me.vMonat.Name = "vMonat"
        Me.vMonat.Size = New System.Drawing.Size(220, 22)
        Me.vMonat.Text = "Monat"
        '
        'vTag
        '
        Me.vTag.Name = "vTag"
        Me.vTag.Size = New System.Drawing.Size(220, 22)
        Me.vTag.Text = "Tag"
        '
        'vStunde
        '
        Me.vStunde.Name = "vStunde"
        Me.vStunde.Size = New System.Drawing.Size(220, 22)
        Me.vStunde.Text = "Stunde"
        '
        'vMinute
        '
        Me.vMinute.Name = "vMinute"
        Me.vMinute.Size = New System.Drawing.Size(220, 22)
        Me.vMinute.Text = "Minute"
        '
        'vSekunde
        '
        Me.vSekunde.Name = "vSekunde"
        Me.vSekunde.Size = New System.Drawing.Size(220, 22)
        Me.vSekunde.Text = "Sekunde"
        '
        'vMonat0
        '
        Me.vMonat0.Name = "vMonat0"
        Me.vMonat0.Size = New System.Drawing.Size(220, 22)
        Me.vMonat0.Text = "Monat mit führender Null"
        '
        'vTag0
        '
        Me.vTag0.Name = "vTag0"
        Me.vTag0.Size = New System.Drawing.Size(220, 22)
        Me.vTag0.Text = "Tag mit führender Null"
        '
        'vStunde0
        '
        Me.vStunde0.Name = "vStunde0"
        Me.vStunde0.Size = New System.Drawing.Size(220, 22)
        Me.vStunde0.Text = "Stunde mit führender Null"
        '
        'vMinute0
        '
        Me.vMinute0.Name = "vMinute0"
        Me.vMinute0.Size = New System.Drawing.Size(220, 22)
        Me.vMinute0.Text = "Minute mit führender Null"
        '
        'vSekunde0
        '
        Me.vSekunde0.Name = "vSekunde0"
        Me.vSekunde0.Size = New System.Drawing.Size(220, 22)
        Me.vSekunde0.Text = "Sekunde mit führender Null"
        '
        'kSet
        '
        Me.kSet.Name = "kSet"
        Me.kSet.Size = New System.Drawing.Size(151, 22)
        Me.kSet.Text = "set"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.vDesktop, Me.vDokumente, Me.vBilder, Me.vMusik, Me.ToolStripSeparator8, Me.vFavoriten, Me.vZuletztVerwendet, Me.vSendenAn, Me.ToolStripSeparator9, Me.vStartmenue, Me.vStartmenueProgramme, Me.vAutostart, Me.ToolStripSeparator7, Me.vCookies, Me.vVerlauf, Me.vCache})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'vDesktop
        '
        Me.vDesktop.Name = "vDesktop"
        Me.vDesktop.Size = New System.Drawing.Size(195, 22)
        Me.vDesktop.Text = "Desktop"
        '
        'vDokumente
        '
        Me.vDokumente.Name = "vDokumente"
        Me.vDokumente.Size = New System.Drawing.Size(195, 22)
        Me.vDokumente.Text = "Dokumente"
        '
        'vBilder
        '
        Me.vBilder.Name = "vBilder"
        Me.vBilder.Size = New System.Drawing.Size(195, 22)
        Me.vBilder.Text = "Bilder"
        '
        'vMusik
        '
        Me.vMusik.Name = "vMusik"
        Me.vMusik.Size = New System.Drawing.Size(195, 22)
        Me.vMusik.Text = "Musik"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(192, 6)
        '
        'vFavoriten
        '
        Me.vFavoriten.Name = "vFavoriten"
        Me.vFavoriten.Size = New System.Drawing.Size(195, 22)
        Me.vFavoriten.Text = "Favoriten"
        '
        'vZuletztVerwendet
        '
        Me.vZuletztVerwendet.Name = "vZuletztVerwendet"
        Me.vZuletztVerwendet.Size = New System.Drawing.Size(195, 22)
        Me.vZuletztVerwendet.Text = "Zuletzt verwendet"
        '
        'vSendenAn
        '
        Me.vSendenAn.Name = "vSendenAn"
        Me.vSendenAn.Size = New System.Drawing.Size(195, 22)
        Me.vSendenAn.Text = "Senden an"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(192, 6)
        '
        'vStartmenue
        '
        Me.vStartmenue.Name = "vStartmenue"
        Me.vStartmenue.Size = New System.Drawing.Size(195, 22)
        Me.vStartmenue.Text = "Startmenü"
        '
        'vStartmenueProgramme
        '
        Me.vStartmenueProgramme.Name = "vStartmenueProgramme"
        Me.vStartmenueProgramme.Size = New System.Drawing.Size(195, 22)
        Me.vStartmenueProgramme.Text = "Startmenü Programme"
        '
        'vAutostart
        '
        Me.vAutostart.Name = "vAutostart"
        Me.vAutostart.Size = New System.Drawing.Size(195, 22)
        Me.vAutostart.Text = "Autostart"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(192, 6)
        '
        'vCookies
        '
        Me.vCookies.Name = "vCookies"
        Me.vCookies.Size = New System.Drawing.Size(195, 22)
        Me.vCookies.Text = "Cookies"
        '
        'vVerlauf
        '
        Me.vVerlauf.Name = "vVerlauf"
        Me.vVerlauf.Size = New System.Drawing.Size(195, 22)
        Me.vVerlauf.Text = "Verlauf"
        '
        'vCache
        '
        Me.vCache.Name = "vCache"
        Me.vCache.Size = New System.Drawing.Size(195, 22)
        Me.vCache.Text = "Cache"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.vBetriebssystemPlatform, Me.vBetriebssystemVersion, Me.vProzessorAnzahl, Me.vUptime})
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SystemToolStripMenuItem.Text = "System"
        '
        'vBetriebssystemPlatform
        '
        Me.vBetriebssystemPlatform.Name = "vBetriebssystemPlatform"
        Me.vBetriebssystemPlatform.Size = New System.Drawing.Size(202, 22)
        Me.vBetriebssystemPlatform.Text = "Betriebssystem Platform"
        '
        'vBetriebssystemVersion
        '
        Me.vBetriebssystemVersion.Name = "vBetriebssystemVersion"
        Me.vBetriebssystemVersion.Size = New System.Drawing.Size(202, 22)
        Me.vBetriebssystemVersion.Text = "Betriebssystem Version"
        '
        'vProzessorAnzahl
        '
        Me.vProzessorAnzahl.Name = "vProzessorAnzahl"
        Me.vProzessorAnzahl.Size = New System.Drawing.Size(202, 22)
        Me.vProzessorAnzahl.Text = "Prozessor Anzahl"
        '
        'vUptime
        '
        Me.vUptime.Name = "vUptime"
        Me.vUptime.Size = New System.Drawing.Size(202, 22)
        Me.vUptime.Text = "Uptime"
        '
        'JamreToolStripMenuItem
        '
        Me.JamreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.vAktuellesVerzeichnis, Me.vApplicationPath})
        Me.JamreToolStripMenuItem.Name = "JamreToolStripMenuItem"
        Me.JamreToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.JamreToolStripMenuItem.Text = "jam-re"
        '
        'vAktuellesVerzeichnis
        '
        Me.vAktuellesVerzeichnis.Name = "vAktuellesVerzeichnis"
        Me.vAktuellesVerzeichnis.Size = New System.Drawing.Size(183, 22)
        Me.vAktuellesVerzeichnis.Text = "Aktuelles Verzeichnis"
        '
        'vApplicationPath
        '
        Me.vApplicationPath.Name = "vApplicationPath"
        Me.vApplicationPath.Size = New System.Drawing.Size(183, 22)
        Me.vApplicationPath.Text = "applicationPath"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Jam Skript|*.jam"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Jam Skript|*.jam"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.RichTextBox2.DetectUrls = False
        Me.RichTextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(852, 519)
        Me.RichTextBox2.TabIndex = 3
        Me.RichTextBox2.Text = ""
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Image = Global.Jam_Editor.My.Resources.Resources.file
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.NeuToolStripMenuItem.Text = "Neu"
        '
        'LadenToolStripMenuItem
        '
        Me.LadenToolStripMenuItem.Image = Global.Jam_Editor.My.Resources.Resources.document
        Me.LadenToolStripMenuItem.Name = "LadenToolStripMenuItem"
        Me.LadenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.LadenToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.LadenToolStripMenuItem.Text = "Laden"
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Image = Global.Jam_Editor.My.Resources.Resources.save
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.SpeichernToolStripMenuItem.Text = "Speichern"
        '
        'SpeichernUnterToolStripMenuItem
        '
        Me.SpeichernUnterToolStripMenuItem.Image = Global.Jam_Editor.My.Resources.Resources.save
        Me.SpeichernUnterToolStripMenuItem.Name = "SpeichernUnterToolStripMenuItem"
        Me.SpeichernUnterToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SpeichernUnterToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.SpeichernUnterToolStripMenuItem.Text = "Speichern unter"
        '
        'SkriptSpeichernUndAusfuehrenToolStripMenuItem
        '
        Me.SkriptSpeichernUndAusfuehrenToolStripMenuItem.Enabled = False
        Me.SkriptSpeichernUndAusfuehrenToolStripMenuItem.Image = Global.Jam_Editor.My.Resources.Resources.run
        Me.SkriptSpeichernUndAusfuehrenToolStripMenuItem.Name = "SkriptSpeichernUndAusfuehrenToolStripMenuItem"
        Me.SkriptSpeichernUndAusfuehrenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.SkriptSpeichernUndAusfuehrenToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.SkriptSpeichernUndAusfuehrenToolStripMenuItem.Text = "Speichern und ausführen"
        Me.SkriptSpeichernUndAusfuehrenToolStripMenuItem.Visible = False
        '
        'AusführenMitParameternToolStripMenuItem
        '
        Me.AusführenMitParameternToolStripMenuItem.Enabled = False
        Me.AusführenMitParameternToolStripMenuItem.Image = Global.Jam_Editor.My.Resources.Resources.run
        Me.AusführenMitParameternToolStripMenuItem.Name = "AusführenMitParameternToolStripMenuItem"
        Me.AusführenMitParameternToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F5), System.Windows.Forms.Keys)
        Me.AusführenMitParameternToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.AusführenMitParameternToolStripMenuItem.Text = "Ausführen mit Parametern"
        Me.AusführenMitParameternToolStripMenuItem.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 519)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Jam Skripteditor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
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
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents kInclude As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AufUpdatesPrüfenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kCls As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kIfPingSuccessfull As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZeitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vJahr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vMonat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vTag As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vStunde As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vMinute As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vSekunde As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vMonat0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vTag0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vStunde0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vMinute0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vSekunde0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents kIf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vDesktop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vDokumente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vBilder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vMusik As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents vFavoriten As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vZuletztVerwendet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vSendenAn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents vStartmenue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vStartmenueProgramme As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vAutostart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents vCookies As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vVerlauf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vCache As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vBetriebssystemPlatform As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vBetriebssystemVersion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vProzessorAnzahl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vUptime As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kSize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kOpacity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kTopMost As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SkriptSpeichernUndAusfuehrenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AusführenMitParameternToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kFontSize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kClearLine As ToolStripMenuItem
    Friend WithEvents kChangeDir As ToolStripMenuItem
    Friend WithEvents JamreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents vApplicationPath As ToolStripMenuItem
    Friend WithEvents vAktuellesVerzeichnis As ToolStripMenuItem
End Class
