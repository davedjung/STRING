<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LINK_MAT
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
        Me.gbxMAT = New System.Windows.Forms.GroupBox()
        Me.txtMATNumberDensityE = New System.Windows.Forms.TextBox()
        Me.lblE = New System.Windows.Forms.Label()
        Me.btnMATRemoveMaterial = New System.Windows.Forms.Button()
        Me.btnMATRemoveElement = New System.Windows.Forms.Button()
        Me.btnMATGenerateCustomMaterial = New System.Windows.Forms.Button()
        Me.lbxMATCustom = New System.Windows.Forms.ListBox()
        Me.btnMATAddCustomElement = New System.Windows.Forms.Button()
        Me.btnMATGenerateMaterial = New System.Windows.Forms.Button()
        Me.txtMATOption2 = New System.Windows.Forms.TextBox()
        Me.lblCreateCustom = New System.Windows.Forms.Label()
        Me.lbxMAT = New System.Windows.Forms.ListBox()
        Me.chkMATMaterialBURN = New System.Windows.Forms.CheckBox()
        Me.lblMATMaterialNameCustom = New System.Windows.Forms.Label()
        Me.lblMATOption2 = New System.Windows.Forms.Label()
        Me.txtMATMaterialNameCustom = New System.Windows.Forms.TextBox()
        Me.txtMATOption3 = New System.Windows.Forms.TextBox()
        Me.lblMATAtomicNumber = New System.Windows.Forms.Label()
        Me.lblMATOption3 = New System.Windows.Forms.Label()
        Me.txtMATAtomicNumber = New System.Windows.Forms.TextBox()
        Me.txtMATOption1 = New System.Windows.Forms.TextBox()
        Me.lblMATOption1 = New System.Windows.Forms.Label()
        Me.lblMATMassNumber = New System.Windows.Forms.Label()
        Me.txtMATMaterialName = New System.Windows.Forms.TextBox()
        Me.lblMATMaterialName = New System.Windows.Forms.Label()
        Me.lblMATNumberDensity = New System.Windows.Forms.Label()
        Me.cbxMATMaterialList = New System.Windows.Forms.ComboBox()
        Me.txtMATNumberDensity = New System.Windows.Forms.TextBox()
        Me.lblMATMaterial = New System.Windows.Forms.Label()
        Me.lblMATNumberDensityUnit = New System.Windows.Forms.Label()
        Me.txtMATMassNumber = New System.Windows.Forms.TextBox()
        Me.gbxHOMO = New System.Windows.Forms.GroupBox()
        Me.btnHOMORemoveHomoMaterial = New System.Windows.Forms.Button()
        Me.btnHOMORemoveMaterial = New System.Windows.Forms.Button()
        Me.lbxHOMOHomoMaterial = New System.Windows.Forms.ListBox()
        Me.btnHOMOGenerateHomoMaterial = New System.Windows.Forms.Button()
        Me.lbxHOMOMaterial = New System.Windows.Forms.ListBox()
        Me.btnHOMOAddMaterial = New System.Windows.Forms.Button()
        Me.lblHOMOHomoMaterialName = New System.Windows.Forms.Label()
        Me.txtHOMOHomoMaterialName = New System.Windows.Forms.TextBox()
        Me.lblHOMOMaterialName = New System.Windows.Forms.Label()
        Me.txtHOMOMaterialName = New System.Windows.Forms.TextBox()
        Me.lblHOMOFraction = New System.Windows.Forms.Label()
        Me.txtHOMOFraction = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.gbxMAT.SuspendLayout()
        Me.gbxHOMO.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(435, 25)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "LINK_MAT_[Reactor Core].dat Configurator"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbxMAT
        '
        Me.gbxMAT.Controls.Add(Me.txtMATNumberDensityE)
        Me.gbxMAT.Controls.Add(Me.lblE)
        Me.gbxMAT.Controls.Add(Me.btnMATRemoveMaterial)
        Me.gbxMAT.Controls.Add(Me.btnMATRemoveElement)
        Me.gbxMAT.Controls.Add(Me.btnMATGenerateCustomMaterial)
        Me.gbxMAT.Controls.Add(Me.lbxMATCustom)
        Me.gbxMAT.Controls.Add(Me.btnMATAddCustomElement)
        Me.gbxMAT.Controls.Add(Me.btnMATGenerateMaterial)
        Me.gbxMAT.Controls.Add(Me.txtMATOption2)
        Me.gbxMAT.Controls.Add(Me.lblCreateCustom)
        Me.gbxMAT.Controls.Add(Me.lbxMAT)
        Me.gbxMAT.Controls.Add(Me.chkMATMaterialBURN)
        Me.gbxMAT.Controls.Add(Me.lblMATMaterialNameCustom)
        Me.gbxMAT.Controls.Add(Me.lblMATOption2)
        Me.gbxMAT.Controls.Add(Me.txtMATMaterialNameCustom)
        Me.gbxMAT.Controls.Add(Me.txtMATOption3)
        Me.gbxMAT.Controls.Add(Me.lblMATAtomicNumber)
        Me.gbxMAT.Controls.Add(Me.lblMATOption3)
        Me.gbxMAT.Controls.Add(Me.txtMATAtomicNumber)
        Me.gbxMAT.Controls.Add(Me.txtMATOption1)
        Me.gbxMAT.Controls.Add(Me.lblMATOption1)
        Me.gbxMAT.Controls.Add(Me.lblMATMassNumber)
        Me.gbxMAT.Controls.Add(Me.txtMATMaterialName)
        Me.gbxMAT.Controls.Add(Me.lblMATMaterialName)
        Me.gbxMAT.Controls.Add(Me.lblMATNumberDensity)
        Me.gbxMAT.Controls.Add(Me.cbxMATMaterialList)
        Me.gbxMAT.Controls.Add(Me.txtMATNumberDensity)
        Me.gbxMAT.Controls.Add(Me.lblMATMaterial)
        Me.gbxMAT.Controls.Add(Me.lblMATNumberDensityUnit)
        Me.gbxMAT.Controls.Add(Me.txtMATMassNumber)
        Me.gbxMAT.Location = New System.Drawing.Point(17, 37)
        Me.gbxMAT.Name = "gbxMAT"
        Me.gbxMAT.Size = New System.Drawing.Size(430, 519)
        Me.gbxMAT.TabIndex = 0
        Me.gbxMAT.TabStop = False
        Me.gbxMAT.Text = "MAT Card"
        '
        'txtMATNumberDensityE
        '
        Me.txtMATNumberDensityE.Location = New System.Drawing.Point(233, 343)
        Me.txtMATNumberDensityE.Name = "txtMATNumberDensityE"
        Me.txtMATNumberDensityE.Size = New System.Drawing.Size(45, 21)
        Me.txtMATNumberDensityE.TabIndex = 13
        '
        'lblE
        '
        Me.lblE.AutoSize = True
        Me.lblE.Location = New System.Drawing.Point(216, 346)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(14, 15)
        Me.lblE.TabIndex = 34
        Me.lblE.Text = "E"
        '
        'btnMATRemoveMaterial
        '
        Me.btnMATRemoveMaterial.Location = New System.Drawing.Point(188, 157)
        Me.btnMATRemoveMaterial.Name = "btnMATRemoveMaterial"
        Me.btnMATRemoveMaterial.Size = New System.Drawing.Size(113, 23)
        Me.btnMATRemoveMaterial.TabIndex = 5
        Me.btnMATRemoveMaterial.Text = "Remove Material"
        Me.btnMATRemoveMaterial.UseVisualStyleBackColor = True
        '
        'btnMATRemoveElement
        '
        Me.btnMATRemoveElement.Location = New System.Drawing.Point(154, 484)
        Me.btnMATRemoveElement.Name = "btnMATRemoveElement"
        Me.btnMATRemoveElement.Size = New System.Drawing.Size(110, 23)
        Me.btnMATRemoveElement.TabIndex = 16
        Me.btnMATRemoveElement.Text = "Remove Element"
        Me.btnMATRemoveElement.UseVisualStyleBackColor = True
        '
        'btnMATGenerateCustomMaterial
        '
        Me.btnMATGenerateCustomMaterial.Location = New System.Drawing.Point(270, 484)
        Me.btnMATGenerateCustomMaterial.Name = "btnMATGenerateCustomMaterial"
        Me.btnMATGenerateCustomMaterial.Size = New System.Drawing.Size(150, 23)
        Me.btnMATGenerateCustomMaterial.TabIndex = 17
        Me.btnMATGenerateCustomMaterial.Text = "Generate Custom Material"
        Me.btnMATGenerateCustomMaterial.UseVisualStyleBackColor = True
        '
        'lbxMATCustom
        '
        Me.lbxMATCustom.FormattingEnabled = True
        Me.lbxMATCustom.ItemHeight = 15
        Me.lbxMATCustom.Location = New System.Drawing.Point(6, 369)
        Me.lbxMATCustom.Name = "lbxMATCustom"
        Me.lbxMATCustom.Size = New System.Drawing.Size(414, 109)
        Me.lbxMATCustom.TabIndex = 15
        '
        'btnMATAddCustomElement
        '
        Me.btnMATAddCustomElement.Location = New System.Drawing.Point(336, 342)
        Me.btnMATAddCustomElement.Name = "btnMATAddCustomElement"
        Me.btnMATAddCustomElement.Size = New System.Drawing.Size(84, 23)
        Me.btnMATAddCustomElement.TabIndex = 14
        Me.btnMATAddCustomElement.Text = "Add Element"
        Me.btnMATAddCustomElement.UseVisualStyleBackColor = True
        '
        'btnMATGenerateMaterial
        '
        Me.btnMATGenerateMaterial.Location = New System.Drawing.Point(307, 157)
        Me.btnMATGenerateMaterial.Name = "btnMATGenerateMaterial"
        Me.btnMATGenerateMaterial.Size = New System.Drawing.Size(113, 23)
        Me.btnMATGenerateMaterial.TabIndex = 6
        Me.btnMATGenerateMaterial.Text = "Generate Material"
        Me.btnMATGenerateMaterial.UseVisualStyleBackColor = True
        '
        'txtMATOption2
        '
        Me.txtMATOption2.Location = New System.Drawing.Point(169, 103)
        Me.txtMATOption2.Name = "txtMATOption2"
        Me.txtMATOption2.Size = New System.Drawing.Size(251, 21)
        Me.txtMATOption2.TabIndex = 3
        '
        'lblCreateCustom
        '
        Me.lblCreateCustom.AutoSize = True
        Me.lblCreateCustom.Location = New System.Drawing.Point(6, 272)
        Me.lblCreateCustom.Name = "lblCreateCustom"
        Me.lblCreateCustom.Size = New System.Drawing.Size(79, 15)
        Me.lblCreateCustom.TabIndex = 4
        Me.lblCreateCustom.Text = "Create Custom"
        '
        'lbxMAT
        '
        Me.lbxMAT.FormattingEnabled = True
        Me.lbxMAT.ItemHeight = 15
        Me.lbxMAT.Location = New System.Drawing.Point(6, 186)
        Me.lbxMAT.Name = "lbxMAT"
        Me.lbxMAT.Size = New System.Drawing.Size(414, 79)
        Me.lbxMAT.TabIndex = 7
        '
        'chkMATMaterialBURN
        '
        Me.chkMATMaterialBURN.AutoSize = True
        Me.chkMATMaterialBURN.Location = New System.Drawing.Point(307, 292)
        Me.chkMATMaterialBURN.Name = "chkMATMaterialBURN"
        Me.chkMATMaterialBURN.Size = New System.Drawing.Size(113, 19)
        Me.chkMATMaterialBURN.TabIndex = 9
        Me.chkMATMaterialBURN.Text = "Burnable Material"
        Me.chkMATMaterialBURN.UseVisualStyleBackColor = True
        '
        'lblMATMaterialNameCustom
        '
        Me.lblMATMaterialNameCustom.AutoSize = True
        Me.lblMATMaterialNameCustom.Location = New System.Drawing.Point(6, 293)
        Me.lblMATMaterialNameCustom.Name = "lblMATMaterialNameCustom"
        Me.lblMATMaterialNameCustom.Size = New System.Drawing.Size(79, 15)
        Me.lblMATMaterialNameCustom.TabIndex = 5
        Me.lblMATMaterialNameCustom.Text = "Material Name"
        '
        'lblMATOption2
        '
        Me.lblMATOption2.AutoSize = True
        Me.lblMATOption2.Location = New System.Drawing.Point(6, 106)
        Me.lblMATOption2.Name = "lblMATOption2"
        Me.lblMATOption2.Size = New System.Drawing.Size(51, 15)
        Me.lblMATOption2.TabIndex = 26
        Me.lblMATOption2.Text = "Option 2"
        '
        'txtMATMaterialNameCustom
        '
        Me.txtMATMaterialNameCustom.Location = New System.Drawing.Point(91, 290)
        Me.txtMATMaterialNameCustom.Name = "txtMATMaterialNameCustom"
        Me.txtMATMaterialNameCustom.Size = New System.Drawing.Size(210, 21)
        Me.txtMATMaterialNameCustom.TabIndex = 8
        '
        'txtMATOption3
        '
        Me.txtMATOption3.Location = New System.Drawing.Point(169, 130)
        Me.txtMATOption3.Name = "txtMATOption3"
        Me.txtMATOption3.Size = New System.Drawing.Size(251, 21)
        Me.txtMATOption3.TabIndex = 4
        '
        'lblMATAtomicNumber
        '
        Me.lblMATAtomicNumber.AutoSize = True
        Me.lblMATAtomicNumber.Location = New System.Drawing.Point(6, 319)
        Me.lblMATAtomicNumber.Name = "lblMATAtomicNumber"
        Me.lblMATAtomicNumber.Size = New System.Drawing.Size(85, 15)
        Me.lblMATAtomicNumber.TabIndex = 7
        Me.lblMATAtomicNumber.Text = "Atomic Number"
        '
        'lblMATOption3
        '
        Me.lblMATOption3.AutoSize = True
        Me.lblMATOption3.Location = New System.Drawing.Point(6, 133)
        Me.lblMATOption3.Name = "lblMATOption3"
        Me.lblMATOption3.Size = New System.Drawing.Size(51, 15)
        Me.lblMATOption3.TabIndex = 24
        Me.lblMATOption3.Text = "Option 3"
        '
        'txtMATAtomicNumber
        '
        Me.txtMATAtomicNumber.Location = New System.Drawing.Point(97, 316)
        Me.txtMATAtomicNumber.Name = "txtMATAtomicNumber"
        Me.txtMATAtomicNumber.Size = New System.Drawing.Size(58, 21)
        Me.txtMATAtomicNumber.TabIndex = 10
        '
        'txtMATOption1
        '
        Me.txtMATOption1.Location = New System.Drawing.Point(169, 76)
        Me.txtMATOption1.Name = "txtMATOption1"
        Me.txtMATOption1.Size = New System.Drawing.Size(251, 21)
        Me.txtMATOption1.TabIndex = 2
        '
        'lblMATOption1
        '
        Me.lblMATOption1.AutoSize = True
        Me.lblMATOption1.Location = New System.Drawing.Point(6, 79)
        Me.lblMATOption1.Name = "lblMATOption1"
        Me.lblMATOption1.Size = New System.Drawing.Size(51, 15)
        Me.lblMATOption1.TabIndex = 22
        Me.lblMATOption1.Text = "Option 1"
        '
        'lblMATMassNumber
        '
        Me.lblMATMassNumber.AutoSize = True
        Me.lblMATMassNumber.Location = New System.Drawing.Point(166, 319)
        Me.lblMATMassNumber.Name = "lblMATMassNumber"
        Me.lblMATMassNumber.Size = New System.Drawing.Size(76, 15)
        Me.lblMATMassNumber.TabIndex = 9
        Me.lblMATMassNumber.Text = "Mass Number"
        '
        'txtMATMaterialName
        '
        Me.txtMATMaterialName.Location = New System.Drawing.Point(169, 49)
        Me.txtMATMaterialName.Name = "txtMATMaterialName"
        Me.txtMATMaterialName.Size = New System.Drawing.Size(251, 21)
        Me.txtMATMaterialName.TabIndex = 1
        '
        'lblMATMaterialName
        '
        Me.lblMATMaterialName.AutoSize = True
        Me.lblMATMaterialName.Location = New System.Drawing.Point(6, 52)
        Me.lblMATMaterialName.Name = "lblMATMaterialName"
        Me.lblMATMaterialName.Size = New System.Drawing.Size(79, 15)
        Me.lblMATMaterialName.TabIndex = 20
        Me.lblMATMaterialName.Text = "Material Name"
        '
        'lblMATNumberDensity
        '
        Me.lblMATNumberDensity.AutoSize = True
        Me.lblMATNumberDensity.Location = New System.Drawing.Point(6, 346)
        Me.lblMATNumberDensity.Name = "lblMATNumberDensity"
        Me.lblMATNumberDensity.Size = New System.Drawing.Size(88, 15)
        Me.lblMATNumberDensity.TabIndex = 11
        Me.lblMATNumberDensity.Text = "Number Density"
        '
        'cbxMATMaterialList
        '
        Me.cbxMATMaterialList.FormattingEnabled = True
        Me.cbxMATMaterialList.Location = New System.Drawing.Point(60, 20)
        Me.cbxMATMaterialList.Name = "cbxMATMaterialList"
        Me.cbxMATMaterialList.Size = New System.Drawing.Size(360, 23)
        Me.cbxMATMaterialList.TabIndex = 0
        '
        'txtMATNumberDensity
        '
        Me.txtMATNumberDensity.Location = New System.Drawing.Point(100, 343)
        Me.txtMATNumberDensity.Name = "txtMATNumberDensity"
        Me.txtMATNumberDensity.Size = New System.Drawing.Size(110, 21)
        Me.txtMATNumberDensity.TabIndex = 12
        '
        'lblMATMaterial
        '
        Me.lblMATMaterial.AutoSize = True
        Me.lblMATMaterial.Location = New System.Drawing.Point(6, 23)
        Me.lblMATMaterial.Name = "lblMATMaterial"
        Me.lblMATMaterial.Size = New System.Drawing.Size(48, 15)
        Me.lblMATMaterial.TabIndex = 0
        Me.lblMATMaterial.Text = "Material"
        '
        'lblMATNumberDensityUnit
        '
        Me.lblMATNumberDensityUnit.AutoSize = True
        Me.lblMATNumberDensityUnit.Location = New System.Drawing.Point(284, 346)
        Me.lblMATNumberDensityUnit.Name = "lblMATNumberDensityUnit"
        Me.lblMATNumberDensityUnit.Size = New System.Drawing.Size(51, 15)
        Me.lblMATNumberDensityUnit.TabIndex = 15
        Me.lblMATNumberDensityUnit.Text = "/cm*barn"
        '
        'txtMATMassNumber
        '
        Me.txtMATMassNumber.Location = New System.Drawing.Point(243, 316)
        Me.txtMATMassNumber.Name = "txtMATMassNumber"
        Me.txtMATMassNumber.Size = New System.Drawing.Size(58, 21)
        Me.txtMATMassNumber.TabIndex = 11
        '
        'gbxHOMO
        '
        Me.gbxHOMO.Controls.Add(Me.btnHOMORemoveHomoMaterial)
        Me.gbxHOMO.Controls.Add(Me.btnHOMORemoveMaterial)
        Me.gbxHOMO.Controls.Add(Me.lbxHOMOHomoMaterial)
        Me.gbxHOMO.Controls.Add(Me.btnHOMOGenerateHomoMaterial)
        Me.gbxHOMO.Controls.Add(Me.lbxHOMOMaterial)
        Me.gbxHOMO.Controls.Add(Me.btnHOMOAddMaterial)
        Me.gbxHOMO.Controls.Add(Me.lblHOMOHomoMaterialName)
        Me.gbxHOMO.Controls.Add(Me.txtHOMOHomoMaterialName)
        Me.gbxHOMO.Controls.Add(Me.lblHOMOMaterialName)
        Me.gbxHOMO.Controls.Add(Me.txtHOMOMaterialName)
        Me.gbxHOMO.Controls.Add(Me.lblHOMOFraction)
        Me.gbxHOMO.Controls.Add(Me.txtHOMOFraction)
        Me.gbxHOMO.Location = New System.Drawing.Point(453, 37)
        Me.gbxHOMO.Name = "gbxHOMO"
        Me.gbxHOMO.Size = New System.Drawing.Size(430, 441)
        Me.gbxHOMO.TabIndex = 1
        Me.gbxHOMO.TabStop = False
        Me.gbxHOMO.Text = "HOMO Card"
        '
        'btnHOMORemoveHomoMaterial
        '
        Me.btnHOMORemoveHomoMaterial.Location = New System.Drawing.Point(66, 220)
        Me.btnHOMORemoveHomoMaterial.Name = "btnHOMORemoveHomoMaterial"
        Me.btnHOMORemoveHomoMaterial.Size = New System.Drawing.Size(176, 23)
        Me.btnHOMORemoveHomoMaterial.TabIndex = 6
        Me.btnHOMORemoveHomoMaterial.Text = "Remove Homogeneous Material"
        Me.btnHOMORemoveHomoMaterial.UseVisualStyleBackColor = True
        '
        'btnHOMORemoveMaterial
        '
        Me.btnHOMORemoveMaterial.Location = New System.Drawing.Point(235, 76)
        Me.btnHOMORemoveMaterial.Name = "btnHOMORemoveMaterial"
        Me.btnHOMORemoveMaterial.Size = New System.Drawing.Size(103, 23)
        Me.btnHOMORemoveMaterial.TabIndex = 3
        Me.btnHOMORemoveMaterial.Text = "Remove Material"
        Me.btnHOMORemoveMaterial.UseVisualStyleBackColor = True
        '
        'lbxHOMOHomoMaterial
        '
        Me.lbxHOMOHomoMaterial.FormattingEnabled = True
        Me.lbxHOMOHomoMaterial.ItemHeight = 15
        Me.lbxHOMOHomoMaterial.Location = New System.Drawing.Point(10, 249)
        Me.lbxHOMOHomoMaterial.Name = "lbxHOMOHomoMaterial"
        Me.lbxHOMOHomoMaterial.Size = New System.Drawing.Size(414, 184)
        Me.lbxHOMOHomoMaterial.TabIndex = 8
        '
        'btnHOMOGenerateHomoMaterial
        '
        Me.btnHOMOGenerateHomoMaterial.Location = New System.Drawing.Point(248, 220)
        Me.btnHOMOGenerateHomoMaterial.Name = "btnHOMOGenerateHomoMaterial"
        Me.btnHOMOGenerateHomoMaterial.Size = New System.Drawing.Size(176, 23)
        Me.btnHOMOGenerateHomoMaterial.TabIndex = 7
        Me.btnHOMOGenerateHomoMaterial.Text = "Generate Homogeneous Material"
        Me.btnHOMOGenerateHomoMaterial.UseVisualStyleBackColor = True
        '
        'lbxHOMOMaterial
        '
        Me.lbxHOMOMaterial.FormattingEnabled = True
        Me.lbxHOMOMaterial.ItemHeight = 15
        Me.lbxHOMOMaterial.Location = New System.Drawing.Point(10, 105)
        Me.lbxHOMOMaterial.Name = "lbxHOMOMaterial"
        Me.lbxHOMOMaterial.Size = New System.Drawing.Size(414, 109)
        Me.lbxHOMOMaterial.TabIndex = 5
        '
        'btnHOMOAddMaterial
        '
        Me.btnHOMOAddMaterial.Location = New System.Drawing.Point(344, 76)
        Me.btnHOMOAddMaterial.Name = "btnHOMOAddMaterial"
        Me.btnHOMOAddMaterial.Size = New System.Drawing.Size(80, 23)
        Me.btnHOMOAddMaterial.TabIndex = 4
        Me.btnHOMOAddMaterial.Text = "Add Material"
        Me.btnHOMOAddMaterial.UseVisualStyleBackColor = True
        '
        'lblHOMOHomoMaterialName
        '
        Me.lblHOMOHomoMaterialName.AutoSize = True
        Me.lblHOMOHomoMaterialName.Location = New System.Drawing.Point(10, 22)
        Me.lblHOMOHomoMaterialName.Name = "lblHOMOHomoMaterialName"
        Me.lblHOMOHomoMaterialName.Size = New System.Drawing.Size(150, 15)
        Me.lblHOMOHomoMaterialName.TabIndex = 5
        Me.lblHOMOHomoMaterialName.Text = "Homogeneous Material Name"
        '
        'txtHOMOHomoMaterialName
        '
        Me.txtHOMOHomoMaterialName.Location = New System.Drawing.Point(166, 17)
        Me.txtHOMOHomoMaterialName.Name = "txtHOMOHomoMaterialName"
        Me.txtHOMOHomoMaterialName.Size = New System.Drawing.Size(258, 21)
        Me.txtHOMOHomoMaterialName.TabIndex = 0
        '
        'lblHOMOMaterialName
        '
        Me.lblHOMOMaterialName.AutoSize = True
        Me.lblHOMOMaterialName.Location = New System.Drawing.Point(10, 48)
        Me.lblHOMOMaterialName.Name = "lblHOMOMaterialName"
        Me.lblHOMOMaterialName.Size = New System.Drawing.Size(79, 15)
        Me.lblHOMOMaterialName.TabIndex = 7
        Me.lblHOMOMaterialName.Text = "Material Name"
        '
        'txtHOMOMaterialName
        '
        Me.txtHOMOMaterialName.Location = New System.Drawing.Point(95, 46)
        Me.txtHOMOMaterialName.Name = "txtHOMOMaterialName"
        Me.txtHOMOMaterialName.Size = New System.Drawing.Size(131, 21)
        Me.txtHOMOMaterialName.TabIndex = 1
        '
        'lblHOMOFraction
        '
        Me.lblHOMOFraction.AutoSize = True
        Me.lblHOMOFraction.Location = New System.Drawing.Point(232, 48)
        Me.lblHOMOFraction.Name = "lblHOMOFraction"
        Me.lblHOMOFraction.Size = New System.Drawing.Size(106, 15)
        Me.lblHOMOFraction.TabIndex = 9
        Me.lblHOMOFraction.Text = "Fraction for Mixture"
        '
        'txtHOMOFraction
        '
        Me.txtHOMOFraction.Location = New System.Drawing.Point(344, 46)
        Me.txtHOMOFraction.Name = "txtHOMOFraction"
        Me.txtHOMOFraction.Size = New System.Drawing.Size(80, 21)
        Me.txtHOMOFraction.TabIndex = 2
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(449, 484)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(93, 72)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(671, 484)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(212, 72)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(548, 484)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(117, 72)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close without Saving"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'LINK_MAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 573)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.gbxHOMO)
        Me.Controls.Add(Me.gbxMAT)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "LINK_MAT"
        Me.Text = "Configure LINK_MAT_[Reactor Code].dat"
        Me.gbxMAT.ResumeLayout(False)
        Me.gbxMAT.PerformLayout()
        Me.gbxHOMO.ResumeLayout(False)
        Me.gbxHOMO.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents gbxMAT As GroupBox
    Friend WithEvents cbxMATMaterialList As ComboBox
    Friend WithEvents lblMATMaterial As Label
    Friend WithEvents chkMATMaterialBURN As CheckBox
    Friend WithEvents txtMATAtomicNumber As TextBox
    Friend WithEvents lblMATAtomicNumber As Label
    Friend WithEvents txtMATMaterialNameCustom As TextBox
    Friend WithEvents lblMATMaterialNameCustom As Label
    Friend WithEvents lblCreateCustom As Label
    Friend WithEvents btnMATGenerateCustomMaterial As Button
    Friend WithEvents lbxMATCustom As ListBox
    Friend WithEvents btnMATAddCustomElement As Button
    Friend WithEvents btnMATGenerateMaterial As Button
    Friend WithEvents txtMATOption2 As TextBox
    Friend WithEvents lblMATOption2 As Label
    Friend WithEvents txtMATOption3 As TextBox
    Friend WithEvents lblMATOption3 As Label
    Friend WithEvents txtMATOption1 As TextBox
    Friend WithEvents lblMATOption1 As Label
    Friend WithEvents lblMATMassNumber As Label
    Friend WithEvents txtMATMaterialName As TextBox
    Friend WithEvents lblMATMaterialName As Label
    Friend WithEvents lblMATNumberDensity As Label
    Friend WithEvents txtMATNumberDensity As TextBox
    Friend WithEvents lblMATNumberDensityUnit As Label
    Friend WithEvents txtMATMassNumber As TextBox
    Friend WithEvents gbxHOMO As GroupBox
    Friend WithEvents lbxHOMOHomoMaterial As ListBox
    Friend WithEvents btnHOMOGenerateHomoMaterial As Button
    Friend WithEvents lbxHOMOMaterial As ListBox
    Friend WithEvents btnHOMOAddMaterial As Button
    Friend WithEvents lblHOMOHomoMaterialName As Label
    Friend WithEvents txtHOMOHomoMaterialName As TextBox
    Friend WithEvents lblHOMOMaterialName As Label
    Friend WithEvents txtHOMOMaterialName As TextBox
    Friend WithEvents lblHOMOFraction As Label
    Friend WithEvents txtHOMOFraction As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnMATRemoveMaterial As Button
    Friend WithEvents btnMATRemoveElement As Button
    Friend WithEvents btnHOMORemoveHomoMaterial As Button
    Friend WithEvents btnHOMORemoveMaterial As Button
    Friend WithEvents lbxMAT As ListBox
    Friend WithEvents txtMATNumberDensityE As TextBox
    Friend WithEvents lblE As Label
    Friend WithEvents btnClose As Button
End Class
