<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Assem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Assem))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gbxLINK = New System.Windows.Forms.GroupBox()
        Me.chkLINK_FA = New System.Windows.Forms.CheckBox()
        Me.chkLINK_MAT = New System.Windows.Forms.CheckBox()
        Me.chkLINK_OPTION = New System.Windows.Forms.CheckBox()
        Me.gbxSPA = New System.Windows.Forms.GroupBox()
        Me.lblDensity = New System.Windows.Forms.Label()
        Me.txtSPALinDensity = New System.Windows.Forms.TextBox()
        Me.lblSpacer = New System.Windows.Forms.Label()
        Me.txtSPASpacerGrid = New System.Windows.Forms.TextBox()
        Me.lblCoolant = New System.Windows.Forms.Label()
        Me.txtSPACoolant = New System.Windows.Forms.TextBox()
        Me.gbxPIN = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pbxPreview = New System.Windows.Forms.PictureBox()
        Me.lbxPinList = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lbxPinInfo = New System.Windows.Forms.ListBox()
        Me.cbxMaterial = New System.Windows.Forms.ComboBox()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.lblMaterial = New System.Windows.Forms.Label()
        Me.lblRadius = New System.Windows.Forms.Label()
        Me.txtOuterRadius = New System.Windows.Forms.TextBox()
        Me.lblOuterSubdivision = New System.Windows.Forms.Label()
        Me.txtOuterSubdivision = New System.Windows.Forms.TextBox()
        Me.lblInnerSubdivision = New System.Windows.Forms.Label()
        Me.txtInnerSubdivision = New System.Windows.Forms.TextBox()
        Me.lblSector = New System.Windows.Forms.Label()
        Me.txtSector = New System.Windows.Forms.TextBox()
        Me.lblPinNumber = New System.Windows.Forms.Label()
        Me.txtPinID = New System.Windows.Forms.TextBox()
        Me.gbxCORE = New System.Windows.Forms.GroupBox()
        Me.lblAssemNumberY = New System.Windows.Forms.Label()
        Me.txtCOREAssemY = New System.Windows.Forms.TextBox()
        Me.lblFAIndex = New System.Windows.Forms.Label()
        Me.txtCOREAssemIndex = New System.Windows.Forms.TextBox()
        Me.lblAssemNumberX = New System.Windows.Forms.Label()
        Me.txtCOREAssemX = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbxLINK.SuspendLayout()
        Me.gbxSPA.SuspendLayout()
        Me.gbxPIN.SuspendLayout()
        CType(Me.pbxPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCORE.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(571, 37)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "[Reactor]_Assem_#.inp Configurator"
        '
        'gbxLINK
        '
        Me.gbxLINK.Controls.Add(Me.chkLINK_FA)
        Me.gbxLINK.Controls.Add(Me.chkLINK_MAT)
        Me.gbxLINK.Controls.Add(Me.chkLINK_OPTION)
        Me.gbxLINK.Location = New System.Drawing.Point(19, 49)
        Me.gbxLINK.Name = "gbxLINK"
        Me.gbxLINK.Size = New System.Drawing.Size(1290, 75)
        Me.gbxLINK.TabIndex = 0
        Me.gbxLINK.TabStop = False
        Me.gbxLINK.Text = "LINK Header"
        '
        'chkLINK_FA
        '
        Me.chkLINK_FA.AutoSize = True
        Me.chkLINK_FA.Location = New System.Drawing.Point(659, 34)
        Me.chkLINK_FA.Name = "chkLINK_FA"
        Me.chkLINK_FA.Size = New System.Drawing.Size(278, 33)
        Me.chkLINK_FA.TabIndex = 2
        Me.chkLINK_FA.Text = "LINK_FA_[Reactor].dat"
        Me.chkLINK_FA.UseVisualStyleBackColor = True
        '
        'chkLINK_MAT
        '
        Me.chkLINK_MAT.AutoSize = True
        Me.chkLINK_MAT.Location = New System.Drawing.Point(354, 34)
        Me.chkLINK_MAT.Name = "chkLINK_MAT"
        Me.chkLINK_MAT.Size = New System.Drawing.Size(299, 33)
        Me.chkLINK_MAT.TabIndex = 1
        Me.chkLINK_MAT.Text = "LINK_MAT_[Reactor].dat"
        Me.chkLINK_MAT.UseVisualStyleBackColor = True
        '
        'chkLINK_OPTION
        '
        Me.chkLINK_OPTION.AutoSize = True
        Me.chkLINK_OPTION.Location = New System.Drawing.Point(6, 34)
        Me.chkLINK_OPTION.Name = "chkLINK_OPTION"
        Me.chkLINK_OPTION.Size = New System.Drawing.Size(342, 33)
        Me.chkLINK_OPTION.TabIndex = 0
        Me.chkLINK_OPTION.Text = "LINK_OPTION_[Reactor].dat"
        Me.chkLINK_OPTION.UseVisualStyleBackColor = True
        '
        'gbxSPA
        '
        Me.gbxSPA.Controls.Add(Me.lblDensity)
        Me.gbxSPA.Controls.Add(Me.txtSPALinDensity)
        Me.gbxSPA.Controls.Add(Me.lblSpacer)
        Me.gbxSPA.Controls.Add(Me.txtSPASpacerGrid)
        Me.gbxSPA.Controls.Add(Me.lblCoolant)
        Me.gbxSPA.Controls.Add(Me.txtSPACoolant)
        Me.gbxSPA.Location = New System.Drawing.Point(19, 130)
        Me.gbxSPA.Name = "gbxSPA"
        Me.gbxSPA.Size = New System.Drawing.Size(1290, 82)
        Me.gbxSPA.TabIndex = 1
        Me.gbxSPA.TabStop = False
        Me.gbxSPA.Text = "SPA Card"
        '
        'lblDensity
        '
        Me.lblDensity.AutoSize = True
        Me.lblDensity.Location = New System.Drawing.Point(826, 37)
        Me.lblDensity.Name = "lblDensity"
        Me.lblDensity.Size = New System.Drawing.Size(240, 29)
        Me.lblDensity.TabIndex = 5
        Me.lblDensity.Text = "Linear Density (g/cm)"
        '
        'txtSPALinDensity
        '
        Me.txtSPALinDensity.Location = New System.Drawing.Point(1072, 34)
        Me.txtSPALinDensity.Name = "txtSPALinDensity"
        Me.txtSPALinDensity.Size = New System.Drawing.Size(155, 35)
        Me.txtSPALinDensity.TabIndex = 2
        '
        'lblSpacer
        '
        Me.lblSpacer.AutoSize = True
        Me.lblSpacer.Location = New System.Drawing.Point(400, 37)
        Me.lblSpacer.Name = "lblSpacer"
        Me.lblSpacer.Size = New System.Drawing.Size(234, 29)
        Me.lblSpacer.TabIndex = 3
        Me.lblSpacer.Text = "Spacer Grid Material"
        '
        'txtSPASpacerGrid
        '
        Me.txtSPASpacerGrid.Location = New System.Drawing.Point(640, 34)
        Me.txtSPASpacerGrid.Name = "txtSPASpacerGrid"
        Me.txtSPASpacerGrid.Size = New System.Drawing.Size(180, 35)
        Me.txtSPASpacerGrid.TabIndex = 1
        '
        'lblCoolant
        '
        Me.lblCoolant.AutoSize = True
        Me.lblCoolant.Location = New System.Drawing.Point(6, 37)
        Me.lblCoolant.Name = "lblCoolant"
        Me.lblCoolant.Size = New System.Drawing.Size(188, 29)
        Me.lblCoolant.TabIndex = 1
        Me.lblCoolant.Text = "Coolant Material"
        '
        'txtSPACoolant
        '
        Me.txtSPACoolant.Location = New System.Drawing.Point(200, 34)
        Me.txtSPACoolant.Name = "txtSPACoolant"
        Me.txtSPACoolant.Size = New System.Drawing.Size(194, 35)
        Me.txtSPACoolant.TabIndex = 0
        '
        'gbxPIN
        '
        Me.gbxPIN.Controls.Add(Me.btnAdd)
        Me.gbxPIN.Controls.Add(Me.pbxPreview)
        Me.gbxPIN.Controls.Add(Me.lbxPinList)
        Me.gbxPIN.Controls.Add(Me.btnRemove)
        Me.gbxPIN.Controls.Add(Me.btnGenerate)
        Me.gbxPIN.Controls.Add(Me.lbxPinInfo)
        Me.gbxPIN.Controls.Add(Me.cbxMaterial)
        Me.gbxPIN.Controls.Add(Me.lblTemperature)
        Me.gbxPIN.Controls.Add(Me.txtTemperature)
        Me.gbxPIN.Controls.Add(Me.lblMaterial)
        Me.gbxPIN.Controls.Add(Me.lblRadius)
        Me.gbxPIN.Controls.Add(Me.txtOuterRadius)
        Me.gbxPIN.Controls.Add(Me.lblOuterSubdivision)
        Me.gbxPIN.Controls.Add(Me.txtOuterSubdivision)
        Me.gbxPIN.Controls.Add(Me.lblInnerSubdivision)
        Me.gbxPIN.Controls.Add(Me.txtInnerSubdivision)
        Me.gbxPIN.Controls.Add(Me.lblSector)
        Me.gbxPIN.Controls.Add(Me.txtSector)
        Me.gbxPIN.Controls.Add(Me.lblPinNumber)
        Me.gbxPIN.Controls.Add(Me.txtPinID)
        Me.gbxPIN.Location = New System.Drawing.Point(19, 218)
        Me.gbxPIN.Name = "gbxPIN"
        Me.gbxPIN.Size = New System.Drawing.Size(1290, 513)
        Me.gbxPIN.TabIndex = 2
        Me.gbxPIN.TabStop = False
        Me.gbxPIN.Text = "PIN Card"
        '
        'btnAdd
        '
        Me.btnAdd.FlatAppearance.BorderSize = 2
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(633, 154)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(141, 40)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'pbxPreview
        '
        Me.pbxPreview.Location = New System.Drawing.Point(794, 17)
        Me.pbxPreview.Name = "pbxPreview"
        Me.pbxPreview.Size = New System.Drawing.Size(490, 490)
        Me.pbxPreview.TabIndex = 20
        Me.pbxPreview.TabStop = False
        '
        'lbxPinList
        '
        Me.lbxPinList.FormattingEnabled = True
        Me.lbxPinList.ItemHeight = 29
        Me.lbxPinList.Location = New System.Drawing.Point(6, 370)
        Me.lbxPinList.Name = "lbxPinList"
        Me.lbxPinList.Size = New System.Drawing.Size(768, 120)
        Me.lbxPinList.TabIndex = 11
        '
        'btnRemove
        '
        Me.btnRemove.FlatAppearance.BorderSize = 2
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnRemove.Location = New System.Drawing.Point(468, 324)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(159, 40)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "Remove &Pin"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.FlatAppearance.BorderSize = 2
        Me.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnGenerate.Location = New System.Drawing.Point(633, 324)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(141, 40)
        Me.btnGenerate.TabIndex = 10
        Me.btnGenerate.Text = "&Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lbxPinInfo
        '
        Me.lbxPinInfo.FormattingEnabled = True
        Me.lbxPinInfo.ItemHeight = 29
        Me.lbxPinInfo.Location = New System.Drawing.Point(6, 198)
        Me.lbxPinInfo.Name = "lbxPinInfo"
        Me.lbxPinInfo.Size = New System.Drawing.Size(768, 120)
        Me.lbxPinInfo.TabIndex = 8
        '
        'cbxMaterial
        '
        Me.cbxMaterial.FormattingEnabled = True
        Me.cbxMaterial.Location = New System.Drawing.Point(481, 116)
        Me.cbxMaterial.Name = "cbxMaterial"
        Me.cbxMaterial.Size = New System.Drawing.Size(206, 37)
        Me.cbxMaterial.TabIndex = 5
        '
        'lblTemperature
        '
        Me.lblTemperature.AutoSize = True
        Me.lblTemperature.Location = New System.Drawing.Point(6, 160)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(191, 29)
        Me.lblTemperature.TabIndex = 13
        Me.lblTemperature.Text = "Temperature (K)"
        '
        'txtTemperature
        '
        Me.txtTemperature.Location = New System.Drawing.Point(203, 157)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(144, 35)
        Me.txtTemperature.TabIndex = 6
        '
        'lblMaterial
        '
        Me.lblMaterial.AutoSize = True
        Me.lblMaterial.Location = New System.Drawing.Point(376, 119)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(99, 29)
        Me.lblMaterial.TabIndex = 11
        Me.lblMaterial.Text = "Material"
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Location = New System.Drawing.Point(6, 119)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(208, 29)
        Me.lblRadius.TabIndex = 9
        Me.lblRadius.Text = "Outer Radius (cm)"
        '
        'txtOuterRadius
        '
        Me.txtOuterRadius.Location = New System.Drawing.Point(220, 116)
        Me.txtOuterRadius.Name = "txtOuterRadius"
        Me.txtOuterRadius.Size = New System.Drawing.Size(150, 35)
        Me.txtOuterRadius.TabIndex = 4
        '
        'lblOuterSubdivision
        '
        Me.lblOuterSubdivision.AutoSize = True
        Me.lblOuterSubdivision.Location = New System.Drawing.Point(390, 78)
        Me.lblOuterSubdivision.Name = "lblOuterSubdivision"
        Me.lblOuterSubdivision.Size = New System.Drawing.Size(288, 29)
        Me.lblOuterSubdivision.TabIndex = 7
        Me.lblOuterSubdivision.Text = "Outer Region Subdivision"
        '
        'txtOuterSubdivision
        '
        Me.txtOuterSubdivision.Location = New System.Drawing.Point(684, 75)
        Me.txtOuterSubdivision.Name = "txtOuterSubdivision"
        Me.txtOuterSubdivision.Size = New System.Drawing.Size(90, 35)
        Me.txtOuterSubdivision.TabIndex = 3
        '
        'lblInnerSubdivision
        '
        Me.lblInnerSubdivision.AutoSize = True
        Me.lblInnerSubdivision.Location = New System.Drawing.Point(6, 78)
        Me.lblInnerSubdivision.Name = "lblInnerSubdivision"
        Me.lblInnerSubdivision.Size = New System.Drawing.Size(282, 29)
        Me.lblInnerSubdivision.TabIndex = 5
        Me.lblInnerSubdivision.Text = "Inner Region Subdivision"
        '
        'txtInnerSubdivision
        '
        Me.txtInnerSubdivision.Location = New System.Drawing.Point(294, 75)
        Me.txtInnerSubdivision.Name = "txtInnerSubdivision"
        Me.txtInnerSubdivision.Size = New System.Drawing.Size(90, 35)
        Me.txtInnerSubdivision.TabIndex = 2
        '
        'lblSector
        '
        Me.lblSector.AutoSize = True
        Me.lblSector.Location = New System.Drawing.Point(156, 37)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(214, 29)
        Me.lblSector.TabIndex = 3
        Me.lblSector.Text = "Number of Sectors"
        '
        'txtSector
        '
        Me.txtSector.Location = New System.Drawing.Point(376, 34)
        Me.txtSector.Name = "txtSector"
        Me.txtSector.Size = New System.Drawing.Size(144, 35)
        Me.txtSector.TabIndex = 1
        '
        'lblPinNumber
        '
        Me.lblPinNumber.AutoSize = True
        Me.lblPinNumber.Location = New System.Drawing.Point(6, 37)
        Me.lblPinNumber.Name = "lblPinNumber"
        Me.lblPinNumber.Size = New System.Drawing.Size(67, 29)
        Me.lblPinNumber.TabIndex = 1
        Me.lblPinNumber.Text = "Pin #"
        '
        'txtPinID
        '
        Me.txtPinID.Location = New System.Drawing.Point(79, 34)
        Me.txtPinID.Name = "txtPinID"
        Me.txtPinID.Size = New System.Drawing.Size(71, 35)
        Me.txtPinID.TabIndex = 0
        '
        'gbxCORE
        '
        Me.gbxCORE.Controls.Add(Me.lblAssemNumberY)
        Me.gbxCORE.Controls.Add(Me.txtCOREAssemY)
        Me.gbxCORE.Controls.Add(Me.lblFAIndex)
        Me.gbxCORE.Controls.Add(Me.txtCOREAssemIndex)
        Me.gbxCORE.Controls.Add(Me.lblAssemNumberX)
        Me.gbxCORE.Controls.Add(Me.txtCOREAssemX)
        Me.gbxCORE.Location = New System.Drawing.Point(19, 737)
        Me.gbxCORE.Name = "gbxCORE"
        Me.gbxCORE.Size = New System.Drawing.Size(774, 153)
        Me.gbxCORE.TabIndex = 3
        Me.gbxCORE.TabStop = False
        Me.gbxCORE.Text = "CORE Card"
        '
        'lblAssemNumberY
        '
        Me.lblAssemNumberY.AutoSize = True
        Me.lblAssemNumberY.Location = New System.Drawing.Point(6, 78)
        Me.lblAssemNumberY.Name = "lblAssemNumberY"
        Me.lblAssemNumberY.Size = New System.Drawing.Size(400, 29)
        Me.lblAssemNumberY.TabIndex = 5
        Me.lblAssemNumberY.Text = "Number of Assemblies in y-direction"
        '
        'txtCOREAssemY
        '
        Me.txtCOREAssemY.Location = New System.Drawing.Point(436, 75)
        Me.txtCOREAssemY.Name = "txtCOREAssemY"
        Me.txtCOREAssemY.Size = New System.Drawing.Size(201, 35)
        Me.txtCOREAssemY.TabIndex = 1
        '
        'lblFAIndex
        '
        Me.lblFAIndex.AutoSize = True
        Me.lblFAIndex.Location = New System.Drawing.Point(6, 119)
        Me.lblFAIndex.Name = "lblFAIndex"
        Me.lblFAIndex.Size = New System.Drawing.Size(235, 29)
        Me.lblFAIndex.TabIndex = 3
        Me.lblFAIndex.Text = "Fuel Assembly Index"
        '
        'txtCOREAssemIndex
        '
        Me.txtCOREAssemIndex.Location = New System.Drawing.Point(396, 116)
        Me.txtCOREAssemIndex.Name = "txtCOREAssemIndex"
        Me.txtCOREAssemIndex.Size = New System.Drawing.Size(204, 35)
        Me.txtCOREAssemIndex.TabIndex = 2
        '
        'lblAssemNumberX
        '
        Me.lblAssemNumberX.AutoSize = True
        Me.lblAssemNumberX.Location = New System.Drawing.Point(6, 37)
        Me.lblAssemNumberX.Name = "lblAssemNumberX"
        Me.lblAssemNumberX.Size = New System.Drawing.Size(400, 29)
        Me.lblAssemNumberX.TabIndex = 1
        Me.lblAssemNumberX.Text = "Number of Assemblies in x-direction"
        '
        'txtCOREAssemX
        '
        Me.txtCOREAssemX.Location = New System.Drawing.Point(422, 34)
        Me.txtCOREAssemX.Name = "txtCOREAssemX"
        Me.txtCOREAssemX.Size = New System.Drawing.Size(205, 35)
        Me.txtCOREAssemX.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.FlatAppearance.BorderSize = 2
        Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(809, 762)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(231, 47)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 2
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(809, 815)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(231, 70)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close without Saving"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(1046, 762)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(263, 123)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Assem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1321, 902)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.gbxCORE)
        Me.Controls.Add(Me.gbxPIN)
        Me.Controls.Add(Me.gbxSPA)
        Me.Controls.Add(Me.gbxLINK)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.MaximizeBox = False
        Me.Name = "Assem"
        Me.Text = "Assem"
        Me.gbxLINK.ResumeLayout(False)
        Me.gbxLINK.PerformLayout()
        Me.gbxSPA.ResumeLayout(False)
        Me.gbxSPA.PerformLayout()
        Me.gbxPIN.ResumeLayout(False)
        Me.gbxPIN.PerformLayout()
        CType(Me.pbxPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCORE.ResumeLayout(False)
        Me.gbxCORE.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents gbxLINK As GroupBox
    Friend WithEvents chkLINK_FA As CheckBox
    Friend WithEvents chkLINK_MAT As CheckBox
    Friend WithEvents chkLINK_OPTION As CheckBox
    Friend WithEvents gbxSPA As GroupBox
    Friend WithEvents lblDensity As Label
    Friend WithEvents txtSPALinDensity As TextBox
    Friend WithEvents lblSpacer As Label
    Friend WithEvents txtSPASpacerGrid As TextBox
    Friend WithEvents lblCoolant As Label
    Friend WithEvents txtSPACoolant As TextBox
    Friend WithEvents gbxPIN As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents pbxPreview As PictureBox
    Friend WithEvents lbxPinList As ListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lbxPinInfo As ListBox
    Friend WithEvents cbxMaterial As ComboBox
    Friend WithEvents lblTemperature As Label
    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents lblMaterial As Label
    Friend WithEvents lblRadius As Label
    Friend WithEvents txtOuterRadius As TextBox
    Friend WithEvents lblOuterSubdivision As Label
    Friend WithEvents txtOuterSubdivision As TextBox
    Friend WithEvents lblInnerSubdivision As Label
    Friend WithEvents txtInnerSubdivision As TextBox
    Friend WithEvents lblSector As Label
    Friend WithEvents txtSector As TextBox
    Friend WithEvents lblPinNumber As Label
    Friend WithEvents txtPinID As TextBox
    Friend WithEvents gbxCORE As GroupBox
    Friend WithEvents lblAssemNumberY As Label
    Friend WithEvents txtCOREAssemY As TextBox
    Friend WithEvents lblFAIndex As Label
    Friend WithEvents txtCOREAssemIndex As TextBox
    Friend WithEvents lblAssemNumberX As Label
    Friend WithEvents txtCOREAssemX As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
End Class
