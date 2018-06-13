Option Explicit On 

Public Class frmCAC
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtExCash As System.Windows.Forms.TextBox
    Friend WithEvents txtTotCash As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnCLOSE As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtePeriod As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbTransType As System.Windows.Forms.ComboBox
    Friend WithEvents txtTellerID As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeTo As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtAmtLeft As System.Windows.Forms.TextBox
    Friend WithEvents txtExcessCheque As System.Windows.Forms.TextBox
    Friend WithEvents txtTotCheque As System.Windows.Forms.TextBox
    Friend WithEvents txtGrandTot As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents statCACBar As System.Windows.Forms.StatusBar
    Friend WithEvents statPanelUser As System.Windows.Forms.StatusBarPanel
    Friend WithEvents statPanelDate As System.Windows.Forms.StatusBarPanel
    Friend WithEvents statPanelTime As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txt1000 As System.Windows.Forms.TextBox
    Friend WithEvents txt500 As System.Windows.Forms.TextBox
    Friend WithEvents txt200 As System.Windows.Forms.TextBox
    Friend WithEvents txt100 As System.Windows.Forms.TextBox
    Friend WithEvents txt50 As System.Windows.Forms.TextBox
    Friend WithEvents txt20 As System.Windows.Forms.TextBox
    Friend WithEvents txt10 As System.Windows.Forms.TextBox
    Friend WithEvents txt5 As System.Windows.Forms.TextBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt010 As System.Windows.Forms.TextBox
    Friend WithEvents txt005 As System.Windows.Forms.TextBox
    Friend WithEvents txt001 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtTot1000 As System.Windows.Forms.TextBox
    Friend WithEvents txtTot500 As System.Windows.Forms.TextBox
    Friend WithEvents txtTot200 As System.Windows.Forms.TextBox
    Friend WithEvents txtTot100 As System.Windows.Forms.TextBox
    Friend WithEvents txtTot50 As System.Windows.Forms.TextBox
    Friend WithEvents txtTot20 As System.Windows.Forms.TextBox
    Friend WithEvents txtTot10 As System.Windows.Forms.TextBox
    Friend WithEvents txtTot5 As System.Windows.Forms.TextBox
    Friend WithEvents txtTot1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTot025 As System.Windows.Forms.TextBox
    Friend WithEvents txtTot010 As System.Windows.Forms.TextBox
    Friend WithEvents txtTot005 As System.Windows.Forms.TextBox
    Friend WithEvents txtTot001 As System.Windows.Forms.TextBox
    Friend WithEvents txt025 As System.Windows.Forms.TextBox
    Friend WithEvents gbCriteria As System.Windows.Forms.GroupBox
    Friend WithEvents gbCash As System.Windows.Forms.GroupBox
    Friend WithEvents gbCheque As System.Windows.Forms.GroupBox
    Friend WithEvents gbControl As System.Windows.Forms.GroupBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents dgChequeStat As System.Windows.Forms.DataGrid
    Friend WithEvents dgChequeDetails As System.Windows.Forms.DataGrid
    Friend WithEvents lblBatch As System.Windows.Forms.Label
    Friend WithEvents lstTimeRange As System.Windows.Forms.ListBox
    Friend WithEvents lblTimeTo As System.Windows.Forms.Label
    Friend WithEvents lblTimeFrom As System.Windows.Forms.Label
    Friend WithEvents lblTimeRange As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents gbHeader As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtComp As ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCAC))
        Me.gbCriteria = New System.Windows.Forms.GroupBox()
        Me.txtComp = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lstTimeRange = New System.Windows.Forms.ListBox()
        Me.lblBatch = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbTransType = New System.Windows.Forms.ComboBox()
        Me.txtTellerID = New System.Windows.Forms.TextBox()
        Me.txtTimeTo = New System.Windows.Forms.TextBox()
        Me.txtTimeFrom = New System.Windows.Forms.TextBox()
        Me.lblTimeTo = New System.Windows.Forms.Label()
        Me.lblTimeFrom = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtePeriod = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTimeRange = New System.Windows.Forms.Label()
        Me.gbCash = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txt001 = New System.Windows.Forms.TextBox()
        Me.txt005 = New System.Windows.Forms.TextBox()
        Me.txt010 = New System.Windows.Forms.TextBox()
        Me.txt025 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.txt10 = New System.Windows.Forms.TextBox()
        Me.txt20 = New System.Windows.Forms.TextBox()
        Me.txt50 = New System.Windows.Forms.TextBox()
        Me.txt100 = New System.Windows.Forms.TextBox()
        Me.txt200 = New System.Windows.Forms.TextBox()
        Me.txt500 = New System.Windows.Forms.TextBox()
        Me.txt1000 = New System.Windows.Forms.TextBox()
        Me.txtTot001 = New System.Windows.Forms.TextBox()
        Me.txtTot005 = New System.Windows.Forms.TextBox()
        Me.txtTot010 = New System.Windows.Forms.TextBox()
        Me.txtTot025 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtTot1 = New System.Windows.Forms.TextBox()
        Me.txtTot5 = New System.Windows.Forms.TextBox()
        Me.txtTot10 = New System.Windows.Forms.TextBox()
        Me.txtTot20 = New System.Windows.Forms.TextBox()
        Me.txtTot50 = New System.Windows.Forms.TextBox()
        Me.txtTot100 = New System.Windows.Forms.TextBox()
        Me.txtTot200 = New System.Windows.Forms.TextBox()
        Me.txtTot500 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTot1000 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAmtLeft = New System.Windows.Forms.TextBox()
        Me.txtTotCash = New System.Windows.Forms.TextBox()
        Me.txtExCash = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbCheque = New System.Windows.Forms.GroupBox()
        Me.txtExcessCheque = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotCheque = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgChequeStat = New System.Windows.Forms.DataGrid()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgChequeDetails = New System.Windows.Forms.DataGrid()
        Me.gbControl = New System.Windows.Forms.GroupBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtGrandTot = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCLOSE = New System.Windows.Forms.Button()
        Me.statCACBar = New System.Windows.Forms.StatusBar()
        Me.statPanelUser = New System.Windows.Forms.StatusBarPanel()
        Me.statPanelDate = New System.Windows.Forms.StatusBarPanel()
        Me.statPanelTime = New System.Windows.Forms.StatusBarPanel()
        Me.lblID = New System.Windows.Forms.Label()
        Me.gbHeader = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbCriteria.SuspendLayout()
        Me.gbCash.SuspendLayout()
        Me.gbCheque.SuspendLayout()
        CType(Me.dgChequeStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgChequeDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbControl.SuspendLayout()
        CType(Me.statPanelUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statPanelDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statPanelTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbCriteria
        '
        Me.gbCriteria.Controls.Add(Me.txtComp)
        Me.gbCriteria.Controls.Add(Me.Label12)
        Me.gbCriteria.Controls.Add(Me.lstTimeRange)
        Me.gbCriteria.Controls.Add(Me.lblBatch)
        Me.gbCriteria.Controls.Add(Me.Label19)
        Me.gbCriteria.Controls.Add(Me.Label18)
        Me.gbCriteria.Controls.Add(Me.cmbTransType)
        Me.gbCriteria.Controls.Add(Me.txtTellerID)
        Me.gbCriteria.Controls.Add(Me.txtTimeTo)
        Me.gbCriteria.Controls.Add(Me.txtTimeFrom)
        Me.gbCriteria.Controls.Add(Me.lblTimeTo)
        Me.gbCriteria.Controls.Add(Me.lblTimeFrom)
        Me.gbCriteria.Controls.Add(Me.Label15)
        Me.gbCriteria.Controls.Add(Me.dtePeriod)
        Me.gbCriteria.Controls.Add(Me.Label14)
        Me.gbCriteria.Controls.Add(Me.Label13)
        Me.gbCriteria.Controls.Add(Me.lblTimeRange)
        resources.ApplyResources(Me.gbCriteria, "gbCriteria")
        Me.gbCriteria.Name = "gbCriteria"
        Me.gbCriteria.TabStop = False
        '
        'txtComp
        '
        resources.ApplyResources(Me.txtComp, "txtComp")
        Me.txtComp.Items.AddRange(New Object() {resources.GetString("txtComp.Items"), resources.GetString("txtComp.Items1"), resources.GetString("txtComp.Items2")})
        Me.txtComp.Name = "txtComp"
        Me.txtComp.TabStop = False
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.ForeColor = System.Drawing.SystemColors.Info
        Me.Label12.Name = "Label12"
        '
        'lstTimeRange
        '
        resources.ApplyResources(Me.lstTimeRange, "lstTimeRange")
        Me.lstTimeRange.Name = "lstTimeRange"
        Me.lstTimeRange.TabStop = False
        '
        'lblBatch
        '
        resources.ApplyResources(Me.lblBatch, "lblBatch")
        Me.lblBatch.ForeColor = System.Drawing.SystemColors.Info
        Me.lblBatch.Name = "lblBatch"
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.ForeColor = System.Drawing.SystemColors.Info
        Me.Label19.Name = "Label19"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.ForeColor = System.Drawing.SystemColors.Info
        Me.Label18.Name = "Label18"
        '
        'cmbTransType
        '
        resources.ApplyResources(Me.cmbTransType, "cmbTransType")
        Me.cmbTransType.Items.AddRange(New Object() {resources.GetString("cmbTransType.Items"), resources.GetString("cmbTransType.Items1"), resources.GetString("cmbTransType.Items2"), resources.GetString("cmbTransType.Items3"), resources.GetString("cmbTransType.Items4")})
        Me.cmbTransType.Name = "cmbTransType"
        Me.cmbTransType.TabStop = False
        '
        'txtTellerID
        '
        Me.txtTellerID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtTellerID, "txtTellerID")
        Me.txtTellerID.Name = "txtTellerID"
        Me.txtTellerID.TabStop = False
        '
        'txtTimeTo
        '
        resources.ApplyResources(Me.txtTimeTo, "txtTimeTo")
        Me.txtTimeTo.Name = "txtTimeTo"
        Me.txtTimeTo.TabStop = False
        '
        'txtTimeFrom
        '
        resources.ApplyResources(Me.txtTimeFrom, "txtTimeFrom")
        Me.txtTimeFrom.Name = "txtTimeFrom"
        Me.txtTimeFrom.TabStop = False
        '
        'lblTimeTo
        '
        resources.ApplyResources(Me.lblTimeTo, "lblTimeTo")
        Me.lblTimeTo.ForeColor = System.Drawing.SystemColors.Info
        Me.lblTimeTo.Name = "lblTimeTo"
        '
        'lblTimeFrom
        '
        resources.ApplyResources(Me.lblTimeFrom, "lblTimeFrom")
        Me.lblTimeFrom.ForeColor = System.Drawing.SystemColors.Info
        Me.lblTimeFrom.Name = "lblTimeFrom"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.ForeColor = System.Drawing.SystemColors.Info
        Me.Label15.Name = "Label15"
        '
        'dtePeriod
        '
        Me.dtePeriod.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        resources.ApplyResources(Me.dtePeriod, "dtePeriod")
        Me.dtePeriod.CalendarMonthBackground = System.Drawing.Color.LightSteelBlue
        Me.dtePeriod.CalendarTitleBackColor = System.Drawing.Color.SteelBlue
        Me.dtePeriod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtePeriod.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtePeriod.Name = "dtePeriod"
        Me.dtePeriod.TabStop = False
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.ForeColor = System.Drawing.SystemColors.Info
        Me.Label14.Name = "Label14"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.ForeColor = System.Drawing.SystemColors.Info
        Me.Label13.Name = "Label13"
        '
        'lblTimeRange
        '
        resources.ApplyResources(Me.lblTimeRange, "lblTimeRange")
        Me.lblTimeRange.ForeColor = System.Drawing.SystemColors.Info
        Me.lblTimeRange.Name = "lblTimeRange"
        '
        'gbCash
        '
        Me.gbCash.Controls.Add(Me.Label35)
        Me.gbCash.Controls.Add(Me.Label34)
        Me.gbCash.Controls.Add(Me.txt001)
        Me.gbCash.Controls.Add(Me.txt005)
        Me.gbCash.Controls.Add(Me.txt010)
        Me.gbCash.Controls.Add(Me.txt025)
        Me.gbCash.Controls.Add(Me.txt1)
        Me.gbCash.Controls.Add(Me.txt5)
        Me.gbCash.Controls.Add(Me.txt10)
        Me.gbCash.Controls.Add(Me.txt20)
        Me.gbCash.Controls.Add(Me.txt50)
        Me.gbCash.Controls.Add(Me.txt100)
        Me.gbCash.Controls.Add(Me.txt200)
        Me.gbCash.Controls.Add(Me.txt500)
        Me.gbCash.Controls.Add(Me.txt1000)
        Me.gbCash.Controls.Add(Me.txtTot001)
        Me.gbCash.Controls.Add(Me.txtTot005)
        Me.gbCash.Controls.Add(Me.txtTot010)
        Me.gbCash.Controls.Add(Me.txtTot025)
        Me.gbCash.Controls.Add(Me.Label33)
        Me.gbCash.Controls.Add(Me.Label32)
        Me.gbCash.Controls.Add(Me.Label31)
        Me.gbCash.Controls.Add(Me.Label30)
        Me.gbCash.Controls.Add(Me.Label29)
        Me.gbCash.Controls.Add(Me.Label28)
        Me.gbCash.Controls.Add(Me.Label27)
        Me.gbCash.Controls.Add(Me.Label26)
        Me.gbCash.Controls.Add(Me.Label25)
        Me.gbCash.Controls.Add(Me.Label24)
        Me.gbCash.Controls.Add(Me.Label23)
        Me.gbCash.Controls.Add(Me.txtTot1)
        Me.gbCash.Controls.Add(Me.txtTot5)
        Me.gbCash.Controls.Add(Me.txtTot10)
        Me.gbCash.Controls.Add(Me.txtTot20)
        Me.gbCash.Controls.Add(Me.txtTot50)
        Me.gbCash.Controls.Add(Me.txtTot100)
        Me.gbCash.Controls.Add(Me.txtTot200)
        Me.gbCash.Controls.Add(Me.txtTot500)
        Me.gbCash.Controls.Add(Me.Label22)
        Me.gbCash.Controls.Add(Me.txtTot1000)
        Me.gbCash.Controls.Add(Me.Label21)
        Me.gbCash.Controls.Add(Me.Label20)
        Me.gbCash.Controls.Add(Me.Label10)
        Me.gbCash.Controls.Add(Me.txtAmtLeft)
        Me.gbCash.Controls.Add(Me.txtTotCash)
        Me.gbCash.Controls.Add(Me.txtExCash)
        Me.gbCash.Controls.Add(Me.Label3)
        Me.gbCash.Controls.Add(Me.Label2)
        Me.gbCash.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.gbCash, "gbCash")
        Me.gbCash.Name = "gbCash"
        Me.gbCash.TabStop = False
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label35, "Label35")
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label35.Name = "Label35"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label34, "Label34")
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label34.Name = "Label34"
        '
        'txt001
        '
        Me.txt001.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txt001, "txt001")
        Me.txt001.Name = "txt001"
        Me.txt001.TabStop = False
        '
        'txt005
        '
        Me.txt005.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txt005, "txt005")
        Me.txt005.Name = "txt005"
        Me.txt005.TabStop = False
        '
        'txt010
        '
        Me.txt010.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txt010, "txt010")
        Me.txt010.Name = "txt010"
        Me.txt010.TabStop = False
        '
        'txt025
        '
        Me.txt025.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txt025, "txt025")
        Me.txt025.Name = "txt025"
        Me.txt025.TabStop = False
        '
        'txt1
        '
        Me.txt1.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txt1, "txt1")
        Me.txt1.Name = "txt1"
        Me.txt1.TabStop = False
        '
        'txt5
        '
        Me.txt5.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txt5, "txt5")
        Me.txt5.Name = "txt5"
        Me.txt5.TabStop = False
        '
        'txt10
        '
        Me.txt10.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txt10, "txt10")
        Me.txt10.Name = "txt10"
        Me.txt10.TabStop = False
        '
        'txt20
        '
        Me.txt20.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txt20, "txt20")
        Me.txt20.Name = "txt20"
        Me.txt20.TabStop = False
        '
        'txt50
        '
        Me.txt50.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txt50, "txt50")
        Me.txt50.Name = "txt50"
        Me.txt50.TabStop = False
        '
        'txt100
        '
        Me.txt100.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txt100, "txt100")
        Me.txt100.Name = "txt100"
        Me.txt100.TabStop = False
        '
        'txt200
        '
        Me.txt200.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txt200, "txt200")
        Me.txt200.Name = "txt200"
        Me.txt200.TabStop = False
        '
        'txt500
        '
        Me.txt500.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txt500, "txt500")
        Me.txt500.Name = "txt500"
        Me.txt500.TabStop = False
        '
        'txt1000
        '
        Me.txt1000.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txt1000, "txt1000")
        Me.txt1000.Name = "txt1000"
        Me.txt1000.TabStop = False
        '
        'txtTot001
        '
        Me.txtTot001.BackColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.txtTot001, "txtTot001")
        Me.txtTot001.Name = "txtTot001"
        Me.txtTot001.ReadOnly = True
        Me.txtTot001.TabStop = False
        '
        'txtTot005
        '
        Me.txtTot005.BackColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.txtTot005, "txtTot005")
        Me.txtTot005.Name = "txtTot005"
        Me.txtTot005.ReadOnly = True
        Me.txtTot005.TabStop = False
        '
        'txtTot010
        '
        Me.txtTot010.BackColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.txtTot010, "txtTot010")
        Me.txtTot010.Name = "txtTot010"
        Me.txtTot010.ReadOnly = True
        Me.txtTot010.TabStop = False
        '
        'txtTot025
        '
        Me.txtTot025.BackColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.txtTot025, "txtTot025")
        Me.txtTot025.Name = "txtTot025"
        Me.txtTot025.ReadOnly = True
        Me.txtTot025.TabStop = False
        '
        'Label33
        '
        resources.ApplyResources(Me.Label33, "Label33")
        Me.Label33.ForeColor = System.Drawing.SystemColors.Info
        Me.Label33.Name = "Label33"
        '
        'Label32
        '
        resources.ApplyResources(Me.Label32, "Label32")
        Me.Label32.ForeColor = System.Drawing.SystemColors.Info
        Me.Label32.Name = "Label32"
        '
        'Label31
        '
        resources.ApplyResources(Me.Label31, "Label31")
        Me.Label31.ForeColor = System.Drawing.SystemColors.Info
        Me.Label31.Name = "Label31"
        '
        'Label30
        '
        resources.ApplyResources(Me.Label30, "Label30")
        Me.Label30.ForeColor = System.Drawing.SystemColors.Info
        Me.Label30.Name = "Label30"
        '
        'Label29
        '
        resources.ApplyResources(Me.Label29, "Label29")
        Me.Label29.ForeColor = System.Drawing.SystemColors.Info
        Me.Label29.Name = "Label29"
        '
        'Label28
        '
        resources.ApplyResources(Me.Label28, "Label28")
        Me.Label28.ForeColor = System.Drawing.SystemColors.Info
        Me.Label28.Name = "Label28"
        '
        'Label27
        '
        resources.ApplyResources(Me.Label27, "Label27")
        Me.Label27.ForeColor = System.Drawing.SystemColors.Info
        Me.Label27.Name = "Label27"
        '
        'Label26
        '
        resources.ApplyResources(Me.Label26, "Label26")
        Me.Label26.ForeColor = System.Drawing.SystemColors.Info
        Me.Label26.Name = "Label26"
        '
        'Label25
        '
        resources.ApplyResources(Me.Label25, "Label25")
        Me.Label25.ForeColor = System.Drawing.SystemColors.Info
        Me.Label25.Name = "Label25"
        '
        'Label24
        '
        resources.ApplyResources(Me.Label24, "Label24")
        Me.Label24.ForeColor = System.Drawing.SystemColors.Info
        Me.Label24.Name = "Label24"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.LightSlateGray
        resources.ApplyResources(Me.Label23, "Label23")
        Me.Label23.ForeColor = System.Drawing.SystemColors.Info
        Me.Label23.Name = "Label23"
        '
        'txtTot1
        '
        Me.txtTot1.BackColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.txtTot1, "txtTot1")
        Me.txtTot1.Name = "txtTot1"
        Me.txtTot1.ReadOnly = True
        Me.txtTot1.TabStop = False
        '
        'txtTot5
        '
        Me.txtTot5.BackColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.txtTot5, "txtTot5")
        Me.txtTot5.Name = "txtTot5"
        Me.txtTot5.ReadOnly = True
        Me.txtTot5.TabStop = False
        '
        'txtTot10
        '
        Me.txtTot10.BackColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.txtTot10, "txtTot10")
        Me.txtTot10.Name = "txtTot10"
        Me.txtTot10.ReadOnly = True
        Me.txtTot10.TabStop = False
        '
        'txtTot20
        '
        Me.txtTot20.BackColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.txtTot20, "txtTot20")
        Me.txtTot20.Name = "txtTot20"
        Me.txtTot20.ReadOnly = True
        Me.txtTot20.TabStop = False
        '
        'txtTot50
        '
        Me.txtTot50.BackColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.txtTot50, "txtTot50")
        Me.txtTot50.Name = "txtTot50"
        Me.txtTot50.ReadOnly = True
        Me.txtTot50.TabStop = False
        '
        'txtTot100
        '
        Me.txtTot100.BackColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.txtTot100, "txtTot100")
        Me.txtTot100.Name = "txtTot100"
        Me.txtTot100.ReadOnly = True
        Me.txtTot100.TabStop = False
        '
        'txtTot200
        '
        Me.txtTot200.BackColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.txtTot200, "txtTot200")
        Me.txtTot200.Name = "txtTot200"
        Me.txtTot200.ReadOnly = True
        Me.txtTot200.TabStop = False
        '
        'txtTot500
        '
        Me.txtTot500.BackColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.txtTot500, "txtTot500")
        Me.txtTot500.Name = "txtTot500"
        Me.txtTot500.ReadOnly = True
        Me.txtTot500.TabStop = False
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.ForeColor = System.Drawing.SystemColors.Info
        Me.Label22.Name = "Label22"
        '
        'txtTot1000
        '
        Me.txtTot1000.BackColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.txtTot1000, "txtTot1000")
        Me.txtTot1000.Name = "txtTot1000"
        Me.txtTot1000.ReadOnly = True
        Me.txtTot1000.TabStop = False
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label21, "Label21")
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Name = "Label21"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.ForeColor = System.Drawing.SystemColors.Info
        Me.Label20.Name = "Label20"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.SystemColors.Info
        Me.Label10.Name = "Label10"
        '
        'txtAmtLeft
        '
        Me.txtAmtLeft.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.txtAmtLeft, "txtAmtLeft")
        Me.txtAmtLeft.Name = "txtAmtLeft"
        Me.txtAmtLeft.ReadOnly = True
        Me.txtAmtLeft.TabStop = False
        '
        'txtTotCash
        '
        Me.txtTotCash.BackColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.txtTotCash, "txtTotCash")
        Me.txtTotCash.Name = "txtTotCash"
        Me.txtTotCash.ReadOnly = True
        Me.txtTotCash.TabStop = False
        '
        'txtExCash
        '
        Me.txtExCash.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.txtExCash, "txtExCash")
        Me.txtExCash.Name = "txtExCash"
        Me.txtExCash.ReadOnly = True
        Me.txtExCash.TabStop = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.SystemColors.Info
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.SystemColors.Info
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Name = "Label1"
        '
        'gbCheque
        '
        Me.gbCheque.Controls.Add(Me.txtExcessCheque)
        Me.gbCheque.Controls.Add(Me.Label9)
        Me.gbCheque.Controls.Add(Me.txtTotCheque)
        Me.gbCheque.Controls.Add(Me.Label8)
        Me.gbCheque.Controls.Add(Me.Label6)
        Me.gbCheque.Controls.Add(Me.dgChequeStat)
        Me.gbCheque.Controls.Add(Me.Label5)
        Me.gbCheque.Controls.Add(Me.Label4)
        Me.gbCheque.Controls.Add(Me.dgChequeDetails)
        resources.ApplyResources(Me.gbCheque, "gbCheque")
        Me.gbCheque.Name = "gbCheque"
        Me.gbCheque.TabStop = False
        '
        'txtExcessCheque
        '
        Me.txtExcessCheque.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.txtExcessCheque, "txtExcessCheque")
        Me.txtExcessCheque.Name = "txtExcessCheque"
        Me.txtExcessCheque.ReadOnly = True
        Me.txtExcessCheque.TabStop = False
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.SystemColors.Info
        Me.Label9.Name = "Label9"
        '
        'txtTotCheque
        '
        Me.txtTotCheque.BackColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.txtTotCheque, "txtTotCheque")
        Me.txtTotCheque.Name = "txtTotCheque"
        Me.txtTotCheque.ReadOnly = True
        Me.txtTotCheque.TabStop = False
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.SystemColors.Info
        Me.Label8.Name = "Label8"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.SystemColors.Info
        Me.Label6.Name = "Label6"
        '
        'dgChequeStat
        '
        Me.dgChequeStat.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgChequeStat.BackColor = System.Drawing.Color.Gainsboro
        Me.dgChequeStat.BackgroundColor = System.Drawing.Color.Silver
        Me.dgChequeStat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgChequeStat.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgChequeStat.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgChequeStat.DataMember = ""
        Me.dgChequeStat.FlatMode = True
        resources.ApplyResources(Me.dgChequeStat, "dgChequeStat")
        Me.dgChequeStat.ForeColor = System.Drawing.Color.Black
        Me.dgChequeStat.GridLineColor = System.Drawing.Color.DimGray
        Me.dgChequeStat.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgChequeStat.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgChequeStat.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgChequeStat.HeaderForeColor = System.Drawing.Color.White
        Me.dgChequeStat.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgChequeStat.Name = "dgChequeStat"
        Me.dgChequeStat.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgChequeStat.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgChequeStat.ReadOnly = True
        Me.dgChequeStat.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgChequeStat.SelectionForeColor = System.Drawing.Color.White
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.SystemColors.Info
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Name = "Label4"
        '
        'dgChequeDetails
        '
        Me.dgChequeDetails.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgChequeDetails.BackColor = System.Drawing.Color.White
        Me.dgChequeDetails.BackgroundColor = System.Drawing.Color.Silver
        Me.dgChequeDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgChequeDetails.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgChequeDetails.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgChequeDetails.DataMember = ""
        Me.dgChequeDetails.FlatMode = True
        resources.ApplyResources(Me.dgChequeDetails, "dgChequeDetails")
        Me.dgChequeDetails.ForeColor = System.Drawing.Color.Black
        Me.dgChequeDetails.GridLineColor = System.Drawing.Color.DimGray
        Me.dgChequeDetails.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgChequeDetails.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgChequeDetails.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgChequeDetails.HeaderForeColor = System.Drawing.Color.White
        Me.dgChequeDetails.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgChequeDetails.Name = "dgChequeDetails"
        Me.dgChequeDetails.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgChequeDetails.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgChequeDetails.PreferredColumnWidth = 100
        Me.dgChequeDetails.ReadOnly = True
        Me.dgChequeDetails.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgChequeDetails.SelectionForeColor = System.Drawing.Color.White
        '
        'gbControl
        '
        Me.gbControl.Controls.Add(Me.Label36)
        Me.gbControl.Controls.Add(Me.txtGrandTot)
        Me.gbControl.Controls.Add(Me.Label11)
        Me.gbControl.Controls.Add(Me.txtRemarks)
        Me.gbControl.Controls.Add(Me.btnNew)
        Me.gbControl.Controls.Add(Me.btnSave)
        Me.gbControl.Controls.Add(Me.btnPrint)
        Me.gbControl.Controls.Add(Me.btnCLOSE)
        resources.ApplyResources(Me.gbControl, "gbControl")
        Me.gbControl.Name = "gbControl"
        Me.gbControl.TabStop = False
        '
        'Label36
        '
        resources.ApplyResources(Me.Label36, "Label36")
        Me.Label36.ForeColor = System.Drawing.SystemColors.Info
        Me.Label36.Name = "Label36"
        '
        'txtGrandTot
        '
        Me.txtGrandTot.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.txtGrandTot, "txtGrandTot")
        Me.txtGrandTot.Name = "txtGrandTot"
        Me.txtGrandTot.ReadOnly = True
        Me.txtGrandTot.TabStop = False
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.SystemColors.Info
        Me.Label11.Name = "Label11"
        '
        'txtRemarks
        '
        resources.ApplyResources(Me.txtRemarks, "txtRemarks")
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.TabStop = False
        '
        'btnNew
        '
        resources.ApplyResources(Me.btnNew, "btnNew")
        Me.btnNew.Name = "btnNew"
        '
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.Name = "btnSave"
        '
        'btnPrint
        '
        resources.ApplyResources(Me.btnPrint, "btnPrint")
        Me.btnPrint.Name = "btnPrint"
        '
        'btnCLOSE
        '
        resources.ApplyResources(Me.btnCLOSE, "btnCLOSE")
        Me.btnCLOSE.Name = "btnCLOSE"
        '
        'statCACBar
        '
        resources.ApplyResources(Me.statCACBar, "statCACBar")
        Me.statCACBar.Name = "statCACBar"
        Me.statCACBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.statPanelUser, Me.statPanelDate, Me.statPanelTime})
        Me.statCACBar.ShowPanels = True
        Me.statCACBar.SizingGrip = False
        '
        'statPanelUser
        '
        resources.ApplyResources(Me.statPanelUser, "statPanelUser")
        '
        'statPanelDate
        '
        resources.ApplyResources(Me.statPanelDate, "statPanelDate")
        '
        'statPanelTime
        '
        resources.ApplyResources(Me.statPanelTime, "statPanelTime")
        '
        'lblID
        '
        resources.ApplyResources(Me.lblID, "lblID")
        Me.lblID.ForeColor = System.Drawing.SystemColors.Info
        Me.lblID.Name = "lblID"
        '
        'gbHeader
        '
        Me.gbHeader.Controls.Add(Me.Label7)
        Me.gbHeader.Controls.Add(Me.PictureBox1)
        resources.ApplyResources(Me.gbHeader, "gbHeader")
        Me.gbHeader.Name = "gbHeader"
        Me.gbHeader.TabStop = False
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label7.Name = "Label7"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'frmCAC
        '
        Me.BackColor = System.Drawing.Color.LightSlateGray
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.gbHeader)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.statCACBar)
        Me.Controls.Add(Me.gbControl)
        Me.Controls.Add(Me.gbCheque)
        Me.Controls.Add(Me.gbCash)
        Me.Controls.Add(Me.gbCriteria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCAC"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.gbCriteria.ResumeLayout(False)
        Me.gbCriteria.PerformLayout()
        Me.gbCash.ResumeLayout(False)
        Me.gbCash.PerformLayout()
        Me.gbCheque.ResumeLayout(False)
        Me.gbCheque.PerformLayout()
        CType(Me.dgChequeStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgChequeDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbControl.ResumeLayout(False)
        Me.gbControl.PerformLayout()
        CType(Me.statPanelUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statPanelDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statPanelTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbHeader.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dtabCash As New DataTable
    Private CallClsCAC As New clsCAC
    Private ValDis As Boolean
    Private ts As DataGridTableStyle
    Private decGrCshAmt As Decimal = 0
    Private decGrChgAmt As Decimal = 0
    Private decExCheque As Decimal = 0
    Private decAmCheque As Decimal = 0
    Private decGrandTotal As Decimal = 0


    Private Sub frmCAC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetStatusBar()
        txtTellerID.Text = zCurrentUser()
        cmbTransType.SelectedItem = "All Transaction"
        txtComp.SelectedItem = "ALL"
        cmbTransType.Focus()
    End Sub

    Private Sub SetStatusBar()
        statPanelDate.Text = CType(FormatDateTime(Today(), DateFormat.LongDate), String) & " "
        statPanelTime.Text = CType(TimeValue(Now()), String) & " "
        statPanelUser.Text = " User Name : " & UCase(zCurrentUser())
    End Sub

#Region "CASH COLLECTION"

    Private Sub TotalCash()
        Dim decTotCash As Decimal = (CType(txtTot1000.Text, Decimal)) + (CType(txtTot500.Text, Decimal)) + (CType(txtTot200.Text, Decimal)) + (CType(txtTot100.Text, Decimal)) + (CType(txtTot50.Text, Decimal)) + (CType(txtTot20.Text, Decimal)) + (CType(txtTot10.Text, Decimal)) + (CType(txtTot5.Text, Decimal)) + (CType(txtTot1.Text, Decimal)) + (CType(txtTot025.Text, Decimal)) + (CType(txtTot010.Text, Decimal)) + (CType(txtTot005.Text, Decimal)) + (CType(txtTot001.Text, Decimal))
        txtTotCash.Text = FormatNumber(CType(decTotCash, String), 2)
        txtAmtLeft.Text = FormatNumber(CType(((decGrCshAmt - decGrChgAmt) - decTotCash), String), 2)
    End Sub

    Private Sub txt1000_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt1000.LostFocus
        ValDis = CallClsCAC.NumVal(txt1000.Text)
        If ValDis = True Then
            txtTot1000.Text = CType(FormatNumber((CType(txt1000.Text, Decimal) * 1000), 2), String)
            TotalCash()
        Else
            MsgBox("Pls. Input a Numeric Value", MsgBoxStyle.Exclamation, "Invalid")
            txt1000.Text = 0
            txt1000.Focus()
            txtTot1000.Text = "0.00"
        End If
    End Sub

    Private Sub txt500_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt500.LostFocus
        ValDis = CallClsCAC.NumVal(txt500.Text)
        If ValDis = True Then
            txtTot500.Text = CType(FormatNumber((CType(txt500.Text, Decimal) * 500), 2), String)
            TotalCash()
        Else
            MsgBox("Pls. Input a Numeric Value", MsgBoxStyle.Exclamation, "Invalid")
            txt500.Text = 0
            txt500.Focus()
            txtTot500.Text = "0.00"
        End If
    End Sub

    Private Sub txt200_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt200.LostFocus
        ValDis = CallClsCAC.NumVal(txt200.Text)
        If ValDis = True Then
            txtTot200.Text = CType(FormatNumber((CType(txt200.Text, Decimal) * 200), 2), String)
            TotalCash()
        Else
            MsgBox("Pls. Input a Numeric Value", MsgBoxStyle.Exclamation, "Invalid")
            txt200.Text = 0
            txt200.Focus()
            txtTot200.Text = "0.00"
        End If
    End Sub

    Private Sub txt100_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt100.LostFocus
        ValDis = CallClsCAC.NumVal(txt100.Text)
        If ValDis = True Then
            txtTot100.Text = CType(FormatNumber((CType(txt100.Text, Decimal) * 100), 2), String)
            TotalCash()
        Else
            MsgBox("Pls. Input a Numeric Value", MsgBoxStyle.Exclamation, "Invalid")
            txt100.Text = 0
            txt100.Focus()
            txtTot100.Text = "0.00"
        End If
    End Sub

    Private Sub txt50_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt50.LostFocus
        ValDis = CallClsCAC.NumVal(txt50.Text)
        If ValDis = True Then
            txtTot50.Text = CType(FormatNumber((CType(txt50.Text, Decimal) * 50), 2), String)
            TotalCash()
        Else
            MsgBox("Pls. Input a Numeric Value", MsgBoxStyle.Exclamation, "Invalid")
            txt50.Text = 0
            txt50.Focus()
            txtTot50.Text = "0.00"
        End If
    End Sub

    Private Sub txt10_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt10.LostFocus
        ValDis = CallClsCAC.NumVal(txt10.Text)
        If ValDis = True Then
            txtTot10.Text = CType(FormatNumber((CType(txt10.Text, Decimal) * 10), 2), String)
            TotalCash()
        Else
            MsgBox("Pls. Input a Numeric Value", MsgBoxStyle.Exclamation, "Invalid")
            txt10.Text = 0
            txt10.Focus()
            txtTot10.Text = "0.00"
        End If
    End Sub

    Private Sub txt20_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt20.LostFocus
        ValDis = CallClsCAC.NumVal(txt20.Text)
        If ValDis = True Then
            txtTot20.Text = CType(FormatNumber((CType(txt20.Text, Decimal) * 20), 2), String)
            TotalCash()
        Else
            MsgBox("Pls. Input a Numeric Value", MsgBoxStyle.Exclamation, "Invalid")
            txt20.Text = 0
            txt20.Focus()
            txtTot20.Text = "0.00"
        End If
    End Sub

    Private Sub txt5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt5.LostFocus
        ValDis = CallClsCAC.NumVal(txt5.Text)
        If ValDis = True Then
            txtTot5.Text = CType(FormatNumber((CType(txt5.Text, Decimal) * 5), 2), String)
            TotalCash()
        Else
            MsgBox("Pls. Input a Numeric Value", MsgBoxStyle.Exclamation, "Invalid")
            txt5.Text = 0
            txt5.Focus()
            txtTot5.Text = "0.00"
        End If
    End Sub

    Private Sub txt1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt1.LostFocus
        ValDis = CallClsCAC.NumVal(txt1.Text)
        If ValDis = True Then
            txtTot1.Text = CType(FormatNumber((CType(txt1.Text, Decimal) * 1), 2), String)
            TotalCash()
        Else
            MsgBox("Pls. Input a Numeric Value", MsgBoxStyle.Exclamation, "Invalid")
            txt1.Text = 0
            txt1.Focus()
            txtTot1.Text = "0.00"
        End If
    End Sub

    Private Sub txt025_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt025.LostFocus
        ValDis = CallClsCAC.NumVal(txt025.Text)
        If ValDis = True Then
            txtTot025.Text = CType(FormatNumber((CType(txt025.Text, Decimal) * 0.25), 2), String)
            TotalCash()
        Else
            MsgBox("Pls. Input a Numeric Value", MsgBoxStyle.Exclamation, "Invalid")
            txt025.Text = 0
            txt025.Focus()
            txtTot025.Text = "0.00"
        End If
    End Sub

    Private Sub txt010_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt010.LostFocus
        ValDis = CallClsCAC.NumVal(txt010.Text)
        If ValDis = True Then
            txtTot010.Text = CType(FormatNumber((CType(txt010.Text, Decimal) * 0.1), 2), String)
            TotalCash()
        Else
            MsgBox("Pls. Input a Numeric Value", MsgBoxStyle.Exclamation, "Invalid")
            txt010.Text = 0
            txt010.Focus()
            txtTot010.Text = "0.00"
        End If
    End Sub

    Private Sub txt005_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt005.LostFocus
        ValDis = CallClsCAC.NumVal(txt005.Text)
        If ValDis = True Then
            txtTot005.Text = CType(FormatNumber((CType(txt005.Text, Decimal) * 0.05), 2), String)
            TotalCash()
        Else
            MsgBox("Pls. Input a Numeric Value", MsgBoxStyle.Exclamation, "Invalid")
            txt005.Text = 0
            txt005.Focus()
            txtTot005.Text = "0.00"
        End If
    End Sub

    Private Sub txt001_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt001.LostFocus
        ValDis = CallClsCAC.NumVal(txt001.Text)
        If ValDis = True Then
            txtTot001.Text = CType(FormatNumber((CType(txt001.Text, Decimal) * 0.01), 2), String)
            TotalCash()
        Else
            MsgBox("Pls. Input a Numeric Value", MsgBoxStyle.Exclamation, "Invalid")
            txt001.Text = 0
            txt001.Focus()
            txtTot001.Text = "0.00"
        End If
    End Sub

    Private Sub txt1000_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt1000.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            txt500.Focus()
        End If
    End Sub

    Private Sub txt20_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt20.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            txt10.Focus()
        End If
    End Sub

    Private Sub txt001_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt001.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            txtRemarks.Focus()
        End If
    End Sub

    Private Sub txt005_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt005.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            txt001.Focus()
        End If
    End Sub

    Private Sub txt010_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt010.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            txt005.Focus()
        End If
    End Sub

    Private Sub txt025_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt025.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            txt010.Focus()
        End If
    End Sub

    Private Sub txt1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt1.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            txt025.Focus()
        End If
    End Sub

    Private Sub txt10_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt10.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            txt5.Focus()
        End If
    End Sub

    Private Sub txt100_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt100.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            txt50.Focus()
        End If
    End Sub

    Private Sub txt200_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt200.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            txt100.Focus()
        End If
    End Sub

    Private Sub txt5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt5.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            txt1.Focus()
        End If
    End Sub

    Private Sub txt50_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt50.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            txt20.Focus()
        End If
    End Sub

    Private Sub txt500_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt500.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            txt200.Focus()
        End If
    End Sub

#End Region

#Region "CRITERIA"

    Private Sub cmbTransType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTransType.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            ValDis = CallClsCAC.StrVal(cmbTransType.Text)
            If ValDis = False Then
                MsgBox("Invalid Transaction Type", MsgBoxStyle.Critical, "Invalid")
                cmbTransType.Focus()
            Else
                txtTellerID.Focus()
            End If
        End If
    End Sub

    Private Sub txtTellerID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTellerID.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            ValDis = CallClsCAC.StrVal(txtTellerID.Text)
            If ValDis = False Then
                MsgBox("Invalid Teller ID", MsgBoxStyle.Critical)
                txtTellerID.Focus()
            Else
                txtComp.Focus()
            End If
        End If
    End Sub

    Private Sub dtePeriod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtePeriod.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            If IsDate(dtePeriod.Text) = False Then
                MsgBox("Invalid Date", MsgBoxStyle.Critical, "Invalid")
                dtePeriod.Focus()
            Else
                CACExisting()
                If dsTurnOverSlip.Tables(0).Rows.Count > 0 Then
                    PopulatelstTimeRange()
                    lblTimeTo.Visible = False
                    lblTimeFrom.Visible = False
                    lblTimeRange.Visible = True
                    lstTimeRange.Visible = True
                    lstTimeRange.Focus()
                Else
                    MsgBox("There are no Time Ranges Saved for this Submission Date.", MsgBoxStyle.Information, "")
                    txtTimeFrom.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txtTimeFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTimeFrom.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            txtTimeTo.Focus()
        End If
    End Sub

    Private Sub txtTimeTo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTimeTo.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            ValDis = CallClsCAC.TimeVal(txtTimeFrom.Text, txtTimeTo.Text)
            If ValDis = True Then
                ValDis = ValgbCriteria()
                If ValDis = True Then
                    If lblBatch.Text <> "" Then
                        Dim strResponse As String
                        strResponse = MsgBox("This particular Time range has already been used by Teller " & UCase(txtTellerID.Text) &
                                             ". If you save this slip, the Data will be overwritten. Proceed Anyway?", MsgBoxStyle.OkCancel, "WARNING")
                        If strResponse = vbOK Then
                            txt1000.Focus()
                            RetrieveData()
                        ElseIf strResponse = vbCancel Then
                            ClearForm()
                        End If
                    Else
                        txt1000.Focus()
                        RetrieveData()
                    End If
                End If
            Else
                MsgBox("Invalid Time Range", MsgBoxStyle.Critical, "Invalid")
                txtTimeFrom.Focus()
                txtTimeFrom.Text = ""
                txtTimeTo.Text = ""
            End If
        End If
    End Sub

    Private Sub lstTimeRange_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstTimeRange.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            If IsNothing(lstTimeRange.SelectedItem) Then
                MsgBox("Invalid Time Range", MsgBoxStyle.Critical, "Invalid")
            Else
                txtTimeFrom.Focus()
                cmbTransType.Enabled = False
                cmbTransType.BackColor = Color.AliceBlue
                txtTellerID.ReadOnly = True
                txtTellerID.BackColor = Color.AliceBlue
                txtComp.Enabled = False
                txtComp.BackColor = Color.AliceBlue
                dtePeriod.Enabled = False
                dtePeriod.BackColor = Color.AliceBlue
                PopulateFields()
                RetrieveData()
                TotalCash()
                txtTimeFrom.ReadOnly = False
                txtTimeFrom.BackColor = Color.White
                txtTimeTo.ReadOnly = False
                txtTimeTo.BackColor = Color.White
            End If
        ElseIf e.KeyCode = 27 Then
            txtTimeFrom.Focus()
            lblTimeTo.Visible = True
            lblTimeFrom.Visible = True
            lblTimeRange.Visible = False
            lstTimeRange.Visible = False
        End If
    End Sub

    Private Function ValgbCriteria() As Boolean
        If cmbTransType.Text <> "" And txtTellerID.Text <> "" And IsDate(dtePeriod.Text) = True Then
            Return True
        Else
            MsgBox("Pls. Complete the Required Fields.", MsgBoxStyle.Critical)
            If cmbTransType.Text = "" Then
                cmbTransType.Focus()
            ElseIf txtTellerID.Text = "" Then
                txtTellerID.Focus()
            ElseIf IsDate(dtePeriod.Text) = False Then
                dtePeriod.Focus()
            End If
            Return False
        End If
    End Function

    Private Sub txtTellerID_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTellerID.Click
        cmbTransType.Focus()
    End Sub

    Private Sub txtTimeFrom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTimeFrom.Click
        cmbTransType.Focus()
    End Sub

    Private Sub txtTimeTo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTimeTo.Click
        cmbTransType.Focus()
    End Sub

#End Region

    Private Sub PopulateFields()
        Dim objListItem As ListItem
        objListItem = CType(lstTimeRange.SelectedItem, ListItem)

        Dim drTurnOver As DataRow = CallClsCAC.GetTurnOver(objListItem.ID)
        If Not IsNothing(drTurnOver) Then
            lblID.Text = drTurnOver.Item("ID") 'HIDDEN VALUE TURNOVERSLIP RECORD FIELD "ID"
            lblBatch.Text = "BATCH NUMBER " & drTurnOver.Item("Batch")
            txt1000.Text = drTurnOver.Item("P1000")
            txt500.Text = drTurnOver.Item("P500")
            txt200.Text = drTurnOver.Item("P200")
            txt100.Text = drTurnOver.Item("P100")
            txt50.Text = drTurnOver.Item("P50")
            txt20.Text = drTurnOver.Item("P20")
            txt10.Text = drTurnOver.Item("P10")
            txt5.Text = drTurnOver.Item("P5")
            txt1.Text = drTurnOver.Item("P1")
            txt025.Text = drTurnOver.Item("P025")
            txt010.Text = drTurnOver.Item("P010")
            txt005.Text = drTurnOver.Item("P005")
            txt001.Text = drTurnOver.Item("P001")
            txtTot1000.Text = FormatNumber(CType((CType(txt1000.Text, Decimal) * 1000), String), 2)
            txtTot500.Text = FormatNumber(CType((CType(txt500.Text, Decimal) * 500), String), 2)
            txtTot200.Text = FormatNumber(CType((CType(txt200.Text, Decimal) * 200), String), 2)
            txtTot100.Text = FormatNumber(CType((CType(txt100.Text, Decimal) * 100), String), 2)
            txtTot50.Text = FormatNumber(CType((CType(txt50.Text, Decimal) * 50), String), 2)
            txtTot20.Text = FormatNumber(CType((CType(txt20.Text, Decimal) * 20), String), 2)
            txtTot10.Text = FormatNumber(CType((CType(txt10.Text, Decimal) * 10), String), 2)
            txtTot5.Text = FormatNumber(CType((CType(txt5.Text, Decimal) * 5), String), 2)
            txtTot1.Text = FormatNumber(CType((CType(txt1.Text, Decimal) * 1), String), 2)
            txtTot025.Text = FormatNumber(CType((CType(txt025.Text, Decimal) * 0.25), String), 2)
            txtTot010.Text = FormatNumber(CType((CType(txt010.Text, Decimal) * 0.1), String), 2)
            txtTot005.Text = FormatNumber(CType((CType(txt005.Text, Decimal) * 0.05), String), 2)
            txtTot001.Text = FormatNumber(CType((CType(txt001.Text, Decimal) * 0.01), String), 2)
            txtTimeFrom.Text = drTurnOver.Item("TimeFrom")
            txtTimeTo.Text = drTurnOver.Item("TimeTo")
            lblTimeTo.Visible = True
            lblTimeFrom.Visible = True
            lblTimeRange.Visible = False
            lstTimeRange.Visible = False
        End If
    End Sub

    Private Sub CACExisting()
        Dim strSQL As String
        Dim TransTyp As String

        Select Case cmbTransType.SelectedItem
            Case "All Transaction"
                TransTyp = "ALL"
            Case "Import"
                TransTyp = "CYM"
            Case "Export"
                TransTyp = "CYX"
            Case "Special Services"
                TransTyp = "CYS"
            Case "Invoice"
                TransTyp = "INV"
            Case Else
                TransTyp = "ALL"
        End Select

        strSQL = "SELECT * FROM TurnOverSlip WHERE TransTyp = '" & TransTyp & "' AND TellerID = '" & txtTellerID.Text & "'" & " AND BatchDate = '" & dtePeriod.Text & "'"

        CallClsCAC.RetrieveTurnOverSlip(strSQL)
    End Sub

    Private Sub PopulatelstTimeRange()
        Dim dv As DataView
        Dim drv As DataRowView
        Dim objListItem As ListItem
        Dim strTimeRange As String

        dv = dsTurnOverSlip.Tables(0).DefaultView
        lstTimeRange.Items.Clear()
        For Each drv In dv
            strTimeRange = drv("TimeFrom") & " - " & drv("TimeTo")
            objListItem = New ListItem(strTimeRange, drv("ID"))
            lstTimeRange.Items.Add(objListItem)
        Next
        lstTimeRange.SetSelected(0, True)
    End Sub
    Private Function selCompanyCode(strComp As String) As String '
        If strComp = "ALL" Then
            selCompanyCode = ""
        Else
            selCompanyCode = "AND CompanyCode = '" & Replace(strComp, "'", "''") & "'"
        End If
    End Function
    Private Sub RetrieveData()
        Dim dteTo As Date = CType(dtePeriod.Text & " " & txtTimeTo.Text, Date)
        Dim dteFrom As Date = CType(dtePeriod.Text & " " & txtTimeFrom.Text, Date)
        Dim strSQL As String
        Select Case cmbTransType.SelectedItem
            Case "All Transaction"
                strSQL = "SELECT distinct cympay.refnum,cshamt,chgamt,chkbnk1,chkbnk2,chkbnk3,chkbnk4,chkbnk5,chkamt1,chkamt2," &
                         "chkamt3,chkamt4,chkamt5,chkno1,chkno2,chkno3,chkno4,chkno5 FROM CYMPay inner join CYMGps on cympay.refnum = cymgps.refnum WHERE cymgps.status <> 'CAN' AND UPPER(cympay.userid) = " &
                         UCase(CallClsCAC.getToString(txtTellerID.Text)) & " AND sysdttm  >= CAST('" & CType(FormatDateTime(dteFrom, DateFormat.GeneralDate), String) &
                         "' AS SMALLDATETIME) AND sysdttm  <= CAST('" & CType(FormatDateTime(dteTo, DateFormat.GeneralDate), String) & "' AS SMALLDATETIME)" &
                         selCompanyCode(txtComp.Text)
                CallClsCAC.RetrieveCAC(strSQL)
                PopulatedgChequeALL("Import")

                strSQL = "SELECT distinct ccrpay.refnum,cshamt,chgamt,chkbnk1,chkbnk2,chkbnk3,chkbnk4,chkbnk5,chkamt1,chkamt2," &
                         "chkamt3,chkamt4,chkamt5,chkno1,chkno2,chkno3,chkno4,chkno5 FROM CCRpay inner join ccrcyx on ccrpay.refnum = ccrcyx.refnum WHERE ccrtyp = '1' AND ccrcyx.status <> 'CAN' AND UPPER(CCRpay.userid) = " &
                         UCase(CallClsCAC.getToString(txtTellerID.Text)) & " AND CCRpay.sysdttm  >= CAST('" & CType(FormatDateTime(dteFrom, DateFormat.GeneralDate), String) &
                         "' AS SMALLDATETIME) AND CCRpay.sysdttm  <= CAST('" & CType(FormatDateTime(dteTo, DateFormat.GeneralDate), String) & "' AS SMALLDATETIME)" &
                         selCompanyCode(txtComp.Text)
                CallClsCAC.RetrieveCAC(strSQL)
                PopulatedgChequeALL("Export")

                strSQL = "SELECT distinct pay.refnum, cshamt,chgamt,chkbnk1,chkbnk2,chkbnk3,chkbnk4,chkbnk5,chkamt1,chkamt2," &
                         "chkamt3,chkamt4,chkamt5,chkno1,chkno2,chkno3,chkno4,chkno5 FROM CCRpay AS PAY INNER JOIN CCRdtl AS DTL ON PAY.refnum = DTL.refnum " &
                         "WHERE DTL.guarntycde <> 'Y' AND PAY.ccrtyp = '2' AND dtl.status <> 'CAN' AND UPPER(PAY.userid) = " &
                         UCase(CallClsCAC.getToString(txtTellerID.Text)) & " AND PAY.sysdttm  >= CAST('" & CType(FormatDateTime(dteFrom, DateFormat.GeneralDate), String) &
                         "' AS SMALLDATETIME) AND PAY.sysdttm  <= CAST('" & CType(FormatDateTime(dteTo, DateFormat.GeneralDate), String) & "' AS SMALLDATETIME) " &
                         selCompanyCode(txtComp.Text)
                CallClsCAC.RetrieveCAC(strSQL)
                PopulatedgChequeALL("Special Services")

                strSQL = "SELECT distinct PAY.ORNUM,CashAMT,AvailAMT,CheckAmt1,CheckAmt2,CheckBnk1,CheckBnk2,CheckNo1,CheckNo2" &
                         " FROM INVPAYHDR as INV inner join INVPAYDTL as PAY on INV.ORNUM = PAY.ORNUM inner join INVICT as ICT on PAY.INVNUM = ICT.INVNUM WHERE ICT.status <>'CAN'" &
                         " AND UPPER(INV.userid) = " & UCase(CallClsCAC.getToString(txtTellerID.Text)) & " AND ORDate  >= CAST('" & CType(FormatDateTime(dteFrom, DateFormat.GeneralDate), String) &
                         "' AS SMALLDATETIME) AND ORDate  <= CAST('" & CType(FormatDateTime(dteTo, DateFormat.GeneralDate), String) & "' AS SMALLDATETIME)" &
                         selCompanyCode(txtComp.Text)

                CallClsCAC.RetrieveCAC(strSQL)
                PopulatedgChequeALL("Invoice")

                If dtabDetails.Rows.Count = 0 Then
                    ' ClearForm()
                    MsgBox("No Cheque Records Found", MsgBoxStyle.Information)
                Else
                    PopulatedgChequeALL2()
                End If

            Case "Import"
                strSQL = "SELECT cshamt,chgamt,chkbnk1,chkbnk2,chkbnk3,chkbnk4,chkbnk5,chkamt1,chkamt2," &
                         "chkamt3,chkamt4,chkamt5,chkno1,chkno2,chkno3,chkno4,chkno5 FROM CYMPay inner join CYMGps on cympay.refnum = cymgps.refnum WHERE cympay.status <> 'CAN' AND UPPER(cympay.userid) = " &
                         UCase(CallClsCAC.getToString(txtTellerID.Text)) & " AND sysdttm  >= CAST('" & CType(FormatDateTime(dteFrom, DateFormat.GeneralDate), String) &
                         "' AS SMALLDATETIME) AND sysdttm  <= CAST('" & CType(FormatDateTime(dteTo, DateFormat.GeneralDate), String) & "' AS SMALLDATETIME)" &
                         selCompanyCode(txtComp.Text)
                CallClsCAC.RetrieveCAC(strSQL)
                If dsCAC.Tables(0).Rows.Count > 0 Then
                    PopulatedgChequeMXS()
                    DisabledgbCriteria()
                Else
                    ClearForm()
                    MsgBox("No Records Found", MsgBoxStyle.Information)
                End If
            Case "Export"
                strSQL = "SELECT cshamt,chgamt,chkbnk1,chkbnk2,chkbnk3,chkbnk4,chkbnk5,chkamt1,chkamt2," &
                         "chkamt3,chkamt4,chkamt5,chkno1,chkno2,chkno3,chkno4,chkno5 FROM CCRpay inner join ccrcyx on ccrpay.refnum = ccrcyx.refnum WHERE ccrtyp = '1' AND CCRpay.status <> 'CAN' AND UPPER(CCRpay.userid) = " &
                         UCase(CallClsCAC.getToString(txtTellerID.Text)) & " AND CCRpay.sysdttm  >= CAST('" & CType(FormatDateTime(dteFrom, DateFormat.GeneralDate), String) &
                         "' AS SMALLDATETIME) AND CCRpay.sysdttm  <= CAST('" & CType(FormatDateTime(dteTo, DateFormat.GeneralDate), String) & "' AS SMALLDATETIME)" &
                         selCompanyCode(txtComp.Text)
                CallClsCAC.RetrieveCAC(strSQL)
                If dsCAC.Tables(0).Rows.Count > 0 Then
                    PopulatedgChequeMXS()
                    DisabledgbCriteria()
                Else
                    ClearForm()
                    MsgBox("No Records Found", MsgBoxStyle.Information)
                End If
            Case "Special Services"
                strSQL = "SELECT cusnam, cshamt,chgamt,chkbnk1,chkbnk2,chkbnk3,chkbnk4,chkbnk5,chkamt1,chkamt2," &
                         "chkamt3,chkamt4,chkamt5,chkno1,chkno2,chkno3,chkno4,chkno5 FROM CCRpay AS PAY INNER JOIN CCRdtl AS DTL ON PAY.refnum = DTL.refnum " &
                         "WHERE DTL.guarntycde <> 'Y' AND PAY.ccrtyp = '2' AND PAY.status <> 'CAN' AND UPPER(PAY.userid) = " &
                         UCase(CallClsCAC.getToString(txtTellerID.Text)) & " AND PAY.sysdttm  >= CAST('" & CType(FormatDateTime(dteFrom, DateFormat.GeneralDate), String) &
                         "' AS SMALLDATETIME) AND PAY.sysdttm  <= CAST('" & CType(FormatDateTime(dteTo, DateFormat.GeneralDate), String) & "' AS SMALLDATETIME) " &
                         selCompanyCode(txtComp.Text) &
                         "GROUP BY pay.refnum, cusnam, cshamt,chgamt,chkbnk1,chkbnk2,chkbnk3,chkbnk4,chkbnk5,chkamt1,chkamt2,chkamt3,chkamt4,chkamt5,chkno1,chkno2,chkno3,chkno4,chkno5"
                CallClsCAC.RetrieveCAC(strSQL)
                If dsCAC.Tables(0).Rows.Count > 0 Then
                    PopulatedgChequeMXS()
                    DisabledgbCriteria()
                Else
                    ClearForm()
                    MsgBox("No Records Found", MsgBoxStyle.Information)
                End If
            Case "Invoice"
                strSQL = "SELECT CashAMT,AvailAMT,CheckAmt1,CheckAmt2,CheckBnk1,CheckBnk2,CheckNo1,CheckNo2" &
                         " FROM INVPAYHDR as INV inner join INVPAYDTL as PAY on INV.ORNUM = PAY.ORNUM inner join INVICT as ICT on PAY.INVNUM = ICT.INVNUM WHERE ICT.status <>'CAN'" &
                         " AND UPPER(INV.userid) = " & UCase(CallClsCAC.getToString(txtTellerID.Text)) & " AND ORDate  >= CAST('" & CType(FormatDateTime(dteFrom, DateFormat.GeneralDate), String) &
                         "' AS SMALLDATETIME) AND ORDate  <= CAST('" & CType(FormatDateTime(dteTo, DateFormat.GeneralDate), String) & "' AS SMALLDATETIME)" &
                         selCompanyCode(txtComp.Text) &
                         " GROUP BY CashAMT,AvailAMT,CheckAmt1,CheckAmt2,CheckBnk1,CheckBnk2,CheckNo1,CheckNo2"
                CallClsCAC.RetrieveCAC(strSQL)
                If dsCAC.Tables(0).Rows.Count > 0 Then
                    PopulatedgChequeINV()
                    DisabledgbCriteria()
                Else
                    ClearForm()
                    MsgBox("No Records Found", MsgBoxStyle.Information)
                End If
        End Select
    End Sub

    Private Sub PopulatedgChequeMXS()
        'Populate datatable
        dtabDetails = New DataTable

        If dtabDetails.Columns.Contains("Bank") = True Then
            dtabDetails.Columns.Remove("Bank")
        End If
        dtabDetails.Columns.Add("Bank", Type.GetType("System.String"))

        If dtabDetails.Columns.Contains("Cheque No.") = True Then
            dtabDetails.Columns.Remove("Cheque No.")
        End If
        dtabDetails.Columns.Add("Cheque No.", Type.GetType("System.String"))

        If dtabDetails.Columns.Contains("Amount") = True Then
            dtabDetails.Columns.Remove("Amount")
        End If
        dtabDetails.Columns.Add("Amount", Type.GetType("System.Decimal"))

        If dtabDetails.Columns.Contains("Excess") = True Then
            dtabDetails.Columns.Remove("Excess")
        End If
        dtabDetails.Columns.Add("Excess", Type.GetType("System.Decimal"))


        Dim dtabdsCAC As New DataTable
        dtabdsCAC = dsCAC.Tables(0)
        decExCheque = 0
        decAmCheque = 0
        decGrandTotal = 0
        decGrCshAmt = 0
        decGrChgAmt = 0

        If dtabdsCAC.Rows.Count > 0 Then
            Dim lngCtr As Long = 0

            Do While lngCtr < dtabdsCAC.Rows.Count
                '------- Expected Grand Total (add the cash amount)
                decGrCshAmt = decGrCshAmt + dtabdsCAC.Rows(lngCtr)("cshamt")
                decGrChgAmt = decGrChgAmt + dtabdsCAC.Rows(lngCtr)("chgamt")

                '------- POPULATING dgChequeDetails
                If dtabdsCAC.Rows(lngCtr)("chkamt1") <> 0 Then
                    Dim dtarow As DataRow
                    dtarow = dtabDetails.NewRow
                    dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk1")
                    dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno1")
                    dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt1")
                    decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt1")
                    If dtabdsCAC.Rows(lngCtr)("cshamt") = 0 Then
                        dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                        decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                    Else
                        dtarow("Excess") = 0
                    End If
                    dtabDetails.Rows.Add(dtarow)
                End If

                If dtabdsCAC.Rows(lngCtr)("chkamt2") <> 0 Then
                    Dim dtarow As DataRow
                    dtarow = dtabDetails.NewRow
                    dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk2")
                    dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno2")
                    dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt2")
                    decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt2")
                    If dtabdsCAC.Rows(lngCtr)("chkbnk1") = "" Then
                        dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                        decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                    Else
                        dtarow("Excess") = 0
                    End If
                    dtabDetails.Rows.Add(dtarow)
                End If

                If dtabdsCAC.Rows(lngCtr)("chkamt3") <> 0 Then
                    Dim dtarow As DataRow
                    dtarow = dtabDetails.NewRow
                    dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk3")
                    dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno3")
                    dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt3")
                    decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt3")
                    If dtabdsCAC.Rows(lngCtr)("cshamt") = 0 And dtabdsCAC.Rows(lngCtr)("chkbnk2") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk1") = "" Then
                        dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                        decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                    Else
                        dtarow("Excess") = 0
                    End If
                    dtabDetails.Rows.Add(dtarow)
                End If

                If dtabdsCAC.Rows(lngCtr)("chkamt4") <> 0 Then
                    Dim dtarow As DataRow
                    dtarow = dtabDetails.NewRow
                    dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk4")
                    dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno4")
                    dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt4")
                    decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt4")
                    If dtabdsCAC.Rows(lngCtr)("cshamt") = 0 And dtabdsCAC.Rows(lngCtr)("chkbnk3") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk2") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk1") = "" Then
                        dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                        decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                    Else
                        dtarow("Excess") = 0
                    End If
                    dtabDetails.Rows.Add(dtarow)
                End If

                If dtabdsCAC.Rows(lngCtr)("chkamt5") <> 0 Then
                    Dim dtarow As DataRow
                    dtarow = dtabDetails.NewRow
                    dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk5")
                    dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno5")
                    dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt5")
                    decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt5")
                    If dtabdsCAC.Rows(lngCtr)("cshamt") = 0 And dtabdsCAC.Rows(lngCtr)("chkbnk4") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk3") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk2") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk1") = "" Then
                        dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                        decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                    Else
                        dtarow("Excess") = 0
                    End If
                    dtabDetails.Rows.Add(dtarow)
                End If

                '------- Expected Grand Total (add cheque amount)
                lngCtr += 1
            Loop
        End If

        ts = New DataGridTableStyle
        ts.MappingName = dtabDetails.ToString
        dgChequeDetails.TableStyles.Add(ts)

        With dgChequeDetails
            .DataSource = dtabDetails
            .AlternatingBackColor = Color.AliceBlue
            .BackColor = Color.White
            .TableStyles(0).RowHeaderWidth = 15
            .TableStyles(0).GridColumnStyles.Item(0).Width = 75
            .TableStyles(0).GridColumnStyles.Item(1).Width = 106
            .TableStyles(0).GridColumnStyles.Item(2).Width = 110
            .TableStyles(0).GridColumnStyles.Item(3).Width = 110
            .TableStyles(0).SelectionBackColor = .TableStyles(0).BackColor.PowderBlue
            .TableStyles(0).SelectionForeColor = .TableStyles(0).ForeColor.Black
            .TableStyles(0).AlternatingBackColor = .TableStyles(0).BackColor.AliceBlue
            .TableStyles(0).BackColor = .TableStyles(0).BackColor.White
            .TableStyles(0).HeaderBackColor = .TableStyles(0).BackColor.MidnightBlue
            .TableStyles(0).HeaderForeColor = .TableStyles(0).ForeColor.White
            .TableStyles(0).HeaderFont = New System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        End With


        '------- POPULATING dgChequeStat
        Dim dtabStat As New DataTable

        If dtabStat.Columns.Contains("Bank") = True Then
            dtabStat.Columns.Remove("Bank")
        End If
        dtabStat.Columns.Add("Bank", Type.GetType("System.String"))

        If dtabStat.Columns.Contains("Pieces") = True Then
            dtabStat.Columns.Remove("Pieces")
        End If
        dtabStat.Columns.Add("Pieces", Type.GetType("System.Int32"))

        If dtabStat.Columns.Contains("Amount") = True Then
            dtabStat.Columns.Remove("Amount")
        End If
        dtabStat.Columns.Add("Amount", Type.GetType("System.Decimal"))



        If dtabDetails.Rows.Count > 0 Then
            Dim dv As DataView
            Dim drv As DataRowView

            dv = dtabDetails.DefaultView
            dv.Sort = "Bank"

            Dim strPreBank As String = ""
            Dim decAmt As Decimal = 0
            Dim intPcs As Integer = 0

            For Each drv In dv
                If Trim(drv("Bank")) = Trim(strPreBank) Then
                    decAmt = decAmt + drv("Amount")
                    intPcs += 1
                Else
                    If strPreBank <> "" Then
                        Dim dtarow As DataRow
                        dtarow = dtabStat.NewRow
                        dtarow("Bank") = strPreBank
                        dtarow("Pieces") = intPcs
                        dtarow("Amount") = decAmt
                        dtabStat.Rows.Add(dtarow)
                    End If
                    strPreBank = drv("Bank")
                    decAmt = drv("Amount")
                    intPcs = 1
                End If
            Next
            '---- add final row of dgChequeStat
            Dim dtarow1 As DataRow
            dtarow1 = dtabStat.NewRow
            dtarow1("Bank") = strPreBank
            dtarow1("Pieces") = intPcs
            dtarow1("Amount") = decAmt
            dtabStat.Rows.Add(dtarow1)
        End If

        ts = New DataGridTableStyle
        ts.MappingName = dtabStat.ToString
        dgChequeStat.TableStyles.Add(ts)

        With dgChequeStat
            .DataSource = dtabStat
            .AlternatingBackColor = Color.AliceBlue
            .BackColor = Color.White
            .TableStyles(0).RowHeaderWidth = 15
            .TableStyles(0).GridColumnStyles.Item(0).Width = 75
            .TableStyles(0).GridColumnStyles.Item(1).Width = 106
            .TableStyles(0).GridColumnStyles.Item(2).Width = 220
            .TableStyles(0).SelectionBackColor = .TableStyles(0).BackColor.PowderBlue
            .TableStyles(0).SelectionForeColor = .TableStyles(0).ForeColor.Black
            .TableStyles(0).AlternatingBackColor = .TableStyles(0).BackColor.AliceBlue
            .TableStyles(0).BackColor = .TableStyles(0).BackColor.White
            .TableStyles(0).HeaderBackColor = .TableStyles(0).BackColor.MidnightBlue
            .TableStyles(0).HeaderForeColor = .TableStyles(0).ForeColor.White
            .TableStyles(0).HeaderFont = New System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        End With


        txtExcessCheque.Text = FormatNumber(CType(decExCheque, String), 2)
        txtTotCheque.Text = FormatNumber(CType(decAmCheque, String), 2)
        txtGrandTot.Text = FormatNumber(CType(((decGrCshAmt + decAmCheque) - decGrChgAmt), String), 2)
        txtExCash.Text = FormatNumber(CType((decGrCshAmt - decGrChgAmt), String), 2)
        txtAmtLeft.Text = FormatNumber(CType((decGrCshAmt - decGrChgAmt), String), 2)

    End Sub

    Private Sub PopulatedgChequeINV()
        'Populate datatable
        dtabDetails = New DataTable

        If dtabDetails.Columns.Contains("Bank") = True Then
            dtabDetails.Columns.Remove("Bank")
        End If
        dtabDetails.Columns.Add("Bank", Type.GetType("System.String"))

        If dtabDetails.Columns.Contains("Cheque No.") = True Then
            dtabDetails.Columns.Remove("Cheque No.")
        End If
        dtabDetails.Columns.Add("Cheque No.", Type.GetType("System.String"))

        If dtabDetails.Columns.Contains("Amount") = True Then
            dtabDetails.Columns.Remove("Amount")
        End If
        dtabDetails.Columns.Add("Amount", Type.GetType("System.Decimal"))

        If dtabDetails.Columns.Contains("Excess") = True Then
            dtabDetails.Columns.Remove("Excess")
        End If
        dtabDetails.Columns.Add("Excess", Type.GetType("System.Decimal"))


        Dim dtabdsCAC As New DataTable
        dtabdsCAC = dsCAC.Tables(0)
        decExCheque = 0
        decAmCheque = 0
        decGrandTotal = 0
        decGrCshAmt = 0
        decGrChgAmt = 0

        If dtabdsCAC.Rows.Count > 0 Then
            Dim lngCtr As Long = 0

            Do While lngCtr < dtabdsCAC.Rows.Count
                '------- Expected Grand Total (add the cash amount)
                decGrCshAmt = decGrCshAmt + dtabdsCAC.Rows(lngCtr)("CashAMT")
                'decGrChgAmt = decGrChgAmt + dtabdsCAC.Rows(lngCtr)("AvailAMT")

                '------- POPULATING dgChequeDetails
                If dtabdsCAC.Rows(lngCtr)("CheckAmt1") <> 0 Then
                    Dim dtarow As DataRow
                    dtarow = dtabDetails.NewRow
                    dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("CheckBnk1")
                    dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("CheckNo1")
                    dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("CheckAmt1")
                    decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("CheckAmt1")
                    'If dtabdsCAC.Rows(lngCtr)("CashAMT") = 0 Then
                    '    dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("AvailAMT")
                    '    decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("AvailAMT")
                    'Else
                    '    dtarow("Excess") = 0
                    'End If
                    dtarow("Excess") = 0
                    dtabDetails.Rows.Add(dtarow)
                End If

                If dtabdsCAC.Rows(lngCtr)("CheckAmt2") <> 0 Then
                    Dim dtarow As DataRow
                    dtarow = dtabDetails.NewRow
                    dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("CheckBnk2")
                    dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("CheckNo2")
                    dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("CheckAmt2")
                    decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("CheckAmt2")
                    'If dtabdsCAC.Rows(lngCtr)("CheckBnk1") = "" And dtabdsCAC.Rows(lngCtr)("CashAMT") = 0 Then
                    '    dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("AvailAMT")
                    '    decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("AvailAMT")
                    'Else
                    '    dtarow("Excess") = 0
                    'End If
                    dtarow("Excess") = 0
                    dtabDetails.Rows.Add(dtarow)
                End If

                '------- Expected Grand Total (add cheque amount)
                lngCtr += 1
            Loop
        End If

        ts = New DataGridTableStyle
        ts.MappingName = dtabDetails.ToString
        dgChequeDetails.TableStyles.Add(ts)

        With dgChequeDetails
            .DataSource = dtabDetails
            .AlternatingBackColor = Color.AliceBlue
            .BackColor = Color.White
            .TableStyles(0).RowHeaderWidth = 15
            .TableStyles(0).GridColumnStyles.Item(0).Width = 75
            .TableStyles(0).GridColumnStyles.Item(1).Width = 106
            .TableStyles(0).GridColumnStyles.Item(2).Width = 110
            .TableStyles(0).GridColumnStyles.Item(3).Width = 110
            .TableStyles(0).SelectionBackColor = .TableStyles(0).BackColor.PowderBlue
            .TableStyles(0).SelectionForeColor = .TableStyles(0).ForeColor.Black
            .TableStyles(0).AlternatingBackColor = .TableStyles(0).BackColor.AliceBlue
            .TableStyles(0).BackColor = .TableStyles(0).BackColor.White
            .TableStyles(0).HeaderBackColor = .TableStyles(0).BackColor.MidnightBlue
            .TableStyles(0).HeaderForeColor = .TableStyles(0).ForeColor.White
            .TableStyles(0).HeaderFont = New System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        End With


        '------- POPULATING dgChequeStat
        Dim dtabStat As New DataTable

        If dtabStat.Columns.Contains("Bank") = True Then
            dtabStat.Columns.Remove("Bank")
        End If
        dtabStat.Columns.Add("Bank", Type.GetType("System.String"))

        If dtabStat.Columns.Contains("Pieces") = True Then
            dtabStat.Columns.Remove("Pieces")
        End If
        dtabStat.Columns.Add("Pieces", Type.GetType("System.Int32"))

        If dtabStat.Columns.Contains("Amount") = True Then
            dtabStat.Columns.Remove("Amount")
        End If
        dtabStat.Columns.Add("Amount", Type.GetType("System.Decimal"))

        If dtabDetails.Rows.Count > 0 Then
            Dim dv As DataView
            Dim drv As DataRowView

            dv = dtabDetails.DefaultView
            dv.Sort = "Bank"

            Dim strPreBank As String = ""
            Dim decAmt As Decimal = 0
            Dim intPcs As Integer = 0

            For Each drv In dv
                If Trim(drv("Bank")) = Trim(strPreBank) Then
                    decAmt = decAmt + drv("Amount")
                    intPcs += 1
                Else
                    If strPreBank <> "" Then
                        Dim dtarow As DataRow
                        dtarow = dtabStat.NewRow
                        dtarow("Bank") = strPreBank
                        dtarow("Pieces") = intPcs
                        dtarow("Amount") = decAmt
                        dtabStat.Rows.Add(dtarow)
                    End If
                    strPreBank = drv("Bank")
                    decAmt = drv("Amount")
                    intPcs = 1
                End If
            Next
            '---- add final row of dgChequeStat
            Dim dtarow1 As DataRow
            dtarow1 = dtabStat.NewRow
            dtarow1("Bank") = strPreBank
            dtarow1("Pieces") = intPcs
            dtarow1("Amount") = decAmt
            dtabStat.Rows.Add(dtarow1)
        End If

        ts = New DataGridTableStyle
        ts.MappingName = dtabStat.ToString
        dgChequeStat.TableStyles.Add(ts)

        With dgChequeStat
            .DataSource = dtabStat
            .AlternatingBackColor = Color.AliceBlue
            .BackColor = Color.White
            .TableStyles(0).RowHeaderWidth = 15
            .TableStyles(0).GridColumnStyles.Item(0).Width = 75
            .TableStyles(0).GridColumnStyles.Item(1).Width = 106
            .TableStyles(0).GridColumnStyles.Item(2).Width = 220
            .TableStyles(0).SelectionBackColor = .TableStyles(0).BackColor.PowderBlue
            .TableStyles(0).SelectionForeColor = .TableStyles(0).ForeColor.Black
            .TableStyles(0).AlternatingBackColor = .TableStyles(0).BackColor.AliceBlue
            .TableStyles(0).BackColor = .TableStyles(0).BackColor.White
            .TableStyles(0).HeaderBackColor = .TableStyles(0).BackColor.MidnightBlue
            .TableStyles(0).HeaderForeColor = .TableStyles(0).ForeColor.White
            .TableStyles(0).HeaderFont = New System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        End With


        txtExcessCheque.Text = FormatNumber(CType(decExCheque, String), 2)
        txtTotCheque.Text = FormatNumber(CType(decAmCheque, String), 2)
        txtGrandTot.Text = FormatNumber(CType(((decGrCshAmt + decAmCheque) - decGrChgAmt), String), 2)
        txtExCash.Text = FormatNumber(CType((decGrCshAmt - decGrChgAmt), String), 2)
        txtAmtLeft.Text = FormatNumber(CType((decGrCshAmt - decGrChgAmt), String), 2)
    End Sub

    Private Sub PopulatedgChequeALL(ByVal strTransType As Object)

        Select Case strTransType
            '*****************************************************
            'IMPORT 
            '*****************************************************
            Case "Import"
                dtabDetails = New DataTable
                decExCheque = 0
                decAmCheque = 0
                decGrandTotal = 0
                decGrCshAmt = 0
                decGrChgAmt = 0

                If dtabDetails.Columns.Contains("Bank") = True Then
                    dtabDetails.Columns.Remove("Bank")
                End If
                dtabDetails.Columns.Add("Bank", Type.GetType("System.String"))

                If dtabDetails.Columns.Contains("Cheque No.") = True Then
                    dtabDetails.Columns.Remove("Cheque No.")
                End If
                dtabDetails.Columns.Add("Cheque No.", Type.GetType("System.String"))

                If dtabDetails.Columns.Contains("Amount") = True Then
                    dtabDetails.Columns.Remove("Amount")
                End If
                dtabDetails.Columns.Add("Amount", Type.GetType("System.Decimal"))

                If dtabDetails.Columns.Contains("Excess") = True Then
                    dtabDetails.Columns.Remove("Excess")
                End If
                dtabDetails.Columns.Add("Excess", Type.GetType("System.Decimal"))

                Dim dtabdsCAC As New DataTable
                dtabdsCAC = dsCAC.Tables(0)

                If dtabdsCAC.Rows.Count > 0 Then
                    Dim lngCtr As Long = 0

                    Do While lngCtr < dtabdsCAC.Rows.Count
                        '------- Expected Grand Total (add the cash amount)
                        decGrCshAmt = decGrCshAmt + dtabdsCAC.Rows(lngCtr)("cshamt")
                        decGrChgAmt = decGrChgAmt + dtabdsCAC.Rows(lngCtr)("chgamt")

                        '------- POPULATING dgChequeDetails
                        If dtabdsCAC.Rows(lngCtr)("chkamt1") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk1")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno1")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt1")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt1")
                            If dtabdsCAC.Rows(lngCtr)("cshamt") = 0 Then
                                dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                                decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                            Else
                                dtarow("Excess") = 0
                            End If
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        If dtabdsCAC.Rows(lngCtr)("chkamt2") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk2")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno2")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt2")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt2")
                            If dtabdsCAC.Rows(lngCtr)("chkbnk1") = "" Then
                                dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                                decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                            Else
                                dtarow("Excess") = 0
                            End If
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        If dtabdsCAC.Rows(lngCtr)("chkamt3") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk3")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno3")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt3")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt3")
                            If dtabdsCAC.Rows(lngCtr)("cshamt") = 0 And dtabdsCAC.Rows(lngCtr)("chkbnk2") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk1") = "" Then
                                dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                                decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                            Else
                                dtarow("Excess") = 0
                            End If
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        If dtabdsCAC.Rows(lngCtr)("chkamt4") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk4")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno4")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt4")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt4")
                            If dtabdsCAC.Rows(lngCtr)("cshamt") = 0 And dtabdsCAC.Rows(lngCtr)("chkbnk3") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk2") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk1") = "" Then
                                dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                                decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                            Else
                                dtarow("Excess") = 0
                            End If
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        If dtabdsCAC.Rows(lngCtr)("chkamt5") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk5")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno5")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt5")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt5")
                            If dtabdsCAC.Rows(lngCtr)("cshamt") = 0 And dtabdsCAC.Rows(lngCtr)("chkbnk4") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk3") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk2") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk1") = "" Then
                                dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                                decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                            Else
                                dtarow("Excess") = 0
                            End If
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        '------- Expected Grand Total (add cheque amount)
                        lngCtr += 1
                    Loop
                End If

                '*****************************************************
                'EXPORT
                '*****************************************************
            Case "Export"
                Dim dtabdsCAC As New DataTable
                dtabdsCAC = dsCAC.Tables(0)

                If dtabdsCAC.Rows.Count > 0 Then
                    Dim lngCtr As Long = 0

                    Do While lngCtr < dtabdsCAC.Rows.Count
                        '------- Expected Grand Total (add the cash amount)
                        decGrCshAmt = decGrCshAmt + dtabdsCAC.Rows(lngCtr)("cshamt")
                        decGrChgAmt = decGrChgAmt + dtabdsCAC.Rows(lngCtr)("chgamt")

                        '------- POPULATING dgChequeDetails
                        If dtabdsCAC.Rows(lngCtr)("chkamt1") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk1")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno1")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt1")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt1")
                            If dtabdsCAC.Rows(lngCtr)("cshamt") = 0 Then
                                dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                                decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                            Else
                                dtarow("Excess") = 0
                            End If
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        If dtabdsCAC.Rows(lngCtr)("chkamt2") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk2")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno2")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt2")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt2")
                            If dtabdsCAC.Rows(lngCtr)("chkbnk1") = "" Then
                                dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                                decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                            Else
                                dtarow("Excess") = 0
                            End If
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        If dtabdsCAC.Rows(lngCtr)("chkamt3") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk3")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno3")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt3")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt3")
                            If dtabdsCAC.Rows(lngCtr)("cshamt") = 0 And dtabdsCAC.Rows(lngCtr)("chkbnk2") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk1") = "" Then
                                dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                                decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                            Else
                                dtarow("Excess") = 0
                            End If
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        If dtabdsCAC.Rows(lngCtr)("chkamt4") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk4")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno4")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt4")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt4")
                            If dtabdsCAC.Rows(lngCtr)("cshamt") = 0 And dtabdsCAC.Rows(lngCtr)("chkbnk3") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk2") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk1") = "" Then
                                dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                                decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                            Else
                                dtarow("Excess") = 0
                            End If
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        If dtabdsCAC.Rows(lngCtr)("chkamt5") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk5")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno5")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt5")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt5")
                            If dtabdsCAC.Rows(lngCtr)("cshamt") = 0 And dtabdsCAC.Rows(lngCtr)("chkbnk4") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk3") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk2") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk1") = "" Then
                                dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                                decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                            Else
                                dtarow("Excess") = 0
                            End If
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        '------- Expected Grand Total (add cheque amount)
                        lngCtr += 1
                    Loop
                End If

                '*****************************************************
                'SPECIAL SERVICES
                '*****************************************************

            Case "Special Services"
                Dim dtabdsCAC As New DataTable
                dtabdsCAC = dsCAC.Tables(0)

                If dtabdsCAC.Rows.Count > 0 Then
                    Dim lngCtr As Long = 0

                    Do While lngCtr < dtabdsCAC.Rows.Count
                        '------- Expected Grand Total (add the cash amount)
                        decGrCshAmt = decGrCshAmt + dtabdsCAC.Rows(lngCtr)("cshamt")
                        decGrChgAmt = decGrChgAmt + dtabdsCAC.Rows(lngCtr)("chgamt")

                        '------- POPULATING dgChequeDetails
                        If dtabdsCAC.Rows(lngCtr)("chkamt1") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk1")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno1")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt1")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt1")
                            If dtabdsCAC.Rows(lngCtr)("cshamt") = 0 Then
                                dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                                decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                            Else
                                dtarow("Excess") = 0
                            End If
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        If dtabdsCAC.Rows(lngCtr)("chkamt2") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk2")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno2")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt2")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt2")
                            If dtabdsCAC.Rows(lngCtr)("chkbnk1") = "" Then
                                dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                                decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                            Else
                                dtarow("Excess") = 0
                            End If
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        If dtabdsCAC.Rows(lngCtr)("chkamt3") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk3")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno3")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt3")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt3")
                            If dtabdsCAC.Rows(lngCtr)("cshamt") = 0 And dtabdsCAC.Rows(lngCtr)("chkbnk2") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk1") = "" Then
                                dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                                decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                            Else
                                dtarow("Excess") = 0
                            End If
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        If dtabdsCAC.Rows(lngCtr)("chkamt4") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk4")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno4")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt4")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt4")
                            If dtabdsCAC.Rows(lngCtr)("cshamt") = 0 And dtabdsCAC.Rows(lngCtr)("chkbnk3") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk2") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk1") = "" Then
                                dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                                decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                            Else
                                dtarow("Excess") = 0
                            End If
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        If dtabdsCAC.Rows(lngCtr)("chkamt5") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("chkbnk5")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("chkno5")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("chkamt5")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("chkamt5")
                            If dtabdsCAC.Rows(lngCtr)("cshamt") = 0 And dtabdsCAC.Rows(lngCtr)("chkbnk4") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk3") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk2") = "" And dtabdsCAC.Rows(lngCtr)("chkbnk1") = "" Then
                                dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("chgamt")
                                decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("chgamt")
                            Else
                                dtarow("Excess") = 0
                            End If
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        '------- Expected Grand Total (add cheque amount)
                        lngCtr += 1
                    Loop
                End If

                '*****************************************************
                'INVOIVE
                '*****************************************************
            Case "Invoice"
                Dim dtabdsCAC As New DataTable
                dtabdsCAC = dsCAC.Tables(0)

                If dtabdsCAC.Rows.Count > 0 Then
                    Dim lngCtr As Long = 0

                    Do While lngCtr < dtabdsCAC.Rows.Count
                        '------- Expected Grand Total (add the cash amount)
                        decGrCshAmt = decGrCshAmt + dtabdsCAC.Rows(lngCtr)("CashAMT")
                        'decGrChgAmt = decGrChgAmt + dtabdsCAC.Rows(lngCtr)("AvailAMT")

                        '------- POPULATING dgChequeDetails
                        If dtabdsCAC.Rows(lngCtr)("CheckAmt1") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("CheckBnk1")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("CheckNo1")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("CheckAmt1")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("CheckAmt1")
                            'If dtabdsCAC.Rows(lngCtr)("CashAMT") = 0 Then
                            '    dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("AvailAMT")
                            '    decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("AvailAMT")
                            'Else
                            '    dtarow("Excess") = 0
                            'End If
                            dtarow("Excess") = 0
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        If dtabdsCAC.Rows(lngCtr)("CheckAmt2") <> 0 Then
                            Dim dtarow As DataRow
                            dtarow = dtabDetails.NewRow
                            dtarow("Bank") = dtabdsCAC.Rows(lngCtr)("CheckBnk2")
                            dtarow("Cheque No.") = dtabdsCAC.Rows(lngCtr)("CheckNo2")
                            dtarow("Amount") = dtabdsCAC.Rows(lngCtr)("CheckAmt2")
                            decAmCheque = decAmCheque + dtabdsCAC.Rows(lngCtr)("CheckAmt2")
                            'If dtabdsCAC.Rows(lngCtr)("CheckBnk1") = "" And dtabdsCAC.Rows(lngCtr)("CashAMT") = 0 Then
                            '    dtarow("Excess") = dtabdsCAC.Rows(lngCtr)("AvailAMT")
                            '    decExCheque = decExCheque + dtabdsCAC.Rows(lngCtr)("AvailAMT")
                            'Else
                            '    dtarow("Excess") = 0
                            'End If
                            dtarow("Excess") = 0
                            dtabDetails.Rows.Add(dtarow)
                        End If

                        '------- Expected Grand Total (add cheque amount)
                        lngCtr += 1
                    Loop
                End If

                ts = New DataGridTableStyle
                ts.MappingName = dtabDetails.ToString
                dgChequeDetails.TableStyles.Add(ts)

                With dgChequeDetails
                    .DataSource = dtabDetails
                    .AlternatingBackColor = Color.AliceBlue
                    .BackColor = Color.White
                    .TableStyles(0).RowHeaderWidth = 15
                    .TableStyles(0).GridColumnStyles.Item(0).Width = 75
                    .TableStyles(0).GridColumnStyles.Item(1).Width = 106
                    .TableStyles(0).GridColumnStyles.Item(2).Width = 110
                    .TableStyles(0).GridColumnStyles.Item(3).Width = 110
                    .TableStyles(0).SelectionBackColor = .TableStyles(0).BackColor.PowderBlue
                    .TableStyles(0).SelectionForeColor = .TableStyles(0).ForeColor.Black
                    .TableStyles(0).AlternatingBackColor = .TableStyles(0).BackColor.AliceBlue
                    .TableStyles(0).BackColor = .TableStyles(0).BackColor.White
                    .TableStyles(0).HeaderBackColor = .TableStyles(0).BackColor.MidnightBlue
                    .TableStyles(0).HeaderForeColor = .TableStyles(0).ForeColor.White
                    .TableStyles(0).HeaderFont = New System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
                End With
        End Select

        txtExcessCheque.Text = FormatNumber(CType(decExCheque, String), 2)
        txtTotCheque.Text = FormatNumber(CType(decAmCheque, String), 2)
        txtGrandTot.Text = FormatNumber(CType(((decGrCshAmt + decAmCheque) - decGrChgAmt), String), 2)
        txtExCash.Text = FormatNumber(CType((decGrCshAmt - decGrChgAmt), String), 2)
        txtAmtLeft.Text = FormatNumber(CType((decGrCshAmt - decGrChgAmt), String), 2)

    End Sub

    Private Sub PopulatedgChequeALL2()
        '------- POPULATING dgChequeStat
        Dim dtabStat As New DataTable

        If dtabStat.Columns.Contains("Bank") = True Then
            dtabStat.Columns.Remove("Bank")
        End If
        dtabStat.Columns.Add("Bank", Type.GetType("System.String"))

        If dtabStat.Columns.Contains("Pieces") = True Then
            dtabStat.Columns.Remove("Pieces")
        End If
        dtabStat.Columns.Add("Pieces", Type.GetType("System.Int32"))

        If dtabStat.Columns.Contains("Amount") = True Then
            dtabStat.Columns.Remove("Amount")
        End If
        dtabStat.Columns.Add("Amount", Type.GetType("System.Decimal"))

        If dtabDetails.Rows.Count > 0 Then
            Dim dv As DataView
            Dim drv As DataRowView

            dv = dtabDetails.DefaultView
            dv.Sort = "Bank"

            Dim strPreBank As String = ""
            Dim decAmt As Decimal = 0
            Dim intPcs As Integer = 0

            For Each drv In dv
                If Trim(drv("Bank")) = Trim(strPreBank) Then
                    decAmt = decAmt + drv("Amount")
                    intPcs += 1
                Else
                    If strPreBank <> "" Then
                        Dim dtarow As DataRow
                        dtarow = dtabStat.NewRow
                        dtarow("Bank") = strPreBank
                        dtarow("Pieces") = intPcs
                        dtarow("Amount") = decAmt
                        dtabStat.Rows.Add(dtarow)
                    End If
                    strPreBank = drv("Bank")
                    decAmt = drv("Amount")
                    intPcs = 1
                End If
            Next
            '---- add final row of dgChequeStat
            Dim dtarow1 As DataRow
            dtarow1 = dtabStat.NewRow
            dtarow1("Bank") = strPreBank
            dtarow1("Pieces") = intPcs
            dtarow1("Amount") = decAmt
            dtabStat.Rows.Add(dtarow1)
        End If

        ts = New DataGridTableStyle
        ts.MappingName = dtabStat.ToString
        dgChequeStat.TableStyles.Add(ts)

        With dgChequeStat
            .DataSource = dtabStat
            .AlternatingBackColor = Color.AliceBlue
            .BackColor = Color.White
            .TableStyles(0).RowHeaderWidth = 15
            .TableStyles(0).GridColumnStyles.Item(0).Width = 75
            .TableStyles(0).GridColumnStyles.Item(1).Width = 106
            .TableStyles(0).GridColumnStyles.Item(2).Width = 220
            .TableStyles(0).SelectionBackColor = .TableStyles(0).BackColor.PowderBlue
            .TableStyles(0).SelectionForeColor = .TableStyles(0).ForeColor.Black
            .TableStyles(0).AlternatingBackColor = .TableStyles(0).BackColor.AliceBlue
            .TableStyles(0).BackColor = .TableStyles(0).BackColor.White
            .TableStyles(0).HeaderBackColor = .TableStyles(0).BackColor.MidnightBlue
            .TableStyles(0).HeaderForeColor = .TableStyles(0).ForeColor.White
            .TableStyles(0).HeaderFont = New System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        End With

    End Sub

    Private Sub ClearForm()
        '--- gbCriteria ---
        cmbTransType.SelectedItem = "All Transaction"
        cmbTransType.Enabled = True
        cmbTransType.BackColor = Color.White
        cmbTransType.Focus()
        txtTellerID.Text = zCurrentUser()
        txtTellerID.ReadOnly = False
        txtTellerID.BackColor = Color.White
        txtComp.SelectedItem = "ALL"
        txtComp.Enabled = True
        txtComp.BackColor = Color.White
        dtePeriod.Text = Today()
        dtePeriod.Enabled = True
        dtePeriod.BackColor = Color.White
        txtTimeFrom.Text = ""
        txtTimeFrom.ReadOnly = False
        txtTimeFrom.BackColor = Color.White
        txtTimeTo.Text = ""
        txtTimeTo.ReadOnly = False
        txtTimeTo.BackColor = Color.White
        lblTimeTo.Visible = True
        lblTimeFrom.Visible = True
        lblTimeRange.Visible = False
        lstTimeRange.Visible = False
        lblBatch.Text = ""
        lblID.Text = ""
        '--- gbCash ---
        decGrCshAmt = 0
        decGrChgAmt = 0
        txt1000.Text = "0"
        txt500.Text = "0"
        txt200.Text = "0"
        txt100.Text = "0"
        txt50.Text = "0"
        txt20.Text = "0"
        txt10.Text = "0"
        txt5.Text = "0"
        txt1.Text = "0"
        txt025.Text = "0"
        txt010.Text = "0"
        txt005.Text = "0"
        txt001.Text = "0"
        txtTot1000.Text = "0.00"
        txtTot500.Text = "0.00"
        txtTot200.Text = "0.00"
        txtTot100.Text = "0.00"
        txtTot50.Text = "0.00"
        txtTot20.Text = "0.00"
        txtTot10.Text = "0.00"
        txtTot5.Text = "0.00"
        txtTot1.Text = "0.00"
        txtTot025.Text = "0.00"
        txtTot010.Text = "0.00"
        txtTot005.Text = "0.00"
        txtTot001.Text = "0.00"
        txtTotCash.Text = "0.00"
        txtAmtLeft.Text = "0.00"
        txtExCash.Text = "0.00"
        '--- gbCheque ---
        dgChequeDetails.DataSource = Nothing
        dgChequeStat.DataSource = Nothing
        txtTotCheque.Text = "0.00"
        txtExcessCheque.Text = "0.00"
        '--- gbControl ---
        txtGrandTot.Text = "0.00"
        txtRemarks.Text = ""
    End Sub

    Private Sub EnabledgbCash()
        txt1000.ReadOnly = False
        txt500.ReadOnly = False
        txt200.ReadOnly = False
        txt100.ReadOnly = False
        txt50.ReadOnly = False
        txt20.ReadOnly = False
        txt10.ReadOnly = False
        txt5.ReadOnly = False
        txt1.ReadOnly = False
        txt025.ReadOnly = False
        txt010.ReadOnly = False
        txt005.ReadOnly = False
        txt001.ReadOnly = False
        txt1000.BackColor = Color.White
        txt500.BackColor = Color.White
        txt200.BackColor = Color.White
        txt100.BackColor = Color.White
        txt50.BackColor = Color.White
        txt20.BackColor = Color.White
        txt10.BackColor = Color.White
        txt5.BackColor = Color.White
        txt1.BackColor = Color.White
        txt025.BackColor = Color.White
        txt010.BackColor = Color.White
        txt005.BackColor = Color.White
        txt001.BackColor = Color.White
    End Sub

    Private Sub DisEnabledgbCash()
        txt1000.ReadOnly = True
        txt500.ReadOnly = True
        txt200.ReadOnly = True
        txt100.ReadOnly = True
        txt50.ReadOnly = True
        txt20.ReadOnly = True
        txt10.ReadOnly = True
        txt5.ReadOnly = True
        txt1.ReadOnly = True
        txt025.ReadOnly = True
        txt010.ReadOnly = True
        txt005.ReadOnly = True
        txt001.ReadOnly = True
        txt1000.BackColor = Color.AliceBlue
        txt500.BackColor = Color.AliceBlue
        txt200.BackColor = Color.AliceBlue
        txt100.BackColor = Color.AliceBlue
        txt50.BackColor = Color.AliceBlue
        txt20.BackColor = Color.AliceBlue
        txt10.BackColor = Color.AliceBlue
        txt5.BackColor = Color.AliceBlue
        txt1.BackColor = Color.AliceBlue
        txt025.BackColor = Color.AliceBlue
        txt010.BackColor = Color.AliceBlue
        txt005.BackColor = Color.AliceBlue
        txt001.BackColor = Color.AliceBlue
    End Sub

    Private Sub DisabledgbCriteria()
        cmbTransType.Enabled = False
        cmbTransType.BackColor = Color.AliceBlue
        txtTellerID.ReadOnly = True
        txtTellerID.BackColor = Color.AliceBlue
        txtComp.Enabled = False
        txtComp.BackColor = Color.AliceBlue
        dtePeriod.Enabled = False
        dtePeriod.BackColor = Color.AliceBlue
        txtTimeFrom.ReadOnly = True
        txtTimeFrom.BackColor = Color.AliceBlue
        txtTimeTo.ReadOnly = True
        txtTimeTo.BackColor = Color.AliceBlue
    End Sub

    Private Function ValidateFields() As Boolean
        If CType(txtGrandTot.Text, Decimal) = 0 Or CType(txtExCash.Text, Decimal) <> CType(txtTotCash.Text, Decimal) Then
            If CType(txtGrandTot.Text, Decimal) = 0 Then
                MsgBox("Expected Cash and Cheque Collection Total should not be P0.00.", MsgBoxStyle.Information, "")
            ElseIf CType(txtExCash.Text, Decimal) > CType(txtTotCash.Text, Decimal) Then
                MsgBox("Please verify, your Remitted Cash cannot be less than the Expected Cash!", MsgBoxStyle.Information, "")
            ElseIf CType(txtExCash.Text, Decimal) < CType(txtTotCash.Text, Decimal) Then
                MsgBox("Please verify, your Remitted Cash exceeds the Expected Cash!", MsgBoxStyle.Information, "")
            End If
            Return False
        ElseIf CType(txtGrandTot.Text, Decimal) > 0 And CType(txtExCash.Text, Decimal) = CType(txtTotCash.Text, Decimal) Then
            Return True
        End If
    End Function

    Private Sub PopulatedtabCashDetails()
        dtabCashDetails = New DataTable

        If dtabCashDetails.Columns.Contains("Denomination") = True Then
            dtabCashDetails.Columns.Remove("Denomination")
        End If
        dtabCashDetails.Columns.Add("Denomination", Type.GetType("System.String"))

        If dtabCashDetails.Columns.Contains("Quantity") = True Then
            dtabCashDetails.Columns.Remove("Quantity")
        End If
        dtabCashDetails.Columns.Add("Quantity", Type.GetType("System.Int32"))

        If dtabCashDetails.Columns.Contains("Amount") = True Then
            dtabCashDetails.Columns.Remove("Amount")
        End If
        dtabCashDetails.Columns.Add("Amount", Type.GetType("System.Decimal"))

        Dim dtarow As DataRow
        dtarow = dtabCashDetails.NewRow
        dtarow("Denomination") = "P1000"
        dtarow("Quantity") = CType(txt1000.Text, Integer)
        dtarow("Amount") = CType(txtTot1000.Text, Decimal)
        dtabCashDetails.Rows.Add(dtarow)

        dtarow = dtabCashDetails.NewRow
        dtarow("Denomination") = "P500"
        dtarow("Quantity") = CType(txt500.Text, Integer)
        dtarow("Amount") = CType(txtTot500.Text, Decimal)
        dtabCashDetails.Rows.Add(dtarow)

        dtarow = dtabCashDetails.NewRow
        dtarow("Denomination") = "P200"
        dtarow("Quantity") = CType(txt200.Text, Integer)
        dtarow("Amount") = CType(txtTot200.Text, Decimal)
        dtabCashDetails.Rows.Add(dtarow)

        dtarow = dtabCashDetails.NewRow
        dtarow("Denomination") = "P100"
        dtarow("Quantity") = CType(txt100.Text, Integer)
        dtarow("Amount") = CType(txtTot100.Text, Decimal)
        dtabCashDetails.Rows.Add(dtarow)

        dtarow = dtabCashDetails.NewRow
        dtarow("Denomination") = "P50"
        dtarow("Quantity") = CType(txt50.Text, Integer)
        dtarow("Amount") = CType(txtTot50.Text, Decimal)
        dtabCashDetails.Rows.Add(dtarow)

        dtarow = dtabCashDetails.NewRow
        dtarow("Denomination") = "P20"
        dtarow("Quantity") = CType(txt20.Text, Integer)
        dtarow("Amount") = CType(txtTot20.Text, Decimal)
        dtabCashDetails.Rows.Add(dtarow)

        dtarow = dtabCashDetails.NewRow
        dtarow("Denomination") = "P10"
        dtarow("Quantity") = CType(txt10.Text, Integer)
        dtarow("Amount") = CType(txtTot10.Text, Decimal)
        dtabCashDetails.Rows.Add(dtarow)

        dtarow = dtabCashDetails.NewRow
        dtarow("Denomination") = "P5"
        dtarow("Quantity") = CType(txt5.Text, Integer)
        dtarow("Amount") = CType(txtTot5.Text, Decimal)
        dtabCashDetails.Rows.Add(dtarow)

        dtarow = dtabCashDetails.NewRow
        dtarow("Denomination") = "P1"
        dtarow("Quantity") = CType(txt1.Text, Integer)
        dtarow("Amount") = CType(txtTot1.Text, Decimal)
        dtabCashDetails.Rows.Add(dtarow)

        dtarow = dtabCashDetails.NewRow
        dtarow("Denomination") = "P025"
        dtarow("Quantity") = CType(txt025.Text, Integer)
        dtarow("Amount") = CType(txtTot025.Text, Decimal)
        dtabCashDetails.Rows.Add(dtarow)

        dtarow = dtabCashDetails.NewRow
        dtarow("Denomination") = "P010"
        dtarow("Quantity") = CType(txt010.Text, Integer)
        dtarow("Amount") = CType(txtTot010.Text, Decimal)
        dtabCashDetails.Rows.Add(dtarow)

        dtarow = dtabCashDetails.NewRow
        dtarow("Denomination") = "P005"
        dtarow("Quantity") = CType(txt005.Text, Integer)
        dtarow("Amount") = CType(txtTot005.Text, Decimal)
        dtabCashDetails.Rows.Add(dtarow)

        dtarow = dtabCashDetails.NewRow
        dtarow("Denomination") = "P001"
        dtarow("Quantity") = CType(txt001.Text, Integer)
        dtarow("Amount") = CType(txtTot001.Text, Decimal)
        dtabCashDetails.Rows.Add(dtarow)

    End Sub

#Region "Buttons"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strSQL As String
        Dim TransTyp As String
        Dim intBatch As String

        Select Case cmbTransType.SelectedItem
            Case "All Transaction"
                TransTyp = "ALL"
            Case "Import"
                TransTyp = "CYM"
            Case "Export"
                TransTyp = "CYX"
            Case "Special Services"
                TransTyp = "CYS"
            Case "Invoice"
                TransTyp = "INV"
        End Select

        If lblBatch.Text = "" Or lblID.Text = "" Then
            Dim ValFields As Boolean = ValidateFields()
            If ValFields = True Then
                strSQL = "SELECT Batch FROM TurnOverSlip WHERE TransTyp = " & CallClsCAC.getToString(TransTyp) & " AND " &
                         "TellerID = " & CallClsCAC.getToString(UCase(txtTellerID.Text)) & " AND " &
                         "CAST(BatchDate as SMALLDATETIME) = CAST(" & CallClsCAC.getToString(dtePeriod.Text) & " AS SMALLDATETIME)"

                intBatch = CallClsCAC.GetBatch(strSQL)

                If intBatch = "Application Cannot Retrive Data From Database" Then
                    MsgBox(intBatch, MsgBoxStyle.Critical, "ERROR")
                    Exit Sub
                End If

                intBatch = CType((CType(intBatch, Integer) + 1), String)

                strSQL = "INSERT INTO TurnOverSlip(BatchDate,TransTyp,TellerID,TimeFrom,TimeTo,P1000,P500,P200,P100,P50,P20,P10,P5,P1,P025,P010,P005,P001,Remarks,Batch) VALUES(" &
                         CallClsCAC.getToString(dtePeriod.Text) & "," &
                         CallClsCAC.getToString(TransTyp) & "," &
                         CallClsCAC.getToString(UCase(txtTellerID.Text)) & "," &
                         CallClsCAC.getToString(CType(TimeValue(txtTimeFrom.Text), String)) & "," &
                         CallClsCAC.getToString(CType(TimeValue(txtTimeTo.Text), String)) & "," &
                         txt1000.Text & "," &
                         txt500.Text & "," &
                         txt200.Text & "," &
                         txt100.Text & "," &
                         txt50.Text & "," &
                         txt20.Text & "," &
                         txt10.Text & "," &
                         txt5.Text & "," &
                         txt1.Text & "," &
                         txt025.Text & "," &
                         txt010.Text & "," &
                         txt005.Text & "," &
                         txt001.Text & "," &
                         CallClsCAC.getToString(txtRemarks.Text) & "," &
                         intBatch & ")"

                Dim isSave As Boolean = CallClsCAC.SaveCAC(strSQL)

                If isSave = True Then
                    MsgBox("Record is Saved", MsgBoxStyle.Information, "")
                Else
                    MsgBox("Record is Not Saved", MsgBoxStyle.Critical, "ERROR")
                End If
            End If
        ElseIf lblBatch.Text <> "" And lblID.Text <> "" Then
            Dim ValFields As Boolean = ValidateFields()
            If ValFields = True Then
                strSQL = "UPDATE TurnOverSlip SET TimeFrom = " & CallClsCAC.getToString(CType(TimeValue(txtTimeFrom.Text), String)) &
                         ",TimeTo = " & CallClsCAC.getToString(CType(TimeValue(txtTimeTo.Text), String)) &
                         ",P1000 = " & txt1000.Text &
                         ",P500 = " & txt500.Text &
                         ",P200 = " & txt200.Text &
                         ",P100 = " & txt100.Text &
                         ",P50 = " & txt50.Text &
                         ",P20 = " & txt20.Text &
                         ",P10 = " & txt10.Text &
                         ",P5 = " & txt5.Text &
                         ",P1 = " & txt1.Text &
                         ",P025 = " & txt025.Text &
                         ",P010 = " & txt010.Text &
                         ",P005 = " & txt005.Text &
                         ",P001 = " & txt001.Text &
                         ",Remarks = " & CallClsCAC.getToString(txtRemarks.Text) &
                         " WHERE ID = " & lblID.Text

                Dim isUpdate As Boolean = CallClsCAC.SaveCAC(strSQL)

                If isUpdate = True Then
                    MsgBox("Record is Updated", MsgBoxStyle.Information, "")
                Else
                    MsgBox("Record is Not Updated", MsgBoxStyle.Critical, "ERROR")
                End If
            End If
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearForm()
    End Sub

    Private Sub btnCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLOSE.Click
        End
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Cursor = Cursors.WaitCursor
        If CType(txtGrandTot.Text, Decimal) = 0 Then
            MsgBox("There is no Cash and Collection Report to Display.", MsgBoxStyle.Exclamation, "Invalid")
            Cursor = Cursors.Default
            Exit Sub
        End If
        PopulatedtabCashDetails()

        Dim frmRptCAC As New frmRptCAC
        Dim RptCAC As New rptCAC

        RptCAC.OpenSubreport("rptCash.rpt").SetDataSource(dtabCashDetails)
        RptCAC.OpenSubreport("rptCheque.rpt").SetDataSource(dtabDetails)
        RptCAC.SetParameterValue("strDate", Trim(dtePeriod.Text))
        RptCAC.SetParameterValue("strTimeRange", Trim(txtTimeFrom.Text & " - " & txtTimeTo.Text))
        RptCAC.SetParameterValue("strTranType", Trim(cmbTransType.SelectedItem))
        RptCAC.SetParameterValue("strCurDate", Trim(CType(Today(), String)))
        RptCAC.SetParameterValue("strRemarks", Trim(txtRemarks.Text))
        RptCAC.SetParameterValue("strUserID", UCase(Trim(txtTellerID.Text)))
        RptCAC.SetParameterValue("numGrandTot", Trim(txtGrandTot.Text))

        frmRptCAC.crvReports.ReportSource = RptCAC
        Cursor = Cursors.Default
        frmRptCAC.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub txtComp_KeyDown(sender As Object, e As KeyEventArgs) Handles txtComp.KeyDown
        If e.KeyCode = 13 Or e.KeyCode = 9 Then
            ValDis = CallClsCAC.StrVal(txtComp.Text)
            If ValDis = False Then
                MsgBox("Invalid Teller ID", MsgBoxStyle.Critical)
                txtComp.Focus()
            Else
                dtePeriod.Focus()
            End If
        End If
    End Sub

    Private Sub frmCAC_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmSplash.Close()
    End Sub


#End Region


End Class
