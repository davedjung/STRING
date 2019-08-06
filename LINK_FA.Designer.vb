﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LINK_FA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gbxHeader = New System.Windows.Forms.GroupBox()
        Me.lblMaterialTemp = New System.Windows.Forms.Label()
        Me.txtMaterialTemp = New System.Windows.Forms.TextBox()
        Me.lblFAMaterial = New System.Windows.Forms.Label()
        Me.txtFAMaterial = New System.Windows.Forms.TextBox()
        Me.lblPinPitch = New System.Windows.Forms.Label()
        Me.txtPinPitch = New System.Windows.Forms.TextBox()
        Me.txtPinNo = New System.Windows.Forms.TextBox()
        Me.lblPinNo = New System.Windows.Forms.Label()
        Me.lblFAIndex = New System.Windows.Forms.Label()
        Me.txtFAIndex = New System.Windows.Forms.TextBox()
        Me.gbxFAOverview = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnErase = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnCreateFA = New System.Windows.Forms.Button()
        Me.btnEraseAll = New System.Windows.Forms.Button()
        Me.btnSetPin = New System.Windows.Forms.Button()
        Me.pbxFA = New System.Windows.Forms.PictureBox()
        Me.btnClearSelection = New System.Windows.Forms.Button()
        Me.lbxFAList = New System.Windows.Forms.ListBox()
        Me.gbxPinInfo = New System.Windows.Forms.GroupBox()
        Me.lbxPinInfo = New System.Windows.Forms.ListBox()
        Me.pbxPin = New System.Windows.Forms.PictureBox()
        Me.lblPinList = New System.Windows.Forms.Label()
        Me.lbxPinList = New System.Windows.Forms.ListBox()
        Me.cbxAssemFile = New System.Windows.Forms.ComboBox()
        Me.lblAssemFile = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbxAssemblyGap = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtPinPitchCalc = New System.Windows.Forms.TextBox()
        Me.txtPinNoCalc = New System.Windows.Forms.TextBox()
        Me.txtAssemPitchCalc = New System.Windows.Forms.TextBox()
        Me.lblPinNoCalc = New System.Windows.Forms.Label()
        Me.lblPinPitchCalc = New System.Windows.Forms.Label()
        Me.lblAssemPitchCalc = New System.Windows.Forms.Label()
        Me.lblCalculator = New System.Windows.Forms.Label()
        Me.txtHalfAssemGap = New System.Windows.Forms.TextBox()
        Me.lblHalfAssemGap = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pbxExit = New System.Windows.Forms.PictureBox()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pbxMinimize = New System.Windows.Forms.PictureBox()
        Me.gbxHeader.SuspendLayout()
        Me.gbxFAOverview.SuspendLayout()
        CType(Me.pbxFA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPinInfo.SuspendLayout()
        CType(Me.pbxPin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxAssemblyGap.SuspendLayout()
        CType(Me.pbxExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.pbxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(470, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "LINK_FA_[Reactor Core].dat Configurator"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbxHeader
        '
        Me.gbxHeader.Controls.Add(Me.lblMaterialTemp)
        Me.gbxHeader.Controls.Add(Me.txtMaterialTemp)
        Me.gbxHeader.Controls.Add(Me.lblFAMaterial)
        Me.gbxHeader.Controls.Add(Me.txtFAMaterial)
        Me.gbxHeader.Controls.Add(Me.lblPinPitch)
        Me.gbxHeader.Controls.Add(Me.txtPinPitch)
        Me.gbxHeader.Controls.Add(Me.txtPinNo)
        Me.gbxHeader.Controls.Add(Me.lblPinNo)
        Me.gbxHeader.Controls.Add(Me.lblFAIndex)
        Me.gbxHeader.Controls.Add(Me.txtFAIndex)
        Me.gbxHeader.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxHeader.Location = New System.Drawing.Point(12, 55)
        Me.gbxHeader.Name = "gbxHeader"
        Me.gbxHeader.Size = New System.Drawing.Size(622, 70)
        Me.gbxHeader.TabIndex = 0
        Me.gbxHeader.TabStop = False
        Me.gbxHeader.Text = "Header"
        '
        'lblMaterialTemp
        '
        Me.lblMaterialTemp.AutoSize = True
        Me.lblMaterialTemp.Location = New System.Drawing.Point(282, 44)
        Me.lblMaterialTemp.Name = "lblMaterialTemp"
        Me.lblMaterialTemp.Size = New System.Drawing.Size(124, 15)
        Me.lblMaterialTemp.TabIndex = 10
        Me.lblMaterialTemp.Text = "Material Inlet Temp (K)"
        '
        'txtMaterialTemp
        '
        Me.txtMaterialTemp.Location = New System.Drawing.Point(412, 41)
        Me.txtMaterialTemp.Name = "txtMaterialTemp"
        Me.txtMaterialTemp.Size = New System.Drawing.Size(204, 21)
        Me.txtMaterialTemp.TabIndex = 4
        Me.txtMaterialTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFAMaterial
        '
        Me.lblFAMaterial.AutoSize = True
        Me.lblFAMaterial.Location = New System.Drawing.Point(6, 44)
        Me.lblFAMaterial.Name = "lblFAMaterial"
        Me.lblFAMaterial.Size = New System.Drawing.Size(108, 15)
        Me.lblFAMaterial.TabIndex = 8
        Me.lblFAMaterial.Text = "Material Filled in FA"
        '
        'txtFAMaterial
        '
        Me.txtFAMaterial.Location = New System.Drawing.Point(120, 41)
        Me.txtFAMaterial.Name = "txtFAMaterial"
        Me.txtFAMaterial.Size = New System.Drawing.Size(156, 21)
        Me.txtFAMaterial.TabIndex = 3
        Me.txtFAMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPinPitch
        '
        Me.lblPinPitch.AutoSize = True
        Me.lblPinPitch.Location = New System.Drawing.Point(411, 17)
        Me.lblPinPitch.Name = "lblPinPitch"
        Me.lblPinPitch.Size = New System.Drawing.Size(76, 15)
        Me.lblPinPitch.TabIndex = 6
        Me.lblPinPitch.Text = "Pin Pitch (cm)"
        '
        'txtPinPitch
        '
        Me.txtPinPitch.Location = New System.Drawing.Point(493, 14)
        Me.txtPinPitch.Name = "txtPinPitch"
        Me.txtPinPitch.Size = New System.Drawing.Size(123, 21)
        Me.txtPinPitch.TabIndex = 2
        Me.txtPinPitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPinNo
        '
        Me.txtPinNo.Location = New System.Drawing.Point(332, 14)
        Me.txtPinNo.Name = "txtPinNo"
        Me.txtPinNo.Size = New System.Drawing.Size(73, 21)
        Me.txtPinNo.TabIndex = 1
        Me.txtPinNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPinNo
        '
        Me.lblPinNo.AutoSize = True
        Me.lblPinNo.Location = New System.Drawing.Point(210, 17)
        Me.lblPinNo.Name = "lblPinNo"
        Me.lblPinNo.Size = New System.Drawing.Size(116, 15)
        Me.lblPinNo.TabIndex = 2
        Me.lblPinNo.Text = "# of Pins in x-direction"
        '
        'lblFAIndex
        '
        Me.lblFAIndex.AutoSize = True
        Me.lblFAIndex.Location = New System.Drawing.Point(6, 17)
        Me.lblFAIndex.Name = "lblFAIndex"
        Me.lblFAIndex.Size = New System.Drawing.Size(117, 15)
        Me.lblFAIndex.TabIndex = 0
        Me.lblFAIndex.Text = "Fuel Assembly Index #"
        '
        'txtFAIndex
        '
        Me.txtFAIndex.Location = New System.Drawing.Point(129, 14)
        Me.txtFAIndex.Name = "txtFAIndex"
        Me.txtFAIndex.Size = New System.Drawing.Size(75, 21)
        Me.txtFAIndex.TabIndex = 0
        Me.txtFAIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbxFAOverview
        '
        Me.gbxFAOverview.Controls.Add(Me.btnAdd)
        Me.gbxFAOverview.Controls.Add(Me.btnErase)
        Me.gbxFAOverview.Controls.Add(Me.btnSelectAll)
        Me.gbxFAOverview.Controls.Add(Me.btnCreateFA)
        Me.gbxFAOverview.Controls.Add(Me.btnEraseAll)
        Me.gbxFAOverview.Controls.Add(Me.btnSetPin)
        Me.gbxFAOverview.Controls.Add(Me.pbxFA)
        Me.gbxFAOverview.Controls.Add(Me.btnClearSelection)
        Me.gbxFAOverview.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFAOverview.Location = New System.Drawing.Point(12, 131)
        Me.gbxFAOverview.Name = "gbxFAOverview"
        Me.gbxFAOverview.Size = New System.Drawing.Size(622, 532)
        Me.gbxFAOverview.TabIndex = 1
        Me.gbxFAOverview.TabStop = False
        Me.gbxFAOverview.Text = "Fuel Assembly Overview"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(516, 296)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 40)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add to &List"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnErase
        '
        Me.btnErase.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnErase.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnErase.ForeColor = System.Drawing.Color.White
        Me.btnErase.Location = New System.Drawing.Point(516, 204)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(100, 40)
        Me.btnErase.TabIndex = 4
        Me.btnErase.Text = "&Erase"
        Me.btnErase.UseVisualStyleBackColor = False
        '
        'btnSelectAll
        '
        Me.btnSelectAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectAll.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll.ForeColor = System.Drawing.Color.White
        Me.btnSelectAll.Location = New System.Drawing.Point(516, 112)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(100, 40)
        Me.btnSelectAll.TabIndex = 2
        Me.btnSelectAll.Text = "Select &All"
        Me.btnSelectAll.UseVisualStyleBackColor = False
        '
        'btnCreateFA
        '
        Me.btnCreateFA.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnCreateFA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateFA.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateFA.ForeColor = System.Drawing.Color.White
        Me.btnCreateFA.Location = New System.Drawing.Point(516, 20)
        Me.btnCreateFA.Name = "btnCreateFA"
        Me.btnCreateFA.Size = New System.Drawing.Size(100, 40)
        Me.btnCreateFA.TabIndex = 0
        Me.btnCreateFA.Text = "Create &FA"
        Me.btnCreateFA.UseVisualStyleBackColor = False
        '
        'btnEraseAll
        '
        Me.btnEraseAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnEraseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEraseAll.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEraseAll.ForeColor = System.Drawing.Color.White
        Me.btnEraseAll.Location = New System.Drawing.Point(516, 250)
        Me.btnEraseAll.Name = "btnEraseAll"
        Me.btnEraseAll.Size = New System.Drawing.Size(100, 40)
        Me.btnEraseAll.TabIndex = 5
        Me.btnEraseAll.Text = "Erase All"
        Me.btnEraseAll.UseVisualStyleBackColor = False
        '
        'btnSetPin
        '
        Me.btnSetPin.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnSetPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetPin.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetPin.ForeColor = System.Drawing.Color.White
        Me.btnSetPin.Location = New System.Drawing.Point(516, 66)
        Me.btnSetPin.Name = "btnSetPin"
        Me.btnSetPin.Size = New System.Drawing.Size(100, 40)
        Me.btnSetPin.TabIndex = 1
        Me.btnSetPin.Text = "Set &Pin #"
        Me.btnSetPin.UseVisualStyleBackColor = False
        '
        'pbxFA
        '
        Me.pbxFA.Enabled = False
        Me.pbxFA.Location = New System.Drawing.Point(9, 20)
        Me.pbxFA.Name = "pbxFA"
        Me.pbxFA.Size = New System.Drawing.Size(501, 501)
        Me.pbxFA.TabIndex = 0
        Me.pbxFA.TabStop = False
        '
        'btnClearSelection
        '
        Me.btnClearSelection.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnClearSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearSelection.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSelection.ForeColor = System.Drawing.Color.White
        Me.btnClearSelection.Location = New System.Drawing.Point(516, 158)
        Me.btnClearSelection.Name = "btnClearSelection"
        Me.btnClearSelection.Size = New System.Drawing.Size(100, 40)
        Me.btnClearSelection.TabIndex = 3
        Me.btnClearSelection.Text = "Clear Selection"
        Me.btnClearSelection.UseVisualStyleBackColor = False
        '
        'lbxFAList
        '
        Me.lbxFAList.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxFAList.FormattingEnabled = True
        Me.lbxFAList.ItemHeight = 15
        Me.lbxFAList.Location = New System.Drawing.Point(12, 720)
        Me.lbxFAList.Name = "lbxFAList"
        Me.lbxFAList.Size = New System.Drawing.Size(621, 79)
        Me.lbxFAList.TabIndex = 4
        '
        'gbxPinInfo
        '
        Me.gbxPinInfo.Controls.Add(Me.lbxPinInfo)
        Me.gbxPinInfo.Controls.Add(Me.pbxPin)
        Me.gbxPinInfo.Controls.Add(Me.lblPinList)
        Me.gbxPinInfo.Controls.Add(Me.lbxPinList)
        Me.gbxPinInfo.Controls.Add(Me.cbxAssemFile)
        Me.gbxPinInfo.Controls.Add(Me.lblAssemFile)
        Me.gbxPinInfo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPinInfo.Location = New System.Drawing.Point(640, 131)
        Me.gbxPinInfo.Name = "gbxPinInfo"
        Me.gbxPinInfo.Size = New System.Drawing.Size(429, 532)
        Me.gbxPinInfo.TabIndex = 2
        Me.gbxPinInfo.TabStop = False
        Me.gbxPinInfo.Text = "Pin Information"
        '
        'lbxPinInfo
        '
        Me.lbxPinInfo.FormattingEnabled = True
        Me.lbxPinInfo.ItemHeight = 15
        Me.lbxPinInfo.Location = New System.Drawing.Point(6, 462)
        Me.lbxPinInfo.Name = "lbxPinInfo"
        Me.lbxPinInfo.Size = New System.Drawing.Size(417, 64)
        Me.lbxPinInfo.TabIndex = 5
        '
        'pbxPin
        '
        Me.pbxPin.BackColor = System.Drawing.Color.White
        Me.pbxPin.Location = New System.Drawing.Point(35, 98)
        Me.pbxPin.Name = "pbxPin"
        Me.pbxPin.Size = New System.Drawing.Size(355, 355)
        Me.pbxPin.TabIndex = 4
        Me.pbxPin.TabStop = False
        '
        'lblPinList
        '
        Me.lblPinList.AutoSize = True
        Me.lblPinList.Location = New System.Drawing.Point(6, 58)
        Me.lblPinList.Name = "lblPinList"
        Me.lblPinList.Size = New System.Drawing.Size(112, 15)
        Me.lblPinList.TabIndex = 3
        Me.lblPinList.Text = "List of Pin(s) Defined"
        '
        'lbxPinList
        '
        Me.lbxPinList.FormattingEnabled = True
        Me.lbxPinList.ItemHeight = 15
        Me.lbxPinList.Location = New System.Drawing.Point(214, 43)
        Me.lbxPinList.Name = "lbxPinList"
        Me.lbxPinList.Size = New System.Drawing.Size(209, 49)
        Me.lbxPinList.TabIndex = 2
        '
        'cbxAssemFile
        '
        Me.cbxAssemFile.FormattingEnabled = True
        Me.cbxAssemFile.Location = New System.Drawing.Point(214, 14)
        Me.cbxAssemFile.Name = "cbxAssemFile"
        Me.cbxAssemFile.Size = New System.Drawing.Size(209, 23)
        Me.cbxAssemFile.TabIndex = 0
        '
        'lblAssemFile
        '
        Me.lblAssemFile.AutoSize = True
        Me.lblAssemFile.Location = New System.Drawing.Point(6, 17)
        Me.lblAssemFile.Name = "lblAssemFile"
        Me.lblAssemFile.Size = New System.Drawing.Size(202, 15)
        Me.lblAssemFile.TabIndex = 0
        Me.lblAssemFile.Text = "Select [Reactor Code]_Assem_#.inp File"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(897, 720)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(172, 79)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'gbxAssemblyGap
        '
        Me.gbxAssemblyGap.Controls.Add(Me.btnCalculate)
        Me.gbxAssemblyGap.Controls.Add(Me.txtPinPitchCalc)
        Me.gbxAssemblyGap.Controls.Add(Me.txtPinNoCalc)
        Me.gbxAssemblyGap.Controls.Add(Me.txtAssemPitchCalc)
        Me.gbxAssemblyGap.Controls.Add(Me.lblPinNoCalc)
        Me.gbxAssemblyGap.Controls.Add(Me.lblPinPitchCalc)
        Me.gbxAssemblyGap.Controls.Add(Me.lblAssemPitchCalc)
        Me.gbxAssemblyGap.Controls.Add(Me.lblCalculator)
        Me.gbxAssemblyGap.Controls.Add(Me.txtHalfAssemGap)
        Me.gbxAssemblyGap.Controls.Add(Me.lblHalfAssemGap)
        Me.gbxAssemblyGap.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAssemblyGap.Location = New System.Drawing.Point(12, 669)
        Me.gbxAssemblyGap.Name = "gbxAssemblyGap"
        Me.gbxAssemblyGap.Size = New System.Drawing.Size(1057, 45)
        Me.gbxAssemblyGap.TabIndex = 3
        Me.gbxAssemblyGap.TabStop = False
        Me.gbxAssemblyGap.Text = "Assembly Gap"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.White
        Me.btnCalculate.Location = New System.Drawing.Point(928, 13)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(123, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtPinPitchCalc
        '
        Me.txtPinPitchCalc.Location = New System.Drawing.Point(822, 14)
        Me.txtPinPitchCalc.Name = "txtPinPitchCalc"
        Me.txtPinPitchCalc.Size = New System.Drawing.Size(100, 21)
        Me.txtPinPitchCalc.TabIndex = 3
        Me.txtPinPitchCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPinNoCalc
        '
        Me.txtPinNoCalc.Location = New System.Drawing.Point(634, 14)
        Me.txtPinNoCalc.Name = "txtPinNoCalc"
        Me.txtPinNoCalc.Size = New System.Drawing.Size(100, 21)
        Me.txtPinNoCalc.TabIndex = 2
        Me.txtPinNoCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAssemPitchCalc
        '
        Me.txtAssemPitchCalc.Location = New System.Drawing.Point(472, 14)
        Me.txtAssemPitchCalc.Name = "txtAssemPitchCalc"
        Me.txtAssemPitchCalc.Size = New System.Drawing.Size(100, 21)
        Me.txtAssemPitchCalc.TabIndex = 1
        Me.txtAssemPitchCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPinNoCalc
        '
        Me.lblPinNoCalc.AutoSize = True
        Me.lblPinNoCalc.Location = New System.Drawing.Point(578, 17)
        Me.lblPinNoCalc.Name = "lblPinNoCalc"
        Me.lblPinNoCalc.Size = New System.Drawing.Size(50, 15)
        Me.lblPinNoCalc.TabIndex = 5
        Me.lblPinNoCalc.Text = "# of Pins"
        '
        'lblPinPitchCalc
        '
        Me.lblPinPitchCalc.AutoSize = True
        Me.lblPinPitchCalc.Location = New System.Drawing.Point(740, 17)
        Me.lblPinPitchCalc.Name = "lblPinPitchCalc"
        Me.lblPinPitchCalc.Size = New System.Drawing.Size(76, 15)
        Me.lblPinPitchCalc.TabIndex = 4
        Me.lblPinPitchCalc.Text = "Pin Pitch (cm)"
        '
        'lblAssemPitchCalc
        '
        Me.lblAssemPitchCalc.AutoSize = True
        Me.lblAssemPitchCalc.Location = New System.Drawing.Point(357, 17)
        Me.lblAssemPitchCalc.Name = "lblAssemPitchCalc"
        Me.lblAssemPitchCalc.Size = New System.Drawing.Size(109, 15)
        Me.lblAssemPitchCalc.TabIndex = 3
        Me.lblAssemPitchCalc.Text = "Assembly Pitch (cm)"
        '
        'lblCalculator
        '
        Me.lblCalculator.AutoSize = True
        Me.lblCalculator.Location = New System.Drawing.Point(289, 17)
        Me.lblCalculator.Name = "lblCalculator"
        Me.lblCalculator.Size = New System.Drawing.Size(62, 15)
        Me.lblCalculator.TabIndex = 2
        Me.lblCalculator.Text = "Calculator: "
        '
        'txtHalfAssemGap
        '
        Me.txtHalfAssemGap.Location = New System.Drawing.Point(153, 14)
        Me.txtHalfAssemGap.Name = "txtHalfAssemGap"
        Me.txtHalfAssemGap.Size = New System.Drawing.Size(100, 21)
        Me.txtHalfAssemGap.TabIndex = 0
        Me.txtHalfAssemGap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHalfAssemGap
        '
        Me.lblHalfAssemGap.AutoSize = True
        Me.lblHalfAssemGap.Location = New System.Drawing.Point(6, 17)
        Me.lblHalfAssemGap.Name = "lblHalfAssemGap"
        Me.lblHalfAssemGap.Size = New System.Drawing.Size(141, 15)
        Me.lblHalfAssemGap.TabIndex = 0
        Me.lblHalfAssemGap.Text = "Half of Assembly Gap (cm)"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(640, 720)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(64, 79)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(710, 720)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(181, 79)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close without Saving"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pbxExit
        '
        Me.pbxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxExit.Image = Global.Project_Joshua.My.Resources.Resources._exit
        Me.pbxExit.InitialImage = Nothing
        Me.pbxExit.Location = New System.Drawing.Point(1063, 0)
        Me.pbxExit.Name = "pbxExit"
        Me.pbxExit.Size = New System.Drawing.Size(20, 20)
        Me.pbxExit.TabIndex = 8
        Me.pbxExit.TabStop = False
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.pbxMinimize)
        Me.pnlTop.Controls.Add(Me.pbxExit)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1083, 20)
        Me.pnlTop.TabIndex = 9
        '
        'pbxMinimize
        '
        Me.pbxMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxMinimize.Image = Global.Project_Joshua.My.Resources.Resources.minimize
        Me.pbxMinimize.InitialImage = Nothing
        Me.pbxMinimize.Location = New System.Drawing.Point(1044, 0)
        Me.pbxMinimize.Name = "pbxMinimize"
        Me.pbxMinimize.Size = New System.Drawing.Size(20, 20)
        Me.pbxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxMinimize.TabIndex = 10
        Me.pbxMinimize.TabStop = False
        '
        'LINK_FA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1083, 813)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.lbxFAList)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.gbxAssemblyGap)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbxPinInfo)
        Me.Controls.Add(Me.gbxFAOverview)
        Me.Controls.Add(Me.gbxHeader)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LINK_FA"
        Me.Text = "Configure LINK_FA_[Reactor Code].dat"
        Me.gbxHeader.ResumeLayout(False)
        Me.gbxHeader.PerformLayout()
        Me.gbxFAOverview.ResumeLayout(False)
        CType(Me.pbxFA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPinInfo.ResumeLayout(False)
        Me.gbxPinInfo.PerformLayout()
        CType(Me.pbxPin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxAssemblyGap.ResumeLayout(False)
        Me.gbxAssemblyGap.PerformLayout()
        CType(Me.pbxExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        CType(Me.pbxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents gbxHeader As GroupBox
    Friend WithEvents lblFAMaterial As Label
    Friend WithEvents txtFAMaterial As TextBox
    Friend WithEvents lblPinPitch As Label
    Friend WithEvents txtPinPitch As TextBox
    Friend WithEvents txtPinNo As TextBox
    Friend WithEvents lblPinNo As Label
    Friend WithEvents lblFAIndex As Label
    Friend WithEvents txtFAIndex As TextBox
    Friend WithEvents lblMaterialTemp As Label
    Friend WithEvents gbxFAOverview As GroupBox
    Friend WithEvents btnEraseAll As Button
    Friend WithEvents btnClearSelection As Button
    Friend WithEvents btnSetPin As Button
    Friend WithEvents pbxFA As PictureBox
    Friend WithEvents gbxPinInfo As GroupBox
    Friend WithEvents cbxAssemFile As ComboBox
    Friend WithEvents lblAssemFile As Label
    Friend WithEvents lbxPinInfo As ListBox
    Friend WithEvents pbxPin As PictureBox
    Friend WithEvents lblPinList As Label
    Friend WithEvents lbxPinList As ListBox
    Friend WithEvents btnSave As Button
    Friend WithEvents gbxAssemblyGap As GroupBox
    Friend WithEvents lblAssemPitchCalc As Label
    Friend WithEvents lblCalculator As Label
    Friend WithEvents txtHalfAssemGap As TextBox
    Friend WithEvents lblHalfAssemGap As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtPinPitchCalc As TextBox
    Friend WithEvents txtPinNoCalc As TextBox
    Friend WithEvents txtAssemPitchCalc As TextBox
    Friend WithEvents lblPinNoCalc As Label
    Friend WithEvents lblPinPitchCalc As Label
    Friend WithEvents txtMaterialTemp As TextBox
    Friend WithEvents btnCreateFA As Button
    Friend WithEvents btnSelectAll As Button
    Friend WithEvents btnErase As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lbxFAList As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents pbxExit As PictureBox
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pbxMinimize As PictureBox
End Class
