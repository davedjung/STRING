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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LINK_MAT))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gbxMAT = New System.Windows.Forms.GroupBox()
        Me.lbxMATList = New System.Windows.Forms.ListBox()
        Me.btnMATRemove = New System.Windows.Forms.Button()
        Me.btnMATGenerate = New System.Windows.Forms.Button()
        Me.lblMATOption3 = New System.Windows.Forms.Label()
        Me.lblMATOption2 = New System.Windows.Forms.Label()
        Me.lblMATOption1 = New System.Windows.Forms.Label()
        Me.lblMATName = New System.Windows.Forms.Label()
        Me.txtMATOption3 = New System.Windows.Forms.TextBox()
        Me.txtMATOption2 = New System.Windows.Forms.TextBox()
        Me.txtMATOption1 = New System.Windows.Forms.TextBox()
        Me.txtMATName = New System.Windows.Forms.TextBox()
        Me.lblMaterial = New System.Windows.Forms.Label()
        Me.cbxMaterial = New System.Windows.Forms.ComboBox()
        Me.gbxCustom = New System.Windows.Forms.GroupBox()
        Me.btnElementRemove = New System.Windows.Forms.Button()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.txtE = New System.Windows.Forms.TextBox()
        Me.chkBURN = New System.Windows.Forms.CheckBox()
        Me.btnCustomGenerate = New System.Windows.Forms.Button()
        Me.lbxCustom = New System.Windows.Forms.ListBox()
        Me.btnElementAdd = New System.Windows.Forms.Button()
        Me.lblE = New System.Windows.Forms.Label()
        Me.lblNumberDensity = New System.Windows.Forms.Label()
        Me.lblMassNumber = New System.Windows.Forms.Label()
        Me.lblAtomicNumber = New System.Windows.Forms.Label()
        Me.txtNumberDensity = New System.Windows.Forms.TextBox()
        Me.txtMassNumber = New System.Windows.Forms.TextBox()
        Me.txtAtomicNumber = New System.Windows.Forms.TextBox()
        Me.txtCustomName = New System.Windows.Forms.TextBox()
        Me.lblCustomName = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.gbxMAT.SuspendLayout()
        Me.gbxCustom.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(597, 37)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "LINK_MAT_[Reactor].dat Configurator"
        '
        'gbxMAT
        '
        Me.gbxMAT.Controls.Add(Me.lbxMATList)
        Me.gbxMAT.Controls.Add(Me.btnMATRemove)
        Me.gbxMAT.Controls.Add(Me.btnMATGenerate)
        Me.gbxMAT.Controls.Add(Me.lblMATOption3)
        Me.gbxMAT.Controls.Add(Me.lblMATOption2)
        Me.gbxMAT.Controls.Add(Me.lblMATOption1)
        Me.gbxMAT.Controls.Add(Me.lblMATName)
        Me.gbxMAT.Controls.Add(Me.txtMATOption3)
        Me.gbxMAT.Controls.Add(Me.txtMATOption2)
        Me.gbxMAT.Controls.Add(Me.txtMATOption1)
        Me.gbxMAT.Controls.Add(Me.txtMATName)
        Me.gbxMAT.Controls.Add(Me.lblMaterial)
        Me.gbxMAT.Controls.Add(Me.cbxMaterial)
        Me.gbxMAT.Location = New System.Drawing.Point(12, 49)
        Me.gbxMAT.Name = "gbxMAT"
        Me.gbxMAT.Size = New System.Drawing.Size(597, 563)
        Me.gbxMAT.TabIndex = 0
        Me.gbxMAT.TabStop = False
        Me.gbxMAT.Text = "MAT Card"
        '
        'lbxMATList
        '
        Me.lbxMATList.FormattingEnabled = True
        Me.lbxMATList.ItemHeight = 29
        Me.lbxMATList.Location = New System.Drawing.Point(6, 289)
        Me.lbxMATList.Name = "lbxMATList"
        Me.lbxMATList.Size = New System.Drawing.Size(585, 265)
        Me.lbxMATList.TabIndex = 7
        '
        'btnMATRemove
        '
        Me.btnMATRemove.FlatAppearance.BorderSize = 2
        Me.btnMATRemove.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMATRemove.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMATRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMATRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnMATRemove.Location = New System.Drawing.Point(99, 241)
        Me.btnMATRemove.Name = "btnMATRemove"
        Me.btnMATRemove.Size = New System.Drawing.Size(243, 39)
        Me.btnMATRemove.TabIndex = 5
        Me.btnMATRemove.Text = "Remove Material"
        Me.btnMATRemove.UseVisualStyleBackColor = True
        '
        'btnMATGenerate
        '
        Me.btnMATGenerate.FlatAppearance.BorderSize = 2
        Me.btnMATGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMATGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMATGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMATGenerate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnMATGenerate.Location = New System.Drawing.Point(348, 241)
        Me.btnMATGenerate.Name = "btnMATGenerate"
        Me.btnMATGenerate.Size = New System.Drawing.Size(243, 39)
        Me.btnMATGenerate.TabIndex = 6
        Me.btnMATGenerate.Text = "&Generate Material"
        Me.btnMATGenerate.UseVisualStyleBackColor = True
        '
        'lblMATOption3
        '
        Me.lblMATOption3.AutoSize = True
        Me.lblMATOption3.Location = New System.Drawing.Point(6, 203)
        Me.lblMATOption3.Name = "lblMATOption3"
        Me.lblMATOption3.Size = New System.Drawing.Size(117, 29)
        Me.lblMATOption3.TabIndex = 9
        Me.lblMATOption3.Text = "Option #3"
        '
        'lblMATOption2
        '
        Me.lblMATOption2.AutoSize = True
        Me.lblMATOption2.Location = New System.Drawing.Point(6, 162)
        Me.lblMATOption2.Name = "lblMATOption2"
        Me.lblMATOption2.Size = New System.Drawing.Size(117, 29)
        Me.lblMATOption2.TabIndex = 8
        Me.lblMATOption2.Text = "Option #2"
        '
        'lblMATOption1
        '
        Me.lblMATOption1.AutoSize = True
        Me.lblMATOption1.Location = New System.Drawing.Point(6, 121)
        Me.lblMATOption1.Name = "lblMATOption1"
        Me.lblMATOption1.Size = New System.Drawing.Size(117, 29)
        Me.lblMATOption1.TabIndex = 7
        Me.lblMATOption1.Text = "Option #1"
        '
        'lblMATName
        '
        Me.lblMATName.AutoSize = True
        Me.lblMATName.Location = New System.Drawing.Point(6, 80)
        Me.lblMATName.Name = "lblMATName"
        Me.lblMATName.Size = New System.Drawing.Size(170, 29)
        Me.lblMATName.TabIndex = 6
        Me.lblMATName.Text = "Material Name"
        '
        'txtMATOption3
        '
        Me.txtMATOption3.Location = New System.Drawing.Point(372, 200)
        Me.txtMATOption3.Name = "txtMATOption3"
        Me.txtMATOption3.Size = New System.Drawing.Size(219, 35)
        Me.txtMATOption3.TabIndex = 4
        '
        'txtMATOption2
        '
        Me.txtMATOption2.Location = New System.Drawing.Point(372, 159)
        Me.txtMATOption2.Name = "txtMATOption2"
        Me.txtMATOption2.Size = New System.Drawing.Size(219, 35)
        Me.txtMATOption2.TabIndex = 3
        '
        'txtMATOption1
        '
        Me.txtMATOption1.Location = New System.Drawing.Point(372, 118)
        Me.txtMATOption1.Name = "txtMATOption1"
        Me.txtMATOption1.Size = New System.Drawing.Size(219, 35)
        Me.txtMATOption1.TabIndex = 2
        '
        'txtMATName
        '
        Me.txtMATName.Location = New System.Drawing.Point(372, 77)
        Me.txtMATName.Name = "txtMATName"
        Me.txtMATName.Size = New System.Drawing.Size(219, 35)
        Me.txtMATName.TabIndex = 1
        '
        'lblMaterial
        '
        Me.lblMaterial.AutoSize = True
        Me.lblMaterial.Location = New System.Drawing.Point(6, 37)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(99, 29)
        Me.lblMaterial.TabIndex = 1
        Me.lblMaterial.Text = "Material"
        '
        'cbxMaterial
        '
        Me.cbxMaterial.FormattingEnabled = True
        Me.cbxMaterial.Location = New System.Drawing.Point(111, 34)
        Me.cbxMaterial.Name = "cbxMaterial"
        Me.cbxMaterial.Size = New System.Drawing.Size(480, 37)
        Me.cbxMaterial.TabIndex = 0
        '
        'gbxCustom
        '
        Me.gbxCustom.Controls.Add(Me.btnElementRemove)
        Me.gbxCustom.Controls.Add(Me.lblUnit)
        Me.gbxCustom.Controls.Add(Me.txtE)
        Me.gbxCustom.Controls.Add(Me.chkBURN)
        Me.gbxCustom.Controls.Add(Me.btnCustomGenerate)
        Me.gbxCustom.Controls.Add(Me.lbxCustom)
        Me.gbxCustom.Controls.Add(Me.btnElementAdd)
        Me.gbxCustom.Controls.Add(Me.lblE)
        Me.gbxCustom.Controls.Add(Me.lblNumberDensity)
        Me.gbxCustom.Controls.Add(Me.lblMassNumber)
        Me.gbxCustom.Controls.Add(Me.lblAtomicNumber)
        Me.gbxCustom.Controls.Add(Me.txtNumberDensity)
        Me.gbxCustom.Controls.Add(Me.txtMassNumber)
        Me.gbxCustom.Controls.Add(Me.txtAtomicNumber)
        Me.gbxCustom.Controls.Add(Me.txtCustomName)
        Me.gbxCustom.Controls.Add(Me.lblCustomName)
        Me.gbxCustom.Location = New System.Drawing.Point(615, 49)
        Me.gbxCustom.Name = "gbxCustom"
        Me.gbxCustom.Size = New System.Drawing.Size(617, 493)
        Me.gbxCustom.TabIndex = 1
        Me.gbxCustom.TabStop = False
        Me.gbxCustom.Text = "Custom Material"
        '
        'btnElementRemove
        '
        Me.btnElementRemove.FlatAppearance.BorderSize = 2
        Me.btnElementRemove.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnElementRemove.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnElementRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElementRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnElementRemove.Location = New System.Drawing.Point(47, 448)
        Me.btnElementRemove.Name = "btnElementRemove"
        Me.btnElementRemove.Size = New System.Drawing.Size(243, 39)
        Me.btnElementRemove.TabIndex = 8
        Me.btnElementRemove.Text = "Remove &Element"
        Me.btnElementRemove.UseVisualStyleBackColor = True
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(501, 121)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(110, 29)
        Me.lblUnit.TabIndex = 15
        Me.lblUnit.Text = "/cm*barn"
        '
        'txtE
        '
        Me.txtE.Location = New System.Drawing.Point(409, 118)
        Me.txtE.Name = "txtE"
        Me.txtE.Size = New System.Drawing.Size(86, 35)
        Me.txtE.TabIndex = 5
        '
        'chkBURN
        '
        Me.chkBURN.AutoSize = True
        Me.chkBURN.Location = New System.Drawing.Point(390, 36)
        Me.chkBURN.Name = "chkBURN"
        Me.chkBURN.Size = New System.Drawing.Size(221, 33)
        Me.chkBURN.TabIndex = 1
        Me.chkBURN.Text = "Burnable Material"
        Me.chkBURN.UseVisualStyleBackColor = True
        '
        'btnCustomGenerate
        '
        Me.btnCustomGenerate.FlatAppearance.BorderSize = 2
        Me.btnCustomGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCustomGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCustomGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomGenerate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnCustomGenerate.Location = New System.Drawing.Point(296, 448)
        Me.btnCustomGenerate.Name = "btnCustomGenerate"
        Me.btnCustomGenerate.Size = New System.Drawing.Size(314, 39)
        Me.btnCustomGenerate.TabIndex = 9
        Me.btnCustomGenerate.Text = "Generate Custom &Material"
        Me.btnCustomGenerate.UseVisualStyleBackColor = True
        '
        'lbxCustom
        '
        Me.lbxCustom.FormattingEnabled = True
        Me.lbxCustom.ItemHeight = 29
        Me.lbxCustom.Location = New System.Drawing.Point(6, 204)
        Me.lbxCustom.Name = "lbxCustom"
        Me.lbxCustom.Size = New System.Drawing.Size(604, 236)
        Me.lbxCustom.TabIndex = 7
        '
        'btnElementAdd
        '
        Me.btnElementAdd.FlatAppearance.BorderSize = 2
        Me.btnElementAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnElementAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnElementAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElementAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnElementAdd.Location = New System.Drawing.Point(448, 159)
        Me.btnElementAdd.Name = "btnElementAdd"
        Me.btnElementAdd.Size = New System.Drawing.Size(163, 39)
        Me.btnElementAdd.TabIndex = 6
        Me.btnElementAdd.Text = "&Add Element"
        Me.btnElementAdd.UseVisualStyleBackColor = True
        '
        'lblE
        '
        Me.lblE.AutoSize = True
        Me.lblE.Location = New System.Drawing.Point(374, 121)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(29, 29)
        Me.lblE.TabIndex = 9
        Me.lblE.Text = "E"
        '
        'lblNumberDensity
        '
        Me.lblNumberDensity.AutoSize = True
        Me.lblNumberDensity.Location = New System.Drawing.Point(6, 121)
        Me.lblNumberDensity.Name = "lblNumberDensity"
        Me.lblNumberDensity.Size = New System.Drawing.Size(185, 29)
        Me.lblNumberDensity.TabIndex = 8
        Me.lblNumberDensity.Text = "Number Density"
        '
        'lblMassNumber
        '
        Me.lblMassNumber.AutoSize = True
        Me.lblMassNumber.Location = New System.Drawing.Point(303, 80)
        Me.lblMassNumber.Name = "lblMassNumber"
        Me.lblMassNumber.Size = New System.Drawing.Size(163, 29)
        Me.lblMassNumber.TabIndex = 7
        Me.lblMassNumber.Text = "Mass Number"
        '
        'lblAtomicNumber
        '
        Me.lblAtomicNumber.AutoSize = True
        Me.lblAtomicNumber.Location = New System.Drawing.Point(6, 80)
        Me.lblAtomicNumber.Name = "lblAtomicNumber"
        Me.lblAtomicNumber.Size = New System.Drawing.Size(179, 29)
        Me.lblAtomicNumber.TabIndex = 6
        Me.lblAtomicNumber.Text = "Atomic Number"
        '
        'txtNumberDensity
        '
        Me.txtNumberDensity.Location = New System.Drawing.Point(197, 118)
        Me.txtNumberDensity.Name = "txtNumberDensity"
        Me.txtNumberDensity.Size = New System.Drawing.Size(171, 35)
        Me.txtNumberDensity.TabIndex = 4
        '
        'txtMassNumber
        '
        Me.txtMassNumber.Location = New System.Drawing.Point(474, 77)
        Me.txtMassNumber.Name = "txtMassNumber"
        Me.txtMassNumber.Size = New System.Drawing.Size(137, 35)
        Me.txtMassNumber.TabIndex = 3
        '
        'txtAtomicNumber
        '
        Me.txtAtomicNumber.Location = New System.Drawing.Point(191, 77)
        Me.txtAtomicNumber.Name = "txtAtomicNumber"
        Me.txtAtomicNumber.Size = New System.Drawing.Size(106, 35)
        Me.txtAtomicNumber.TabIndex = 2
        '
        'txtCustomName
        '
        Me.txtCustomName.Location = New System.Drawing.Point(182, 34)
        Me.txtCustomName.Name = "txtCustomName"
        Me.txtCustomName.Size = New System.Drawing.Size(202, 35)
        Me.txtCustomName.TabIndex = 0
        '
        'lblCustomName
        '
        Me.lblCustomName.AutoSize = True
        Me.lblCustomName.Location = New System.Drawing.Point(6, 37)
        Me.lblCustomName.Name = "lblCustomName"
        Me.lblCustomName.Size = New System.Drawing.Size(170, 29)
        Me.lblCustomName.TabIndex = 1
        Me.lblCustomName.Text = "Material Name"
        '
        'btnSave
        '
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(1005, 548)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(227, 64)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 2
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(735, 548)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(264, 64)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close without Saving"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.FlatAppearance.BorderSize = 2
        Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(615, 548)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(114, 64)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'LINK_MAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1240, 624)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbxCustom)
        Me.Controls.Add(Me.gbxMAT)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.MaximizeBox = False
        Me.Name = "LINK_MAT"
        Me.Text = "LINK_MAT"
        Me.gbxMAT.ResumeLayout(False)
        Me.gbxMAT.PerformLayout()
        Me.gbxCustom.ResumeLayout(False)
        Me.gbxCustom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents gbxMAT As GroupBox
    Friend WithEvents lblMATOption3 As Label
    Friend WithEvents lblMATOption2 As Label
    Friend WithEvents lblMATOption1 As Label
    Friend WithEvents lblMATName As Label
    Friend WithEvents txtMATOption3 As TextBox
    Friend WithEvents txtMATOption2 As TextBox
    Friend WithEvents txtMATOption1 As TextBox
    Friend WithEvents txtMATName As TextBox
    Friend WithEvents lblMaterial As Label
    Friend WithEvents cbxMaterial As ComboBox
    Friend WithEvents lbxMATList As ListBox
    Friend WithEvents btnMATRemove As Button
    Friend WithEvents btnMATGenerate As Button
    Friend WithEvents gbxCustom As GroupBox
    Friend WithEvents lbxCustom As ListBox
    Friend WithEvents btnElementAdd As Button
    Friend WithEvents btnCustomGenerate As Button
    Friend WithEvents lblE As Label
    Friend WithEvents lblNumberDensity As Label
    Friend WithEvents lblMassNumber As Label
    Friend WithEvents lblAtomicNumber As Label
    Friend WithEvents txtNumberDensity As TextBox
    Friend WithEvents txtMassNumber As TextBox
    Friend WithEvents txtAtomicNumber As TextBox
    Friend WithEvents txtCustomName As TextBox
    Friend WithEvents lblCustomName As Label
    Friend WithEvents btnElementRemove As Button
    Friend WithEvents lblUnit As Label
    Friend WithEvents txtE As TextBox
    Friend WithEvents chkBURN As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReset As Button
End Class
