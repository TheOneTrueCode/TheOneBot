﻿Imports System.Drawing.Color
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.tblMain = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnCon = New System.Windows.Forms.Button()
        Me.tblTop = New System.Windows.Forms.TableLayoutPanel()
        Me.flowTopLeft = New System.Windows.Forms.FlowLayoutPanel()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.lblUname = New System.Windows.Forms.Label()
        Me.picBot = New System.Windows.Forms.PictureBox()
        Me.flowTopRight = New System.Windows.Forms.FlowLayoutPanel()
        Me.panPing = New System.Windows.Forms.Panel()
        Me.lblPing = New System.Windows.Forms.Label()
        Me.secondlast = New System.Windows.Forms.TabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.lblGeneral = New System.Windows.Forms.Label()
        Me.txtWake = New System.Windows.Forms.TextBox()
        Me.lblWakeCount = New System.Windows.Forms.Label()
        Me.lblWake = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.flowCommand = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkDel = New System.Windows.Forms.CheckBox()
        Me.chkHelp = New System.Windows.Forms.CheckBox()
        Me.chkPing = New System.Windows.Forms.CheckBox()
        Me.chkEcho = New System.Windows.Forms.CheckBox()
        Me.chkLast = New System.Windows.Forms.CheckBox()
        Me.chkStats = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabHelp = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.panHelpAdm = New System.Windows.Forms.Panel()
        Me.txtHelpAdmin = New System.Windows.Forms.TextBox()
        Me.panHelp = New System.Windows.Forms.Panel()
        Me.txtHelp = New System.Windows.Forms.TextBox()
        Me.tabAuth = New System.Windows.Forms.TabPage()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tabLog = New System.Windows.Forms.TabPage()
        Me.log = New System.Windows.Forms.ListBox()
        Me.Check = New System.Windows.Forms.Timer(Me.components)
        Me.Reloader = New System.Windows.Forms.Timer(Me.components)
        Me.Ping = New System.Windows.Forms.Timer(Me.components)
        Me.chkRemote = New System.Windows.Forms.CheckBox()
        Me.tblMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tblTop.SuspendLayout()
        Me.flowTopLeft.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flowTopRight.SuspendLayout()
        Me.secondlast.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.flowCommand.SuspendLayout()
        Me.tabHelp.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panHelpAdm.SuspendLayout()
        Me.panHelp.SuspendLayout()
        Me.tabAuth.SuspendLayout()
        Me.tabLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblMain
        '
        Me.tblMain.ColumnCount = 1
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMain.Controls.Add(Me.Panel1, 0, 2)
        Me.tblMain.Controls.Add(Me.tblTop, 0, 0)
        Me.tblMain.Controls.Add(Me.secondlast, 0, 1)
        Me.tblMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblMain.Location = New System.Drawing.Point(0, 0)
        Me.tblMain.Margin = New System.Windows.Forms.Padding(4)
        Me.tblMain.Name = "tblMain"
        Me.tblMain.RowCount = 3
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.tblMain.Size = New System.Drawing.Size(940, 501)
        Me.tblMain.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.btnCon)
        Me.Panel1.Controls.Add(Me.chkRemote)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 453)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(932, 44)
        Me.Panel1.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(3, 4)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(192, 36)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Offline"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCon
        '
        Me.btnCon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCon.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCon.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCon.Location = New System.Drawing.Point(791, 4)
        Me.btnCon.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCon.Name = "btnCon"
        Me.btnCon.Size = New System.Drawing.Size(137, 36)
        Me.btnCon.TabIndex = 0
        Me.btnCon.Text = "Connect"
        Me.btnCon.UseVisualStyleBackColor = False
        '
        'tblTop
        '
        Me.tblTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.tblTop.ColumnCount = 2
        Me.tblTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.tblTop.Controls.Add(Me.flowTopLeft, 0, 0)
        Me.tblTop.Controls.Add(Me.flowTopRight, 1, 0)
        Me.tblTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTop.Location = New System.Drawing.Point(3, 3)
        Me.tblTop.Name = "tblTop"
        Me.tblTop.RowCount = 1
        Me.tblTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTop.Size = New System.Drawing.Size(934, 51)
        Me.tblTop.TabIndex = 5
        '
        'flowTopLeft
        '
        Me.flowTopLeft.Controls.Add(Me.picProfile)
        Me.flowTopLeft.Controls.Add(Me.lblUname)
        Me.flowTopLeft.Controls.Add(Me.picBot)
        Me.flowTopLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowTopLeft.Location = New System.Drawing.Point(3, 3)
        Me.flowTopLeft.Name = "flowTopLeft"
        Me.flowTopLeft.Size = New System.Drawing.Size(528, 45)
        Me.flowTopLeft.TabIndex = 5
        '
        'picProfile
        '
        Me.picProfile.Image = Global.TheOneBot.My.Resources.Resources.none
        Me.picProfile.Location = New System.Drawing.Point(3, 3)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(40, 40)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 4
        Me.picProfile.TabStop = False
        '
        'lblUname
        '
        Me.lblUname.AutoSize = True
        Me.lblUname.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUname.Location = New System.Drawing.Point(49, 0)
        Me.lblUname.Name = "lblUname"
        Me.lblUname.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.lblUname.Size = New System.Drawing.Size(88, 39)
        Me.lblUname.TabIndex = 2
        Me.lblUname.Text = "Offline"
        Me.lblUname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picBot
        '
        Me.picBot.Image = Global.TheOneBot.My.Resources.Resources.bot
        Me.picBot.Location = New System.Drawing.Point(143, 3)
        Me.picBot.Name = "picBot"
        Me.picBot.Size = New System.Drawing.Size(50, 30)
        Me.picBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBot.TabIndex = 5
        Me.picBot.TabStop = False
        Me.picBot.Visible = False
        '
        'flowTopRight
        '
        Me.flowTopRight.Controls.Add(Me.panPing)
        Me.flowTopRight.Controls.Add(Me.lblPing)
        Me.flowTopRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowTopRight.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.flowTopRight.Location = New System.Drawing.Point(537, 3)
        Me.flowTopRight.Name = "flowTopRight"
        Me.flowTopRight.Size = New System.Drawing.Size(394, 45)
        Me.flowTopRight.TabIndex = 6
        '
        'panPing
        '
        Me.panPing.BackColor = System.Drawing.Color.Red
        Me.panPing.Location = New System.Drawing.Point(361, 3)
        Me.panPing.Name = "panPing"
        Me.panPing.Size = New System.Drawing.Size(30, 30)
        Me.panPing.TabIndex = 3
        '
        'lblPing
        '
        Me.lblPing.AutoSize = True
        Me.lblPing.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPing.Location = New System.Drawing.Point(296, 0)
        Me.lblPing.Name = "lblPing"
        Me.lblPing.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.lblPing.Size = New System.Drawing.Size(59, 36)
        Me.lblPing.TabIndex = 2
        Me.lblPing.Text = "0ms"
        Me.lblPing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'secondlast
        '
        Me.secondlast.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.secondlast.Controls.Add(Me.tabGeneral)
        Me.secondlast.Controls.Add(Me.TabPage1)
        Me.secondlast.Controls.Add(Me.tabHelp)
        Me.secondlast.Controls.Add(Me.tabAuth)
        Me.secondlast.Controls.Add(Me.tabLog)
        Me.secondlast.Location = New System.Drawing.Point(3, 60)
        Me.secondlast.Name = "secondlast"
        Me.secondlast.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.secondlast.SelectedIndex = 0
        Me.secondlast.Size = New System.Drawing.Size(934, 386)
        Me.secondlast.TabIndex = 10
        '
        'tabGeneral
        '
        Me.tabGeneral.Controls.Add(Me.lblGeneral)
        Me.tabGeneral.Controls.Add(Me.txtWake)
        Me.tabGeneral.Controls.Add(Me.lblWakeCount)
        Me.tabGeneral.Controls.Add(Me.lblWake)
        Me.tabGeneral.ForeColor = System.Drawing.Color.Black
        Me.tabGeneral.Location = New System.Drawing.Point(4, 26)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(926, 356)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        Me.tabGeneral.UseVisualStyleBackColor = True
        '
        'lblGeneral
        '
        Me.lblGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGeneral.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneral.Location = New System.Drawing.Point(3, 3)
        Me.lblGeneral.Name = "lblGeneral"
        Me.lblGeneral.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblGeneral.Size = New System.Drawing.Size(920, 40)
        Me.lblGeneral.TabIndex = 3
        Me.lblGeneral.Text = "General"
        Me.lblGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtWake
        '
        Me.txtWake.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtWake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWake.ForeColor = System.Drawing.Color.White
        Me.txtWake.Location = New System.Drawing.Point(162, 43)
        Me.txtWake.Name = "txtWake"
        Me.txtWake.Size = New System.Drawing.Size(89, 25)
        Me.txtWake.TabIndex = 1
        Me.txtWake.Text = "/"
        '
        'lblWakeCount
        '
        Me.lblWakeCount.Location = New System.Drawing.Point(257, 43)
        Me.lblWakeCount.Name = "lblWakeCount"
        Me.lblWakeCount.Size = New System.Drawing.Size(150, 25)
        Me.lblWakeCount.TabIndex = 2
        Me.lblWakeCount.Text = "Characters: "
        Me.lblWakeCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWake
        '
        Me.lblWake.Location = New System.Drawing.Point(6, 43)
        Me.lblWake.Name = "lblWake"
        Me.lblWake.Size = New System.Drawing.Size(150, 25)
        Me.lblWake.TabIndex = 0
        Me.lblWake.Text = "Wake key:"
        Me.lblWake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.flowCommand)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(926, 356)
        Me.TabPage1.TabIndex = 11
        Me.TabPage1.Text = "Commands"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'flowCommand
        '
        Me.flowCommand.AutoScroll = True
        Me.flowCommand.Controls.Add(Me.chkDel)
        Me.flowCommand.Controls.Add(Me.chkHelp)
        Me.flowCommand.Controls.Add(Me.chkPing)
        Me.flowCommand.Controls.Add(Me.chkEcho)
        Me.flowCommand.Controls.Add(Me.chkLast)
        Me.flowCommand.Controls.Add(Me.chkStats)
        Me.flowCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowCommand.Location = New System.Drawing.Point(0, 40)
        Me.flowCommand.Name = "flowCommand"
        Me.flowCommand.Size = New System.Drawing.Size(926, 316)
        Me.flowCommand.TabIndex = 5
        '
        'chkDel
        '
        Me.chkDel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDel.Location = New System.Drawing.Point(3, 3)
        Me.chkDel.Name = "chkDel"
        Me.chkDel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDel.Size = New System.Drawing.Size(342, 25)
        Me.chkDel.TabIndex = 2
        Me.chkDel.Text = "Delete command after excecution:"
        Me.chkDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDel.UseVisualStyleBackColor = True
        '
        'chkHelp
        '
        Me.chkHelp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHelp.Checked = True
        Me.chkHelp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHelp.Location = New System.Drawing.Point(351, 3)
        Me.chkHelp.Name = "chkHelp"
        Me.chkHelp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkHelp.Size = New System.Drawing.Size(168, 25)
        Me.chkHelp.TabIndex = 2
        Me.chkHelp.Text = "Help:"
        Me.chkHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHelp.UseVisualStyleBackColor = True
        '
        'chkPing
        '
        Me.chkPing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPing.Checked = True
        Me.chkPing.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPing.Location = New System.Drawing.Point(525, 3)
        Me.chkPing.Name = "chkPing"
        Me.chkPing.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPing.Size = New System.Drawing.Size(168, 25)
        Me.chkPing.TabIndex = 2
        Me.chkPing.Text = "Ping:"
        Me.chkPing.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPing.UseVisualStyleBackColor = True
        '
        'chkEcho
        '
        Me.chkEcho.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEcho.Checked = True
        Me.chkEcho.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEcho.Location = New System.Drawing.Point(699, 3)
        Me.chkEcho.Name = "chkEcho"
        Me.chkEcho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkEcho.Size = New System.Drawing.Size(168, 25)
        Me.chkEcho.TabIndex = 2
        Me.chkEcho.Text = "Echo:"
        Me.chkEcho.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEcho.UseVisualStyleBackColor = True
        '
        'chkLast
        '
        Me.chkLast.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLast.Location = New System.Drawing.Point(3, 34)
        Me.chkLast.Name = "chkLast"
        Me.chkLast.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkLast.Size = New System.Drawing.Size(168, 25)
        Me.chkLast.TabIndex = 2
        Me.chkLast.Text = "Previous:"
        Me.chkLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLast.UseVisualStyleBackColor = True
        '
        'chkStats
        '
        Me.chkStats.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkStats.Location = New System.Drawing.Point(177, 34)
        Me.chkStats.Name = "chkStats"
        Me.chkStats.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkStats.Size = New System.Drawing.Size(168, 25)
        Me.chkStats.TabIndex = 2
        Me.chkStats.Text = "Stats (exparemental):"
        Me.chkStats.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkStats.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(926, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Command toggles"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabHelp
        '
        Me.tabHelp.Controls.Add(Me.TableLayoutPanel1)
        Me.tabHelp.Location = New System.Drawing.Point(4, 26)
        Me.tabHelp.Name = "tabHelp"
        Me.tabHelp.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHelp.Size = New System.Drawing.Size(926, 356)
        Me.tabHelp.TabIndex = 2
        Me.tabHelp.Text = "Help List"
        Me.tabHelp.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.panHelpAdm, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.panHelp, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(920, 350)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'panHelpAdm
        '
        Me.panHelpAdm.Controls.Add(Me.txtHelpAdmin)
        Me.panHelpAdm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panHelpAdm.Location = New System.Drawing.Point(3, 236)
        Me.panHelpAdm.Name = "panHelpAdm"
        Me.panHelpAdm.Padding = New System.Windows.Forms.Padding(10)
        Me.panHelpAdm.Size = New System.Drawing.Size(914, 111)
        Me.panHelpAdm.TabIndex = 2
        '
        'txtHelpAdmin
        '
        Me.txtHelpAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtHelpAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHelpAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtHelpAdmin.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpAdmin.ForeColor = System.Drawing.Color.White
        Me.txtHelpAdmin.Location = New System.Drawing.Point(10, 10)
        Me.txtHelpAdmin.Multiline = True
        Me.txtHelpAdmin.Name = "txtHelpAdmin"
        Me.txtHelpAdmin.Size = New System.Drawing.Size(894, 91)
        Me.txtHelpAdmin.TabIndex = 0
        Me.txtHelpAdmin.Text = resources.GetString("txtHelpAdmin.Text")
        Me.txtHelpAdmin.WordWrap = False
        '
        'panHelp
        '
        Me.panHelp.Controls.Add(Me.txtHelp)
        Me.panHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panHelp.Location = New System.Drawing.Point(3, 3)
        Me.panHelp.Name = "panHelp"
        Me.panHelp.Padding = New System.Windows.Forms.Padding(10)
        Me.panHelp.Size = New System.Drawing.Size(914, 227)
        Me.panHelp.TabIndex = 1
        '
        'txtHelp
        '
        Me.txtHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtHelp.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelp.ForeColor = System.Drawing.Color.White
        Me.txtHelp.Location = New System.Drawing.Point(10, 10)
        Me.txtHelp.Multiline = True
        Me.txtHelp.Name = "txtHelp"
        Me.txtHelp.Size = New System.Drawing.Size(894, 207)
        Me.txtHelp.TabIndex = 0
        Me.txtHelp.Text = resources.GetString("txtHelp.Text")
        Me.txtHelp.WordWrap = False
        '
        'tabAuth
        '
        Me.tabAuth.Controls.Add(Me.btnAdd)
        Me.tabAuth.ForeColor = System.Drawing.Color.Black
        Me.tabAuth.Location = New System.Drawing.Point(4, 26)
        Me.tabAuth.Name = "tabAuth"
        Me.tabAuth.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAuth.Size = New System.Drawing.Size(926, 356)
        Me.tabAuth.TabIndex = 10
        Me.tabAuth.Text = "Add bot to Discord"
        Me.tabAuth.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(233, 90)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(465, 180)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add to Discord"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tabLog
        '
        Me.tabLog.Controls.Add(Me.log)
        Me.tabLog.Location = New System.Drawing.Point(4, 26)
        Me.tabLog.Name = "tabLog"
        Me.tabLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLog.Size = New System.Drawing.Size(926, 356)
        Me.tabLog.TabIndex = 1
        Me.tabLog.Text = "Log"
        Me.tabLog.UseVisualStyleBackColor = True
        '
        'log
        '
        Me.log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.log.FormattingEnabled = True
        Me.log.ItemHeight = 17
        Me.log.Location = New System.Drawing.Point(3, 3)
        Me.log.Name = "log"
        Me.log.Size = New System.Drawing.Size(920, 350)
        Me.log.TabIndex = 0
        '
        'Check
        '
        Me.Check.Enabled = True
        Me.Check.Interval = 500
        '
        'Reloader
        '
        Me.Reloader.Enabled = True
        Me.Reloader.Interval = 1000
        '
        'Ping
        '
        Me.Ping.Enabled = True
        Me.Ping.Interval = 10000
        '
        'chkRemote
        '
        Me.chkRemote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkRemote.AutoSize = True
        Me.chkRemote.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRemote.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.chkRemote.Location = New System.Drawing.Point(617, 7)
        Me.chkRemote.Name = "chkRemote"
        Me.chkRemote.Size = New System.Drawing.Size(167, 32)
        Me.chkRemote.TabIndex = 4
        Me.chkRemote.Text = "Remote Admin"
        Me.chkRemote.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(940, 501)
        Me.Controls.Add(Me.tblMain)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(624, 540)
        Me.Name = "main"
        Me.Text = "Serverhost"
        Me.tblMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tblTop.ResumeLayout(False)
        Me.flowTopLeft.ResumeLayout(False)
        Me.flowTopLeft.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flowTopRight.ResumeLayout(False)
        Me.flowTopRight.PerformLayout()
        Me.secondlast.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.flowCommand.ResumeLayout(False)
        Me.tabHelp.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.panHelpAdm.ResumeLayout(False)
        Me.panHelpAdm.PerformLayout()
        Me.panHelp.ResumeLayout(False)
        Me.panHelp.PerformLayout()
        Me.tabAuth.ResumeLayout(False)
        Me.tabLog.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblMain As TableLayoutPanel
    Friend WithEvents btnCon As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents Check As Timer
    Friend WithEvents tblTop As TableLayoutPanel
    Friend WithEvents flowTopLeft As FlowLayoutPanel
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents lblUname As Label
    Friend WithEvents picBot As PictureBox
    Friend WithEvents flowTopRight As FlowLayoutPanel
    Friend WithEvents lblPing As Label
    Friend WithEvents secondlast As TabControl
    Friend WithEvents tabGeneral As TabPage
    Friend WithEvents txtWake As TextBox
    Friend WithEvents lblWakeCount As Label
    Friend WithEvents lblWake As Label
    Friend WithEvents tabLog As TabPage
    Friend WithEvents log As ListBox
    Friend WithEvents tabAuth As TabPage
    Friend WithEvents btnAdd As Button
    Friend WithEvents tabHelp As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents panHelp As Panel
    Friend WithEvents txtHelp As TextBox
    Friend WithEvents panHelpAdm As Panel
    Friend WithEvents txtHelpAdmin As TextBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents chkHelp As CheckBox
    Friend WithEvents lblGeneral As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Reloader As Timer
    Friend WithEvents chkDel As CheckBox
    Friend WithEvents Ping As Timer
    Friend WithEvents panPing As Panel
    Friend WithEvents chkPing As CheckBox
    Friend WithEvents flowCommand As FlowLayoutPanel
    Friend WithEvents chkEcho As CheckBox
    Friend WithEvents chkLast As CheckBox
    Friend WithEvents chkStats As CheckBox
    Friend WithEvents chkRemote As CheckBox
End Class
