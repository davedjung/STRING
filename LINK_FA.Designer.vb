<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LINK_FA))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaterialTemp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFAMaterial = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPinPitch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPinNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFAIndex = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEraseAll = New System.Windows.Forms.Button()
        Me.btnErase = New System.Windows.Forms.Button()
        Me.btnClearSelection = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnSetPin = New System.Windows.Forms.Button()
        Me.btnCreateFA = New System.Windows.Forms.Button()
        Me.pbxFA = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbxPinInfo = New System.Windows.Forms.ListBox()
        Me.pbxPin = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbxPinList = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxAssemFile = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtPinPitchCalc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPinNoCalc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAssemPitchCalc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHalfAssemGap = New System.Windows.Forms.TextBox()
        Me.lbxFAList = New System.Windows.Forms.ListBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbxFA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pbxPin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(570, 37)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "LINK_FA_[Reactor].dat Configurator"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMaterialTemp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtFAMaterial)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPinPitch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPinNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFAIndex)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1278, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Header"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(376, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(334, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Material Inlet Temperature (K)"
        '
        'txtMaterialTemp
        '
        Me.txtMaterialTemp.Location = New System.Drawing.Point(716, 75)
        Me.txtMaterialTemp.Name = "txtMaterialTemp"
        Me.txtMaterialTemp.Size = New System.Drawing.Size(152, 35)
        Me.txtMaterialTemp.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Material Filled in FA"
        '
        'txtFAMaterial
        '
        Me.txtFAMaterial.Location = New System.Drawing.Point(239, 75)
        Me.txtFAMaterial.Name = "txtFAMaterial"
        Me.txtFAMaterial.Size = New System.Drawing.Size(131, 35)
        Me.txtFAMaterial.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(695, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Pin Pitch (cm)"
        '
        'txtPinPitch
        '
        Me.txtPinPitch.Location = New System.Drawing.Point(862, 34)
        Me.txtPinPitch.Name = "txtPinPitch"
        Me.txtPinPitch.Size = New System.Drawing.Size(82, 35)
        Me.txtPinPitch.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "# of Pinx in x-direction"
        '
        'txtPinNo
        '
        Me.txtPinNo.Location = New System.Drawing.Point(607, 34)
        Me.txtPinNo.Name = "txtPinNo"
        Me.txtPinNo.Size = New System.Drawing.Size(82, 35)
        Me.txtPinNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fuel Assembly Index #"
        '
        'txtFAIndex
        '
        Me.txtFAIndex.Location = New System.Drawing.Point(266, 34)
        Me.txtFAIndex.Name = "txtFAIndex"
        Me.txtFAIndex.Size = New System.Drawing.Size(82, 35)
        Me.txtFAIndex.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.btnEraseAll)
        Me.GroupBox2.Controls.Add(Me.btnErase)
        Me.GroupBox2.Controls.Add(Me.btnClearSelection)
        Me.GroupBox2.Controls.Add(Me.btnSelectAll)
        Me.GroupBox2.Controls.Add(Me.btnSetPin)
        Me.GroupBox2.Controls.Add(Me.btnCreateFA)
        Me.GroupBox2.Controls.Add(Me.pbxFA)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(621, 453)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fuel Assembly Overview"
        '
        'btnAdd
        '
        Me.btnAdd.FlatAppearance.BorderSize = 2
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(425, 314)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(190, 41)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "&Add to List"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEraseAll
        '
        Me.btnEraseAll.FlatAppearance.BorderSize = 2
        Me.btnEraseAll.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEraseAll.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnEraseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEraseAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnEraseAll.Location = New System.Drawing.Point(425, 267)
        Me.btnEraseAll.Name = "btnEraseAll"
        Me.btnEraseAll.Size = New System.Drawing.Size(190, 41)
        Me.btnEraseAll.TabIndex = 5
        Me.btnEraseAll.Text = "Erase All"
        Me.btnEraseAll.UseVisualStyleBackColor = True
        '
        'btnErase
        '
        Me.btnErase.FlatAppearance.BorderSize = 2
        Me.btnErase.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnErase.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnErase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnErase.Location = New System.Drawing.Point(425, 220)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(190, 41)
        Me.btnErase.TabIndex = 4
        Me.btnErase.Text = "&Erase"
        Me.btnErase.UseVisualStyleBackColor = True
        '
        'btnClearSelection
        '
        Me.btnClearSelection.FlatAppearance.BorderSize = 2
        Me.btnClearSelection.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClearSelection.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnClearSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearSelection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnClearSelection.Location = New System.Drawing.Point(425, 173)
        Me.btnClearSelection.Name = "btnClearSelection"
        Me.btnClearSelection.Size = New System.Drawing.Size(190, 41)
        Me.btnClearSelection.TabIndex = 3
        Me.btnClearSelection.Text = "Clear Selection"
        Me.btnClearSelection.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.FlatAppearance.BorderSize = 2
        Me.btnSelectAll.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSelectAll.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnSelectAll.Location = New System.Drawing.Point(425, 126)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(190, 41)
        Me.btnSelectAll.TabIndex = 2
        Me.btnSelectAll.Text = "Select All"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'btnSetPin
        '
        Me.btnSetPin.FlatAppearance.BorderSize = 2
        Me.btnSetPin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSetPin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSetPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetPin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnSetPin.Location = New System.Drawing.Point(425, 79)
        Me.btnSetPin.Name = "btnSetPin"
        Me.btnSetPin.Size = New System.Drawing.Size(190, 41)
        Me.btnSetPin.TabIndex = 1
        Me.btnSetPin.Text = "Set Pin &#"
        Me.btnSetPin.UseVisualStyleBackColor = True
        '
        'btnCreateFA
        '
        Me.btnCreateFA.FlatAppearance.BorderSize = 2
        Me.btnCreateFA.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCreateFA.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCreateFA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateFA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnCreateFA.Location = New System.Drawing.Point(425, 30)
        Me.btnCreateFA.Name = "btnCreateFA"
        Me.btnCreateFA.Size = New System.Drawing.Size(190, 41)
        Me.btnCreateFA.TabIndex = 0
        Me.btnCreateFA.Text = "Create &FA"
        Me.btnCreateFA.UseVisualStyleBackColor = True
        '
        'pbxFA
        '
        Me.pbxFA.Location = New System.Drawing.Point(11, 34)
        Me.pbxFA.Name = "pbxFA"
        Me.pbxFA.Size = New System.Drawing.Size(408, 408)
        Me.pbxFA.TabIndex = 0
        Me.pbxFA.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbxPinInfo)
        Me.GroupBox3.Controls.Add(Me.pbxPin)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lbxPinList)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cbxAssemFile)
        Me.GroupBox3.Location = New System.Drawing.Point(639, 176)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(652, 453)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pin Information"
        '
        'lbxPinInfo
        '
        Me.lbxPinInfo.FormattingEnabled = True
        Me.lbxPinInfo.ItemHeight = 29
        Me.lbxPinInfo.Location = New System.Drawing.Point(277, 174)
        Me.lbxPinInfo.Name = "lbxPinInfo"
        Me.lbxPinInfo.Size = New System.Drawing.Size(369, 265)
        Me.lbxPinInfo.TabIndex = 2
        '
        'pbxPin
        '
        Me.pbxPin.Location = New System.Drawing.Point(6, 174)
        Me.pbxPin.Name = "pbxPin"
        Me.pbxPin.Size = New System.Drawing.Size(265, 265)
        Me.pbxPin.TabIndex = 4
        Me.pbxPin.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 29)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "List of Pin(s) Defined"
        '
        'lbxPinList
        '
        Me.lbxPinList.FormattingEnabled = True
        Me.lbxPinList.ItemHeight = 29
        Me.lbxPinList.Location = New System.Drawing.Point(247, 77)
        Me.lbxPinList.Name = "lbxPinList"
        Me.lbxPinList.Size = New System.Drawing.Size(399, 91)
        Me.lbxPinList.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(383, 29)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Select [Reactor]_Assem_#.inp File"
        '
        'cbxAssemFile
        '
        Me.cbxAssemFile.FormattingEnabled = True
        Me.cbxAssemFile.Location = New System.Drawing.Point(395, 34)
        Me.cbxAssemFile.Name = "cbxAssemFile"
        Me.cbxAssemFile.Size = New System.Drawing.Size(251, 37)
        Me.cbxAssemFile.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnCalculate)
        Me.GroupBox4.Controls.Add(Me.txtPinPitchCalc)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtPinNoCalc)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtAssemPitchCalc)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtHalfAssemGap)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 635)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1279, 122)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Assembly Gap"
        '
        'btnCalculate
        '
        Me.btnCalculate.FlatAppearance.BorderSize = 2
        Me.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnCalculate.Location = New System.Drawing.Point(1082, 72)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(191, 40)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtPinPitchCalc
        '
        Me.txtPinPitchCalc.Location = New System.Drawing.Point(906, 75)
        Me.txtPinPitchCalc.Name = "txtPinPitchCalc"
        Me.txtPinPitchCalc.Size = New System.Drawing.Size(170, 35)
        Me.txtPinPitchCalc.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(739, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 29)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Pin Pitch (cm)"
        '
        'txtPinNoCalc
        '
        Me.txtPinNoCalc.Location = New System.Drawing.Point(656, 75)
        Me.txtPinNoCalc.Name = "txtPinNoCalc"
        Me.txtPinNoCalc.Size = New System.Drawing.Size(77, 35)
        Me.txtPinNoCalc.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(545, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 29)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "# of Pins"
        '
        'txtAssemPitchCalc
        '
        Me.txtAssemPitchCalc.Location = New System.Drawing.Point(369, 75)
        Me.txtAssemPitchCalc.Name = "txtAssemPitchCalc"
        Me.txtAssemPitchCalc.Size = New System.Drawing.Size(170, 35)
        Me.txtAssemPitchCalc.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(133, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(230, 29)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Assembly Pitch (cm)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 29)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Calculator"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(296, 29)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Half of Assembly Gap (cm)"
        '
        'txtHalfAssemGap
        '
        Me.txtHalfAssemGap.Location = New System.Drawing.Point(308, 34)
        Me.txtHalfAssemGap.Name = "txtHalfAssemGap"
        Me.txtHalfAssemGap.Size = New System.Drawing.Size(173, 35)
        Me.txtHalfAssemGap.TabIndex = 0
        '
        'lbxFAList
        '
        Me.lbxFAList.FormattingEnabled = True
        Me.lbxFAList.ItemHeight = 29
        Me.lbxFAList.Location = New System.Drawing.Point(12, 763)
        Me.lbxFAList.Name = "lbxFAList"
        Me.lbxFAList.Size = New System.Drawing.Size(857, 149)
        Me.lbxFAList.TabIndex = 4
        '
        'btnReset
        '
        Me.btnReset.FlatAppearance.BorderSize = 2
        Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(881, 763)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(171, 53)
        Me.btnReset.TabIndex = 5
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
        Me.btnClose.Location = New System.Drawing.Point(881, 822)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(171, 90)
        Me.btnClose.TabIndex = 6
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
        Me.btnSave.Location = New System.Drawing.Point(1058, 763)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(233, 149)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'LINK_FA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1299, 924)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lbxFAList)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.MaximizeBox = False
        Me.Name = "LINK_FA"
        Me.Text = "LINK_FA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pbxFA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pbxPin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMaterialTemp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFAMaterial As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPinPitch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPinNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFAIndex As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEraseAll As Button
    Friend WithEvents btnErase As Button
    Friend WithEvents btnClearSelection As Button
    Friend WithEvents btnSelectAll As Button
    Friend WithEvents btnSetPin As Button
    Friend WithEvents btnCreateFA As Button
    Friend WithEvents pbxFA As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbxPinInfo As ListBox
    Friend WithEvents pbxPin As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbxPinList As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxAssemFile As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtPinPitchCalc As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPinNoCalc As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAssemPitchCalc As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHalfAssemGap As TextBox
    Friend WithEvents lbxFAList As ListBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
End Class
