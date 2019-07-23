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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gbxLINK = New System.Windows.Forms.GroupBox()
        Me.chkLINK_FA = New System.Windows.Forms.CheckBox()
        Me.chkLINK_MAT = New System.Windows.Forms.CheckBox()
        Me.chkLINK_OPTION = New System.Windows.Forms.CheckBox()
        Me.gbxSPA = New System.Windows.Forms.GroupBox()
        Me.lblSPALinDensity = New System.Windows.Forms.Label()
        Me.txtSPALinDensity = New System.Windows.Forms.TextBox()
        Me.lblSPASpacerGrid = New System.Windows.Forms.Label()
        Me.lblSPACoolant = New System.Windows.Forms.Label()
        Me.txtSPASpacerGrid = New System.Windows.Forms.TextBox()
        Me.txtSPACoolant = New System.Windows.Forms.TextBox()
        Me.gbxPIN = New System.Windows.Forms.GroupBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.pbxPreview = New System.Windows.Forms.PictureBox()
        Me.lbxPinList = New System.Windows.Forms.ListBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lbxPinInfo = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.cbxMaterial = New System.Windows.Forms.ComboBox()
        Me.lblPinMaterial = New System.Windows.Forms.Label()
        Me.txtOuterRadius = New System.Windows.Forms.TextBox()
        Me.lblOuterRadius = New System.Windows.Forms.Label()
        Me.txtOuterSubdivision = New System.Windows.Forms.TextBox()
        Me.lblOuterSubdivision = New System.Windows.Forms.Label()
        Me.txtInnerSubdivision = New System.Windows.Forms.TextBox()
        Me.lblInnerSubdivision = New System.Windows.Forms.Label()
        Me.txtSector = New System.Windows.Forms.TextBox()
        Me.lblSector = New System.Windows.Forms.Label()
        Me.txtPinID = New System.Windows.Forms.TextBox()
        Me.lblPinID = New System.Windows.Forms.Label()
        Me.gbxCORE = New System.Windows.Forms.GroupBox()
        Me.txtCOREAssemIndex = New System.Windows.Forms.TextBox()
        Me.lblCOREAssemIndex = New System.Windows.Forms.Label()
        Me.txtCOREAssemY = New System.Windows.Forms.TextBox()
        Me.lblCOREAssemY = New System.Windows.Forms.Label()
        Me.txtCOREAssemX = New System.Windows.Forms.TextBox()
        Me.lblCOREAssemX = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
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
        Me.lblTitle.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(412, 25)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "[Reactor Core]_Assem_#.inp Configurator"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbxLINK
        '
        Me.gbxLINK.Controls.Add(Me.chkLINK_FA)
        Me.gbxLINK.Controls.Add(Me.chkLINK_MAT)
        Me.gbxLINK.Controls.Add(Me.chkLINK_OPTION)
        Me.gbxLINK.Location = New System.Drawing.Point(17, 37)
        Me.gbxLINK.Name = "gbxLINK"
        Me.gbxLINK.Size = New System.Drawing.Size(407, 69)
        Me.gbxLINK.TabIndex = 0
        Me.gbxLINK.TabStop = False
        Me.gbxLINK.Text = "LINK Header"
        '
        'chkLINK_FA
        '
        Me.chkLINK_FA.AutoSize = True
        Me.chkLINK_FA.Checked = True
        Me.chkLINK_FA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLINK_FA.Location = New System.Drawing.Point(203, 45)
        Me.chkLINK_FA.Name = "chkLINK_FA"
        Me.chkLINK_FA.Size = New System.Drawing.Size(173, 19)
        Me.chkLINK_FA.TabIndex = 2
        Me.chkLINK_FA.Text = "LINK_FA_[Reactor Code].dat"
        Me.chkLINK_FA.UseVisualStyleBackColor = True
        '
        'chkLINK_MAT
        '
        Me.chkLINK_MAT.AutoSize = True
        Me.chkLINK_MAT.Checked = True
        Me.chkLINK_MAT.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLINK_MAT.Location = New System.Drawing.Point(6, 45)
        Me.chkLINK_MAT.Name = "chkLINK_MAT"
        Me.chkLINK_MAT.Size = New System.Drawing.Size(186, 19)
        Me.chkLINK_MAT.TabIndex = 1
        Me.chkLINK_MAT.Text = "LINK_MAT_[Reactor Code].dat"
        Me.chkLINK_MAT.UseVisualStyleBackColor = True
        '
        'chkLINK_OPTION
        '
        Me.chkLINK_OPTION.AutoSize = True
        Me.chkLINK_OPTION.Checked = True
        Me.chkLINK_OPTION.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLINK_OPTION.Location = New System.Drawing.Point(6, 20)
        Me.chkLINK_OPTION.Name = "chkLINK_OPTION"
        Me.chkLINK_OPTION.Size = New System.Drawing.Size(204, 19)
        Me.chkLINK_OPTION.TabIndex = 0
        Me.chkLINK_OPTION.Text = "LINK_OPTION_[Reactor Code].dat"
        Me.chkLINK_OPTION.UseVisualStyleBackColor = True
        '
        'gbxSPA
        '
        Me.gbxSPA.Controls.Add(Me.lblSPALinDensity)
        Me.gbxSPA.Controls.Add(Me.txtSPALinDensity)
        Me.gbxSPA.Controls.Add(Me.lblSPASpacerGrid)
        Me.gbxSPA.Controls.Add(Me.lblSPACoolant)
        Me.gbxSPA.Controls.Add(Me.txtSPASpacerGrid)
        Me.gbxSPA.Controls.Add(Me.txtSPACoolant)
        Me.gbxSPA.Location = New System.Drawing.Point(430, 37)
        Me.gbxSPA.Name = "gbxSPA"
        Me.gbxSPA.Size = New System.Drawing.Size(407, 69)
        Me.gbxSPA.TabIndex = 1
        Me.gbxSPA.TabStop = False
        Me.gbxSPA.Text = "SPA Card"
        '
        'lblSPALinDensity
        '
        Me.lblSPALinDensity.AutoSize = True
        Me.lblSPALinDensity.Location = New System.Drawing.Point(196, 46)
        Me.lblSPALinDensity.Name = "lblSPALinDensity"
        Me.lblSPALinDensity.Size = New System.Drawing.Size(112, 15)
        Me.lblSPALinDensity.TabIndex = 5
        Me.lblSPALinDensity.Text = "Linear Density (g/cm)"
        '
        'txtSPALinDensity
        '
        Me.txtSPALinDensity.Location = New System.Drawing.Point(314, 43)
        Me.txtSPALinDensity.Name = "txtSPALinDensity"
        Me.txtSPALinDensity.Size = New System.Drawing.Size(87, 21)
        Me.txtSPALinDensity.TabIndex = 2
        '
        'lblSPASpacerGrid
        '
        Me.lblSPASpacerGrid.AutoSize = True
        Me.lblSPASpacerGrid.Location = New System.Drawing.Point(6, 46)
        Me.lblSPASpacerGrid.Name = "lblSPASpacerGrid"
        Me.lblSPASpacerGrid.Size = New System.Drawing.Size(108, 15)
        Me.lblSPASpacerGrid.TabIndex = 3
        Me.lblSPASpacerGrid.Text = "Spacer Grid Material"
        '
        'lblSPACoolant
        '
        Me.lblSPACoolant.AutoSize = True
        Me.lblSPACoolant.Location = New System.Drawing.Point(6, 21)
        Me.lblSPACoolant.Name = "lblSPACoolant"
        Me.lblSPACoolant.Size = New System.Drawing.Size(89, 15)
        Me.lblSPACoolant.TabIndex = 1
        Me.lblSPACoolant.Text = "Coolant Material"
        '
        'txtSPASpacerGrid
        '
        Me.txtSPASpacerGrid.Location = New System.Drawing.Point(120, 43)
        Me.txtSPASpacerGrid.Name = "txtSPASpacerGrid"
        Me.txtSPASpacerGrid.Size = New System.Drawing.Size(70, 21)
        Me.txtSPASpacerGrid.TabIndex = 1
        '
        'txtSPACoolant
        '
        Me.txtSPACoolant.Location = New System.Drawing.Point(101, 18)
        Me.txtSPACoolant.Name = "txtSPACoolant"
        Me.txtSPACoolant.Size = New System.Drawing.Size(70, 21)
        Me.txtSPACoolant.TabIndex = 0
        '
        'gbxPIN
        '
        Me.gbxPIN.Controls.Add(Me.btnRemove)
        Me.gbxPIN.Controls.Add(Me.pbxPreview)
        Me.gbxPIN.Controls.Add(Me.lbxPinList)
        Me.gbxPIN.Controls.Add(Me.btnGenerate)
        Me.gbxPIN.Controls.Add(Me.lbxPinInfo)
        Me.gbxPIN.Controls.Add(Me.btnAdd)
        Me.gbxPIN.Controls.Add(Me.txtTemperature)
        Me.gbxPIN.Controls.Add(Me.lblTemperature)
        Me.gbxPIN.Controls.Add(Me.cbxMaterial)
        Me.gbxPIN.Controls.Add(Me.lblPinMaterial)
        Me.gbxPIN.Controls.Add(Me.txtOuterRadius)
        Me.gbxPIN.Controls.Add(Me.lblOuterRadius)
        Me.gbxPIN.Controls.Add(Me.txtOuterSubdivision)
        Me.gbxPIN.Controls.Add(Me.lblOuterSubdivision)
        Me.gbxPIN.Controls.Add(Me.txtInnerSubdivision)
        Me.gbxPIN.Controls.Add(Me.lblInnerSubdivision)
        Me.gbxPIN.Controls.Add(Me.txtSector)
        Me.gbxPIN.Controls.Add(Me.lblSector)
        Me.gbxPIN.Controls.Add(Me.txtPinID)
        Me.gbxPIN.Controls.Add(Me.lblPinID)
        Me.gbxPIN.Location = New System.Drawing.Point(17, 112)
        Me.gbxPIN.Name = "gbxPIN"
        Me.gbxPIN.Size = New System.Drawing.Size(820, 433)
        Me.gbxPIN.TabIndex = 2
        Me.gbxPIN.TabStop = False
        Me.gbxPIN.Text = "PIN Card"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(9, 285)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(188, 23)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "Remove Pin"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'pbxPreview
        '
        Me.pbxPreview.Location = New System.Drawing.Point(404, 13)
        Me.pbxPreview.Name = "pbxPreview"
        Me.pbxPreview.Size = New System.Drawing.Size(410, 410)
        Me.pbxPreview.TabIndex = 18
        Me.pbxPreview.TabStop = False
        '
        'lbxPinList
        '
        Me.lbxPinList.FormattingEnabled = True
        Me.lbxPinList.ItemHeight = 15
        Me.lbxPinList.Location = New System.Drawing.Point(9, 314)
        Me.lbxPinList.Name = "lbxPinList"
        Me.lbxPinList.Size = New System.Drawing.Size(382, 109)
        Me.lbxPinList.TabIndex = 11
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(203, 285)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(188, 23)
        Me.btnGenerate.TabIndex = 10
        Me.btnGenerate.Text = "&Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lbxPinInfo
        '
        Me.lbxPinInfo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxPinInfo.FormattingEnabled = True
        Me.lbxPinInfo.ItemHeight = 15
        Me.lbxPinInfo.Location = New System.Drawing.Point(9, 155)
        Me.lbxPinInfo.Name = "lbxPinInfo"
        Me.lbxPinInfo.Size = New System.Drawing.Size(382, 124)
        Me.lbxPinInfo.TabIndex = 8
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(203, 126)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(188, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtTemperature
        '
        Me.txtTemperature.Location = New System.Drawing.Point(100, 128)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(84, 21)
        Me.txtTemperature.TabIndex = 6
        '
        'lblTemperature
        '
        Me.lblTemperature.AutoSize = True
        Me.lblTemperature.Location = New System.Drawing.Point(6, 131)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(88, 15)
        Me.lblTemperature.TabIndex = 12
        Me.lblTemperature.Text = "Temperature (K)"
        '
        'cbxMaterial
        '
        Me.cbxMaterial.FormattingEnabled = True
        Me.cbxMaterial.Location = New System.Drawing.Point(255, 101)
        Me.cbxMaterial.Name = "cbxMaterial"
        Me.cbxMaterial.Size = New System.Drawing.Size(136, 23)
        Me.cbxMaterial.TabIndex = 5
        '
        'lblPinMaterial
        '
        Me.lblPinMaterial.AutoSize = True
        Me.lblPinMaterial.Location = New System.Drawing.Point(198, 104)
        Me.lblPinMaterial.Name = "lblPinMaterial"
        Me.lblPinMaterial.Size = New System.Drawing.Size(48, 15)
        Me.lblPinMaterial.TabIndex = 10
        Me.lblPinMaterial.Text = "Material"
        '
        'txtOuterRadius
        '
        Me.txtOuterRadius.Location = New System.Drawing.Point(108, 101)
        Me.txtOuterRadius.Name = "txtOuterRadius"
        Me.txtOuterRadius.Size = New System.Drawing.Size(84, 21)
        Me.txtOuterRadius.TabIndex = 4
        '
        'lblOuterRadius
        '
        Me.lblOuterRadius.AutoSize = True
        Me.lblOuterRadius.Location = New System.Drawing.Point(6, 104)
        Me.lblOuterRadius.Name = "lblOuterRadius"
        Me.lblOuterRadius.Size = New System.Drawing.Size(96, 15)
        Me.lblOuterRadius.TabIndex = 8
        Me.lblOuterRadius.Text = "Outer Radius (cm)"
        '
        'txtOuterSubdivision
        '
        Me.txtOuterSubdivision.Location = New System.Drawing.Point(281, 74)
        Me.txtOuterSubdivision.Name = "txtOuterSubdivision"
        Me.txtOuterSubdivision.Size = New System.Drawing.Size(110, 21)
        Me.txtOuterSubdivision.TabIndex = 3
        '
        'lblOuterSubdivision
        '
        Me.lblOuterSubdivision.AutoSize = True
        Me.lblOuterSubdivision.Location = New System.Drawing.Point(6, 77)
        Me.lblOuterSubdivision.Name = "lblOuterSubdivision"
        Me.lblOuterSubdivision.Size = New System.Drawing.Size(272, 15)
        Me.lblOuterSubdivision.TabIndex = 6
        Me.lblOuterSubdivision.Text = "Number of Radial Subdivision in the Outermost Region"
        '
        'txtInnerSubdivision
        '
        Me.txtInnerSubdivision.Location = New System.Drawing.Point(281, 47)
        Me.txtInnerSubdivision.Name = "txtInnerSubdivision"
        Me.txtInnerSubdivision.Size = New System.Drawing.Size(110, 21)
        Me.txtInnerSubdivision.TabIndex = 2
        '
        'lblInnerSubdivision
        '
        Me.lblInnerSubdivision.AutoSize = True
        Me.lblInnerSubdivision.Location = New System.Drawing.Point(6, 50)
        Me.lblInnerSubdivision.Name = "lblInnerSubdivision"
        Me.lblInnerSubdivision.Size = New System.Drawing.Size(269, 15)
        Me.lblInnerSubdivision.TabIndex = 4
        Me.lblInnerSubdivision.Text = "Number of Radial Subdivision in the Innermost Region"
        '
        'txtSector
        '
        Me.txtSector.Location = New System.Drawing.Point(212, 20)
        Me.txtSector.Name = "txtSector"
        Me.txtSector.Size = New System.Drawing.Size(70, 21)
        Me.txtSector.TabIndex = 1
        '
        'lblSector
        '
        Me.lblSector.AutoSize = True
        Me.lblSector.Location = New System.Drawing.Point(109, 23)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(97, 15)
        Me.lblSector.TabIndex = 2
        Me.lblSector.Text = "Number of Sectors"
        '
        'txtPinID
        '
        Me.txtPinID.Location = New System.Drawing.Point(44, 20)
        Me.txtPinID.Name = "txtPinID"
        Me.txtPinID.Size = New System.Drawing.Size(59, 21)
        Me.txtPinID.TabIndex = 0
        '
        'lblPinID
        '
        Me.lblPinID.AutoSize = True
        Me.lblPinID.Location = New System.Drawing.Point(6, 23)
        Me.lblPinID.Name = "lblPinID"
        Me.lblPinID.Size = New System.Drawing.Size(32, 15)
        Me.lblPinID.TabIndex = 0
        Me.lblPinID.Text = "Pin #"
        '
        'gbxCORE
        '
        Me.gbxCORE.Controls.Add(Me.txtCOREAssemIndex)
        Me.gbxCORE.Controls.Add(Me.lblCOREAssemIndex)
        Me.gbxCORE.Controls.Add(Me.txtCOREAssemY)
        Me.gbxCORE.Controls.Add(Me.lblCOREAssemY)
        Me.gbxCORE.Controls.Add(Me.txtCOREAssemX)
        Me.gbxCORE.Controls.Add(Me.lblCOREAssemX)
        Me.gbxCORE.Location = New System.Drawing.Point(17, 551)
        Me.gbxCORE.Name = "gbxCORE"
        Me.gbxCORE.Size = New System.Drawing.Size(407, 105)
        Me.gbxCORE.TabIndex = 3
        Me.gbxCORE.TabStop = False
        Me.gbxCORE.Text = "CORE Card"
        '
        'txtCOREAssemIndex
        '
        Me.txtCOREAssemIndex.Location = New System.Drawing.Point(212, 74)
        Me.txtCOREAssemIndex.Name = "txtCOREAssemIndex"
        Me.txtCOREAssemIndex.Size = New System.Drawing.Size(189, 21)
        Me.txtCOREAssemIndex.TabIndex = 2
        '
        'lblCOREAssemIndex
        '
        Me.lblCOREAssemIndex.AutoSize = True
        Me.lblCOREAssemIndex.Location = New System.Drawing.Point(6, 77)
        Me.lblCOREAssemIndex.Name = "lblCOREAssemIndex"
        Me.lblCOREAssemIndex.Size = New System.Drawing.Size(108, 15)
        Me.lblCOREAssemIndex.TabIndex = 4
        Me.lblCOREAssemIndex.Text = "Fuel Assembly Index"
        '
        'txtCOREAssemY
        '
        Me.txtCOREAssemY.Location = New System.Drawing.Point(212, 47)
        Me.txtCOREAssemY.Name = "txtCOREAssemY"
        Me.txtCOREAssemY.Size = New System.Drawing.Size(189, 21)
        Me.txtCOREAssemY.TabIndex = 1
        '
        'lblCOREAssemY
        '
        Me.lblCOREAssemY.AutoSize = True
        Me.lblCOREAssemY.Location = New System.Drawing.Point(6, 50)
        Me.lblCOREAssemY.Name = "lblCOREAssemY"
        Me.lblCOREAssemY.Size = New System.Drawing.Size(184, 15)
        Me.lblCOREAssemY.TabIndex = 2
        Me.lblCOREAssemY.Text = "Number of Assemblies in y-direction"
        '
        'txtCOREAssemX
        '
        Me.txtCOREAssemX.Location = New System.Drawing.Point(212, 20)
        Me.txtCOREAssemX.Name = "txtCOREAssemX"
        Me.txtCOREAssemX.Size = New System.Drawing.Size(189, 21)
        Me.txtCOREAssemX.TabIndex = 0
        '
        'lblCOREAssemX
        '
        Me.lblCOREAssemX.AutoSize = True
        Me.lblCOREAssemX.Location = New System.Drawing.Point(6, 23)
        Me.lblCOREAssemX.Name = "lblCOREAssemX"
        Me.lblCOREAssemX.Size = New System.Drawing.Size(182, 15)
        Me.lblCOREAssemX.TabIndex = 0
        Me.lblCOREAssemX.Text = "Number of Assemblies in x-direction"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(430, 551)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(67, 105)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(640, 551)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(197, 105)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(503, 551)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(131, 105)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close without Saving"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Assem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 673)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.gbxCORE)
        Me.Controls.Add(Me.gbxPIN)
        Me.Controls.Add(Me.gbxSPA)
        Me.Controls.Add(Me.gbxLINK)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Assem"
        Me.Text = "Configure [Reactor Core]_Assem_#.inp"
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
    Friend WithEvents lblSPALinDensity As Label
    Friend WithEvents txtSPALinDensity As TextBox
    Friend WithEvents lblSPASpacerGrid As Label
    Friend WithEvents lblSPACoolant As Label
    Friend WithEvents txtSPASpacerGrid As TextBox
    Friend WithEvents txtSPACoolant As TextBox
    Friend WithEvents gbxPIN As GroupBox
    Friend WithEvents pbxPreview As PictureBox
    Friend WithEvents lbxPinList As ListBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lbxPinInfo As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents lblTemperature As Label
    Friend WithEvents cbxMaterial As ComboBox
    Friend WithEvents lblPinMaterial As Label
    Friend WithEvents txtOuterRadius As TextBox
    Friend WithEvents lblOuterRadius As Label
    Friend WithEvents txtOuterSubdivision As TextBox
    Friend WithEvents lblOuterSubdivision As Label
    Friend WithEvents txtInnerSubdivision As TextBox
    Friend WithEvents lblInnerSubdivision As Label
    Friend WithEvents txtSector As TextBox
    Friend WithEvents lblSector As Label
    Friend WithEvents txtPinID As TextBox
    Friend WithEvents lblPinID As Label
    Friend WithEvents gbxCORE As GroupBox
    Friend WithEvents txtCOREAssemIndex As TextBox
    Friend WithEvents lblCOREAssemIndex As Label
    Friend WithEvents txtCOREAssemY As TextBox
    Friend WithEvents lblCOREAssemY As Label
    Friend WithEvents txtCOREAssemX As TextBox
    Friend WithEvents lblCOREAssemX As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRemove As Button
End Class
